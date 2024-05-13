using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeDLSharp.Metadata;
using YTR.Classes;
using YTR.Logging;
using YTR.Extensions;
using YTR.Utils;
using Winista.MimeDetect;
using Winista.Mime;

namespace YTR.Utils
{
    public static class MimeUtil
    {
        public static async Task<List<YTRThumbnailData>> GetYTRThumbnailDataFromByteArrayAsync(List<ThumbnailData> thumbnailData)
        {
            var ytrThumbData = new List<YTRThumbnailData>();
            foreach (ThumbnailData td in thumbnailData)
            {
                var byteArray = await WebUtil.DownloadByteArrayAsync(td.Url);
                var mimeInfo = await GetMimeTypeAsync(byteArray);
                ytrThumbData.Add(td.ToYTRThumbnailData(mimeInfo));
            }
            return ytrThumbData;
        }

        public static async Task<MimeType> GetMimeTypeAsync(byte[] imageBytes)
        {
            try
            {
                var mimeTypes = new MimeTypes();
                var test = await Task.Run(() => mimeTypes.GetMimeType(imageBytes));
                return test;
            }
            catch (Exception ex)
            {
                ExceptionHandler.LogException(ex);
            }
            return null;
        }

        public static List<string> ImageExtensions = new List<string>()
        {
            "jpeg",
            "jpg",
            "png",
            "gif",
            "bmp"
        };
    }
}
