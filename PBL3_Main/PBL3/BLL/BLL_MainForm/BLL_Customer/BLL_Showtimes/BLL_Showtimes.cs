using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL.BLL_Login.BLL_Login_Admin;
using PBL3.DTO.DTO_Person;
using PBL3.DTO.DTO_ShowTime;
using PBL3.EntityFramework;
using PBL3.GUI.DelegateTemplate;
using PBL3.GUI.GUI_AdditionalUserControl.UC_ButtonTimePrice;
using PBL3.GUI.GUI_MainForm.GUI_Customer.CusMainForm_UserControl;

namespace PBL3.BLL.BLL_MainForm.BLL_Customer.BLL_Showtimes
{
    public class BLL_Showtimes
    {
        private QLRapChieuPhim db = new QLRapChieuPhim();
        private static BLL_Showtimes _Instance;

        public static BLL_Showtimes Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_Showtimes();
                }

                return _Instance;
            }
            private set { }
        }
        private BLL_Showtimes()
        {
        }

        //public Control[] getListItem(DateTime dateTime, Del_Movie importData, Del_ShowTime openBuyTicket)
        //{

        //    var showTimeinThisDay = db.ShowTimes.Where(st => DbFunctions.TruncateTime(st.Time) == dateTime.Date).ToList();
        //    //var movieinThisDay = (from st in showTimeinThisDay group st by st.IdMovie into g select g).ToList();
        //    var movieinThisDay = showTimeinThisDay.GroupBy(st => st.IdMovie).ToList();
        //    int numofMovie = movieinThisDay.Count;
        //    ListItem[] listItems = new ListItem[numofMovie];
        //    for (int i = 0; i < numofMovie; i++)
        //    {
        //        string tempKey = movieinThisDay[i].Key;
        //        Movie temp = db.Movies.FirstOrDefault(m => m.IdMovie == tempKey);
        //        listItems[i] = new ListItem(temp.IdMovie, openBuyTicket);
        //        listItems[i].TitleText = temp.NameMovie;
        //        listItems[i].DescriptionText = temp.Description;
        //        listItems[i].Rating = (float)temp.Rate;
        //        listItems[i].PosterImage = getImagebyIdMovie(temp.IdMovie);
        //        var showTimeByMovieinThisDay =
        //            showTimeinThisDay.Where(st => st.IdMovie == temp.IdMovie).ToList();
        //        listItems[i].ChangeTimeList(showTimeByMovieinThisDay);
        //        //set delegate
        //        listItems[i].importDatatoPanelDetail = importData;
        //    }
        //    return listItems;
        //}

        public ListItem[] getListItem(DateTime dateTime, Del_Movie importData, Del_ShowTime buyTicketbyShowTime_Tickets, string text)
        {
            var showTimeinThisDay = db.ShowTimes.Include("Movie").Where(st => DbFunctions.TruncateTime(st.Time) == dateTime.Date).ToList();
            //var movieinThisDay = (from st in showTimeinThisDay group st by st.IdMovie into g select g).ToList();
            var movieinThisDay = showTimeinThisDay.Where(st => st.Movie.NameMovie.ToLower().Contains(text.ToLower())).GroupBy(st => st.IdMovie).ToList();
            int numofMovie = movieinThisDay.Count;
            ListItem[] listItems = new ListItem[numofMovie];
            for (int i = 0; i < numofMovie; i++)
            {
                string tempKey = movieinThisDay[i].Key;
                Movie temp = db.Movies.FirstOrDefault(m => m.IdMovie == tempKey);
                listItems[i] = new ListItem(temp.IdMovie);
                listItems[i].buyTicketbyShowTime_ListItem = buyTicketbyShowTime_Tickets;
                listItems[i].TitleText = temp.NameMovie;
                listItems[i].DescriptionText = temp.Description;
                listItems[i].Rating = (float)temp.Rate;
                listItems[i].PosterImage = getImagebyIdMovie(temp.IdMovie);
                var showTimeByMovieinThisDay =
                    showTimeinThisDay.Where(st => st.IdMovie == temp.IdMovie).OrderBy(st => st.Time).ToList();
                listItems[i].ChangeTimeList(showTimeByMovieinThisDay);
                //set delegate
                listItems[i].importDatatoPanelDetail = importData;
            }
            return listItems;
        }
        public Movie getMoviebyIdMovie(string idMovie)
        {
            return db.Movies.FirstOrDefault(m => m.IdMovie == idMovie);
        }

        public Image getImagebyIdMovie(string idMovie)
        {
            return Image.FromFile(@"..\..\Image\Picture\PictureMovie\" + idMovie + ".jpeg");
        }
    }
}
