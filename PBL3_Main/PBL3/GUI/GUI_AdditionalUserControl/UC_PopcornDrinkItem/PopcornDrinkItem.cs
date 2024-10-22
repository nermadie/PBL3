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

namespace PBL3.GUI.GUI_AdditionalUserControl.UC_PopcornDrinkItem
{
    public partial class PopcornDrinkItem : UserControl
    {
        public Del_stringbool add_removeCart { get; set; }
        public string currentIdPopcornDrink;
        public PopcornDrinkItem(string idPopcornDrink)
        {
            InitializeComponent();
            currentIdPopcornDrink = idPopcornDrink;
        }
        private void PopcornDrinkItem_Load(object sender, EventArgs e)
        {
            buttonTick.Visible = false;
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
            Description("Change Poster.")
        ]
        public Image PosterImage
        {
            get
            {
                return guna2PictureBoxItem.Image;
            }
            set
            {
                guna2PictureBoxItem.Image = value;
            }
        }

        public void disableButtonTick()
        {
            buttonTick.Visible = false;
        }
        private void guna2PictureBoxItem_Click(object sender, EventArgs e)
        {
            if (buttonTick.Visible)
            {
                buttonTick.Visible = false;
                add_removeCart(currentIdPopcornDrink, false);
            }
            else
            {
                buttonTick.Visible = true;
                add_removeCart(currentIdPopcornDrink, true);
            }
        }

    }
}
