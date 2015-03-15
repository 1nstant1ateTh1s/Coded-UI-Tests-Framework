using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using FDACodedUITests_Framework.Resources;

namespace FDACodedUITests_Framework.Config
{
    public class PlaybackConfig
    {
        /// <summary>
        /// Set the SearchTimeout Playback Setting based on the PlaybackConfiguration value
        /// </summary>
        public static void SetThinkSearchTimeOut()
        {
            Playback.PlaybackSettings.SearchTimeout = Convert.ToInt32(PlaybackConfiguration.SearchTimeout);
        }

        /// <summary>
        /// Set the WaitForReadyTimeout Playback Setting based on the PlaybackConfiguration value
        /// </summary>
        public static void SetWaitForReadyTimeout()
        {
            Playback.PlaybackSettings.WaitForReadyTimeout = Convert.ToInt32(PlaybackConfiguration.WaitForReadyTimeout);
        }

        /// <summary>
        /// Reset Playback Settings to default
        /// </summary>
        public static void ResetPlaybackSettings()
        {
            Playback.PlaybackSettings.ResetToDefault();
        }
    }
}
