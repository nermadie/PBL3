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
    public partial class AMF_Home : UserControl
    {
        public AMF_Home()
        {
            InitializeComponent();
            show();
        }
        private void show()
        {
            int earnings = 0;
            List<Detail_Order> l = BLL_QLRapchieuphim.Instance.List_Order_To_List_Detail_Order(BLL_QLRapchieuphim.Instance.Get_Order_By_IdCustomer("All"));
            foreach (Detail_Order item in l)
            {
                earnings += item.TotalCost;
            }
            labelEarnings.Text = earnings.ToString() + "đ";

            labelCus.Text = BLL_QLRapchieuphim.Instance.Get_Customer_By_Keyword("").Count.ToString();

            labelEms.Text = BLL_QLRapchieuphim.Instance.Get_Employee_By_Keyword("").Count.ToString();

            labelTics.Text = BLL_QLRapchieuphim.Instance.GetAll_TicketOrder().Count.ToString();


            Movie Top1Trending = BLL_QLRapchieuphim.Instance.Get_Top1_Trending_Movie();
            labelNameMovie.Text = Top1Trending.NameMovie;
            labelDirector.Text = "Director: " + Top1Trending.Director;
            labelActor.Text = "Actors: " + Top1Trending.Actor;
            //labelDescription.Text = "Description: " + Top1Trending.Description;
            labelReleaseDate.Text = "Release date: " + Top1Trending.ReleaseDate.ToString();
            labelCategory.Text = "Category" + Top1Trending.Category;

        }
    }
}
