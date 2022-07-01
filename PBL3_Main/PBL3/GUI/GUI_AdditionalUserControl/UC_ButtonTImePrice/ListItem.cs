using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO.DTO_ShowTime;
using PBL3.GUI.DelegateTemplate;

namespace PBL3.GUI.GUI_AdditionalUserControl.UC_ButtonTimePrice
{
    public partial class ListItem : UserControl
    {
        public Del_ShowTime buyTicketbyShowTime_ListItem { get; set; }
        public Del_Movie importDatatoPanelDetail { get; set; }
        private string idMovie;
        public ListItem(string idMovie, Del_ShowTime openBuyTicket)
        {
            InitializeComponent();
            this.idMovie = idMovie;
            this.buyTicketbyShowTime_ListItem = openBuyTicket;
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

        public void ChangeTimeList(List<ShowTime> showtimes)
        {
            var buttonTimePrice = new ButtonTimePrice[showtimes.Count];
            for (int i = 0; i < showtimes.Count; i++)
            {
                buttonTimePrice[i] = new ButtonTimePrice(showtimes[i]);
                buttonTimePrice[i].buyTicketbyShowTime = buyTicketbyShowTime_ListItem;
            }
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

        private void guna2HtmlLabelTitle_Click(object sender, EventArgs e)
        {
            guna2PictureBoxPoster_Click(sender, e);
        }

        private void guna2PictureBoxPoster_Click(object sender, EventArgs e)
        {
            importDatatoPanelDetail(idMovie);
        }
    }
}
