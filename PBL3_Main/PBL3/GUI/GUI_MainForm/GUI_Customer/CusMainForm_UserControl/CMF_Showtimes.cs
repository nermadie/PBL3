using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL.BLL_MainForm.BLL_Customer.BLL_Showtimes;
using PBL3.BLL.BLL_MainForm.BLL_Customer.BLL_Tickets;
using PBL3.DTO.DTO_ShowTime;
using PBL3.GUI.DelegateTemplate;
using PBL3.GUI.GUI_AdditionalUserControl.UC_ButtonTimePrice;
using PBL3.GUI.GUI_Alert;

namespace PBL3.GUI.GUI_MainForm.GUI_Customer.CusMainForm_UserControl
{
    public partial class CMF_Showtimes : UserControl
    {
        public Del_string openMovieDetail { get; set; }
        public Del_ShowTime buyTicketbyShowTime_Tickets { get; set; }
        private string currentIdMovie;
        private string currentText = "";
        public CMF_Showtimes()
        {
            InitializeComponent();
        }

        private void Tickets_Load(object sender, EventArgs e)
        {
            //Load showtime today
            dateTimePicker.Value = DateTime.Now;
            loadDataintoFlowLayoutPanel(dateTimePicker.Value);
        }

        private void ImportDatatoPanelDetail(string idMovie)
        {
            currentIdMovie = idMovie;
            Movie temp = BLL_Showtimes.Instance.getMoviebyIdMovie(idMovie);
            guna2PanelDetail.Enabled = true;
            guna2PictureBoxPoster.Enabled = true;
            guna2PictureBoxPoster.Image = BLL_Showtimes.Instance.getImagebyIdMovie(idMovie);
            textBoxTitle.Text = temp.NameMovie;
            textBoxDescription.Text = temp.Description;
            textBoxActor.Text = temp.Actor;
            textBoxCategory.Text = temp.Category;
            labelReleaseDateValue.Text = temp.ReleaseDate.ToShortDateString();
            labelDurationValue.Text = temp.Duration.ToString();
            labelRateNum.Text = string.Format("{0:0.0}", temp.Rate);
            currentIdMovie = idMovie;
        }

        private void loadDataintoFlowLayoutPanel(DateTime time, string text = "", bool isSearching = false)
        {
            flowLayoutPanelListST.Controls.Clear();
            flowLayoutPanelListST.Controls.AddRange(BLL_Showtimes.Instance.getListItem(time, ImportDatatoPanelDetail, buyTicketbyShowTime_Tickets, text));
            guna2PanelDetail.Enabled = false;
            guna2PictureBoxPoster.Enabled = false;
            if (flowLayoutPanelListST.Controls.Count == 0 && !isSearching)
            {
                Alert alert = new Alert();
                alert.showAlert("There is no showtime today", "Please be back later. Thank you.", Alert.enumType.Info);
            }
        }
        private void guna2ButtonMoreDetail_Click(object sender, EventArgs e)
        {
            openMovieDetail(currentIdMovie);
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            loadDataintoFlowLayoutPanel(dateTimePicker.Value, currentText);
        }

        public void searchinListST(string text)
        {
            currentText = text;
            loadDataintoFlowLayoutPanel(dateTimePicker.Value, text, true);
        }
    }
}
