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
using PBL3.DTO.DTO_PopcornDrink;

namespace PBL3.GUI.GUI_MainForm.GUI_Admin.AdMainForm_UserControl
{
    public partial class Form_AddUpdate_PopcornDrink : Form
    {
        private string IdPopcornDrink;
        public Form_AddUpdate_PopcornDrink(string _IdPopcornDrink = "")
        {
            InitializeComponent();
            IdPopcornDrink = _IdPopcornDrink;
            if (_IdPopcornDrink != "")
            {
                Load_Detail(_IdPopcornDrink);
            }
        }

        private void Load_Detail(string _IdPopcornDrink)
        {
            if (BLL_QLRapchieuphim.Instance.CheckExist_PopcornDrink_By_IdPopcornDrink(_IdPopcornDrink) == true)
            {
                PopcornDrink pd = BLL_QLRapchieuphim.Instance.Get_PopcornDrink_By_IdPopcornDrink(_IdPopcornDrink);
                textBoxName.Text = pd.NamePopcornDrink;
                textBoxPrice.Text = pd.PricePopcornDrink.ToString();
            }
            else //almost cant happen
            {
                MessageBox.Show("PopcornDrink not found");
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == String.Empty || textBoxPrice.Text == String.Empty || IsSuitablePrice() == false)
            {
                MessageBox.Show("Every fields must be filled with suitable values!\nInput NumberSeats is not an suitable value, it must be divided by 10 and positive");
            }
            else
            {
                PopcornDrink pd = new PopcornDrink
                {
                    IdPopcornDrink = "temp",
                    NamePopcornDrink = textBoxName.Text,
                    PricePopcornDrink = Convert.ToInt32(textBoxPrice.Text)
                };
                if (IdPopcornDrink != "")
                {
                    pd.IdPopcornDrink = IdPopcornDrink;
                }
                string notification = BLL_QLRapchieuphim.Instance.AddUpdate_PopcornDrink(pd);
                MessageBox.Show(notification);
                if (notification == "Updated" || notification == "Added")
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }

        }

        private bool IsSuitablePrice()
        {
            try
            {
                int Price = Convert.ToInt32(textBoxPrice.Text);
                if (Price % 1000 != 0 || Price <= 0)
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
            Dispose();
        }
    }
}
