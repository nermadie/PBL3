using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO.DTO_ShowTime
{
    public sealed class Room
    {
        public Room()
        {
            ShowTimes = new HashSet<ShowTime>();
        }
        [Key]
        public string IdRoom { get; set; }
        public string NameRoom { get; set; }
        public int NumberSeats { get; set; }
        //Navigation Properties
        public ICollection<ShowTime> ShowTimes { get; set; }
    }
}
