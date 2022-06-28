using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.GUI.GUI_UserControl
{
    public partial class ButtonTimePrice : UserControl
    {
        public ButtonTimePrice(string time, int price)
        {
            InitializeComponent();
            this.guna2Button1.Text = time + " " + price + "K";
        }
    }
}
