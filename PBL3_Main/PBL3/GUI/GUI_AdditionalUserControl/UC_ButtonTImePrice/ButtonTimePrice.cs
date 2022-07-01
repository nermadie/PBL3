using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO.DTO_ShowTime;
using PBL3.GUI.DelegateTemplate;

namespace PBL3.GUI.GUI_AdditionalUserControl.UC_ButtonTimePrice
{
    public partial class ButtonTimePrice : UserControl
    {
        public Del_ShowTime buyTicketbyShowTime { get; set; }
        private string currentShowTime_IdRoom;
        private DateTime currentShowTime_Time;
        private ShowTime currentShowTime;
        public ButtonTimePrice(ShowTime showtime)
        {
            InitializeComponent();
            currentShowTime = showtime;
        }
        private void ButtonTimePrice_Load(object sender, EventArgs e)
        {
            string hour_string = "";
            string minute_string = "";
            int hour = currentShowTime.Time.Hour;
            int minute = currentShowTime.Time.Minute;
            if (hour < 10)
                hour_string += "0" + hour;
            else
                hour_string = hour.ToString();
            if (minute < 10)
                minute_string += "0" + minute;
            else
                minute_string = minute.ToString();
            this.guna2ButtonTimePrice.Text = hour_string + ":" + minute_string + " " + currentShowTime.TicketPrice / 1000 + "K";
            currentShowTime_IdRoom = currentShowTime.IdRoom;
            currentShowTime_Time = currentShowTime.Time;
        }
        private void guna2Button1TimePrice_Click(object sender, EventArgs e)
        {
            buyTicketbyShowTime(currentShowTime_IdRoom, currentShowTime_Time);
        }
    }
}
