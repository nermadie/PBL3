using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO.DTO_View
{
    public class Detail_Movie
    {
        public string IdMovie { get; set; }
        public string NameMovie { get; set; }
        public string Director { get; set; }
        public TimeSpan Duration { get; set; }
        public string Actor { get; set; }
        public string Category { get; set; }
        public double Rate { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        //if you want to be able to click a link to watch the trailer
        //put that attribute here and go to the BLL_Admin to fix some bugs
    }
}
