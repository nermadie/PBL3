using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.EntityFramework;
using PBL3.DTO.DTO_Person;
using PBL3.GUI.GUI_Alert;
using PBL3.GUI.GUI_MainForm;

namespace PBL3.GUI.GUI_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Alert aForm = new Alert();
            //aForm.showAlert("abc", "abc", Alert.enumType.Info);
            genDB();
        }

        private void genDB()
        {
            QLRapChieuPhim db = new QLRapChieuPhim();
            dataGridView1.DataSource = db.Customers.ToList();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            Alert aForm = new Alert();
            aForm.showAlert("abc", "abc", Alert.enumType.Info);
        }
    }
}
