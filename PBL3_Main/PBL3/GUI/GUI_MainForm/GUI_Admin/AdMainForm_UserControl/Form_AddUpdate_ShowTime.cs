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
    public partial class Form_AddUpdate_ShowTime : Form
    {
        private ShowTime thisST = null;
        private string NameRoom = "";
        private string NameMovie = "";
        public Form_AddUpdate_ShowTime(ShowTime st = null)
        {
            InitializeComponent();
            View_tableLayoutPanelInformation();
            if (st != null)
            {
                thisST = st;
                NameMovie = BLL_QLRapchieuphim.Instance.Get_Movie_By_IdMovie(st.IdMovie).NameMovie;
                NameRoom = BLL_QLRapchieuphim.Instance.Get_Room_By_IdRoom(st.IdRoom).NameRoom;
                Load_Detail();
            }
            else
            {
                ((ComboBox)tableLayoutPanelInformation.GetControlFromPosition(1, 0)).SelectedIndex = 0;
                ((ComboBox)tableLayoutPanelInformation.GetControlFromPosition(1, 1)).SelectedIndex = 0;
            }
        }
        private void Load_Detail()
        {
            if (thisST != null)
            {
                ((ComboBox)tableLayoutPanelInformation.GetControlFromPosition(1, 0)).SelectedIndex = ((ComboBox)tableLayoutPanelInformation.GetControlFromPosition(1, 0)).Items.IndexOf(NameRoom);
                ((ComboBox)tableLayoutPanelInformation.GetControlFromPosition(1, 1)).SelectedIndex = ((ComboBox)tableLayoutPanelInformation.GetControlFromPosition(1, 1)).Items.IndexOf(NameMovie);
                ((DateTimePicker)tableLayoutPanelInformation.GetControlFromPosition(1, 2)).Value = thisST.Time;
                ((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 3)).Text = thisST.TicketPrice.ToString();
            }
        }
        private void View_tableLayoutPanelInformation()
        {
            tableLayoutPanelInformation.Controls.Clear();
            string[] TextOfAttributeLabel = {   "NameRoom",
                                                "NameMovie",
                                                "Time",
                                                "TicketPrice"};
            for (int i = 0; i < tableLayoutPanelInformation.RowCount; i++)
            {
                Label label = new Label();
                label.Font = new Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label.Text = TextOfAttributeLabel[i];
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.TopLeft;
                tableLayoutPanelInformation.Controls.Add(label, 0, i);
            }
            //cbbNameRoom
            ComboBox comboxBoxNameRoom = new ComboBox();
            comboxBoxNameRoom.Font = new Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            comboxBoxNameRoom.Items.Clear();
            foreach (CBBItemS item in BLL_QLRapchieuphim.Instance.Get_CBBNameRoom())
            {
                comboxBoxNameRoom.Items.Add(item.Text);
            }
            comboxBoxNameRoom.Dock = DockStyle.Fill;
            comboxBoxNameRoom.TabIndex = 0;
            tableLayoutPanelInformation.Controls.Add(comboxBoxNameRoom, 1, 0);
            //cbbNameMovie
            ComboBox comboxBoxNameMovie = new ComboBox();
            comboxBoxNameMovie.Font = new Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            comboxBoxNameMovie.Items.Clear();
            foreach (CBBItemS item in BLL_QLRapchieuphim.Instance.Get_CBBFilter_By_Movie_For_ShowTime())
            {
                if (item.Value != "All")
                {
                    comboxBoxNameMovie.Items.Add(item.Text);
                }
            }
            comboxBoxNameMovie.TabIndex = 1;
            comboxBoxNameMovie.Dock = DockStyle.Fill;
            tableLayoutPanelInformation.Controls.Add(comboxBoxNameMovie, 1, 1);
            //Time
            DateTimePicker dateTimePickerShowTime = new DateTimePicker();
            dateTimePickerShowTime.Format = DateTimePickerFormat.Time;
            dateTimePickerShowTime.Font = new Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateTimePickerShowTime.Dock = DockStyle.Fill;
            dateTimePickerShowTime.TabIndex = 2;
            tableLayoutPanelInformation.Controls.Add(dateTimePickerShowTime, 1, 2);
            //TicketPrice
            TextBox textBoxPrice = new TextBox();
            textBoxPrice.Font = new Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBoxPrice.Dock = DockStyle.Fill;
            textBoxPrice.TextAlign = HorizontalAlignment.Left;
            textBoxPrice.TabIndex = 3;
            tableLayoutPanelInformation.Controls.Add(textBoxPrice, 1, 3);
        }
        private int Get_TicketPrice_Suitable_Value()
        {
            try
            {
                int res = Convert.ToInt32(((TextBox)tableLayoutPanelInformation.GetControlFromPosition(1, 3)).Text);
                if (res <= 0 || res % 1000 != 0)
                {
                    return -1;
                }
                return res;
            }
            catch
            {
                return -1;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (Get_TicketPrice_Suitable_Value() != -1)
            {
                ShowTime st = new ShowTime();
                int indexOf_CBBItem_Room_Chosen = ((ComboBox)tableLayoutPanelInformation.GetControlFromPosition(1, 0)).SelectedIndex;
                int indexOf_CBBItem_Movie_Chosen = ((ComboBox)tableLayoutPanelInformation.GetControlFromPosition(1, 1)).SelectedIndex + 1;//there is a "all" item
                st.IdMovie = BLL_QLRapchieuphim.Instance.Get_CBBFilter_By_Movie_For_ShowTime().ElementAt(indexOf_CBBItem_Movie_Chosen).Value;
                st.IdRoom = BLL_QLRapchieuphim.Instance.Get_CBBNameRoom().ElementAt(indexOf_CBBItem_Room_Chosen).Value;
                st.TicketPrice = Get_TicketPrice_Suitable_Value();
                st.Time = ((DateTimePicker)tableLayoutPanelInformation.GetControlFromPosition(1, 2)).Value;
                st.Seat = "temp";
                string notification = BLL_QLRapchieuphim.Instance.AddUpdate_ShowTime(st);
                MessageBox.Show(notification);
                if (notification == "Updated" || notification == "Added")
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
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
