using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LexiconMDB.Models
{
    public class Movie   // POCO  ska vara enkel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }
        public Genre Genre { get; set; }
        public int AgeLimit { get; set; }
        public int MetaScore { get; set; }

        public string LengthInHours  // kommer inte med i data basen
        {
            get
            {
                var hours = Length / 60;
                var minutes = Length - hours * 60;
                return $"{hours}:{minutes:00}";
            }
        }
    }

    public enum Genre
    {
        Action,
        Drama,
        Horror,
        Comedy,
        DramaComedy
    }
}