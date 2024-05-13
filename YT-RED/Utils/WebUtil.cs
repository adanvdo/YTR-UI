using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using YTR.Classes;
using YTR.Logging;
using YTR.Settings;

namespace YTR.Utils
{
    public static class WebUtil
    {
        public static async Task<MemoryStream> GetStreamFromUrl(string url)
        {
            try
            {
                Uri uri = new Uri(url);
                byte[] dataBytes = null;
                using (var client = new WebClient())
                {
                    dataBytes = await client.DownloadDataTaskAsync(url.Contains("ytimg.com") ? uri.GetLeftPart(UriPartial.Path) : uri.AbsoluteUri);
                }
                return new MemoryStream(dataBytes);
            }
            catch(Exception ex)
            {
                ExceptionHandler.LogException(ex);
            }
            return null;
        }

        public static async Task<byte[]> DownloadByteArrayAsync(string url)
        {
            try
            {
                Uri uri = new Uri(url);
                byte[] dataBytes = null;
                using (var client = new WebClient())
                {
                    dataBytes = await client.DownloadDataTaskAsync(url.Contains("ytimg.com") ? uri.GetLeftPart(UriPartial.Path) : uri.AbsoluteUri);
                }
                return dataBytes;
            }
            catch (Exception ex)
            {
                ExceptionHandler.LogException(ex);
            }
            return null;
        }

        public static async Task<bool> DownloadFile(string url, string destination)
        {
            try
            {
                using (var client = new WebClient())
                {
                    await client.DownloadFileTaskAsync(url, destination);
                }
                return true;
            }
            catch (Exception ex)
            {
                ExceptionHandler.LogException(ex);
            }
            return false;
        }

        public static async Task<bool> DownloadFileWithProgress(string url, string destination, DownloadProgressChangedEventHandler progressChanged)
        {
            try
            {
                using (var client = new WebClient())
                {
                    client.DownloadProgressChanged += progressChanged;
                    await client.DownloadFileTaskAsync(url, destination);
                }
                return true;
            }
            catch (Exception ex)
            {
                ExceptionHandler.LogException(ex);
            }
            return false;
        }
    }
}
