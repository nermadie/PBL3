using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;
using PBL3.GUI.DelegateTemplate;
using PBL3.GUI.GUI_Alert;
using PBL3.Properties;

namespace PBL3.GUI.GUI_Login.Login_Customer.LogIn_UserControl
{
    public partial class SignUp_Customer : UserControl
    {
        public Del_Event backToSignIn { get; set; }
        private bool checkIconEyeSlashPass = false;
        private bool checkIconEyeSlashConfirm = false;
        public SignUp_Customer()
        {
            InitializeComponent();
            textBoxWarnUser.Visible = false;
            textBoxWarnPass.Visible = false;
            textBoxWarnConfirm.Visible = false;
            textBoxWarnName.Visible = false;
        }
        private void initial_Color()
        {
            panelPass.BackColor = Color.WhiteSmoke;
            textBoxPass.ForeColor = Color.WhiteSmoke;
            panelUser.BackColor = Color.WhiteSmoke;
            textBoxUser.ForeColor = Color.WhiteSmoke;
            panelConfirm.BackColor = Color.WhiteSmoke;
            textBoxConfirm.ForeColor = Color.WhiteSmoke;
            panelName.BackColor = Color.WhiteSmoke;
            textBoxName.ForeColor = Color.WhiteSmoke;
        }
        private void textBoxUser_Click(object sender, EventArgs e)
        {
            initial_Color();
            if (textBoxWarnUser.Visible == true)
                textBoxWarnUser.Visible = false;
            panelUser.BackColor = Color.FromArgb(252, 187, 193);
            textBoxUser.ForeColor = Color.FromArgb(252, 187, 193);
        }
        private void textBoxName_Click(object sender, EventArgs e)
        {
            initial_Color();
            if (textBoxWarnName.Visible == true)
                textBoxWarnName.Visible = false;
            panelName.BackColor = Color.FromArgb(252, 187, 193);
            textBoxName.ForeColor = Color.FromArgb(252, 187, 193);
        }
        private void textBoxPass_Click(object sender, EventArgs e)
        {
            initial_Color();
            if (textBoxWarnPass.Visible == true)
                textBoxWarnPass.Visible = false;
            if (!checkIconEyeSlashPass)
            {
                textBoxPass.PasswordChar = '•';
                checkIconEyeSlashPass = true;
            }
            panelPass.BackColor = Color.FromArgb(252, 187, 193);
            textBoxPass.ForeColor = Color.FromArgb(252, 187, 193);
        }
        private void textBoxConfirm_Click(object sender, EventArgs e)
        {
            initial_Color();
            if (textBoxWarnConfirm.Visible == true)
                textBoxWarnConfirm.Visible = false;
            if (!checkIconEyeSlashConfirm)
            {
                textBoxConfirm.PasswordChar = '•';
                checkIconEyeSlashConfirm = true;
            }
            panelConfirm.BackColor = Color.FromArgb(252, 187, 193);
            textBoxConfirm.ForeColor = Color.FromArgb(252, 187, 193);
        }

        private void iconButtonEyePass_Click(object sender, EventArgs e)
        {
            if (textBoxPass.PasswordChar == '•')
            {
                iconButtonEyePass.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                textBoxPass.PasswordChar = '\0';
            }
            else if (textBoxPass.PasswordChar == '\0')
            {
                iconButtonEyePass.IconChar = FontAwesome.Sharp.IconChar.Eye;
                textBoxPass.PasswordChar = '•';
            }
        }
        private void iconButtonEyeConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxConfirm.PasswordChar == '•')
            {
                iconButtonEyeConfirm.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                textBoxConfirm.PasswordChar = '\0';
            }
            else if (textBoxConfirm.PasswordChar == '\0')
            {
                iconButtonEyeConfirm.IconChar = FontAwesome.Sharp.IconChar.Eye;
                textBoxConfirm.PasswordChar = '•';
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            //If textbox is empty
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
            if (textBoxConfirm.Text == "")
            {
                textBoxWarnConfirm.Text = "! Invalid Confirm Password";
                textBoxWarnConfirm.Visible = true;
                return;
            }
            if (textBoxPass.Text != textBoxConfirm.Text)
            {
                textBoxWarnConfirm.Text = "! Password does not match";
                textBoxWarnConfirm.Visible = true;
                return;
            }
            if (textBoxName.Text == "")
            {
                textBoxWarnName.Text = "! Invalid Name";
                textBoxWarnName.Visible = true;
                return;
            }
            if (!Regex.IsMatch(textBoxName.Text, @"^[a-zA-Z\s]+$"))
            {
                textBoxWarnName.Text = "! Name contain only letters and spaces";
                textBoxWarnName.Visible = true;
                return;
            }
            //Check if did user agree with Terms and Conditions
            if (checkBoxAgree.Checked)
            {
                LogIn_Customer.checkFirstTimeGenDB = true;
                if (BLL_QLRapchieuphim.Instance.checkUsernameSignUpCustomer(textBoxUser.Text))
                {
                    BLL_QLRapchieuphim.Instance.addCustomertoDatabase(textBoxUser.Text, textBoxPass.Text, textBoxName.Text);
                    Alert aForm = new Alert();
                    aForm.showAlert("Congratulation", "Now use your account to sign in", Alert.enumType.Success);
                    backToSignIn(new object(), EventArgs.Empty);
                }
                else
                {
                    textBoxWarnUser.Text = "! That Username/Email is taken. Try another";
                    textBoxWarnUser.Visible = true;
                }
            }
            else
            {
                Alert aForm = new Alert();
                aForm.showAlert("Warning", "You must agree to the Terms and Conditions", Alert.enumType.Warning);
            }
        }

        private void buttonSignUp_MouseHover(object sender, EventArgs e)
        {
            if (LogIn_Customer.checkFirstTimeGenDB == false)
            {
                Alert aForm = new Alert();
                aForm.showAlert("First time loading ", "You may have to wait a moment", Alert.enumType.Info);
            }
        }

        public void SignUp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSignUp.PerformClick();
            }
        }
    }
}
