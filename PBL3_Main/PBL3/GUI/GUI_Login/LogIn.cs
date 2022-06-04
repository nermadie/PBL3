using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.GUI.GUI_Login.LogIn_ChildForm;

namespace PBL3.GUI.GUI_Login
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            SignIn signin = new SignIn();
            OpenChildForm(signin);
            signin.DelPanelCreate = new SignIn.DelTriggerButton(labelCreateACC_DelegateClick);
            signin.DelPanelForgot = new SignIn.DelTriggerButton(labelForgotPass_DelegateClick);
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
        //============================================================//
        //============================================================/LOGIN FORM
        //Child form for SignUp and Forgot Password
        private Form _currentChildForm;
        private void OpenChildForm(Form childForm)
        {
            if (_currentChildForm != null)
            {
                //open only form
                _currentChildForm.Close();
            }

            _currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelLogIn.Controls.Add(childForm);
            panelLogIn.Tag = childForm;//Associate the form to the panel
            childForm.BringToFront();
            childForm.Show();
        }
        //============================================================//
        //============================================================//SIGN IN FORM
        private void labelForgotPass_DelegateClick()
        {
            MessageBox.Show("Forgot Password");
            OpenChildForm(new ForgotPassword());
        }
        private void labelCreateACC_DelegateClick()
        {
            MessageBox.Show("CreateAccount");
            OpenChildForm(new SignUp());
        }
        //============================================================//

        //============================================================//SIGN UP FORM

        //============================================================//

        //============================================================//FORGOT PASSWORD FORM
        //============================================================//

    }
}
