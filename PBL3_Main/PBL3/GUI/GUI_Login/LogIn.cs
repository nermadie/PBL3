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
using PBL3.GUI.GUI_Login.LogIn_ChildForm;
using PBL3.GUI.GUI_MainForm;
using KeyEventArgs = System.Windows.Forms.KeyEventArgs;

namespace PBL3.GUI.GUI_Login
{
    public partial class LogIn : KryptonForm
    {
        private SignIn signIn = new SignIn();
        private ForgotPassword forgotPassword = new ForgotPassword();
        private SignUp signUp = new SignUp();
        public LogIn()
        {
            InitializeComponent();
            addUserControl(signIn);
            signIn.hideLoginForm = new SignIn.Del_String(ShowMainForm);
            signIn.showSignup = new SignIn.Del_Void(labelCreateACC_DelegateClick);
            signIn.showForgot = new SignIn.Del_Void(labelForgotPass_DelegateClick);
        }
        //Add UserControl
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelLogIn.Controls.Clear();
            panelLogIn.Controls.Add(userControl);
            userControl.BringToFront();
        }
        //============================================================/LOGIN FORM
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

        //============================================================//
        //============================================================//SIGN IN FORM
        public void ShowMainForm(string username)
        {
            this.Visible = false;
            MainForm mForm = new MainForm(username);
            mForm.Show();
        }
        private void labelForgotPass_DelegateClick()
        {
            addUserControl(forgotPassword);
        }
        private void labelCreateACC_DelegateClick()
        {
            addUserControl(signUp);
        }
        //============================================================//

        //============================================================//SIGN UP FORM

        //============================================================//

        //============================================================//FORGOT PASSWORD FORM
        //============================================================//

    }
}
