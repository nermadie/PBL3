using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.GUI.GUI_Login
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        //=============================================================//MOVE THE FORM
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Panel1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        //============================================================//
        //============================================================//PANEL TITLE
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonSignIn.PerformClick();
        }
        //============================================================//
        //============================================================//SIGN IN FORM
        private void lbForgotPass_Click(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //Goi BLL cua Sign In
        }

        private void lbCreateACC_Click(object sender, EventArgs e)
        {

        }

        private void tbUser_Click(object sender, EventArgs e)
        {
            textBoxUser.Clear();
            panelUser.BackColor = Color.FromArgb(113, 231, 232);
            textBoxUser.ForeColor = Color.FromArgb(113, 231, 232);

            panelPass.BackColor = Color.WhiteSmoke;
            textBoxPass.ForeColor = Color.WhiteSmoke;
        }

        private void tbPass_Click(object sender, EventArgs e)
        {
            textBoxPass.Clear();
            textBoxPass.PasswordChar = '•';
            panelPass.BackColor = Color.FromArgb(113, 231, 232);
            textBoxPass.ForeColor = Color.FromArgb(113, 231, 232);

            panelUser.BackColor = Color.WhiteSmoke;
            textBoxUser.ForeColor = Color.WhiteSmoke;

        }


        private void tbPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbPass_Click(object sender, EventArgs e)
        {

        }

        private void buttonEye_Click(object sender, EventArgs e)
        {
            if (textBoxPass.PasswordChar == '•')
            {
                buttonEyeSlash.BringToFront();
                textBoxPass.PasswordChar = '\0';
            }
        }

        private void buttonEyeSlash_Click(object sender, EventArgs e)
        {

            if (textBoxPass.PasswordChar == '\0')
            {
                buttonEye.BringToFront();
                textBoxPass.PasswordChar = '•';
            }
        }
        //============================================================//

        //============================================================//SIGN UP FORM
        //============================================================//

        //============================================================//FORGOT PASSWORD FORM
        //============================================================//

    }
}
