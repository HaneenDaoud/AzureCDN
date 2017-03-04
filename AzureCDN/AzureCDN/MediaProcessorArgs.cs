using System.Collections.Generic;
using Sitecore.Data.Items;
using Sitecore.Pipelines;

namespace MediaLibrary.Azure.CDN
{
    class MediaProcessorArgs : PipelineArgs
    {
        public IEnumerable<Item> UploadedItems { get; set; }
    }
}
