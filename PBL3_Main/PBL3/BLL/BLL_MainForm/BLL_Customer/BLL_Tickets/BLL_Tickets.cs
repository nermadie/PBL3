using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL.BLL_Login.BLL_Login_Admin;
using PBL3.DTO.DTO_Person;
using PBL3.DTO.DTO_ShowTime;
using PBL3.EntityFramework;
using PBL3.GUI.GUI_AdditionalUserControl.UC_ButtonTimePrice;

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

        public Control[] getListItem(DateTime dateTime)
        {
            var showTimeinThisDay = db.ShowTimes.Where(st => st.Time == dateTime).ToList();
            //var movieinThisDay = (from st in showTimeinThisDay group st by st.IdMovie into g select g).ToList();
            var movieinThisDay = showTimeinThisDay.GroupBy(st => st.IdMovie).ToList();
            int numofMovie = movieinThisDay.Count;
            ListItem[] listItems = new ListItem[numofMovie];
            for (int i = 0; i < numofMovie; i++)
            {
                string tempKey = movieinThisDay[i].Key;
                Movie temp = db.Movies.FirstOrDefault(m => m.IdMovie == tempKey);
                listItems[i] = new ListItem();
                listItems[i].TitleText = temp.NameMovie;
                listItems[i].DescriptionText = temp.Description;
                listItems[i].Rating = (float)temp.Rate;
                listItems[i].PosterImage = Image.FromFile(@"..\..\Image\Picture\PictureMovie\" + temp.IdMovie + ".jpeg");
                var showTimeByMovieinThisDay =
                    showTimeinThisDay.Where(st => st.IdMovie == temp.IdMovie).ToList();
                string[] time = new string[showTimeByMovieinThisDay.Count()];
                int[] price = new int[showTimeByMovieinThisDay.Count()];
                for (int j = 0; j < showTimeByMovieinThisDay.Count(); j++)
                {
                    time[j] = showTimeByMovieinThisDay[j].Time.Hour + ":" +
                              showTimeByMovieinThisDay[j].Time.Minute;
                    price[j] = showTimeByMovieinThisDay[j].TicketPrice;
                }
                listItems[i].ChangeTimeList(time, price);
            }
            return listItems;
        }
    }
}
