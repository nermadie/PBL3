using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public ButtonTimePrice(ShowTime showtime)
        {
            InitializeComponent();
            this.guna2ButtonTimePrice.Text = showtime.Time.Hour + ":" + showtime.Time.Minute + " " + showtime.TicketPrice / 1000 + "K";
            currentShowTime_IdRoom = showtime.IdRoom;
            currentShowTime_Time = showtime.Time;
        }

        private void guna2Button1TimePrice_Click(object sender, EventArgs e)
        {
            buyTicketbyShowTime(currentShowTime_IdRoom, currentShowTime_Time);
        }
    }
}
