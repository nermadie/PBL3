using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL.BLL_MainForm.BLL_Customer.BLL_Payment;
using PBL3.BLL.BLL_MainForm.BLL_Customer.BLL_Tickets;
using PBL3.DTO.DTO_Order;
using PBL3.DTO.DTO_ShowTime;
using PBL3.GUI.DelegateTemplate;
using PBL3.GUI.GUI_AdditionalUserControl.UC_CartPopcornDrink;
using PBL3.GUI.GUI_AdditionalUserControl.UC_PDPayment;
using PBL3.GUI.GUI_Alert;

namespace PBL3.GUI.GUI_MainForm.GUI_Customer.CusMainForm_UserControl
{
    public partial class CMF_Payment : UserControl
    {
        public Del_void openHome { get; set; }
        public Del_Event openCart_Cancel { get; set; }
        private ShowTime showtime;
        private List<string> seatsPurchased;
        private DataGridViewRowCollection dataGridViewRows;
        private string currentCus;
        public CMF_Payment(string idCustomer, ShowTime showtime, List<string> seatsPurchased, DataGridViewRowCollection dataGridViewRows, int ticketPrice, int pdPrice, int totalPrice)
        {
            InitializeComponent();
            currentCus = idCustomer;
            textBoxTitle.Text = "";
            labelQuantity.Text = "";
            if (showtime != null)
            {
                this.showtime = showtime;
                textBoxTitle.Text = showtime.Movie.NameMovie;
                labelQuantity.Text = "x" + seatsPurchased.Count;
            }
            this.seatsPurchased = seatsPurchased;
            this.dataGridViewRows = dataGridViewRows;
            foreach (DataGridViewRow dataGridViewRow in dataGridViewRows)
            {
                PDPayment temp = new PDPayment(dataGridViewRow.Cells["NamePopcornDrink"].Value.ToString(), dataGridViewRow.Cells["Quantity"].Value.ToString());
                flowLayoutPanel1.Controls.Add(temp);
            }
            labelPDPrice.Text = pdPrice + " đ";
            labelTicketPrice.Text = ticketPrice + " đ";
            textBoxTotal.Text = totalPrice.ToString();
        }
        private void CMF_Payment_Load(object sender, EventArgs e)
        {
            panelCredit.Enabled = false;
        }
        private void radioButtonCash_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCash.Checked)
                panelCredit.Enabled = false;
        }

        private void radioButtonCredit_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCredit.Checked)
                panelCredit.Enabled = true;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (radioButtonCredit.Checked == false && radioButtonCash.Checked == false)
            {
                Alert alert = new Alert();
                alert.showAlert("Warning!", "Please select payment method", Alert.enumType.Warning);
            }
            else
            {
                DateTime temp = DateTime.Now;
                //Tao 1 order moi
                Order order = new Order
                {
                    IdOrder = BLL_Payment.Instance.findGoodIdOrder(),
                    IdCustomer = currentCus,
                    TimeOrder = temp,
                    Code = BLL_Payment.Instance.RandomString(8)
                };
                BLL_Payment.Instance.AddOrder(order);
                //tao ticketorder
                if (showtime != null)
                {
                    foreach (string seat in seatsPurchased)
                    {
                        TicketOrder ticketOrder = new TicketOrder
                        {
                            IdTicketOrder = BLL_Payment.Instance.findGoodIdTicketOrder(), //8
                            IdOrder = order.IdOrder,
                            IdRoom = showtime.IdRoom,
                            Time = showtime.Time,
                            SeatPurchased = seat
                        };
                        BLL_Payment.Instance.AddTicketOrder(ticketOrder);
                    }
                    //Vao showtime chinh lai so ghe trong
                    foreach (string seat in seatsPurchased)
                    {
                        BLL_Payment.Instance.UpdateShowtimeSeats(seat, showtime.IdRoom, showtime.Time);
                    }
                }
                //tao pdorder
                if (dataGridViewRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridViewRows)
                    {
                        PopcornDrinkOrder popcornDrinkOrder = new PopcornDrinkOrder
                        {
                            IdPopcornDrinkOrder = BLL_Payment.Instance.findGoodIdPDOrder(),//8
                            IdOrder = order.IdOrder,
                            NamePopcornDrink = row.Cells["NamePopcornDrink"].Value.ToString(),
                            PopcornDrinkPrice = Convert.ToInt32(row.Cells["PopcornDrinkPrice"].Value.ToString()),
                            Quantity = Convert.ToInt32(row.Cells["Quantity"].Value.ToString())
                        };
                        BLL_Payment.Instance.AddPDOrder(popcornDrinkOrder);
                    }
                }
                //Success and Turn back to home, flush Cart
                Alert alert = new Alert();
                Alert alert2 = new Alert();
                alert.showAlert($"Successful. CODE: {order.Code}", "Use this code to get tickets at the cashier!", Alert.enumType.Success);
                alert2.showAlert("View purchase history", "You can check your code in the purchase history section", Alert.enumType.Info);
                openHome();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            openCart_Cancel(new object(), EventArgs.Empty);
        }
    }
}
