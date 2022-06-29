using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.GUI.GUI_Alert;
using PBL3.GUI.GUI_Login.Login_Admin;
using PBL3.GUI.GUI_Login.Login_Customer;
using PBL3.GUI.GUI_Login.Login_Employee;
using Timer = System.Threading.Timer;

namespace PBL3.GUI.GUI_ChooseRole
{
    public partial class ChooseRole : Form
    {
        public ChooseRole()
        {
            InitializeComponent();
            Alert alert = new Alert();
            alert.showAlert("Welcome to Cinema", "Choose your role to continue.", Alert.enumType.Info);
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showChooseRole()
        {
            this.Visible = true;
        }
        private void guna2GradientButtonCus_Click(object sender, EventArgs e)
        {
            LogIn_Customer lc = new LogIn_Customer();
            lc.Show();
            this.Visible = false;
            lc.showChooseRole = this.showChooseRole;
        }
        private void guna2GradientButtonEm_Click(object sender, EventArgs e)
        {
            Login_Employee le = new Login_Employee();
            le.Show();
            this.Visible = false;
            le.showChooseRole = this.showChooseRole;
        }

        private void guna2GradientButtonAd_Click(object sender, EventArgs e)
        {
            Login_Admin la = new Login_Admin();
            la.Show();
            this.Visible = false;
            la.showChooseRole = this.showChooseRole;
        }
        //===================//TIMER
        //Button Customer
        private void guna2GradientButtonCus_MouseEnter(object sender, EventArgs e)
        {
            timerCusLeave.Stop();
            timerCusEnter.Start();
        }
        private void timerCusEnter_Tick(object sender, EventArgs e)
        {
            buttonCus.Height += 10;
            buttonEm.Location = new Point(0, buttonCus.Location.Y + buttonCus.Height + 5);
            buttonAd.Location = new Point(0, buttonEm.Location.Y + buttonEm.Height + 5);
            if (buttonCus.Height == buttonCus.MaximumSize.Height)
                timerCusEnter.Stop();
        }

        private void guna2GradientButtonCus_MouseLeave(object sender, EventArgs e)
        {
            timerCusEnter.Stop();
            timerCusLeave.Start();
        }

        private void timerCusLeave_Tick(object sender, EventArgs e)
        {
            buttonCus.Height -= 10;
            buttonEm.Location = new Point(0, buttonCus.Location.Y + buttonCus.Height + 5);
            buttonAd.Location = new Point(0, buttonEm.Location.Y + buttonEm.Height + 5);
            if (buttonCus.Height == buttonCus.MinimumSize.Height)
                timerCusLeave.Stop();
        }
        //Button Employee
        private void buttonEm_MouseEnter(object sender, EventArgs e)
        {
            timerEmLeave.Stop();
            timerEmEnter.Start();
        }
        private void timerEmEnter_Tick(object sender, EventArgs e)
        {
            buttonEm.Height += 10;
            buttonAd.Location = new Point(0, buttonEm.Location.Y + buttonEm.Height + 5);
            if (buttonEm.Height == buttonEm.MaximumSize.Height)
                timerEmEnter.Stop();
        }
        private void buttonEm_MouseLeave(object sender, EventArgs e)
        {
            timerEmEnter.Stop();
            timerEmLeave.Start();
        }
        private void timerEmLeave_Tick(object sender, EventArgs e)
        {
            buttonEm.Height -= 10;
            buttonAd.Location = new Point(0, buttonEm.Location.Y + buttonEm.Height + 5);
            if (buttonEm.Height == buttonEm.MinimumSize.Height)
                timerEmLeave.Stop();
        }

        //Button Administrator
        private void buttonAd_MouseEnter(object sender, EventArgs e)
        {
            timerAdLeave.Stop();
            timerAdEnter.Start();
        }

        private void timerAdEnter_Tick(object sender, EventArgs e)
        {
            buttonAd.Height += 10;
            if (buttonAd.Height == buttonAd.MaximumSize.Height)
                timerAdEnter.Stop();
        }

        private void buttonAd_MouseLeave(object sender, EventArgs e)
        {
            timerAdEnter.Stop();
            timerAdLeave.Start();
        }
        private void timerAdLeave_Tick(object sender, EventArgs e)
        {
            buttonAd.Height -= 10;
            if (buttonAd.Height == buttonAd.MinimumSize.Height)
                timerAdEnter.Stop();
        }
    }
}
