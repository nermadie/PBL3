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
    public partial class AMF_ShowTime : UserControl
    {
        public AMF_ShowTime()
        {
            InitializeComponent();
            dataGridViewShow.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            Setup_CBBSort();
            comboBoxSort.SelectedIndex = 0;
            Setup_CBBCanBuy();
            comboBoxCanBuy.SelectedIndex = 0;
            Setup_CBBMovie();
            comboBoxMovie.SelectedIndex = 0;
            //ShowDGV();
        }
        private void Setup_CBBSort()
        {
            comboBoxSort.Items.Clear();
            foreach (CBBItemS item in BLL_QLRapchieuphim.Instance.Get_CBBSort_For_ShowTime())
            {
                comboBoxSort.Items.Add(item);
            }
        }
        private void Setup_CBBMovie()
        {
            comboBoxMovie.Items.Clear();
            foreach (CBBItemS item in BLL_QLRapchieuphim.Instance.Get_CBBFilter_By_Movie_For_ShowTime())
            {
                comboBoxMovie.Items.Add(item);
            }
        }
        private void Setup_CBBCanBuy()
        {
            comboBoxCanBuy.Items.Clear();
            foreach (CBBItemS item in BLL_QLRapchieuphim.Instance.Get_CBBFilter_By_1HourAgo_For_ShowTime())
            {
                comboBoxCanBuy.Items.Add(item);
            }
        }
        private void ShowDGV()
        {
            if (Check_Selected() == true)
            {
                string _CBBCanBuyText = ((CBBItemS)comboBoxCanBuy.SelectedItem).Value;
                string _IdMovie = ((CBBItemS)comboBoxMovie.SelectedItem).Value;
                string _SortBy = ((CBBItemS)comboBoxSort.SelectedItem).Value;
                if (BLL_QLRapchieuphim.Instance.Filter_By1HourAgo_And_IdMovie(_CBBCanBuyText, _IdMovie) != null)
                {
                    List<ShowTime> filtered = BLL_QLRapchieuphim.Instance.Filter_By1HourAgo_And_IdMovie(_CBBCanBuyText, _IdMovie);
                    if (BLL_QLRapchieuphim.Instance.List_ShowTime_To_List_Detail_ShowTime(filtered) != null)
                    {
                        List<Detail_ShowTime> toDetail = BLL_QLRapchieuphim.Instance.List_ShowTime_To_List_Detail_ShowTime(filtered);
                        dataGridViewShow.DataSource = BLL_QLRapchieuphim.Instance.Sort_List_Detail_ShowTime(toDetail, _SortBy);
                    }
                }
            }

        }
        private bool Check_Selected()
        {
            if (comboBoxMovie.SelectedIndex < 0
                || comboBoxSort.SelectedIndex < 0
                || comboBoxCanBuy.SelectedIndex < 0)
            {
                return false;
            }
            return true;
        }
        private void comboBoxCanBuy_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDGV();
        }
        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDGV();

        }
        private void comboBoxMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDGV();

        }
        private void guna2ButtonAdd_Click(object sender, EventArgs e)
        {
            Form_AddUpdate_ShowTime f = new Form_AddUpdate_ShowTime();
            if (f.ShowDialog() == DialogResult.OK)
            {
                ShowDGV();
            }
        }
        private void guna2ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewShow.SelectedRows.Count == 1)
            {
                string _NameRoom = dataGridViewShow.SelectedRows[0].Cells[1].Value.ToString();
                DateTime _Time = Convert.ToDateTime(dataGridViewShow.SelectedRows[0].Cells[2].Value);
                string _IdRoom = BLL_QLRapchieuphim.Instance.Get_Room_By_NameRoom(_NameRoom).IdRoom;
                ShowTime choosen = BLL_QLRapchieuphim.Instance.Get_ShowTime_By_IdRoom_And_Time(_IdRoom, _Time);
                Form_AddUpdate_ShowTime f = new Form_AddUpdate_ShowTime(choosen);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    ShowDGV();
                }
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
