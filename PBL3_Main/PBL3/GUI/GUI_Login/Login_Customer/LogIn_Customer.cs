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
using System.Windows.Input;
using ComponentFactory.Krypton.Toolkit;
using PBL3.DTO.DTO_Person;
using PBL3.GUI.DelegateTemplate;
using PBL3.GUI.GUI_Login.Login_Customer.LogIn_UserControl;
using PBL3.GUI.GUI_MainForm;
using PBL3.GUI.GUI_MainForm.GUI_Customer;
using KeyEventArgs = System.Windows.Forms.KeyEventArgs;

namespace PBL3.GUI.GUI_Login.Login_Customer
{
    public partial class LogIn_Customer : Form
    {
        public Del_void showChooseRole { get; set; }
        public static bool checkFirstTimeGenDB = false;
        private SignIn_Customer signIn;
        private ForgotPassword_Customer forgotPassword;
        private SignUp_Customer signUp;
        private UserControl currentUserControl;
        public LogIn_Customer()
        {
            InitializeComponent();
            signIn = new SignIn_Customer();
            addUserControl(signIn);
            signIn.hideLoginForm = ShowMainForm;
            signIn.showSignup = labelCreateACC_DelegateClick;
            signIn.showForgot = labelForgotPass_DelegateClick;
        }
        //Add UserControl
        private void addUserControl(UserControl userControl)
        {
            currentUserControl = userControl;
            userControl.Dock = DockStyle.Fill;
            panelLogIn.Controls.Clear();
            panelLogIn.Controls.Add(userControl);
            userControl.BringToFront();
        }
        //============================================================//SIGN IN FORM
        public void ShowMainForm(Customer cus)
        {
            this.Visible = false;
            CustomerMainForm mForm = new CustomerMainForm(cus.IdPerson);
            mForm.Show();
        }

        //============================================================//

        //============================================================//SIGN UP FORM
        private void labelCreateACC_DelegateClick()
        {
            signUp = new SignUp_Customer();
            addUserControl(signUp);
            buttonBack.Visible = true;
            signUp.backToSignIn = buttonBack_Click;
        }

        //============================================================//

        //============================================================//FORGOT PASSWORD FORM
        private void labelForgotPass_DelegateClick()
        {
            forgotPassword = new ForgotPassword_Customer();
            addUserControl(forgotPassword);
            buttonBack.Visible = true;
            forgotPassword.backToSignIn = buttonBack_Click;
        }
        //============================================================//

        //============================================================//BUTTON and KEYDOWN
        //=====//PANEL TITLE
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //=====//KEYDOWN
        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (currentUserControl == signIn)
            {
                showChooseRole();
                this.Dispose();
            }
            else
                addUserControl(signIn);
        }

        private void LogIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && currentUserControl == signIn)
                signIn.SignIn_KeyDown(sender, e);
            else if (e.KeyCode == Keys.Enter && currentUserControl == signUp)
                signUp.SignUp_KeyDown(sender, e);
            else if (e.KeyCode == Keys.Enter && currentUserControl == forgotPassword)
                forgotPassword.ForgotPassword_KeyDown(sender, e);
            else if (e.KeyCode == Keys.Escape)
                buttonBack.PerformClick();
        }
        //============================================================//

    }
}
