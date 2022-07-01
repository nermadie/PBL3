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
using PBL3.DTO.DTO_Person;
using PBL3.GUI.GUI_MainForm.GUI_Admin.AdMainForm_UserControl;

namespace PBL3.GUI.GUI_MainForm.GUI_Admin
{
    public partial class AdminMainForm : Form
    {
        //Fields
        private IconButton currentButton;
        private Panel leftBorderButton;
        private UserControl currentUserControl;
        //Constructor
        public AdminMainForm(Admin admin)
        {
            InitializeComponent();
            CollapseMenu();
            leftBorderButton = new Panel();
            leftBorderButton.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderButton);
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
                currentButton = (IconButton)senderBtn;
                currentButton.BackColor = Color.FromArgb(37, 36, 81);
                currentButton.ForeColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = color;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;
                currentButton.Font = new Font("Segoe UI SemiBold", 14);
                currentButton.IconSize = 40;
                //Left border button
                leftBorderButton.BackColor = color;
                leftBorderButton.Location = new Point(0, currentButton.Location.Y);
                leftBorderButton.Visible = true;
                leftBorderButton.BringToFront();
                //Icon Current Child Form
                iconCurrentChildForm.IconChar = currentButton.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(31, 30, 68);
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = Color.Gainsboro;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
                currentButton.Font = new Font("Segoe UI SemiBold", 12);
                currentButton.IconSize = 32;
            }
        }

        private void addUserControl(UserControl userControl)
        {
            currentUserControl?.Dispose();
            currentUserControl = userControl;
            userControl.Dock = DockStyle.Fill;
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(userControl);
            userControl.BringToFront();
            currentUserControl = userControl;
        }
        private void iconButtonMovie_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            addUserControl(new AMF_Movie());
        }

        private void iconButtonShowTime_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            addUserControl(new AMF_ShowTime());
        }

        private void iconButtonRoom_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            addUserControl(new AMF_Room());
        }

        private void iconButtonPCDrink_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            addUserControl(new AMF_PopcornDrink());
        }

        private void iconButtonCustomer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            addUserControl(new AMF_Employee());
        }

        private void iconButtonEmployee_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            addUserControl(new AMF_Employee());
        }

        private void iconButtonStatistic_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            //addUserControl();
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            currentUserControl.Dispose();
            Reset();
            currentButton = null;
        }

        private void Reset()
        {
            DisableButton();
            leftBorderButton.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.Gainsboro;
            labelTitleChildForm.Text = "Home";
        }
        //Mouse Enter - To emphasize the division that is Entering:
        private void iconButtonDivision_MouseEnter(object senderBtn, EventArgs e)
        {
            IconButton enteringButton = (IconButton)senderBtn;
            if (enteringButton != currentButton)
            {
                enteringButton.BackColor = Color.Gainsboro;
                enteringButton.ForeColor = Color.FromArgb(26, 25, 62);
                enteringButton.IconColor = Color.FromArgb(26, 25, 62);
            }
        }
        private void iconButtonDivision_MouseLeave(object senderBtn, EventArgs e)
        {
            IconButton leavingButton = (IconButton)senderBtn;
            if (leavingButton != currentButton)
            {
                leavingButton.BackColor = Color.FromArgb(31, 30, 68);
                leavingButton.ForeColor = Color.Gainsboro;
                leavingButton.IconColor = Color.Gainsboro;
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200)
            {
                panelMenu.Width = 100;
                pictureBoxLogo.Visible = false;
                buttonMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {
                panelMenu.Width = 230;
                pictureBoxLogo.Visible = true;
                buttonMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 20, 0);
                }
            }
        }
    }
}
