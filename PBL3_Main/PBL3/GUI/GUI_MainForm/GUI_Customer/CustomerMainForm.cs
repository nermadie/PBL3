﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;
using PBL3.DTO.DTO_Person;
using PBL3.DTO.DTO_ShowTime;
using PBL3.GUI.DelegateTemplate;
using PBL3.GUI.GUI_AdditionalUserControl.UC_CartPopcornDrink;
using PBL3.GUI.GUI_MainForm.GUI_Customer.CusMainForm_UserControl;

namespace PBL3.GUI.GUI_MainForm.GUI_Customer
{
    public partial class CustomerMainForm : Form
    {
        public Del_void openLogin { get; set; }
        private UserControl currentUserControl;
        private CMF_Home home;
        private CMF_Movies movies;
        private CMF_Showtimes showtimes;
        private CMF_PopcornDrinks popcornDrinks;
        private CMF_Tickets tickets;
        private CMF_MovieDetail movieDetail;
        private CMF_Cart cart;
        private CMF_Payment payment;
        private CMF_History history;
        private string currentCus;
        public CustomerMainForm(string idCustomer)
        {
            InitializeComponent();
            reloadImageUser(idCustomer);
            cart = new CMF_Cart();
            cart.openPayment = openPayment;
            shadowPanelPopup.Visible = false;
            buttonPayment.Visible = false;
            home = new CMF_Home();
            addUserControl(home);
            currentCus = idCustomer;
        }

        private void reloadImageUser(string idPerson)
        {
            circlePictureBoxUser.Image = BLL_QLRapchieuphim.Instance.getImagebyIdPerson(idPerson);
            if (circlePictureBoxUser.Image == null)
                circlePictureBoxUser.Image = circlePictureBoxUser.ErrorImage;
        }
        //Add UserControl
        private void addUserControl(UserControl userControl)
        {
            if (currentUserControl == payment)
            {
                buttonPayment.Visible = false;
            }
            panelCenter.Controls.Clear();
            UserControl prevUserControl = currentUserControl;
            textBoxSearch.Text = "";
            currentUserControl = userControl;
            userControl.Dock = DockStyle.Fill;
            panelCenter.Controls.Add(userControl);
            userControl.BringToFront();
            prevUserControl?.Dispose();
        }

        private void openPayment(ShowTime showtime, List<string> seatsPurchased, DataGridViewRowCollection dataGridViewRows, int ticketPrice, int pdPrice, int totalPrice)
        {
            uncheckAnotherButton();
            payment = new CMF_Payment(currentCus, showtime, seatsPurchased, dataGridViewRows, ticketPrice, pdPrice, totalPrice);
            payment.openHome = openHome;
            payment.openCart_Cancel = buttonCart_Click;
            addUserControl(payment);
            buttonPayment.Visible = true;
            buttonPayment.Checked = true;
        }

        private void openHome()
        {
            cart.buttonResetAll_Click(new object(), EventArgs.Empty);
            guna2CirclePictureBoxLogo_Click(new object(), EventArgs.Empty);
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
            buttonCart.Checked = false;
            buttonPopDrinks.Checked = false;
        }
        //SHOWTIMES
        private void buttonShowtimes_Click(object sender, EventArgs e)
        {
            uncheckAnotherButton();
            buttonShowtimes.Checked = true;
            showtimes = new CMF_Showtimes();
            showtimes.openMovieDetail = openMovieDetail;
            showtimes.buyTicketbyShowTime_Tickets = openBuyTicket;
            addUserControl(showtimes);
        }

        private void openShowtimeswithSearch(string text)
        {
            buttonShowtimes_Click(new object(), EventArgs.Empty);
            textBoxSearch.Text = text;
        }
        //TICKETS
        private void openBuyTicket(string idRoom, DateTime time)
        {
            tickets = new CMF_Tickets(idRoom, time);
            tickets.saveDataTicket = cart.saveDataTicket;
            tickets.openCartFromTicket = openCartFromTicket;
            addUserControl(tickets);
        }

        private void openCartFromTicket(string idRoom, DateTime time, List<string> bookingSeats)
        {
            cart.saveDataTicket(idRoom, time, bookingSeats);
            buttonCart_Click(new object(), EventArgs.Empty);
        }
        //MOVIES
        private void buttonMovies_Click(object sender, EventArgs e)
        {
            uncheckAnotherButton();
            buttonMovies.Checked = true;
            movies = new CMF_Movies();
            movies.openMovieDetail = openMovieDetail;
            addUserControl(movies);
        }
        //-->MovieDetail
        private void openMovieDetail(string idMovie)
        {
            uncheckAnotherButton();
            buttonMovies.Checked = true;
            movieDetail = new CMF_MovieDetail(idMovie);
            movieDetail.openShowtimes = openShowtimeswithSearch;
            addUserControl(movieDetail);
        }

        //private void buttonTickets_Click(object sender, EventArgs e)
        //{
        //    uncheckAnotherButton();
        //    buttonCart.Checked = true;
        //    tickets = new CMF_Tickets();
        //    addUserControl(tickets);
        //}

        private void buttonPopDrinks_Click(object sender, EventArgs e)
        {
            uncheckAnotherButton();
            buttonPopDrinks.Checked = true;
            popcornDrinks = new CMF_PopcornDrinks();
            popcornDrinks.saveDataPD = cart.saveDataPD;
            popcornDrinks.openCartFromPD = openCartFromPD;
            addUserControl(popcornDrinks);
        }

        private void openCartFromPD(List<CartPopcornDrink> listCartPopcornDrinks)
        {
            cart.saveDataPD(listCartPopcornDrinks);
            buttonCart_Click(new object(), EventArgs.Empty);
        }
        private void buttonCart_Click(object sender, EventArgs e)
        {
            uncheckAnotherButton();
            buttonCart.Checked = true;
            panelCenter.Controls.Clear();
            textBoxSearch.Text = "";
            panelCenter.Controls.Add(cart);
            cart.BringToFront();
            currentUserControl?.Dispose();
            buttonPayment.Visible = false;
        }

        private void guna2CirclePictureBoxLogo_Click(object sender, EventArgs e)
        {
            uncheckAnotherButton();
            home = new CMF_Home();
            addUserControl(home);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (currentUserControl == showtimes)
            {
                showtimes.searchinListST(textBoxSearch.Text);
            }
            else if (currentUserControl == movies)
            {
                movies.searchMovies(textBoxSearch.Text);
            }
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            uncheckAnotherButton();
            history = new CMF_History(currentCus);
            addUserControl(history);
        }

        private void guna2ButtonLogout_Click(object sender, EventArgs e)
        {
            openLogin();
            this.Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            uncheckAnotherButton();
            CMF_Profile profile = new CMF_Profile(currentCus);
            profile.setImageUser = setImageUser;
            profile.openHome = guna2CirclePictureBoxLogo_Click;
            profile.logOut = guna2ButtonLogout_Click;
            addUserControl(profile);
        }

        private void setImageUser(Image image)
        {
            circlePictureBoxUser.Image = image;
        }
        private void guna2ControlBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
