using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;
using PBL3.DTO.DTO_ShowTime;

namespace PBL3.GUI.GUI_MainForm.GUI_Admin.AdMainForm_UserControl
{
    public partial class Form_AddUpdate_Movie : Form
    {
        private string IdMovie;
        public Form_AddUpdate_Movie(string _IdMovie = "")
        {
            InitializeComponent();
            IdMovie = _IdMovie;
            View_tableLayoutPanelInformation();
            if (_IdMovie != "")
            {
                Load_Detail(_IdMovie);
            }
        }
        private void Load_Detail(string _IdMovie)
        {
            if (BLL_QLRapchieuphim.Instance.CheckExist_Movie_By_IdMovie(_IdMovie) == true)
            {
                Movie mv = BLL_QLRapchieuphim.Instance.Get_Movie_By_IdMovie(_IdMovie);
                ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 0)).Text = mv.NameMovie;
                ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 1)).Text = mv.Director;
                ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 2)).Text = mv.Actor;
                ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 3)).Text = mv.Category;
                ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 4)).Text = mv.Rate.ToString();
                ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 5)).Text = mv.Description;
                ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 6)).Text = mv.LinkTrailer;
                ((ComboBox)((TableLayoutPanel)tableLayoutPanelInformation.GetControlFromPosition(1, 7)).GetControlFromPosition(0, 0)).SelectedIndex = ((ComboBox)((TableLayoutPanel)tableLayoutPanelInformation.GetControlFromPosition(1, 7)).GetControlFromPosition(0, 0)).Items.IndexOf(mv.Duration.Hours.ToString());
                ((ComboBox)((TableLayoutPanel)tableLayoutPanelInformation.GetControlFromPosition(1, 7)).GetControlFromPosition(2, 0)).SelectedIndex = ((ComboBox)((TableLayoutPanel)tableLayoutPanelInformation.GetControlFromPosition(1, 7)).GetControlFromPosition(2, 0)).Items.IndexOf(mv.Duration.Minutes.ToString());
                ((DateTimePicker)tableLayoutPanelInformation.GetControlFromPosition(1, 8)).Value = mv.ReleaseDate;
            }
            else
            {
                MessageBox.Show("Movie not found");
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }
        private void View_tableLayoutPanelInformation()
        {
            tableLayoutPanelInformation.Controls.Clear();
            string[] TextOfAttributeLabel = {   "NameMovie",
                                                "Director",
                                                "Actor",
                                                "Category",
                                                "Rate",
                                                "Description",
                                                "LinkTrailer",
                                                "Duration",
                                                "ReleaseDate"};
            for (int i = 0; i < tableLayoutPanelInformation.RowCount; i++)
            {
                Label label = new Label();
                label.Font = new Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label.Text = TextOfAttributeLabel[i];
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.TopLeft;
                tableLayoutPanelInformation.Controls.Add(label, 0, i);
            }
            for (int i = 0; i < tableLayoutPanelInformation.RowCount - 2; i++)
            {
                TextBox textBox = new TextBox();
                textBox.Font = new Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                textBox.Dock = DockStyle.Fill;
                textBox.TextAlign = HorizontalAlignment.Left;
                textBox.TabIndex = i;
                tableLayoutPanelInformation.Controls.Add(textBox, 1, i);
            }
            TableLayoutPanel TLP_Duraton = new TableLayoutPanel();
            TLP_Duraton.ColumnCount = 4;
            TLP_Duraton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            TLP_Duraton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            TLP_Duraton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            TLP_Duraton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            TLP_Duraton.RowCount = 1;
            TLP_Duraton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            TLP_Duraton.Dock = System.Windows.Forms.DockStyle.Fill;
            //cbbH
            ComboBox cbbH = new ComboBox();
            cbbH.Font = new Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            for (int i = 0; i < 5; i++)
            {
                cbbH.Items.Add(i.ToString());
            }
            cbbH.SelectedIndex = 0;
            cbbH.Dock = DockStyle.Fill;
            TLP_Duraton.Controls.Add(cbbH, 0, 0);
            //cbbM
            ComboBox cbbM = new ComboBox();
            cbbM.Font = new Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            for (int i = 0; i < 59; i++)
            {
                cbbM.Items.Add(i.ToString());
            }
            cbbM.SelectedIndex = 0;
            cbbM.Dock = DockStyle.Fill;
            TLP_Duraton.Controls.Add(cbbM, 2, 0);
            //labelH
            Label labelH = new Label();
            labelH.Text = "h";
            labelH.Font = new Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelH.Dock = DockStyle.Fill;
            labelH.TextAlign = ContentAlignment.MiddleLeft;
            TLP_Duraton.Controls.Add(labelH, 1, 0);
            //labelM
            Label labelM = new Label();
            labelM.Text = "m";
            labelM.Font = new Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelM.Dock = DockStyle.Fill;
            labelM.TextAlign = ContentAlignment.MiddleLeft;
            TLP_Duraton.Controls.Add(labelM, 3, 0);
            //Add TLP_Duration
            tableLayoutPanelInformation.Controls.Add(TLP_Duraton, 1, 7);
            //
            DateTimePicker dateTimePickerBirth = new DateTimePicker();
            dateTimePickerBirth.Format = DateTimePickerFormat.Time;
            dateTimePickerBirth.Font = new Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateTimePickerBirth.Dock = DockStyle.Fill;
            dateTimePickerBirth.TabIndex = 8;
            tableLayoutPanelInformation.Controls.Add(dateTimePickerBirth, 1, 8);
        }

        private bool Check_All_TextBox_Filled_With_Suitable_Values()
        {
            if (((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 0)).Text == String.Empty
                || ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 1)).Text == String.Empty
                || ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 2)).Text == String.Empty
                || ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 3)).Text == String.Empty
                || ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 4)).Text == String.Empty
                || ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 5)).Text == String.Empty
                || ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 6)).Text == String.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private TimeSpan Get_Duration_From_TLP_Duration()
        {
            TableLayoutPanel tlpChild = (TableLayoutPanel)tableLayoutPanelInformation.GetControlFromPosition(1, 7);
            ComboBox cbbChild = (ComboBox)tlpChild.GetControlFromPosition(0, 0);

            int h = Convert.ToInt32(((ComboBox)((TableLayoutPanel)tableLayoutPanelInformation.GetControlFromPosition(1, 7)).GetControlFromPosition(0, 0)).SelectedItem.ToString());
            int m = Convert.ToInt32(((ComboBox)((TableLayoutPanel)tableLayoutPanelInformation.GetControlFromPosition(1, 7)).GetControlFromPosition(2, 0)).SelectedItem.ToString());
            return new TimeSpan(h, m, 0);
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (Check_All_TextBox_Filled_With_Suitable_Values() == true)
            {
                Movie mv = new Movie();
                mv.IdMovie = "temp";
                mv.NameMovie = ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 0)).Text;
                mv.Director = ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 1)).Text;
                mv.Actor = ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 2)).Text;
                mv.Category = ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 3)).Text;
                mv.Rate = Convert.ToDouble(((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 4)).Text);
                mv.Description = ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 5)).Text;
                mv.LinkTrailer = ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 6)).Text;
                mv.Duration = Get_Duration_From_TLP_Duration();
                mv.ReleaseDate = ((DateTimePicker)tableLayoutPanelInformation.GetControlFromPosition(1, 8)).Value;
                if (IdMovie != "")
                {
                    mv.IdMovie = IdMovie;
                }
                MessageBox.Show(BLL_QLRapchieuphim.Instance.AddUpdate_Movie(mv));
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(labelTitle.Text);
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
