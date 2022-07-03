using System;
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

namespace PBL3.GUI.GUI_MainForm.GUI_Employee.EmMainForm_UserControl
{
    public partial class EMF_History : UserControl
    {
        private Customer currentCus;
        public EMF_History(string cus)
        {
            InitializeComponent();
            this.currentCus = BLL_QLRapchieuphim.Instance.getCustomerbyIDCus(cus);
        }
        private void EMF_History_Load(object sender, EventArgs e)
        {
            //Load CBBItem
            guna2ComboBox.Items.AddRange(BLL_QLRapchieuphim.Instance.GetCBBHistory(currentCus));
        }
        private void guna2DataGridViewPD_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewPD.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void guna2DataGridViewTicket_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewTicket.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void guna2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //load PD
            List<PopcornDrinkOrder> listPDO = BLL_QLRapchieuphim.Instance.getDataPDbyIdOrder(((CBBItemS)guna2ComboBox.SelectedItem).Value);
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
            List<TicketOrder> listTO = BLL_QLRapchieuphim.Instance.getDataTicketOrderbyIdOrder(((CBBItemS)guna2ComboBox.SelectedItem).Value);
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
            string code = BLL_QLRapchieuphim.Instance.getCodebyIdOrder(((CBBItemS)guna2ComboBox.SelectedItem).Value);
            if (code != null)
            {
                textBoxCode.Text = code;
            }
            else
            {
                textBoxCode.Text = "Tickets received";
            }
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

    }
}
