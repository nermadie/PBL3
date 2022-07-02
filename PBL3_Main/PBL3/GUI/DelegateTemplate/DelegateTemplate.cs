using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO.DTO_Person;
using PBL3.DTO.DTO_ShowTime;
using PBL3.GUI.GUI_AdditionalUserControl.UC_CartPopcornDrink;

namespace PBL3.GUI.DelegateTemplate
{
    public delegate void Del_void();
    public delegate void Del_string(string str);
    public delegate void Del_stringbool(string str, bool b);

    public delegate void Del_Customer(Customer cus);
    public delegate void Del_Event(object sender, EventArgs e);

    public delegate void Del_Movie(string idMovie);
    public delegate void Del_ShowTime(string idRoom, DateTime time);
    public delegate void Del_ShowTimeListSeat(string idRoom, DateTime time, List<string> seatsPurchased);

    public delegate void Del_ListCartPopcornDrinks(List<CartPopcornDrink> listcaCartPopcornDrinks);
    public delegate void Del_ShowTimeListstringDataGridViewRow(ShowTime showtime, List<string> seatsPurchased, DataGridViewRowCollection dataGridViewRows, int ticketPrice, int pdPrice, int totalPrice);
}
