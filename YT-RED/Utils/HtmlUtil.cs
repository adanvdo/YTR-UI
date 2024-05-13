using HtmlAgilityPack;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using YTR.Classes;
using YTR.Logging;

namespace YTR.Utils
{
    public static class HtmlUtil
    {
        /// <summary>
        /// Checks if the passed url is a reddit or youtube url
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static DownloadType CheckUrl(string url)
        {
            if (url.StartsWith(@"https://www.youtube.com") || url.StartsWith("https://youtu.be") || url.StartsWith(@"https://youtube.com"))
                return DownloadType.YouTube;
            if (url.StartsWith(@"https://reddit.com") || url.StartsWith(@"https://www.reddit.com"))
                return DownloadType.Reddit;
            if (url.StartsWith(@"https://twitter.com") || url.StartsWith(@"https://www.twitter.com") || url.StartsWith(@"https://m.twitter.com") || url.StartsWith(@"http://mobile.twitter.com"))
                return DownloadType.Twitter;
            if (url.StartsWith(@"https://www.twitch.tv") || url.StartsWith(@"https://twitch.tv") || url.StartsWith(@"https://go.twitch.tv") || url.StartsWith(@"https://m.twitch.tv"))
                return DownloadType.Twitch;
            if (url.StartsWith(@"https://vimeo.com") || url.StartsWith(@"https://www.vimeo.com") || url.StartsWith(@"https://player.vimeo.com") || url.StartsWith(@"https://vimeopro.com"))
                return DownloadType.Vimeo;
            if (url.StartsWith(@"https://instagram.com") || url.StartsWith(@"https://www.instagram.com"))
                return DownloadType.Instagram;
            if (url.StartsWith(@"https://www.tiktok.com") || tiktokAltUrls.Any(url.Contains))
                return DownloadType.TikTok;

            var test = @"^[a-zA-Z][a-zA-Z0-9]*$";
            var t2 = Regex.Match(url, test);
            if (t2.Success && (url.Length == 11 || url.Length == 34)) return DownloadType.YouTube;

            if (string.IsNullOrEmpty(url)) return DownloadType.Empty;

            return DownloadType.Unknown;
        }

        private static List<string> tiktokAltUrls = new List<string>()
        {
            "abtest-sg-tiktok.byteoversea.com",
            "abtest-va-tiktok.byteoversea.com",
            "byteglb.com",
            "gts.byteoversea.net",
            "isnssdk.com",
            "lf1-ttcdn-tos.pstatp.com",
            "muscdn.com",
            "musemuse.cn",
            "musical.ly",
            "p16-ad-sg.ibyteimg.com",
            "p16-tiktok-sg.ibyteimg.com",
            "p16-tiktok-sign-va-h2.ibyteimg.com",
            "p16-tiktok-va-h2.ibyteimg.com",
            "p16-tiktok-va.ibyteimg.com",
            "p16-va-tiktok.ibyteimg.com",
            "p1-tt.byteimg.com",
            "p1-tt-ipv6.byteimg.com",
            "p26-tt.byteimg.com",
            "p3-tt-ipv6.byteimg.com",
            "p9-tt.byteimg.com",
            "pull-f3-hs.pstatp.com",
            "pull-f5-hs.flive.pstatp.com",
            "pull-f5-hs.pstatp.com",
            "pull-f5-mus.pstatp.com",
            "pull-flv-f1-hs.pstatp.com",
            "pull-flv-f6-hs.pstatp.com",
            "pull-flv-l1-hs.pstatp.com",
            "pull-flv-l1-mus.pstatp.com",
            "pull-flv-l6-hs.pstatp.com",
            "pull-hls-l1-mus.pstatp.com",
            "pull-l3-hs.pstatp.com",
            "pull-rtmp-f1-hs.pstatp.com",
            "pull-rtmp-f6-hs.pstatp.com",
            "pull-rtmp-l1-hs.pstatp.com",
            "pull-rtmp-l1-mus.pstatp.com",
            "pull-rtmp-l6-hs.pstatp.com",
            "quic-tiktok-core-proxy-i18n-gcpva.byteoversea.net",
            "quic-tiktok-proxy-i18n-gcpva.byteoversea.net",
            "sf16-ttcdn-tos.ipstatp.com",
            "sf1-ttcdn-tos.pstatp.com",
            "sf6-ttcdn-tos.pstatp.com",
            "sgsnssdk.com",
            "tiktokcdn.com",
            "tiktokcdn-eu.com",
            "tiktokcdn-eu.net",
            "tiktokcdn-in.com",
            "tiktokcdn-us.com",
            "tiktok.com",
            "tiktokd.org",
            "tiktokglobalshop.com",
            "tiktokglobalshopv.com",
            "tiktok.in",
            "tiktok-lb-alisg.byteoversea.net",
            "tiktok-lb-maliva.byteoversea.net",
            "tiktok-lb-texas.useast5.byteoversea.net.byteigtm.com",
            "tiktokmusic.app",
            "tiktok-platform-lb-alisg.byteoversea.net",
            "tiktok-platform-lb-maliva.byteoversea.net",
            "tiktokshop.com",
            "tiktokstaticb.com",
            "tiktokv.com",
            "tiktokv.eu",
            "tiktokv.us",
            "tiktokw.us",
            "tlivecdn.com",
            "ttapis.com",
            "ttdns2.com",
            "ttlivecdn.com",
            "ttoversea.net",
            "ttoverseaus.net",
            "ttwstatic.com"
        };
    }
}
