﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace YT_RED.Settings
{
    public class AdvancedSettings : FeatureSettings
    {
        public override AppFeature Feature => AppFeature.Advanced;        

        
        [Category("Processing")]
        [DisplayName("Preferred Video Format")]
        [Description("Prefer this format when downloading \"Preferred\" video")]
        [JsonProperty("preferred_video_format")]
        public YoutubeDLSharp.Options.DownloadMergeFormat PreferredVideoFormat { get; set; }

        [Category("Processing")]
        [DisplayName("Preferred Audio Format")]
        [Description("Prefer this format when downloading \"preferred\" audio")]
        [JsonProperty("preferred_audio_format")]
        public YoutubeDLSharp.Options.AudioConversionFormat PreferredAudioFormat { get; set; }

        public AdvancedSettings()
        {
            PreferredVideoFormat = YoutubeDLSharp.Options.DownloadMergeFormat.Mp4;
            PreferredAudioFormat = YoutubeDLSharp.Options.AudioConversionFormat.Mp3;
        }

        public override async Task<string> ValidateSettings()
        {
            return await base.ValidateSettings();
        }
    }
}
