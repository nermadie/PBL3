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
    public partial class AMF_Employee : UserControl
    {
        public AMF_Employee()
        {
            InitializeComponent();
            dataGridViewShow.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            Setup_CBBFilter();
            Setup_CBBSort();
            comboBoxSort.SelectedIndex = 0;
            comboBoxFilter.SelectedIndex = 0;
            ShowDGV();
        }
        private void Setup_CBBSort()
        {
            comboBoxSort.Items.Clear();
            foreach (CBBItemS item in BLL_QLRapchieuphim.Instance.Get_CBBSort_For_Employee())
            {
                comboBoxSort.Items.Add(item);
            }
        }
        private void Setup_CBBFilter()
        {
            comboBoxFilter.Items.Clear();
            foreach (CBBItemS item in BLL_QLRapchieuphim.Instance.Get_CBBFilter_By_Shift_For_Employee())
            {
                comboBoxFilter.Items.Add(item);
            }
        }
        private void ShowDGV()
        {
            string _Keyword = "";
            if (textBoxSearch.Text != String.Empty)
            {
                _Keyword = textBoxSearch.Text;
            }
            int _Shift = Convert.ToInt32(((CBBItemS)comboBoxFilter.SelectedItem).Value);
            string _SortBy = ((CBBItemS)comboBoxSort.SelectedItem).Value;
            if (BLL_QLRapchieuphim.Instance.Get_Employee_By_Keyword(_Keyword) != null)
            {
                List<Employee> searched = BLL_QLRapchieuphim.Instance.Get_Employee_By_Keyword(_Keyword);
                if (BLL_QLRapchieuphim.Instance.Filter_Employee_By_Shift(searched, _Shift) != null)
                {
                    List<Employee> filtered = BLL_QLRapchieuphim.Instance.Filter_Employee_By_Shift(searched, _Shift);
                    if (BLL_QLRapchieuphim.Instance.List_Employee_To_List_Detail_Employee(filtered) != null)
                    {
                        List<Detail_Employee> toDetail = BLL_QLRapchieuphim.Instance.List_Employee_To_List_Detail_Employee(filtered);
                        dataGridViewShow.DataSource = BLL_QLRapchieuphim.Instance.Sort_List_Detail_Employee(toDetail, _SortBy);
                    }
                }
            }
        }
        private bool Check_Selected()
        {
            if (comboBoxFilter.SelectedIndex < 0 || comboBoxSort.SelectedIndex < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void guna2ButtonSearch_Click(object sender, EventArgs e)
        {
            if (Check_Selected() == true)
            {
                ShowDGV();
            }
        }
        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Check_Selected() == true)
            {
                ShowDGV();
            }
        }
        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Check_Selected() == true)
            {
                ShowDGV();
            }
        }
        private void guna2ButtonAdd_Click(object sender, EventArgs e)
        {
            Form_AddUpdate_Employee f = new Form_AddUpdate_Employee();
            if (f.ShowDialog() == DialogResult.OK)
            {
                ShowDGV();
            }
        }
        private void guna2ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewShow.SelectedRows.Count == 1)
            {
                string _IdEmployee = dataGridViewShow.SelectedRows[0].Cells[0].Value.ToString();
                Form_AddUpdate_Employee f = new Form_AddUpdate_Employee(_IdEmployee);
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
                    BLL_QLRapchieuphim.Instance.Delete_Employee_By_IdPerson(row.Cells[0].Value.ToString());
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
    }
}
