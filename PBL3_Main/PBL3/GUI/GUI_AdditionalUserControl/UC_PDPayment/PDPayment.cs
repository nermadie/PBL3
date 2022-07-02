using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.GUI.GUI_AdditionalUserControl.UC_PDPayment
{
    public partial class PDPayment : UserControl
    {
        public PDPayment(string title, string quantity)
        {
            InitializeComponent();
            textBoxTitle.Text = title;
            textBoxQuantity.Text = "x" + quantity;
        }
    }
}
