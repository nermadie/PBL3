using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.GUI.GUI_AdditionalUserControl.UC_MovieItem
{
    public partial class MovieItem : UserControl
    {
        public MovieItem()
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
                return labelTitle.Text;
            }
            set
            {
                labelTitle.Text = value;
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
            Description("Change Poster.")
        ]
        public string PosterImage
        {
            get
            {
                return pictureBoxPoster.Image.ToString();
            }
            set
            {
                pictureBoxPoster.Image = Image.FromFile(value);
            }
        }
    }
}
