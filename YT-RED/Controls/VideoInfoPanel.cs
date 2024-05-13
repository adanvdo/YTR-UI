﻿using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeDLSharp.Metadata;
using YTR.Classes;
using YTR.Utils;

namespace YTR.Controls
{
    public partial class VideoInfoPanel : DevExpress.XtraEditors.XtraUserControl
    {
        [Browsable(true)]
        public event EventHandler Crop_Click;

        public string Title
        {
            get { return txtTitle.Text; }
        }

        private Image currentImage;
        public Image CurrentImage
        {
            get { return currentImage; }
        }

        private Size useMediaSize;
        public Size UseMediaSize
        {
            get { return useMediaSize; }
            set { useMediaSize = value; }
        }

        public VideoInfoPanel()
        {
            InitializeComponent();
        }

        public void QualifyCropButton(bool show)
        {
            if (currentImage != null && useMediaSize.Width > 0 && useMediaSize.Height > 0 && show)
            {
                AspectRatio videoAR = AspectRatio.FromDimensions(useMediaSize);
                AspectRatio thumbAR = AspectRatio.FromDimensions(currentImage.Width, currentImage.Height);
                btnCropMedia.Visible = peThumbnail.Image != null && videoAR.ToDecimal() == thumbAR.ToDecimal();
            }
        }

        public void Clear()
        {
            var old = peThumbnail.Image;
            peThumbnail.Image = null;
            if (old != null) old.Dispose();
            btnCropMedia.Visible = false;
            if(currentImage != null)
                currentImage.Dispose();
            currentImage = null;
            clearText();
        }

        public async Task Populate(VideoData videoData)
        {
            Clear();

            if (videoData != null) 
            {
                txtTitle.Text = string.IsNullOrEmpty(videoData.Title) ? "Unknown Title" : videoData.Title.ToUpper();
                txtDuration.Text = videoData.Duration != null ? $"Duration: {TimeSpan.FromSeconds((float)videoData.Duration)}" : "Duration: unknown";
                if (string.IsNullOrEmpty(videoData.Description))
                {
                    txtDescription.Properties.ScrollBars = ScrollBars.None;
                }
                else
                {
                    txtDescription.Properties.ScrollBars = ScrollBars.Vertical;
                    txtDescription.Lines = videoData.Description.Split('\n');
                }

                if(videoData.Thumbnails != null && videoData.Thumbnails.Length > 0)
                {
                    List<YTRThumbnailData> ytrThumbnails = new List<YTRThumbnailData>();
                    if (!videoData.Thumbnails.Any(t => t.Preference != null))
                    {
                        ytrThumbnails = await MimeUtil.GetYTRThumbnailDataFromByteArrayAsync(videoData.Thumbnails.ToList());
                        var supportedYTRImages = ytrThumbnails.OrderByDescending(t => t.Resolution).Where(t => MimeUtil.ImageExtensions.Any(e => t.MimeType.Extensions.Any(me => me.ToLower() == e.ToLower()))).ToList();
                        var supportedYTRImage = supportedYTRImages.FirstOrDefault();
                        for (int i = supportedYTRImages.Count; i > 0; i--)
                        {
                            try
                            {
                                await loadThumbnail(supportedYTRImage);
                                break;
                            }
                            catch (WebException ex)
                            {
                                var response = (HttpWebResponse)ex.Response;
                                if (response.StatusCode == HttpStatusCode.NotFound || response.StatusCode == HttpStatusCode.Unauthorized)
                                {
                                    supportedYTRImages.RemoveAt(0);
                                    supportedYTRImage = supportedYTRImages.FirstOrDefault();
                                }
                            }
                        }
                    }
                    else
                    {
                        var supportedImages = videoData.Thumbnails.OrderByDescending(tn => tn.Preference).Where(tn => !tn.Url.ToLower().EndsWith(".webp")).ToList();
                        var supportedImage = supportedImages.FirstOrDefault();
                        for (int i = supportedImages.Count; i > 0; i--)
                        {
                            try
                            {
                                await loadThumbnail(supportedImage);
                                break;
                            }
                            catch (WebException ex)
                            {
                                var response = (HttpWebResponse)ex.Response;
                                if (response.StatusCode == HttpStatusCode.NotFound || response.StatusCode == HttpStatusCode.Unauthorized)
                                {
                                    supportedImages.RemoveAt(0);
                                    supportedImage = supportedImages.FirstOrDefault();
                                }
                            }
                        }
                    }
                }
            }
        }

        private async Task loadThumbnail(ThumbnailData thumbData)
        {            
            if (thumbData != null)
            {
                Stream thumbnailStream = await Utils.WebUtil.GetStreamFromUrl(thumbData.Url);
                currentImage = Image.FromStream(thumbnailStream, false, true);
                useMediaSize = currentImage.Size;
                peThumbnail.Image = currentImage;
            }
        }

        private void clearText()
        {
            txtTitle.Text = string.Empty;
            txtDuration.Text = string.Empty;
            txtDescription.Lines = new string[] { };
        }

        private void btnCropMedia_Click(object sender, EventArgs e)
        {
            if(Crop_Click != null)
                Crop_Click(sender, e);
        }
    }
}
