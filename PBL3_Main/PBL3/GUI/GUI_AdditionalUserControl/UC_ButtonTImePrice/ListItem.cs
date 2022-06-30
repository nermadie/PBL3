using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.GUI.GUI_AdditionalUserControl.UC_ButtonTimePrice
{
    public partial class ListItem : UserControl
    {
        public ListItem()
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
                return guna2HtmlLabelTitle.Text;
            }
            set
            {
                guna2HtmlLabelTitle.Text = value;
            }
        }
        [
            Category("Data"),
            Description("Change Description.")
        ]
        public string DescriptionText
        {
            get
            {
                return textBoxDescription.Text;
            }
            set
            {
                textBoxDescription.Text = value;
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
                return guna2PictureBoxPoster.Image;
            }
            set
            {
                guna2PictureBoxPoster.Image = value;
            }
        }

        public float Rating
        {
            get
            {
                return guna2RatingStar.Value;
            }
            set
            {
                guna2RatingStar.Value = value;
            }
        }

        public void ChangeTimeList(string[] time, int[] price)
        {
            var buttonTimePrice = new ButtonTimePrice[time.Length];
            for (int i = 0; i < time.Length; i++)
                buttonTimePrice[i] = new ButtonTimePrice(time[i], price[i]);
            flowLayoutPanelListTime.Controls.Clear();
            flowLayoutPanelListTime.Controls.AddRange(buttonTimePrice);
            int heightFlowList = ((flowLayoutPanelListTime.Controls.Count - 1) / 6) + 1;
            this.Size = new System.Drawing.Size(700, 190 + heightFlowList * 60);
            this.flowLayoutPanelListTime.Size = new System.Drawing.Size(470, 60 * heightFlowList);
        }

        public void ChangeBackColor(Color color)
        {
            guna2PanelAll.BackColor = color;
        }
    }
}
