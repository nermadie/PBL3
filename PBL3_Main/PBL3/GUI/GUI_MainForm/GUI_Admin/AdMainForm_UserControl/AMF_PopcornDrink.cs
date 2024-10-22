using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3;
using PBL3.BLL;

namespace PBL3.GUI.GUI_MainForm.GUI_Admin.AdMainForm_UserControl
{
    public partial class AMF_PopcornDrink : UserControl
    {
        public AMF_PopcornDrink()
        {
            InitializeComponent();
            dataGridViewShow.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;

            ShowDGV();
        }
        private void ShowDGV(string _Keyword = "")
        {
            dataGridViewShow.DataSource = BLL_QLRapchieuphim.Instance.Get_PopcornDrink_By_KeyWord(_Keyword);
        }
        private void guna2ButtonSearch_Click(object sender, EventArgs e)
        {
            string _Keyword = textBoxSearch.Text;
            ShowDGV(_Keyword);
        }
        private void guna2ButtonAdd_Click(object sender, EventArgs e)
        {
            Form_AddUpdate_PopcornDrink f = new Form_AddUpdate_PopcornDrink("");
            if (f.ShowDialog() == DialogResult.OK)
            {
                ShowDGV();
            }
        }

        private void guna2ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewShow.SelectedRows.Count == 1)
            {
                string _IdPopcornDrink = dataGridViewShow.SelectedRows[0].Cells[0].Value.ToString();
                Form_AddUpdate_PopcornDrink f = new Form_AddUpdate_PopcornDrink(_IdPopcornDrink);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    ShowDGV();
                }
            }
        }

        private void guna2ButtonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewShow.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewShow.SelectedRows)
                {
                    BLL_QLRapchieuphim.Instance.Delete_PopcornDrink_By_IdPopcornDrink(row.Cells[0].Value.ToString());
                }
                ShowDGV();
            }
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
