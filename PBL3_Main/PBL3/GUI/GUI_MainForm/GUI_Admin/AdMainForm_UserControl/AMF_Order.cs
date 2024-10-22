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
    public partial class AMF_Order : UserControl
    {
        public AMF_Order()
        {
            InitializeComponent();
            dataGridViewShow.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            ShowDGV(true);
        }
        private void ShowDGV(bool IsAll)
        {
            if (IsAll)
            {
                dataGridViewShow.DataSource = BLL_QLRapchieuphim.Instance.List_Order_To_List_Detail_Order(BLL_QLRapchieuphim.Instance.Get_Order_By_IdCustomer("All"));
            }
            else
            {
                DateTime date = guna2DateTimePicker1.Value.Date;
                if (BLL_QLRapchieuphim.Instance.Get_Order_By_Date(date) != null)
                {
                    dataGridViewShow.DataSource = BLL_QLRapchieuphim.Instance.List_Order_To_List_Detail_Order(BLL_QLRapchieuphim.Instance.Get_Order_By_Date(date));
                }
            }
        }
        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ShowDGV(false);
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
