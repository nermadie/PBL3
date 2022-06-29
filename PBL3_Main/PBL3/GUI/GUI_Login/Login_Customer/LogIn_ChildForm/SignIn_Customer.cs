using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using PBL3.BLL.BLL_Login.BLL_Login_Admin;
using PBL3.DTO.DTO_Person;
using PBL3.GUI.GUI_Alert;
using PBL3.GUI.DelegateTemplate;
namespace PBL3.GUI.GUI_Login.Login_Customer.LogIn_ChildForm
{
    public partial class SignIn_Customer : UserControl
    {
        public Del_Customer hideLoginForm { get; set; }
        public Del_void showSignup { get; set; }
        public Del_void showForgot { get; set; }
        private bool checkIconEyeSlash = false;
        public SignIn_Customer()
        {
            InitializeComponent();
            textBoxWarnUser.Visible = false;
            textBoxWarnPass.Visible = false;
        }

        //============================================================//SIGN IN FORM
        private void initial_Textbox()
        {
            if (textBoxUser.Text == "")
                textBoxUser.Text = "Username or email address";
            if (textBoxPass.Text == "")
            {
                textBoxPass.Text = "Password";
                iconButtonEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
                textBoxPass.PasswordChar = '\0';
                checkIconEyeSlash = false;
            }
        }
        private void textBoxUser_Click(object sender, EventArgs e)
        {
            initial_Textbox();
            textBoxUser.Clear();
            if (textBoxWarnUser.Visible == true)
                textBoxWarnUser.Visible = false;
            panelUser.BackColor = Color.FromArgb(252, 187, 193);
            textBoxUser.ForeColor = Color.FromArgb(252, 187, 193);

            panelPass.BackColor = Color.WhiteSmoke;
            textBoxPass.ForeColor = Color.WhiteSmoke;
        }

        private void textBoxPass_Click(object sender, EventArgs e)
        {
            initial_Textbox();
            textBoxPass.Clear();
            if (textBoxWarnPass.Visible == true)
                textBoxWarnPass.Visible = false;
            if (!checkIconEyeSlash)
            {
                textBoxPass.PasswordChar = '•';
                checkIconEyeSlash = true;
            }
            panelPass.BackColor = Color.FromArgb(252, 187, 193);
            textBoxPass.ForeColor = Color.FromArgb(252, 187, 193);

            panelUser.BackColor = Color.WhiteSmoke;
            textBoxUser.ForeColor = Color.WhiteSmoke;

        }

        private void iconButtonEye_Click(object sender, EventArgs e)
        {
            if (textBoxPass.PasswordChar == '•')
            {
                iconButtonEye.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                textBoxPass.PasswordChar = '\0';
            }
            else if (textBoxPass.PasswordChar == '\0')
            {
                iconButtonEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
                textBoxPass.PasswordChar = '•';
            }
        }
        //==========================ALERT
        public void callShowAlert(string message, string detail, Alert.enumType type)
        {
            Alert aForm = new Alert();
            aForm.showAlert(message, detail, type);
        }
        //==========================
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "")
            {
                textBoxWarnUser.Text = "! Invalid Username/Email address";
                textBoxWarnUser.Visible = true;
                return;
            }
            if (textBoxPass.Text == "")
            {
                textBoxWarnPass.Text = "! Invalid Password";
                textBoxWarnPass.Visible = true;
                return;
            }

            LogIn_Customer.checkFirstTimeGenDB = true;
            if (BLL_Login_Customer.Instance.checkUsernameSignIn(textBoxUser.Text))
            {
                Customer customer;
                if ((customer = BLL_Login_Customer.Instance.checkAccountSignIn(textBoxUser.Text, textBoxPass.Text)) != null)
                {
                    hideLoginForm(customer);
                    //In ra thong bao
                    callShowAlert("Success", "Sign In successful", Alert.enumType.Success);
                }
                else
                {
                    textBoxWarnPass.Text = "! Password does not match";
                    textBoxWarnPass.Visible = true;
                }
            }
            else
            {
                textBoxWarnUser.Text = "! Username/Email address does not exist";
                textBoxWarnUser.Visible = true;
            }
        }

        private void buttonSignIn_MouseHover(object sender, EventArgs e)
        {
            if (!LogIn_Customer.checkFirstTimeGenDB)
                callShowAlert("First time loading ", "You may have to wait a moment", Alert.enumType.Info);
        }

        public void SignIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSignIn.PerformClick();
            }
        }

        private void labelForgot_Click(object sender, EventArgs e)
        {
            showForgot();
        }

        private void labelCreateAcc_Click(object sender, EventArgs e)
        {
            showSignup();
        }
        //============================================================//
    }
}
