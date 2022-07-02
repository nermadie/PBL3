using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.GUI.DelegateTemplate;

namespace PBL3.GUI.GUI_AdditionalUserControl.UC_CartPopcornDrink
{
    public partial class CartPopcornDrink : UserControl
    {
        public Del_void updateTotal { get; set; }
        public Del_stringbool add_removeCart { get; set; }
        public string currentPopcornDrink;
        public CartPopcornDrink(string idPopcornDrink)
        {
            InitializeComponent();
            currentPopcornDrink = idPopcornDrink;
        }

        public CartPopcornDrink()
        {
            InitializeComponent();
        }

        [
            Category("Data"),
            Description("Change Title.")
        ]
        public string TitleText
        {
            get
            {
                return textBoxTitle.Text;
            }
            set
            {
                textBoxTitle.Text = value;
            }
        }
        [
            Category("Data"),
            Description("Change Price.")
        ]
        public string PriceText
        {
            get
            {
                return labelPrice.Text;
            }
            set
            {
                labelPrice.Text = value;
            }
        }
        [
            Category("Data"),
            Description("Change quantity.")
        ]
        public decimal Quantity
        {
            get
            {
                return guna2NumericUpDown1.Value;
            }
            set
            {
                guna2NumericUpDown1.Value = value;
            }
        }
        private void pictureBoxRemove_Click(object sender, EventArgs e)
        {
            add_removeCart(currentPopcornDrink, false);
        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            updateTotal();
        }
    }
}
