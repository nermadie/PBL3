using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL.BLL_MainForm.BLL_Admin;

namespace PBL3.GUI.GUI_MainForm.GUI_Admin.AdMainForm_UserControl
{
    public partial class AMF_PopcornDrink : UserControl
    {
        public AMF_PopcornDrink()
        {
            InitializeComponent();
            ShowDGV();
        }
        private void ShowDGV()
        {
            dataGridViewShow.DataSource = BLL_Admin.Instance.GetAll_PopcornDrink();
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

        private void guna2ButtonAdd_Click(object sender, EventArgs e)
        {
            DetailForm_PopcornDrink f = new DetailForm_PopcornDrink(null);
            if (f.ShowDialog() == DialogResult.OK)
            {
                ShowDGV();
            }
        }

        private void guna2ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewShow.SelectedRows.Count == 1)
            {
                string _IdPopcornDrink = dataGridViewShow.SelectedRows[0].Cells["0"].Value.ToString();
                DetailForm_PopcornDrink f = new DetailForm_PopcornDrink(_IdPopcornDrink);
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
                    BLL_Admin.Instance.Delete_PopcornDrink_By_IdPopcornDrink(row.Cells["0"].Value.ToString());
                }
                ShowDGV();
            }
        }
    }
}
