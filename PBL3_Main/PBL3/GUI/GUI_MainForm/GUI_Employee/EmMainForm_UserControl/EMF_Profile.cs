﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;
using PBL3.DTO.DTO_Person;
using PBL3.GUI.DelegateTemplate;
using PBL3.GUI.GUI_Alert;

namespace PBL3.GUI.GUI_MainForm.GUI_Employee.EmMainForm_UserControl
{
    public partial class EMF_Profile : UserControl
    {
        private bool checkChangePass = false;
        public Del_Image setImageUser { get; set; }
        public Del_Event openHome { get; set; }
        public Del_Event logOut { get; set; }
        private Employee currentEmployee;
        public EMF_Profile(string idEmployee)
        {
            InitializeComponent();
            this.currentEmployee = BLL_QLRapchieuphim.Instance.getEmployeebyIDEm(idEmployee);
        }

        private void EMF_Profile_Load(object sender, EventArgs e)
        {
            panelChangePassword.Visible = false;
            pictureBoxUser.Image = BLL_QLRapchieuphim.Instance.getImagebyIdPerson(currentEmployee.IdPerson) ??
                                   pictureBoxUser.ErrorImage;
            textBoxName.Text = currentEmployee.NamePerson;
            textBoxPhone.Text = currentEmployee.Phone;
            textBoxAddress.Text = currentEmployee.Address;
            radioButtonMale.Checked = currentEmployee.Gender;
            dateTimePickerBirth.Value = currentEmployee.Birth;
            textBoxUsername.Text = currentEmployee.Username;
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            panelChangePassword.Visible = !panelChangePassword.Visible;
            checkChangePass = panelChangePassword.Visible;
        }

        private void buttonGetImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            openFileDialog.Title = "Choose Image";
            string path = openFileDialog.FileName;
            if (path == String.Empty)
            {
                Alert alert = new Alert();
                alert.showAlert("Warning", "No files have been selected yet.", Alert.enumType.Warning);
            }
            else if (Path.GetExtension(path) != ".jpeg" && Path.GetExtension(path) != ".png" &&
                     Path.GetExtension(path) != ".jpg")
            {
                Alert alert = new Alert();
                alert.showAlert("Warning", "The file is not in the correct format.", Alert.enumType.Warning);
            }
            else
            {
                BLL_QLRapchieuphim.Instance.delImagebyIdPerson(currentEmployee.IdPerson);
                File.Move(openFileDialog.FileName, @"..\..\Image\Picture\PicturePerson\" + currentEmployee.IdPerson + Path.GetExtension(path));
                pictureBoxUser.Image = BLL_QLRapchieuphim.Instance.getImagebyIdPerson(currentEmployee.IdPerson);
                setImageUser(pictureBoxUser.Image);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (checkChangePass)
            {
                if (textBoxCurrentPassword.Text == "" || textBoxNewPassword.Text == "" ||
                    textBoxConfirmPassword.Text == "")
                {
                    Alert alert = new Alert();
                    alert.showAlert("Warning", "Please fill in the password information.", Alert.enumType.Warning);
                }
                else if (currentEmployee.Password != textBoxCurrentPassword.Text)
                {
                    Alert alert = new Alert();
                    alert.showAlert("Warning", "Wrong current Password.", Alert.enumType.Warning);
                }
                else if (textBoxNewPassword.Text != textBoxConfirmPassword.Text)
                {
                    Alert alert = new Alert();
                    alert.showAlert("Warning", "Confirm Password not match.", Alert.enumType.Warning);
                }
                else
                {
                    Customer customer = new Customer
                    {
                        IdPerson = currentEmployee.IdPerson,
                        NamePerson = textBoxName.Text,
                        Phone = textBoxPhone.Text,
                        Address = textBoxAddress.Text,
                        Gender = radioButtonMale.Checked,
                        Birth = dateTimePickerBirth.Value,
                        Username = currentEmployee.Username,
                        Password = textBoxNewPassword.Text
                    };
                    BLL_QLRapchieuphim.Instance.updateCustomer(customer);
                    Alert alert = new Alert();
                    alert.showAlert("Successful", "Your information has been updated!", Alert.enumType.Success);
                    Alert alert2 = new Alert();
                    alert2.showAlert("Login with new Password", "You have to Login again!", Alert.enumType.Info);
                    logOut(new object(), EventArgs.Empty);
                }
            }
            else
            {
                Customer customer = new Customer
                {
                    IdPerson = currentEmployee.IdPerson,
                    NamePerson = textBoxName.Text,
                    Phone = textBoxPhone.Text,
                    Address = textBoxAddress.Text,
                    Gender = radioButtonMale.Checked,
                    Birth = dateTimePickerBirth.Value,
                    Username = currentEmployee.Username,
                    Password = currentEmployee.Password
                };
                BLL_QLRapchieuphim.Instance.updateCustomer(customer);
                BLL_QLRapchieuphim.Instance.updateCustomer(customer);
                Alert alert = new Alert();
                alert.showAlert("Successful", "Your information has been updated!", Alert.enumType.Success);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            openHome(new object(), EventArgs.Empty);
        }
    }
}
