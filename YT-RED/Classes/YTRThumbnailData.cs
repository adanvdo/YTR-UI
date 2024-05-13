using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winista.Mime;
using YoutubeDLSharp.Metadata;

namespace YTR.Classes
{
    public class YTRThumbnailData : YoutubeDLSharp.Metadata.ThumbnailData
    {
        public MimeType MimeType { get; set; }

        public YTRThumbnailData() : base() { }
        public YTRThumbnailData(MimeType mimeType) : base()
        {
            this.MimeType = mimeType;
        }
    }
}
