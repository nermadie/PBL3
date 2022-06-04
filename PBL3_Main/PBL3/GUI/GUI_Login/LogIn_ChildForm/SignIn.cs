using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.GUI.GUI_Login.LogIn_ChildForm
{
    public partial class SignIn : Form
    {
        public delegate void DelTriggerButton();

        public DelTriggerButton DelPanelCreate { get; set; }
        public DelTriggerButton DelPanelForgot { get; set; }

        public SignIn()
        {
            InitializeComponent();
        }
        private void SignIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonSignIn.PerformClick();
        }
        private void labelCreateACC_Click(object sender, EventArgs e)
        {
            DelPanelCreate();
        }
        private void labelForgotPass_Click(object sender, EventArgs e)
        {
            DelPanelForgot();
        }
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            //Goi BLL cua Sign In

            MessageBox.Show("Sign In");
        }


        private void textBoxUser_Click(object sender, EventArgs e)
        {
            textBoxUser.Clear();
            panelUser.BackColor = Color.FromArgb(113, 231, 232);
            textBoxUser.ForeColor = Color.FromArgb(113, 231, 232);

            panelPass.BackColor = Color.WhiteSmoke;
            textBoxPass.ForeColor = Color.WhiteSmoke;
        }

        private void textBoxPass_Click(object sender, EventArgs e)
        {
            textBoxPass.Clear();
            textBoxPass.UseSystemPasswordChar = true;
            panelPass.BackColor = Color.FromArgb(113, 231, 232);
            textBoxPass.ForeColor = Color.FromArgb(113, 231, 232);

            panelUser.BackColor = Color.WhiteSmoke;
            textBoxUser.ForeColor = Color.WhiteSmoke;

        }
    }
}
