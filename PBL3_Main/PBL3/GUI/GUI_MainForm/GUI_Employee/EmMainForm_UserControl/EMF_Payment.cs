﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;
using PBL3.DTO.DTO_Order;
using PBL3.DTO.DTO_ShowTime;
using PBL3.GUI.DelegateTemplate;
using PBL3.GUI.GUI_AdditionalUserControl.UC_CartPopcornDrink;
using PBL3.GUI.GUI_AdditionalUserControl.UC_PDPayment;
using PBL3.GUI.GUI_Alert;

namespace PBL3.GUI.GUI_MainForm.GUI_Employee.EmMainForm_UserControl
{
    public partial class EMF_Payment : UserControl
    {
        public Del_void openHome { get; set; }
        public Del_Event openCart_Cancel { get; set; }
        private ShowTime showtime;
        private List<string> seatsPurchased;
        private DataGridViewRowCollection dataGridViewRows;
        public EMF_Payment(ShowTime showtime, List<string> seatsPurchased, DataGridViewRowCollection dataGridViewRows, int ticketPrice, int pdPrice, int totalPrice)
        {
            InitializeComponent();
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
        private void EMF_Payment_Load(object sender, EventArgs e)
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
                    IdOrder = BLL_QLRapchieuphim.Instance.findGoodIdOrder(),
                    IdCustomer = null,
                    TimeOrder = temp,
                    Code = null
                };
                BLL_QLRapchieuphim.Instance.AddOrder(order);
                //tao ticketorder
                if (showtime != null)
                {
                    foreach (string seat in seatsPurchased)
                    {
                        TicketOrder ticketOrder = new TicketOrder
                        {
                            IdTicketOrder = BLL_QLRapchieuphim.Instance.findGoodIdTicketOrder(), //8
                            IdOrder = order.IdOrder,
                            IdRoom = showtime.IdRoom,
                            Time = showtime.Time,
                            SeatPurchased = seat
                        };
                        BLL_QLRapchieuphim.Instance.AddTicketOrder(ticketOrder);
                    }
                    //Vao showtime chinh lai so ghe trong
                    foreach (string seat in seatsPurchased)
                    {
                        BLL_QLRapchieuphim.Instance.UpdateShowtimeSeats(seat, showtime.IdRoom, showtime.Time);
                    }
                }
                //tao pdorder
                if (dataGridViewRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridViewRows)
                    {
                        PopcornDrinkOrder popcornDrinkOrder = new PopcornDrinkOrder
                        {
                            IdPopcornDrinkOrder = BLL_QLRapchieuphim.Instance.findGoodIdPDOrder(),//8
                            IdOrder = order.IdOrder,
                            NamePopcornDrink = row.Cells["NamePopcornDrink"].Value.ToString(),
                            PopcornDrinkPrice = Convert.ToInt32(row.Cells["PopcornDrinkPrice"].Value.ToString()),
                            Quantity = Convert.ToInt32(row.Cells["Quantity"].Value.ToString())
                        };
                        BLL_QLRapchieuphim.Instance.AddPDOrder(popcornDrinkOrder);
                    }
                }
                //Success and Turn back to home, flush Cart
                Alert alert = new Alert();
                alert.showAlert($"Successful", "Give the ticket to Customer!", Alert.enumType.Success);
                openHome();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            openCart_Cancel(new object(), EventArgs.Empty);
        }
    }
}
