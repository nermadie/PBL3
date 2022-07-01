using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO.DTO_Person;
using PBL3.DTO.DTO_ShowTime;
using PBL3.GUI.GUI_MainForm.GUI_Customer.CusMainForm_UserControl;

namespace PBL3.GUI.GUI_MainForm.GUI_Customer
{
    public partial class CustomerMainForm : Form
    {
        private UserControl currentUserControl;
        private Home home;
        private Movies movies;
        private Showtimes showtimes;
        private PopcornDrinks popcornDrinks;
        private Tickets tickets;
        public CustomerMainForm(Customer cus)
        {
            InitializeComponent();
            shadowPanelPopup.Visible = false;
            home = new Home();
            addUserControl(home);
        }
        //Add UserControl
        private void addUserControl(UserControl userControl)
        {
            currentUserControl = userControl;
            userControl.Dock = DockStyle.Fill;
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(userControl);
            userControl.BringToFront();
            currentUserControl = userControl;
        }
        private void circlePictureBoxOpenPopup_Click(object sender, EventArgs e)
        {
            if (shadowPanelPopup.Visible == false)
                guna2TransitionOpenPopup.ShowSync(shadowPanelPopup);
            else
                guna2TransitionClosePopup.HideSync(shadowPanelPopup);
        }

        private void buttonClosePopup_Click(object sender, EventArgs e)
        {
            guna2TransitionClosePopup.HideSync(shadowPanelPopup);
        }

        private void uncheckAnotherButton()
        {
            buttonShowtimes.Checked = false;
            buttonMovies.Checked = false;
            buttonTickets.Checked = false;
            buttonPopDrinks.Checked = false;
        }
        //TICKETS
        private void buttonShowtimes_Click(object sender, EventArgs e)
        {
            uncheckAnotherButton();
            buttonShowtimes.Checked = true;
            showtimes = new Showtimes(openBuyTicket);
            addUserControl(showtimes);
        }

        private void openBuyTicket(string idRoom, DateTime time)
        {
            tickets = new Tickets(idRoom, time);
            addUserControl(tickets);
        }
        //MOVIES
        private void buttonMovies_Click(object sender, EventArgs e)
        {
            uncheckAnotherButton();
            buttonMovies.Checked = true;
            movies = new Movies();
            addUserControl(movies);
        }

        private void buttonTickets_Click(object sender, EventArgs e)
        {
            uncheckAnotherButton();
            buttonTickets.Checked = true;
            tickets = new Tickets();
            addUserControl(tickets);
        }

        private void buttonPopDrinks_Click(object sender, EventArgs e)
        {
            uncheckAnotherButton();
            buttonPopDrinks.Checked = true;
            popcornDrinks = new PopcornDrinks();
            addUserControl(popcornDrinks);
        }

        private void guna2CirclePictureBoxLogo_Click(object sender, EventArgs e)
        {
            uncheckAnotherButton();
            home = new Home();
            addUserControl(home);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (currentUserControl == showtimes)
            {
                showtimes.searchinListST(textBoxSearch.Text);
            }
        }
    }
}
