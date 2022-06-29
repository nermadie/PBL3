﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL.BLL_Login.BLL_Login_Admin;
using PBL3.BLL.BLL_Login.BLL_Login_Employee;
using PBL3.DTO.DTO_Person;
using PBL3.GUI.DelegateTemplate;
using PBL3.GUI.GUI_Alert;
using PBL3.GUI.GUI_MainForm.GUI_Admin;
using PBL3.GUI.GUI_MainForm.GUI_Employee;

namespace PBL3.GUI.GUI_Login.Login_Employee
{
    public partial class Login_Employee : Form
    {
        public Del_void showChooseRole { get; set; }
        private bool checkFirstTimeGenDB = false;
        private bool checkIconEyeSlash = false;
        public Login_Employee()
        {
            InitializeComponent();
            textBoxForgot.Visible = false;
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
            panelUser.BackColor = Color.FromArgb(254, 240, 162);
            textBoxUser.ForeColor = Color.FromArgb(254, 240, 162);

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
            panelPass.BackColor = Color.FromArgb(254, 240, 162);
            textBoxPass.ForeColor = Color.FromArgb(254, 240, 162);

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

        //============================================================//BUTTON and KEYDOWN
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LogIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonSignIn.PerformClick();
            else if (e.KeyCode == Keys.Escape)
                buttonBack.PerformClick();
        }
        private void buttonSignIn_MouseHover(object sender, EventArgs e)
        {
            if (!checkFirstTimeGenDB)
            {
                Alert alert = new Alert();
                alert.showAlert("First time loading ", "You may have to wait a moment", Alert.enumType.Info);
            }
        }

        private void labelForgot_Click(object sender, EventArgs e)
        {
            if (textBoxForgot.Visible == false)
                textBoxForgot.Visible = true;
            else textBoxForgot.Visible = false;
        }

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

            checkFirstTimeGenDB = true;
            if (BLL_SignIn_Employee.Instance.checkUsernameSignIn(textBoxUser.Text))
            {
                Employee employee;
                if ((employee = BLL_SignIn_Employee.Instance.checkAccountSignIn(textBoxUser.Text, textBoxPass.Text)) != null)
                {
                    EmployeeMainForm amf = new EmployeeMainForm(employee);
                    amf.Show();
                    this.Visible = false;
                    //In ra thong bao
                    Alert alert = new Alert();
                    alert.showAlert("Success", "Sign In successful", Alert.enumType.Success);
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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            showChooseRole();
            this.Dispose();
        }
        //============================================================//
    }
}