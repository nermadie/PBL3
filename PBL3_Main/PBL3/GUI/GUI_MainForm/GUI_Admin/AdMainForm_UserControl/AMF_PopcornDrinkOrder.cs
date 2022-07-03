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
    public partial class AMF_PopcornDrinkOrder : UserControl
    {
        public AMF_PopcornDrinkOrder()
        {
            InitializeComponent();
            dataGridViewShow.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            ShowDGV();
        }
        private void ShowDGV()
        {
            dataGridViewShow.DataSource = BLL_QLRapchieuphim.Instance.List_PopcornDrinkOrder_To_List_Detail_PopcornDrinkOrder(BLL_QLRapchieuphim.Instance.GetAll_PopcornDrinkOrder());
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
