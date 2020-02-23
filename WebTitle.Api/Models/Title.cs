using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace WebTitle.Api.Models
{
    public partial class Title
    {
        public Title()
        {
            Awards = new HashSet<TitleAward>();
            OtherNames = new HashSet<OtherName>();
            Storylines = new HashSet<StoryLine>();
            TitleGenres = new HashSet<TitleGenre>();
            Participants = new HashSet<TitleParticipant>();
        }

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public int TitleId { get; set; }

        [BsonElement("TitleName")]
        public string TitleName { get; set; }
        public string TitleNameSortable { get; set; }
        public int? TitleTypeId { get; set; }
        public int? ReleaseYear { get; set; }
        public DateTime? ProcessedDateTimeUtc { get; set; }

        public string[] Genres { get; set; }

        public string[] KeyGenres { get; set; }
        public string[] Keywords { get; set; }

        public virtual ICollection<TitleAward> Awards { get; set; }


        public virtual ICollection<OtherName> OtherNames { get; set; }


        public virtual ICollection<StoryLine> Storylines { get; set; }


        public virtual ICollection<TitleGenre> TitleGenres { get; set; }


        public virtual ICollection<TitleParticipant> Participants { get; set; }
    }
}
