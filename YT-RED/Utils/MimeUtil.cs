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
        public static async Task<List<YTRThumbnailData>> GetSupportedYTRThumbnailDataFromByteArrayAsync(ThumbnailData[] thumbnailData)
        {
            var ytrThumbData = YTRThumbnailData.ConvertFromThumbnailDataArray(thumbnailData, SortPriority.Resolution);
            foreach (YTRThumbnailData td in ytrThumbData)
            {
                var byteArray = await WebUtil.DownloadByteArrayAsync(td.Url);
                var mimeInfo = await GetMimeTypeAsync(byteArray);
                td.MimeType = mimeInfo;
            }

            return YTRThumbnailData.UpdateThumbnailOrder(ytrThumbData.Where(t => MimeUtil.ImageExtensions.Any(e => t.MimeType.Extensions.Any(me => me.ToLower() == e.ToLower())))).ToList();
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
