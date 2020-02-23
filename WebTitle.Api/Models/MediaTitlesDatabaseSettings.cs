using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTitle.Api.Models
{
    public class MediaTitlesDatabaseSettings : IMediaTitlesDatabaseSettings
    {
        public string MediaTitlesCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }

    }

    public interface IMediaTitlesDatabaseSettings
    {
        string MediaTitlesCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
