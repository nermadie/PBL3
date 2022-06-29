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
    }
}
