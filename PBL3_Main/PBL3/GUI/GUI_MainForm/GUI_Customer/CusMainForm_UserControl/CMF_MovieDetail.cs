using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL.BLL_MainForm.BLL_Customer.BLL_Movies;
using PBL3.BLL.BLL_MainForm.BLL_Customer.BLL_Showtimes;
using PBL3.DTO.DTO_ShowTime;
using PBL3.GUI.DelegateTemplate;

namespace PBL3.GUI.GUI_MainForm.GUI_Customer.CusMainForm_UserControl
{
    public partial class CMF_MovieDetail : UserControl
    {
        public Del_string openShowtimes { get; set; }
        private string currentIdMovie;
        public CMF_MovieDetail(string idMovie)
        {
            currentIdMovie = idMovie;
            InitializeComponent();
            MovieDetail_Load(new object(), new EventArgs());
        }
        private void MovieDetail_Load(object sender, EventArgs e)
        {
            Movie temp = BLL_MovieDetail.Instance.getMoviebyIdMovie(currentIdMovie);
            pictureBoxPoster.Image = BLL_Showtimes.Instance.getImagebyIdMovie(currentIdMovie);
            textBoxTitle.Text = temp.NameMovie;
            textBoxDescription.Text = temp.Description;
            textBoxActor.Text = temp.Actor;
            textBoxCategory.Text = temp.Category;
            labelReleaseDateValue.Text = temp.ReleaseDate.ToShortDateString();
            labelDurationValue.Text = temp.Duration.ToString();
            labelRateValue.Text = string.Format("{0:0.0}", temp.Rate);
            openTrailer(temp.LinkTrailer);
        }
        private void openTrailer(string url)
        {
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='725' height='370' frameborder='0' allowfullscreen></iframe>";
            html += "</body></html>";
            this.webBrowser1.DocumentText = string.Format(html, url.Split('=')[1]);
        }

        private void guna2ButtonTicket_Click(object sender, EventArgs e)
        {
            Movie temp = BLL_MovieDetail.Instance.getMoviebyIdMovie(currentIdMovie);
            openShowtimes(temp.NameMovie);
        }
    }
}
