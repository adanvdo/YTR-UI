using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winista.Mime;
using YoutubeDLSharp.Metadata;
using YTR.Classes;

namespace YTR.Extensions
{
    public static class ThumbnailDataExtensions
    {
        public static YTRThumbnailData ToYTRThumbnailData(this ThumbnailData thumbnailData, MimeType mimeTypeInfo = null)
        {
            var thumb = new YTRThumbnailData()
            {
                Filesize = thumbnailData.Filesize,
                Height = thumbnailData.Height,
                Width = thumbnailData.Width,
                ID = thumbnailData.ID,
                Preference = thumbnailData.Preference,
                Resolution = thumbnailData.Resolution,
                Url = thumbnailData.Url,
                MimeType = mimeTypeInfo
            };
            return thumb;
        }
    }
}
