using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;
using PBL3.BLL.BLL_MainForm.BLL_Customer.BLL_BuyTicket;
using PBL3.BLL.BLL_MainForm.BLL_Customer.BLL_Tickets;
using PBL3.DTO.DTO_ShowTime;
using PBL3.GUI.GUI_Alert;

namespace PBL3.GUI.GUI_MainForm.GUI_Customer.CusMainForm_UserControl
{
    public partial class Tickets : UserControl
    {
        private ShowTime showtime;
        private List<string> bookingSeats;

        public Tickets()
        {
            InitializeComponent();
            this.Enabled = false;
            Alert alert = new Alert();
            alert.showAlert("Choose Showtimes First", "We will enable this tab when you have your showtime.", Alert.enumType.Warning);
        }
        public Tickets(string idRoom, DateTime time)
        {
            InitializeComponent();
            showtime = BLL_Tickets.Instance.getShowTimebyidRoom_Time(idRoom, time);
            ticket_Initial();
            bookingSeats = new List<string>();
            loadRightPanel();
        }

        private void loadRightPanel()
        {
            //Load Right Panel
            guna2PictureBoxPoster.Image = BLL_Showtimes.Instance.getImagebyIdMovie(showtime.IdMovie);
            textBoxRoom.Text = showtime.Room.NameRoom;
            textBoxTitle.Text = showtime.Movie.NameMovie;
            textBoxTime.Text = showtime.Time.ToString();
            textBoxTicketPrice.Text = showtime.TicketPrice.ToString();
            textBoxTotal.Text = (showtime.TicketPrice * bookingSeats.Count).ToString();
        }
        private void ticket_Initial()
        {
            int numofSeat = showtime.Seat.Length;
            int numofRow = (numofSeat - 1) / 10 + 1;
            int numofLastRow = (numofSeat) - (numofRow - 1) * 10;
            foreach (Control ctrl in guna2PanelRoom.Controls)
            {
                if (ctrl.GetType().ToString() == "Guna.UI2.WinForms.Guna2Panel")
                {
                    string temp = ctrl.Name;
                    int tempLastChartoNum = Convert.ToInt32(temp[temp.Length - 1].ToString());
                    if (tempLastChartoNum > numofRow)
                        ctrl.Visible = false;
                    else if (tempLastChartoNum == numofRow)
                    {
                        foreach (Control subCtrl in ctrl.Controls)
                        {
                            if (subCtrl.GetType().ToString() == "Guna.UI2.WinForms.Guna2Button")
                            {
                                string temp2 = subCtrl.Name;
                                int tempLastChartoNum2 = Convert.ToInt32(temp2[temp2.Length - 1].ToString());
                                if (tempLastChartoNum2 >= numofLastRow)
                                    subCtrl.Visible = false;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < showtime.Seat.Length; i++)
            {
                if (showtime.Seat[i] == '1')
                {
                    foreach (Control ctrl in guna2PanelRoom.Controls)
                    {
                        foreach (Control subCtrl in ctrl.Controls)
                        {
                            if (subCtrl.Name == "guna2Button" + i)
                            {
                                subCtrl.Enabled = false;
                            }
                        }
                    }
                }
            }
        }

        private void guna2Button_Click(object sender, EventArgs e)
        {
            if (((Guna.UI2.WinForms.Guna2Button)sender).Checked == false)
            {
                ((Guna.UI2.WinForms.Guna2Button)sender).Checked = true;
                string nameButton = ((Guna.UI2.WinForms.Guna2Button)sender).Name;
                string seat = nameButton.Substring(11);
                int seatNum = Convert.ToInt32(seat);
                string res = "";
                res += ((char)(seatNum / 10 + 65)).ToString();
                res += "" + (seatNum % 10);
                bookingSeats.Add(res);
            }
            else
            {
                ((Guna.UI2.WinForms.Guna2Button)sender).Checked = false;
                string nameButton = ((Guna.UI2.WinForms.Guna2Button)sender).Name;
                string seat = nameButton.Substring(11);
                int seatNum = Convert.ToInt32(seat);
                string res = "";
                res += ((char)(seatNum / 10 + 65)).ToString();
                res += "" + (seatNum % 10);
                bookingSeats.Remove(res);
            }
            textBoxSeats.Text = String.Join(" ,", bookingSeats);
            textBoxTotal.Text = (showtime.TicketPrice * bookingSeats.Count).ToString();
        }
    }
}
