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
using PBL3.BLL;
using PBL3.DTO.DTO_ShowTime;
using PBL3.GUI.DelegateTemplate;
using PBL3.GUI.GUI_AdditionalUserControl.UC_CartPopcornDrink;
using PBL3.GUI.GUI_Alert;

namespace PBL3.GUI.GUI_MainForm.GUI_Employee.EmMainForm_UserControl
{
    public partial class EMF_Cart : UserControl
    {
        //Data of Ticket
        //Data of PopcornDrink
        public Del_ShowTimeListstringDataGridViewRow openPayment { get; set; }
        private ShowTime currentShowTime;
        private List<string> currentseatsPurchased;
        private int totalPrice;
        private int ticketPrice;
        private int pdPrice;
        public EMF_Cart()
        {
            InitializeComponent();
            currentseatsPurchased = new List<string>();
        }
        private void CMF_Cart_Load(object sender, EventArgs e)
        {
            changePrice();
        }

        public void saveDataTicket(string idRoom, DateTime time, List<string> seatsPurchased)
        {
            dataGridViewTicket.Rows.Clear();
            ShowTime tempShowTime = BLL_QLRapchieuphim.Instance.getShowTimebyidRoom_Time(idRoom, time);
            currentShowTime = tempShowTime;
            currentseatsPurchased = seatsPurchased;
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
            ticketPrice = 0;
            pdPrice = 0;
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
            currentseatsPurchased.Clear();
            changePrice();
        }

        private void buttonResetPD_Click(object sender, EventArgs e)
        {
            dataGridViewPD.Rows.Clear();
            changePrice();
        }

        public void buttonResetAll_Click(object sender, EventArgs e)
        {
            dataGridViewTicket.Rows.Clear();
            currentseatsPurchased.Clear();
            dataGridViewPD.Rows.Clear();
            changePrice();
        }

        private void buttonPayNow_Click(object sender, EventArgs e)
        {
            if (currentseatsPurchased.Count != 0 || dataGridViewPD.Rows.Count != 0)
                openPayment(currentShowTime, currentseatsPurchased, dataGridViewPD.Rows, ticketPrice, pdPrice, totalPrice);
            else
            {
                Alert alert = new Alert();
                alert.showAlert("Warning!", "Your cart is empty!", Alert.enumType.Warning);
            }
        }

        private void dataGridViewTicket_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            changePrice();
            currentseatsPurchased.RemoveAt(e.RowIndex);
        }

        private void dataGridViewPD_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            changePrice();
        }
    }
}
