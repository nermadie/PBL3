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
using PBL3.GUI.GUI_AdditionalUserControl.UC_MovieItem;

namespace PBL3.GUI.GUI_MainForm.GUI_Customer.CusMainForm_UserControl
{
    public partial class CMF_Movies : UserControl
    {
        public Del_string openMovieDetail { get; set; }
        private string currentTextContains = "";
        private bool checkLoading = false;
        public CMF_Movies()
        {
            InitializeComponent();
        }
        private void Movies_Load(object sender, EventArgs e)
        {
            loadDataFilmintoFlowLayoutPanel();
            guna2ComboBoxCategory.Items.AddRange(BLL_Movies.Instance.getCBBCategory());
            guna2ComboBoxCategory.SelectedIndex = 0;
            guna2ComboBoxSortBy.SelectedIndex = 0;
            checkLoading = true;
        }
        private void loadDataFilmintoFlowLayoutPanel(string text_Contains = "", string sortBy = "Latest", string category = "All")
        {
            flowLayoutPanel.Controls.Clear();
            List<Movie> tempMovie = BLL_Movies.Instance.getMovies(text_Contains, sortBy, category);
            foreach (Movie movie in tempMovie)
            {
                MovieItem item = new MovieItem(movie.IdMovie);
                item.callToOpenMovieDetail = openMovieDetail;
                item.PosterImage = BLL_Showtimes.Instance.getImagebyIdMovie(movie.IdMovie);
                item.TitleText = movie.NameMovie;
                item.ReleaseText = movie.ReleaseDate.ToShortDateString();
                item.DurationText = movie.Duration.ToString();
                flowLayoutPanel.Controls.Add(item);
            }
        }

        public void searchMovies(string text)
        {
            loadDataFilmintoFlowLayoutPanel(text, guna2ComboBoxSortBy.Text, guna2ComboBoxCategory.Text);
            currentTextContains = text;
        }

        private void guna2ComboBoxTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkLoading)
                loadDataFilmintoFlowLayoutPanel(currentTextContains, guna2ComboBoxSortBy.Text, guna2ComboBoxCategory.Text);
        }

        private void guna2ComboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkLoading)
                loadDataFilmintoFlowLayoutPanel(currentTextContains, guna2ComboBoxSortBy.Text, guna2ComboBoxCategory.Text);
        }

    }
}
