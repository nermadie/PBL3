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

namespace PBL3.GUI.GUI_AdditionalUserControl.UC_MovieItem
{
    public partial class MovieItem : UserControl
    {
        public Del_string callToOpenMovieDetail { get; set; }
        private string currentIdMovie { get; set; }

        public MovieItem(string idMovie)
        {
            InitializeComponent();
            currentIdMovie = idMovie;
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
            Description("Change Release Date.")
        ]
        public string ReleaseText
        {
            get
            {
                return labelRelease.Text;
            }
            set
            {
                labelRelease.Text = value;
            }
        }
        [
            Category("Data"),
            Description("Change Duration.")
        ]
        public string DurationText
        {
            get
            {
                return labelDuration.Text;
            }
            set
            {
                labelDuration.Text = value;
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
                return pictureBoxPoster.Image;
            }
            set
            {
                pictureBoxPoster.Image = value;
            }
        }

        private void pictureBoxPoster_Click(object sender, EventArgs e)
        {
            callToOpenMovieDetail(currentIdMovie);
        }

        private void textBoxTitle_Click(object sender, EventArgs e)
        {
            pictureBoxPoster_Click(sender, e);
        }
    }
}
