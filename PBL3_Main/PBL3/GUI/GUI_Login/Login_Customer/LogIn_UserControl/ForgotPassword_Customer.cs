using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL.BLL_Login.BLL_Login_Admin;
using PBL3.GUI.DelegateTemplate;
using PBL3.GUI.GUI_Alert;

namespace PBL3.GUI.GUI_Login.Login_Customer.LogIn_UserControl
{
    public partial class ForgotPassword_Customer : UserControl
    {
        public Del_Event backToSignIn { get; set; }
        public ForgotPassword_Customer()
        {
            InitializeComponent();
            textBoxWarnUser.Visible = false;
        }

        private void textBoxUser_Click(object sender, EventArgs e)
        {
            if (textBoxWarnUser.Visible == true)
                textBoxWarnUser.Visible = false;
            panelUser.BackColor = Color.FromArgb(252, 187, 193);
            textBoxUser.ForeColor = Color.FromArgb(252, 187, 193);
        }

        private void buttonConfirm_MouseHover(object sender, EventArgs e)
        {
            if (LogIn_Customer.checkFirstTimeGenDB == false)
            {
                Alert aForm = new Alert();
                aForm.showAlert("First time loading ", "You may have to wait a moment", Alert.enumType.Info);
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            LogIn_Customer.checkFirstTimeGenDB = true;
            string password = "";
            if ((password = BLL_Login_Customer.Instance.checkUsernameForgot(textBoxUser.Text)) != "")
            {
                Alert aForm = new Alert();
                aForm.showAlert("Your Pass: " + password, "Now use your account to sign in", Alert.enumType.Success);
                backToSignIn(new object(), EventArgs.Empty);
            }
            else
            {
                textBoxWarnUser.Text = "! This Username/Email does not match any account";
                textBoxWarnUser.Visible = true;
            }
        }

        public void ForgotPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonConfirm.PerformClick();
            }
        }
    }
}
