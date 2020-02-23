using System;
using System.Collections.Generic;

namespace WebTitle.Api.Models
{
    public partial class Genre
    {
        public Genre()
        {
            //TitleGenres = new HashSet<TitleGenre>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        //public virtual ICollection<TitleGenre> TitleGenres { get; set; }
    }
}
