using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using PBL3.BLL.BLL_MainForm.BLL_Customer.BLL_Tickets;
using PBL3.DTO.DTO_ShowTime;
using PBL3.GUI.GUI_AdditionalUserControl.UC_CartPopcornDrink;

namespace PBL3.GUI.GUI_MainForm.GUI_Customer.CusMainForm_UserControl
{
    public partial class CMF_Cart : UserControl
    {
        //Data of Ticket
        //Data of PopcornDrink
        private int totalPrice = 0;
        public CMF_Cart()
        {
            InitializeComponent();
        }
        private void CMF_Cart_Load(object sender, EventArgs e)
        {
            changePrice();
        }

        public void saveDataTicket(string idRoom, DateTime time, List<string> seatsPurchased)
        {
            dataGridViewTicket.Rows.Clear();
            ShowTime tempShowTime = BLL_Tickets.Instance.getShowTimebyidRoom_Time(idRoom, time);
            foreach (var seat in seatsPurchased)
            {
                dataGridViewTicket.Rows.Add(new object[]
                {
                    0,
                    tempShowTime.Movie.NameMovie,
                    tempShowTime.Room.NameRoom,
                    tempShowTime.Time,
                    seat,
                    tempShowTime.TicketPrice
                });
            }
            changePrice();
        }

        public void saveDataPD(List<CartPopcornDrink> listCartPopcornDrinks)
        {
            dataGridViewPD.Rows.Clear();
            foreach (CartPopcornDrink cartPopcornDrink in listCartPopcornDrinks)
            {
                dataGridViewPD.Rows.Add(new object[]
                {
                    0,
                    cartPopcornDrink.TitleText,
                    Convert.ToInt32(cartPopcornDrink.PriceText),
                    cartPopcornDrink.Quantity
                });
            }
            changePrice();
        }
        private void changePrice()
        {
            int ticketPrice = 0;
            int pdPrice = 0;
            foreach (DataGridViewRow row in dataGridViewTicket.Rows)
            {
                ticketPrice += Convert.ToInt32(row.Cells["TicketPrice"].Value);
            }

            foreach (DataGridViewRow row in dataGridViewPD.Rows)
            {
                pdPrice += Convert.ToInt32(row.Cells["PopcornDrinkPrice"].Value) * Convert.ToInt32(row.Cells["Quantity"].Value);
            }
            labelTicketPrice.Text = ticketPrice + " đ";
            labelPDPrice.Text = pdPrice + " đ";
            textBoxTotal.Text = (ticketPrice + pdPrice).ToString();
            totalPrice = ticketPrice + pdPrice;
        }
        private void guna2DataGridViewPD_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewPD.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void guna2DataGridViewTicket_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewTicket.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void buttonResetTicket_Click(object sender, EventArgs e)
        {
            dataGridViewTicket.Rows.Clear();
            changePrice();
        }

        private void buttonResetPD_Click(object sender, EventArgs e)
        {
            dataGridViewPD.Rows.Clear();
            changePrice();
        }

        private void buttonResetAll_Click(object sender, EventArgs e)
        {
            dataGridViewTicket.Rows.Clear();
            dataGridViewPD.Rows.Clear();
            changePrice();
        }

        private void buttonPayNow_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewTicket_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            changePrice();
        }

        private void dataGridViewPD_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            changePrice();
        }
    }
}
