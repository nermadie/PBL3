using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL.BLL_MainForm.BLL_Admin;
using PBL3.DTO.DTO_PopcornDrink;

namespace PBL3.GUI.GUI_MainForm.GUI_Admin.AdMainForm_UserControl
{
    public partial class DetailForm_PopcornDrink : Form
    {
        public DetailForm_PopcornDrink(string _IdPopcornDrink)
        {
            InitializeComponent();
            Load_Detail(_IdPopcornDrink);
        }

        private void Load_Detail(string _IdPopcornDrink)
        {
            if (_IdPopcornDrink != null)
            {
                PopcornDrink pd = BLL_Admin.Instance.Find_PopcornDrink_By_IdPopcornDrink(_IdPopcornDrink);
                textBoxName.Text = pd.NamePopcornDrink;
                textBoxPrice.Text = pd.PricePopcornDrink.ToString();
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == String.Empty || textBoxPrice.Text == String.Empty || IsSuitablePrice() == false)
            {
                MessageBox.Show("Please fill all the textbox with suitable values");
            }
            else
            {
                PopcornDrink pd = new PopcornDrink
                {
                    IdPopcornDrink = "temp",
                    NamePopcornDrink = textBoxName.Text,
                    PricePopcornDrink = Convert.ToInt32(textBoxPrice.Text)
                };
                MessageBox.Show(BLL_Admin.Instance.AddUpdate_PopcornDrink(pd));
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool IsSuitablePrice()
        {
            try
            {
                Convert.ToInt32(textBoxPrice.Text);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
