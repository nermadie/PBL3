using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;
using PBL3.DTO.DTO_Person;

namespace PBL3.GUI.GUI_MainForm.GUI_Admin.AdMainForm_UserControl
{
    public partial class Form_AddUpdate_Employee : Form
    {
        private string IdEmployee;
        public Form_AddUpdate_Employee(string _IdEmployee = "")
        {
            InitializeComponent();
            View_tableLayoutPanelInformation();
            IdEmployee = _IdEmployee;
            if (_IdEmployee != "")
            {
                Load_Detail(_IdEmployee);
            }
        }
        private void Load_Detail(string _IdEmployee)
        {
            if (BLL_QLRapchieuphim.Instance.CheckExist_Employee_By_IdPerson(_IdEmployee) == true)
            {
                Employee em = BLL_QLRapchieuphim.Instance.Get_Employee_By_IdPerson(_IdEmployee);
                ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 0)).Text = em.Username;
                ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 1)).Text = em.Password;
                ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 2)).Text = em.NamePerson;
                ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 3)).Text = em.Shift.ToString();
                ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 4)).Text = em.Wage.ToString();
                ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 5)).Text = em.Phone;
                ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 6)).Text = em.Address;
                ((CheckBox)tableLayoutPanelInformation.GetControlFromPosition(1, 7)).Checked = em.Gender;
                ((DateTimePicker)tableLayoutPanelInformation.GetControlFromPosition(1, 8)).Value = em.Birth;
            }
            else
            {
                MessageBox.Show("Employee not found");
                DialogResult = DialogResult.Cancel;
                Dispose();
            }
        }
        private void View_tableLayoutPanelInformation()
        {
            tableLayoutPanelInformation.Controls.Clear();
            string[] TextOfAttributeLabel = {   "Username",
                                                "Password",
                                                "Name",
                                                "Shift",
                                                "Wage",
                                                "Phone",
                                                "Address",
                                                "Male",
                                                "Birth"};
            for (int i = 0; i < tableLayoutPanelInformation.RowCount; i++)
            {
                Label label = new Label();
                label.Font = new Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label.Text = TextOfAttributeLabel[i];
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.TopLeft;
                tableLayoutPanelInformation.Controls.Add(label, 0, i);
            }
            for (int i = 0; i < tableLayoutPanelInformation.RowCount - 2; i++)
            {
                TextBox textBox = new TextBox();
                textBox.Font = new Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                textBox.Dock = DockStyle.Fill;
                textBox.TextAlign = HorizontalAlignment.Left;
                textBox.TabIndex = i;
                tableLayoutPanelInformation.Controls.Add(textBox, 1, i);
            }
            CheckBox checkBoxMale = new CheckBox();
            checkBoxMale.Font = new Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            checkBoxMale.Dock = DockStyle.Fill;
            checkBoxMale.TabIndex = 7;
            tableLayoutPanelInformation.Controls.Add(checkBoxMale, 1, 7);

            DateTimePicker dateTimePickerBirth = new DateTimePicker();
            dateTimePickerBirth.Value = DateTime.Today;
            dateTimePickerBirth.Font = new Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateTimePickerBirth.Dock = DockStyle.Fill;
            dateTimePickerBirth.TabIndex = 8;
            tableLayoutPanelInformation.Controls.Add(dateTimePickerBirth, 1, 8);
        }
        private bool Check_Shift_And_Wage_Suitable_Values()
        {
            try
            {
                Convert.ToInt32(((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 3)).Text);
                Convert.ToInt32(((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 4)).Text);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private bool Check_All_TextBox_Filled_With_Suitable_Values()
        {
            if (((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 0)).Text == String.Empty
                || ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 1)).Text == String.Empty
                || ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 2)).Text == String.Empty
                || ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 3)).Text == String.Empty
                || ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 4)).Text == String.Empty
                || ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 5)).Text == String.Empty
                || ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 6)).Text == String.Empty
                || Check_Shift_And_Wage_Suitable_Values() == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (Check_All_TextBox_Filled_With_Suitable_Values() == true)
            {
                Employee em = new Employee
                {
                    IdPerson = "temp",
                    Username = ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 0)).Text,
                    Password = ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 1)).Text,
                    NamePerson = ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 2)).Text,
                    Shift = Convert.ToInt32(((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 3)).Text),
                    Wage = Convert.ToInt32(((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 4)).Text),
                    Phone = ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 5)).Text,
                    Address = ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 6)).Text,
                    Gender = ((CheckBox)tableLayoutPanelInformation.GetControlFromPosition(1, 7)).Checked,
                    Birth = ((DateTimePicker)tableLayoutPanelInformation.GetControlFromPosition(1, 8)).Value,
                };
                if (IdEmployee != "")
                {
                    em.IdPerson = IdEmployee;
                }
                MessageBox.Show(BLL_QLRapchieuphim.Instance.AddUpdate_Employee(em));
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(labelTitle.Text);
            }
        }
    }
}
