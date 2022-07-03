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
using PBL3.DTO.DTO_View;

namespace PBL3.GUI.GUI_MainForm.GUI_Admin.AdMainForm_UserControl
{
    public partial class AMF_Movie : UserControl
    {
        public AMF_Movie()
        {
            InitializeComponent();
            dataGridViewShow.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            Setup_CBBSort();
            comboBoxSort.SelectedIndex = 0;
            ShowDGV();
        }
        private void Setup_CBBSort()
        {
            comboBoxSort.Items.Clear();
            foreach (CBBItemS item in BLL_QLRapchieuphim.Instance.Get_CBBSort_For_Movie())
            {
                comboBoxSort.Items.Add(item);
            }
        }
        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDGV();
        }
        private bool Check_Selected()
        {
            if (comboBoxSort.SelectedIndex < 0)
            {
                return false;
            }
            return true;
        }
        private void ShowDGV()
        {
            if (Check_Selected() == true)
            {
                string _Keyword = "";
                if (textBoxSearch.Text != String.Empty)
                {
                    _Keyword = textBoxSearch.Text;
                }
                string _SortBy = ((CBBItemS)comboBoxSort.SelectedItem).Value;
                if (BLL_QLRapchieuphim.Instance.Get_Movie_By_Keyword(_Keyword) != null)
                {
                    List<Movie> searched = BLL_QLRapchieuphim.Instance.Get_Movie_By_Keyword(_Keyword);
                    if (BLL_QLRapchieuphim.Instance.List_Movie_To_List_Detail_Movie(searched) != null)
                    {
                        List<Detail_Movie> toDetail = BLL_QLRapchieuphim.Instance.List_Movie_To_List_Detail_Movie(searched);
                        dataGridViewShow.DataSource = BLL_QLRapchieuphim.Instance.Sort_List_Detail_Movie(toDetail, _SortBy);
                    }
                }
            }
        }
        private void guna2ButtonAdd_Click(object sender, EventArgs e)
        {
            Form_AddUpdate_Movie f = new Form_AddUpdate_Movie();
            if (f.ShowDialog() == DialogResult.OK)
            {
                ShowDGV();
            }
        }
        private void guna2ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewShow.SelectedRows.Count == 1)
            {
                string _IdMovie = dataGridViewShow.SelectedRows[0].Cells[0].Value.ToString();
                Form_AddUpdate_Movie f = new Form_AddUpdate_Movie(_IdMovie);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    ShowDGV();
                }
            }
        }

        private void guna2ButtonSearch_Click(object sender, EventArgs e)
        {
            ShowDGV();
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void scrollBarShow_Scroll(object sender, ScrollEventArgs e)
        {

            try
            {
                dataGridViewShow.FirstDisplayedScrollingRowIndex = dataGridViewShow.Rows[e.NewValue].Index;
            }
            catch (Exception)
            {

            }
        }

        private void dataGridViewShow_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                scrollBarShow.Maximum = dataGridViewShow.RowCount - 1;
            }
            catch (Exception)
            {

            }
        }

        private void dataGridViewShow_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                scrollBarShow.Maximum = dataGridViewShow.RowCount - 1;
            }
            catch (Exception)
            {

            }
        }
    }
}
