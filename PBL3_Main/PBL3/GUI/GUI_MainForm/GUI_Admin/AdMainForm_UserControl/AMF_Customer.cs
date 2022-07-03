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
using PBL3.DTO.DTO_Person;
using PBL3.DTO.DTO_View;

namespace PBL3.GUI.GUI_MainForm.GUI_Admin.AdMainForm_UserControl
{
    public partial class AMF_Customer : UserControl
    {
        public AMF_Customer()
        {
            InitializeComponent();
            dataGridViewShow.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            ShowDGV();
        }
        private void ShowDGV()
        {
            string _Keyword = "";
            if (textBoxSearch.Text != String.Empty)
            {
                _Keyword = textBoxSearch.Text;
            }
            if (BLL_QLRapchieuphim.Instance.Get_Customer_By_Keyword(_Keyword) != null)
            {
                List<Customer> searched = BLL_QLRapchieuphim.Instance.Get_Customer_By_Keyword(_Keyword);
                if (BLL_QLRapchieuphim.Instance.List_Customer_To_List_Detail_Customer(searched) != null)
                {
                    List<Detail_Customer> toDetail = BLL_QLRapchieuphim.Instance.List_Customer_To_List_Detail_Customer(searched);
                    dataGridViewShow.DataSource = toDetail;
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
