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
using PBL3.BLL;
using PBL3.DTO.DTO_ShowTime;
using PBL3.GUI.DelegateTemplate;
using PBL3.GUI.GUI_Alert;

namespace PBL3.GUI.GUI_MainForm.GUI_Customer.CusMainForm_UserControl
{
    public partial class CMF_Tickets : UserControl
    {
        public Del_ShowTimeListSeat saveDataTicket { get; set; }
        public Del_ShowTimeListSeat openCartFromTicket { get; set; }
        private ShowTime showtime;
        private List<string> bookingSeats;

        public CMF_Tickets()
        {
            InitializeComponent();
            this.Enabled = false;
            Alert alert = new Alert();
            alert.showAlert("Choose Showtimes First", "We will enable this tab when you have your showtime.", Alert.enumType.Warning);
        }
        public CMF_Tickets(string idRoom, DateTime time)
        {
            InitializeComponent();
            showtime = BLL_QLRapchieuphim.Instance.getShowTimebyidRoom_Time(idRoom, time);
            ticket_Initial();
            bookingSeats = new List<string>();
            loadRightPanel();
        }

        private void loadRightPanel()
        {
            //Load Right Panel
            guna2PictureBoxPoster.Image = BLL_QLRapchieuphim.Instance.getImagebyIdMovie(showtime.IdMovie);
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
                if (bookingSeats.Count < 6)
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
                    Alert alert = new Alert();
                    alert.showAlert("Warning!", "Only 6 tickets can be booked at the same time.", Alert.enumType.Warning);
                }
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
            textBoxSeats.Text = String.Join(", ", bookingSeats);
            textBoxTotal.Text = (showtime.TicketPrice * bookingSeats.Count).ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveDataTicket(showtime.IdRoom, showtime.Time, bookingSeats);
            Alert alert = new Alert();
            alert.showAlert("Successful", "Tickets have been saved to cart!", Alert.enumType.Success);
            List<string> bookingSeatsTemp = new List<string>();
            bookingSeatsTemp.AddRange(bookingSeats.ToArray());
            bookingSeats = bookingSeatsTemp;
        }

        private void buttonPayNow_Click(object sender, EventArgs e)
        {
            openCartFromTicket(showtime.IdRoom, showtime.Time, bookingSeats);
            List<string> bookingSeatsTemp = new List<string>();
            bookingSeatsTemp.AddRange(bookingSeats.ToArray());
            bookingSeats = bookingSeatsTemp;
        }
    }
}
