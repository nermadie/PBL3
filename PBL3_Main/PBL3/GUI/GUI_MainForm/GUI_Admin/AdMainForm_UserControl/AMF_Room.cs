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

namespace PBL3.GUI.GUI_MainForm.GUI_Admin.AdMainForm_UserControl
{
    public partial class AMF_Room : UserControl
    {
        public AMF_Room()
        {
            InitializeComponent();
            dataGridViewShow.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            ShowDGV();
        }
        private void ShowDGV()
        {
            dataGridViewShow.DataSource = BLL_QLRapchieuphim.Instance.List_Room_To_List_Detail_Room(BLL_QLRapchieuphim.Instance.GetAll_Room());
        }
        private void guna2ButtonAdd_Click(object sender, EventArgs e)
        {
            Form_AddUpdate_Room f = new Form_AddUpdate_Room("");
            if (f.ShowDialog() == DialogResult.OK)
            {
                ShowDGV();
            }
        }
        private void guna2ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewShow.SelectedRows.Count == 1)
            {
                string _IdRoom = dataGridViewShow.SelectedRows[0].Cells[0].Value.ToString();
                Form_AddUpdate_Room f = new Form_AddUpdate_Room(_IdRoom);
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
                    BLL_QLRapchieuphim.Instance.Delete_Room_By_IdRoom(row.Cells[0].Value.ToString());
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
