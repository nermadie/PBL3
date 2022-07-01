using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO.DTO_ShowTime;
using PBL3.EntityFramework;

namespace PBL3.BLL.BLL_MainForm.BLL_Customer.BLL_Tickets
{
    public class BLL_Tickets
    {
        private QLRapChieuPhim db = new QLRapChieuPhim();
        private static BLL_Tickets _Instance;

        public static BLL_Tickets Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_Tickets();
                }

                return _Instance;
            }
            private set { }
        }
        private BLL_Tickets()
        {
        }

        public ShowTime getShowTimebyidRoom_Time(string idRoom, DateTime time)
        {
            return db.ShowTimes.Include("Room").Include("Movie").FirstOrDefault(t => t.IdRoom == idRoom && t.Time == time);
        }
    }
}
