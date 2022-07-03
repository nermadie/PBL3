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
using PBL3.DTO.DTO_ShowTime;

namespace PBL3.GUI.GUI_MainForm.GUI_Admin.AdMainForm_UserControl
{
    public partial class Form_AddUpdate_Room : Form
    {
        private string IdRoom;

        public Form_AddUpdate_Room(string _IdRoom = "")
        {
            InitializeComponent();
            IdRoom = _IdRoom;
            if (_IdRoom != "")
            {
                Load_Detail(_IdRoom);
            }
        }

        private void Load_Detail(string _IdRoom)
        {
            if (BLL_QLRapchieuphim.Instance.CheckExist_Room_By_IdRoom(_IdRoom) == true)
            {
                Room r = BLL_QLRapchieuphim.Instance.Get_Room_By_IdRoom(_IdRoom);
                textBoxName.Text = r.NameRoom;
                textBoxNumber.Text = r.NumberSeats.ToString();
            }
            else //almost cant happen
            {
                MessageBox.Show("Room not found");
                DialogResult = DialogResult.Cancel;
                Close();
            }

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == String.Empty || textBoxNumber.Text == String.Empty || IsSuitableNumber() == false)
            {
                MessageBox.Show("Every fields must be filled with suitable values!\nInput NumberSeats is not an suitable value, it must be divided by 10 and positive");
            }
            else
            {
                Room r = new Room
                {
                    IdRoom = "temp",
                    NameRoom = textBoxName.Text,
                    NumberSeats = Convert.ToInt32(textBoxNumber.Text)
                };
                if (IdRoom != "")
                {
                    r.IdRoom = IdRoom;
                }
                string notification = BLL_QLRapchieuphim.Instance.AddUpdate_Room(r);
                MessageBox.Show(notification);
                if (notification == "Updated" || notification == "Added")
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private bool IsSuitableNumber()
        {
            try
            {
                int NumberSeats = Convert.ToInt32(textBoxNumber.Text);
                if (NumberSeats % 10 != 0 || NumberSeats <= 0)
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
