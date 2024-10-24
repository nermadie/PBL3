﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using PBL3.BLL;
using PBL3.DTO.DTO_Order;
using PBL3.DTO.DTO_Person;
using PBL3.DTO.DTO_ShowTime;
using PBL3.DTO.DTO_View;
using PBL3.GUI.GUI_Alert;

namespace PBL3.GUI.GUI_MainForm.GUI_Employee.EmMainForm_UserControl
{
    public partial class EMF_CheckCode : UserControl
    {
        private Employee currentEmployee;
        public EMF_CheckCode(string em)
        {
            InitializeComponent();
            this.currentEmployee = BLL_QLRapchieuphim.Instance.getEmployeebyIDEm(em);
        }
        private void EMF_History_Load(object sender, EventArgs e)
        {
        }
        private void guna2DataGridViewPD_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewPD.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void guna2DataGridViewTicket_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewTicket.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void loadData()
        {
            //load PD
            List<PopcornDrinkOrder> listPDO = BLL_QLRapchieuphim.Instance.getDataPDbyCode(textBoxCode.Text);
            dataGridViewPD.Rows.Clear();
            foreach (PopcornDrinkOrder popcornDrinkOrder in listPDO)
            {
                dataGridViewPD.Rows.Add(new object[]
                {
                    0,
                    popcornDrinkOrder.NamePopcornDrink,
                    popcornDrinkOrder.PopcornDrinkPrice,
                    popcornDrinkOrder.Quantity
                });
            }
            //load Ticket
            dataGridViewTicket.Rows.Clear();
            List<TicketOrder> listTO = BLL_QLRapchieuphim.Instance.getDataTicketOrderbyCode(textBoxCode.Text);
            foreach (TicketOrder ticketOrder in listTO)
            {
                dataGridViewTicket.Rows.Add(new object[]
                {
                    0,
                    ticketOrder.ShowTime.Movie.NameMovie,
                    ticketOrder.ShowTime.Room.NameRoom,
                    ticketOrder.ShowTime.Time,
                    ticketOrder.SeatPurchased,
                    ticketOrder.ShowTime.TicketPrice
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
        }

        private void buttonGetOrder_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (BLL_QLRapchieuphim.Instance.checkCodeforOrder(textBoxCode.Text))
            {
                Alert alert = new Alert();
                alert.showAlert("Success", "Code Checked!", Alert.enumType.Success);
            }
            else
            {
                Alert alert = new Alert();
                alert.showAlert("Warning", "Code does not match!", Alert.enumType.Warning);
            }
        }
    }
}
