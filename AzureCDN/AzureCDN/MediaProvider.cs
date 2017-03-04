using Sitecore.Configuration;
using Sitecore.Data.Items;
using Sitecore.Events.Hooks;
using Sitecore.Resources.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MediaLibrary.Azure.CDN
{
    class MediaProvider : Sitecore.Resources.Media.MediaProvider
    {
        public void Initialize()
        {
            MediaManager.Provider = this;
        }

        public override string GetMediaUrl(MediaItem item)
        {
            string mediaUrl = base.GetMediaUrl(item);
            return GetMediaUrl(mediaUrl, item);
        }

        public override string GetMediaUrl(MediaItem item, MediaUrlOptions options)
        {
            string mediaUrl = base.GetMediaUrl(item, options);
            return GetMediaUrl(mediaUrl, item);
        }



        /// <summary>
        /// Sites that are allows to use the CDN Media Provider
        /// </summary>
        public string GetMediaPath(MediaItem mediaItem, string extension = "")
        {
            string newFileName = Sitecore.MainUtil.EncodeName(mediaItem.Name);
            return (mediaItem.MediaPath.TrimStart('/').Replace(mediaItem.DisplayName, newFileName + "." + extension).ToLower());
        }

        /// <summary>
        /// Determines if we should be pulling from the CDN or not and return item with its version 
        /// </summary>
        /// <param name="mediaUrl"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public string GetMediaUrl(string mediaUrl, MediaItem item)
        {
            string OriginPrefix = Settings.GetSetting("OriginPrefix");
            if (Sitecore.Context.Database.Name != "core")
            {
                if (string.IsNullOrEmpty(OriginPrefix))
                {
                    return mediaUrl;
                }
                if (mediaUrl.ToLower().Contains("-/media/"))
                {
                    mediaUrl = OriginPrefix + mediaUrl.Substring(mediaUrl.LastIndexOf("-/media/") + 8, mediaUrl.Length - 8 - mediaUrl.LastIndexOf("-/media/")).ToLower();
                    mediaUrl= mediaUrl.Replace((item.Name + "." + item.Extension).ToLower(), (item.Name + "-" + Sitecore.Context.Language.Name   + "." + item.Extension).ToLower()).ToLower();

                }
                if (mediaUrl.ToLower().Contains("?"))
                {
                    mediaUrl = mediaUrl.Split('?')[0];
                }

                mediaUrl = string.Format("{0}?rv={1}", mediaUrl, item.InnerItem.Statistics.Revision);
            }
            return mediaUrl;
        }
    }
}