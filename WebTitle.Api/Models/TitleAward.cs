using System;
using System.Collections.Generic;


namespace WebTitle.Api.Models
{

    public partial class TitleAward
    {
        public TitleAward()
        {
            Participants = new HashSet<string>();
        }

        public int TitleId { get; set; }
        public bool? AwardWon { get; set; }
        public int? AwardYear { get; set; }
        public string Award { get; set; }
        public string AwardCompany { get; set; }
        public int Id { get; set; }

        //public virtual Title Title { get; set; }
        public virtual ICollection<string> Participants { get; set; }

    }
}
