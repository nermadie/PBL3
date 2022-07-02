using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO.DTO_Person;
using PBL3.DTO.DTO_ShowTime;
using PBL3.GUI.GUI_ChooseRole;
using PBL3.GUI.GUI_Login.Login_Admin;
using PBL3.GUI.GUI_Login.Login_Customer;
using PBL3.GUI.GUI_Login.Login_Employee;
using PBL3.GUI.GUI_Test;
using PBL3.GUI.GUI_MainForm;
using PBL3.GUI.GUI_MainForm.GUI_Admin;
using PBL3.GUI.GUI_MainForm.GUI_Customer;
using PBL3.GUI.GUI_MainForm.GUI_Customer.CusMainForm_UserControl;

namespace PBL3
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new CustomerMainForm("customer000001"));
            Application.Run(new ChooseRole());
            //Application.Run(new AdminMainForm(new Admin()));
        }
    }
}
