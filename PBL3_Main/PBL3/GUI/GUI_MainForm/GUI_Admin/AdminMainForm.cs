using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using PBL3.DTO.DTO_Person;
using PBL3.GUI.GUI_MainForm.GUI_Admin.AdMainForm_UserControl;

namespace PBL3.GUI.GUI_MainForm.GUI_Admin
{
    public partial class AdminMainForm : Form
    {
        private AMF_Home home;
        private AMF_Customer customer;
        private AMF_Employee employee;
        private AMF_Movie movie;
        private AMF_ShowTime showtime;
        private AMF_PopcornDrink popcornDrink;
        private AMF_PopcornDrinkOrder popcornDrinkOrder;
        private AMF_TicketOrder ticketOrder;
        private AMF_Room room;
        private AMF_Order order;
        public AdminMainForm()
        {
            InitializeComponent();
            buttonMenuTicketOrder.Visible = false;
            buttonMenuPopcornDrinkOrder.Visible = false;
            home = new AMF_Home();
            addUserControl(home);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainerAdmin.Controls.Clear();
            panelContainerAdmin.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonShowMenu_Click(object sender, EventArgs e)
        {
            pictureBoxSmallMenu.Visible = false;
            pictureBoxBigMenu.Visible = true;
            buttonShowMenu.Visible = false;
            buttonHideMenu.Visible = true;
            panelMenuAdmin.Visible = false;
            panelMenuAdmin.Width = 234;
            guna2Transition1.ShowSync(panelMenuAdmin);
        }

        private void buttonHideMenu_Click(object sender, EventArgs e)
        {
            pictureBoxSmallMenu.Visible = true;
            pictureBoxBigMenu.Visible = false;
            panelMenuAdmin.Visible = false;
            buttonHideMenu.Visible = false;
            buttonShowMenu.Visible = true;
            panelMenuAdmin.Width = 44;
            guna2Transition1.ShowSync(panelMenuAdmin);
        }

        private void buttonMenuHome_Click(object sender, EventArgs e)
        {
            home = new AMF_Home();
            addUserControl(home);
        }

        private void buttonMenuCustomer_Click(object sender, EventArgs e)
        {
            customer = new AMF_Customer();
            addUserControl(customer);
        }

        private void buttonMenuEmployee_Click(object sender, EventArgs e)
        {
            employee = new AMF_Employee();
            addUserControl(employee);
        }

        private void buttonMenuMovie_Click(object sender, EventArgs e)
        {
            movie = new AMF_Movie();
            addUserControl(movie);
        }

        private void buttonMenuOrder_Click(object sender, EventArgs e)
        {
            order = new AMF_Order();
            addUserControl(order);
        }

        private void buttonMenuPopcornDrink_Click(object sender, EventArgs e)
        {
            popcornDrink = new AMF_PopcornDrink();
            addUserControl(popcornDrink);
        }

        private void buttonMenuPopcornDrinkOrder_Click(object sender, EventArgs e)
        {
            popcornDrinkOrder = new AMF_PopcornDrinkOrder();
            addUserControl(popcornDrinkOrder);
        }

        private void buttonMenuRoom_Click(object sender, EventArgs e)
        {
            room = new AMF_Room();
            addUserControl(room);
        }

        private void buttonMenuShowTime_Click(object sender, EventArgs e)
        {
            showtime = new AMF_ShowTime();
            addUserControl(showtime);
        }

        private void buttonMenuTicketOrder_Click(object sender, EventArgs e)
        {
            ticketOrder = new AMF_TicketOrder();
            addUserControl(ticketOrder);
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

