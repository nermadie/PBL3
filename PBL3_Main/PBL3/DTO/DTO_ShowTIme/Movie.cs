using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO.DTO_ShowTime
{
    public sealed class Movie
    {
        public Movie()
        {
            ShowTimes = new HashSet<ShowTime>();
        }
        [Key]
        public string IdMovie { get; set; }
        public string NameMovie { get; set; }
        public string Director { get; set; }
        public TimeSpan Duration { get; set; }
        public string Actor { get; set; }
        public string Category { get; set; }
        public double Rate { get; set; }
        public string Description { get; set; }

        public DateTime ReleaseDate { get; set; }
        public string LinkTrailer { get; set; }

        //Navigation Properties
        public ICollection<ShowTime> ShowTimes { get; set; }
    }
}
