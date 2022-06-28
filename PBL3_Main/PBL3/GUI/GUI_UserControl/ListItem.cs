using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.GUI.GUI_UserControl
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

        public void ChangePoster(string path)
        {
            guna2PictureBoxPoster.Image = Image.FromFile(path);
            this.guna2PictureBoxPoster.BorderRadius = 10;
        }

        public void ChangeRating(float rate)
        {
            guna2RatingStar.Value = rate;
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
