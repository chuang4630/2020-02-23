using System;
using System.Collections.Generic;

namespace WebTitle.Api.Models
{
    public partial class TitleParticipant
    {
        public int Id { get; set; }
        public int TitleId { get; set; }
        public int ParticipantId { get; set; }
        public bool IsKey { get; set; }
        public string RoleType { get; set; }
        public bool IsOnScreen { get; set; }

        public string Name { get; set; }
        public string ParticipantType { get; set; }
        public int SortOrder { get; set; }


        //public virtual Participant Participant { get; set; }
        public virtual Title Title { get; set; }
    }
}
