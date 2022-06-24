﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using YT_RED.Classes;
using YT_RED.Logging;
using YT_RED.Settings;
using Newtonsoft.Json;

namespace YT_RED.Utils
{
    public static class HttpUtil
    {
        private static string serverUrl = @"https://www.jamgalactic.com/api/ytred";
        private static async Task<HttpWebResponse> postErrorLogs(DateTime date)
        {
            try
            {
                string tidyLogs = string.Empty;
                string logFile = Path.Combine(AppSettings.Default.General.ErrorLogPath, $"ErrorLogs_{date.ToShortDateString()}.txt");
                if (File.Exists(logFile))
                {
                    string rawLogs = File.ReadAllText(logFile);
                    tidyLogs = rawLogs.Replace(@"\", @"\\").Replace(System.Environment.NewLine, @"\n").Replace("\n", @"\n").Trim();
                    if (tidyLogs.StartsWith("\n"))
                    {
                        tidyLogs = tidyLogs.Remove(0, 1);
                    }
                    if (tidyLogs.StartsWith("\\n"))
                    {
                        tidyLogs = tidyLogs.Remove(0, 2);
                    }                    
                }

                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(serverUrl);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(await httpWebRequest.GetRequestStreamAsync()))
                {
                    LogPostRequest request = new LogPostRequest(ReportingUtil.GetMac(), DateTime.Now, tidyLogs);
                    string json = JsonConvert.SerializeObject(request);

                    streamWriter.Write(json);
                }

                HttpWebResponse httpResponse = (HttpWebResponse)await httpWebRequest.GetResponseAsync();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                }

                return httpResponse;
            }
            catch(Exception ex)
            {
                ExceptionHandler.LogException(ex);
            }
            return null;
        }

        private static async Task<HttpWebResponse> postErrorLogs(string logs)
        {
            if (string.IsNullOrEmpty(logs))
                throw new ArgumentNullException("logs");

            try
            {
                string tidyLogs = logs.Replace(@"\", @"\\").Replace(System.Environment.NewLine, @"\n").Replace("\n", @"\n").Trim();
                if (tidyLogs.StartsWith("\n"))
                {
                    tidyLogs = tidyLogs.Remove(0, 1);
                }
                if (tidyLogs.StartsWith("\\n"))
                {
                    tidyLogs = tidyLogs.Remove(0, 2);
                }
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(serverUrl);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(await httpWebRequest.GetRequestStreamAsync()))
                {
                    LogPostRequest request = new LogPostRequest(ReportingUtil.GetMac(), DateTime.Now, tidyLogs);
                    string json = JsonConvert.SerializeObject(request);

                    streamWriter.Write(json);
                }

                HttpWebResponse httpResponse = (HttpWebResponse)await httpWebRequest.GetResponseAsync();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                }

                return httpResponse;
            }
            catch (Exception ex)
            {
                ExceptionHandler.LogException(ex);
            }
            return null;
        }
        public static async Task<bool> UploadErrorLogs(DateTime date)
        {
            try
            {
                HttpWebResponse postResponse = await postErrorLogs(date);
                if (postResponse.StatusCode == System.Net.HttpStatusCode.Created)
                    return true;
            }
            catch (Exception ex)
            {
                ExceptionHandler.LogException(ex);
            }
            return false;
        }

        public static async Task<bool> UploadErrorLogs(int max)
        {
            try
            {
                DirectoryInfo logDir = new DirectoryInfo(AppSettings.Default.General.ErrorLogPath);
                FileInfo[] files = await Task.Run(() => logDir.GetFiles());
                for(int i = 0; i < files.Length && i < max; i++)
                {
                    FileInfo file = files[i];
                    string logs = string.Empty;
                    if (File.Exists(file.FullName))
                    {
                        logs = await Task.Run(() => File.ReadAllText(file.FullName)); 
                        HttpWebResponse postResponse = await postErrorLogs(logs);
                        if (postResponse.StatusCode != HttpStatusCode.Created)
                            return false;
                    }
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
