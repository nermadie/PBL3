using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.GUI.GUI_Alert;

namespace PBL3.GUI.GUI_Login.LogIn_ChildForm
{
    public partial class SignUp : UserControl
    {
        private bool checkIconEyeSlashPass = false;
        private bool checkIconEyeSlashConfirm = false;
        public SignUp()
        {
            InitializeComponent();
            textBoxWarnUser.Visible = false;
            textBoxWarnPass.Visible = false;
            textBoxWarnConfirm.Visible = false;
        }

        private void resetColor()
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
            resetColor();
            textBoxUser.Clear();
            if (textBoxWarnUser.Visible == true)
                textBoxWarnUser.Visible = false;
            panelUser.BackColor = Color.FromArgb(113, 231, 232);
            textBoxUser.ForeColor = Color.FromArgb(113, 231, 232);
        }
        private void textBoxName_Click(object sender, EventArgs e)
        {
            resetColor();
            textBoxName.Clear();
            panelName.BackColor = Color.FromArgb(113, 231, 232);
            textBoxName.ForeColor = Color.FromArgb(113, 231, 232);
        }
        private void textBoxPass_Click(object sender, EventArgs e)
        {
            resetColor();
            textBoxPass.Clear();
            if (textBoxWarnPass.Visible == true)
                textBoxWarnPass.Visible = false;
            if (!checkIconEyeSlashPass)
            {
                textBoxConfirm.PasswordChar = '•';
                checkIconEyeSlashPass = true;
            }
            panelPass.BackColor = Color.FromArgb(113, 231, 232);
            textBoxPass.ForeColor = Color.FromArgb(113, 231, 232);
        }
        private void textBoxConfirm_Click(object sender, EventArgs e)
        {
            resetColor();
            textBoxPass.Clear();
            if (textBoxWarnConfirm.Visible == true)
                textBoxWarnConfirm.Visible = false;
            if (!checkIconEyeSlashConfirm)
            {
                textBoxConfirm.PasswordChar = '•';
                checkIconEyeSlashConfirm = true;
            }
            panelConfirm.BackColor = Color.FromArgb(113, 231, 232);
            textBoxConfirm.ForeColor = Color.FromArgb(113, 231, 232);
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
            if (textBoxPass.PasswordChar == '•')
            {
                iconButtonEyeConfirm.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                textBoxConfirm.PasswordChar = '\0';
            }
            else if (textBoxPass.PasswordChar == '\0')
            {
                iconButtonEyeConfirm.IconChar = FontAwesome.Sharp.IconChar.Eye;
                textBoxConfirm.PasswordChar = '•';
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            if (checkBoxAgree.Checked == true)
            {

            }
            else
            {
                Alert aForm = new Alert();
                aForm.showAlert("Warning", "You must agree to the Terms and Conditions", Alert.enumType.Warning);
            }
        }
    }
}
