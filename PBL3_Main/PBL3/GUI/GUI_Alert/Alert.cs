using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using PBL3.Properties;

namespace PBL3.GUI.GUI_Alert
{
    public partial class Alert : Form
    {
        public Alert()
        {
            InitializeComponent();
        }

        public enum enumAction
        {
            wait,
            start,
            close
        }

        public enum enumType
        {
            Success,
            Warning,
            Error,
            Info
        }

        private Alert.enumAction action;
        private int x, y;

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enumAction.close;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enumAction.wait:
                    timer1.Interval = 5000;
                    action = enumAction.close;
                    break;
                case enumAction.start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = enumAction.wait;
                        }
                    }
                    break;
                case enumAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        public void showAlert(string message, string detail, enumType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;
            for (int i = 1; i < 12; i++)
            {
                fname = "alert" + i.ToString();
                Alert aForm = (Alert)Application.OpenForms[fname];
                if (aForm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
            switch (type)
            {
                case enumType.Success:
                    this.pictureBox1.Image = Resources._checked;
                    this.BackColor = Color.SeaGreen;
                    labelDetail.BackColor = Color.SeaGreen;
                    labelDetail.DisabledState.FillColor = Color.SeaGreen;
                    labelDetail.DisabledState.ForeColor = Color.White;
                    break;
                case enumType.Error:
                    this.pictureBox1.Image = Resources.error;
                    this.BackColor = Color.DarkRed;
                    labelDetail.BackColor = Color.DarkRed;
                    labelDetail.DisabledState.FillColor = Color.DarkRed;
                    labelDetail.DisabledState.ForeColor = Color.White;
                    break;
                case enumType.Info:
                    this.pictureBox1.Image = Resources.info;
                    this.BackColor = Color.RoyalBlue;
                    labelDetail.BackColor = Color.RoyalBlue;
                    labelDetail.DisabledState.FillColor = Color.RoyalBlue;
                    labelDetail.DisabledState.ForeColor = Color.White;
                    break;
                case enumType.Warning:
                    this.pictureBox1.Image = Resources.warning;
                    this.BackColor = Color.DarkOrange;
                    labelDetail.DisabledState.FillColor = Color.DarkOrange;
                    labelDetail.DisabledState.ForeColor = Color.White;
                    break;
            }
            this.labelMessage.Text = message;
            this.labelDetail.Text = detail;
            this.Show();
            this.action = enumAction.start;
            this.timer1.Interval = 1;
            timer1.Start();
        }
    }
}
