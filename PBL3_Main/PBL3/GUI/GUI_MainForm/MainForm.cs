using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using PBL3.GUI.GUI_MainForm.MainForm_ChildForm;

namespace PBL3.GUI.GUI_MainForm
{
    public partial class MainForm : Form
    {
        //Fields
        private IconButton _currentButton;
        private Panel _leftBorderButton;
        private Form _currentChildForm;
        //Constructor
        public MainForm()
        {
            InitializeComponent();
            CollapseMenu();
            _leftBorderButton = new Panel();
            _leftBorderButton.Size = new Size(7, 60);
            panelMenu.Controls.Add(_leftBorderButton);
            //Form - Reduce flickering in the form graphics
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            //Not maximize over taskbar
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //Struct Store RGB color
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(238, 84, 100);
            public static Color color2 = Color.FromArgb(103, 152, 208);
            public static Color color3 = Color.FromArgb(255, 207, 86);
            public static Color color4 = Color.FromArgb(91, 194, 167);
            public static Color color5 = Color.FromArgb(243, 109, 84);
            public static Color color6 = Color.FromArgb(161, 85, 185);
            public static Color color7 = Color.FromArgb(247, 101, 163);
        }
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                _currentButton = (IconButton)senderBtn;
                _currentButton.BackColor = Color.FromArgb(37, 36, 81);
                _currentButton.ForeColor = color;
                _currentButton.TextAlign = ContentAlignment.MiddleCenter;
                _currentButton.IconColor = color;
                _currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                _currentButton.ImageAlign = ContentAlignment.MiddleRight;
                _currentButton.Font = new Font("Segoe UI SemiBold", 14);
                _currentButton.IconSize = 40;
                //Left border button
                _leftBorderButton.BackColor = color;
                _leftBorderButton.Location = new Point(0, _currentButton.Location.Y);
                _leftBorderButton.Visible = true;
                _leftBorderButton.BringToFront();
                //Icon Current Child Form
                iconCurrentChildForm.IconChar = _currentButton.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (_currentButton != null)
            {
                _currentButton.BackColor = Color.FromArgb(31, 30, 68);
                _currentButton.ForeColor = Color.Gainsboro;
                _currentButton.TextAlign = ContentAlignment.MiddleCenter;
                _currentButton.IconColor = Color.Gainsboro;
                _currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                _currentButton.ImageAlign = ContentAlignment.MiddleLeft;
                _currentButton.Font = new Font("Segoe UI SemiBold", 12);
                _currentButton.IconSize = 32;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (_currentChildForm != null)
            {
                //open only form
                _currentChildForm.Close();
            }

            _currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;//Associate the form to the panel
            childForm.BringToFront();
            childForm.Show();
            labelTitleChildForm.Text = childForm.Text;
        }
        private void iconButtonMovie_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Movie());
        }

        private void iconButtonShowTime_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new ShowTime());
        }

        private void iconButtonRoom_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Room());
        }

        private void iconButtonPCDrink_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new PopcornDrink());
        }

        private void iconButtonCustomer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new Customer());
        }

        private void iconButtonEmployee_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new Employee());
        }

        private void iconButtonStatistic_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            OpenChildForm(new Statistic());
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            _currentChildForm.Close();
            Reset();
            _currentButton = null;
        }

        private void Reset()
        {
            DisableButton();
            _leftBorderButton.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.Gainsboro;
            labelTitleChildForm.Text = "Home";
        }
        //Hold and move form:
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Mouse Enter - To emphasize the division that is Entering:
        private void iconButtonDivision_MouseEnter(object senderBtn, EventArgs e)
        {
            IconButton enteringButton = (IconButton)senderBtn;
            if (enteringButton != _currentButton)
            {
                enteringButton.BackColor = Color.Gainsboro;
                enteringButton.ForeColor = Color.FromArgb(26, 25, 62);
                enteringButton.IconColor = Color.FromArgb(26, 25, 62);
            }
        }
        private void iconButtonDivision_MouseLeave(object senderBtn, EventArgs e)
        {
            IconButton leavingButton = (IconButton)senderBtn;
            if (leavingButton != _currentButton)
            {
                leavingButton.BackColor = Color.FromArgb(31, 30, 68);
                leavingButton.ForeColor = Color.Gainsboro;
                leavingButton.IconColor = Color.Gainsboro;
            }
        }
        //Title bar button:
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonClose_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(232, 17, 35);
        }

        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(26, 25, 62);
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if(this.panelMenu.Width > 200)
            {
                panelMenu.Width = 100;
                pictureBoxLogo.Visible = false;
                buttonMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding =new Padding(0);
                }
            }
            else
            {
                panelMenu.Width = 230;
                pictureBoxLogo.Visible = true;
                buttonMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text ="   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 20, 0);
                }
            }
        }
    }
}
