using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO.DTO_View
{
    public class Detail_ShowTime
    {
        public string NameMovie { get; set; }
        public string NameRoom { get; set; }
        public DateTime Time { get; set; }
        public string SeatView { get; set; } //View the DGV
        public string SlotView { get; set; } //View the DGV
        public int TicketPrice { get; set; }
        public int NumberSlots { get; set; }//View the DGV
        public int Get_NumberSlots_From_SeatStatus(string _SeatStatus)
        {
            int res = 0;
            foreach (char i in _SeatStatus)
            {
                if (i == '0')
                {
                    res++;
                }
            }
            return res;
        }
        public string Get_SeatView_From_SeatStatus(string _SeatStatus)
        {
            int NumberSeats = _SeatStatus.Length;
            if (NumberSeats % 10 == 0 && NumberSeats != 0)
            {
                string res = "";
                int NumberRows = NumberSeats / 10;
                for (int rowCount = 0; rowCount < NumberRows; rowCount++)
                {
                    for (int colCount = 0; colCount < 10; colCount++)
                    {
                        if (_SeatStatus[rowCount * 10 + colCount] == '1')
                        {
                            char rowChar = Convert.ToChar('A' + rowCount);
                            res += rowChar + colCount.ToString() + " ";
                        }
                    }
                }
                return res;
            }
            else
            {
                return "Error: length of _SeatStatus is not divided by 10";
            }
        }
        public string Get_SlotView_From_SeatStatus(string _SeatStatus)
        {
            int NumberSeats = _SeatStatus.Length;
            if (NumberSeats % 10 == 0 && NumberSeats != 0)
            {
                string res = "";
                int NumberRows = NumberSeats / 10;
                for (int rowCount = 0; rowCount < NumberRows; rowCount++)
                {
                    for (int colCount = 0; colCount < 10; colCount++)
                    {
                        if (_SeatStatus[rowCount * 10 + colCount] == '0')
                        {
                            char rowChar = Convert.ToChar('A' + rowCount);
                            res += rowChar + colCount.ToString() + " ";
                        }
                    }
                }
                return res;
            }
            else
            {
                return "Error: length of _SeatStatus is not divided by 10";
            }
        }
    }
}
