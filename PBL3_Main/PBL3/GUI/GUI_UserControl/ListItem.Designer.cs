namespace PBL3.GUI.GUI_UserControl
{
    partial class ListItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2PanelAll = new Guna.UI2.WinForms.Guna2Panel();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.guna2RatingStar = new Guna.UI2.WinForms.Guna2RatingStar();
            this.guna2PictureBoxPoster = new Guna.UI2.WinForms.Guna2PictureBox();
            this.flowLayoutPanelListTime = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2HtmlLabelTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2PanelAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PanelAll
            // 
            this.guna2PanelAll.BackColor = System.Drawing.Color.White;
            this.guna2PanelAll.Controls.Add(this.textBoxDescription);
            this.guna2PanelAll.Controls.Add(this.guna2RatingStar);
            this.guna2PanelAll.Controls.Add(this.guna2PictureBoxPoster);
            this.guna2PanelAll.Controls.Add(this.flowLayoutPanelListTime);
            this.guna2PanelAll.Controls.Add(this.guna2HtmlLabelTitle);
            this.guna2PanelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PanelAll.Location = new System.Drawing.Point(0, 0);
            this.guna2PanelAll.Name = "guna2PanelAll";
            this.guna2PanelAll.Size = new System.Drawing.Size(700, 250);
            this.guna2PanelAll.TabIndex = 0;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.Color.White;
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.Enabled = false;
            this.textBoxDescription.Font = new System.Drawing.Font("Cerebri Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxDescription.Location = new System.Drawing.Point(203, 65);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(470, 90);
            this.textBoxDescription.TabIndex = 11;
            this.textBoxDescription.Text = "[Description]";
            // 
            // guna2RatingStar
            // 
            this.guna2RatingStar.Enabled = false;
            this.guna2RatingStar.FillColor = System.Drawing.Color.Transparent;
            this.guna2RatingStar.Location = new System.Drawing.Point(553, 30);
            this.guna2RatingStar.Name = "guna2RatingStar";
            this.guna2RatingStar.RatingColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2RatingStar.Size = new System.Drawing.Size(120, 28);
            this.guna2RatingStar.TabIndex = 10;
            // 
            // guna2PictureBoxPoster
            // 
            this.guna2PictureBoxPoster.BorderRadius = 10;
            this.guna2PictureBoxPoster.ImageRotate = 0F;
            this.guna2PictureBoxPoster.Location = new System.Drawing.Point(28, 36);
            this.guna2PictureBoxPoster.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBoxPoster.Name = "guna2PictureBoxPoster";
            this.guna2PictureBoxPoster.Size = new System.Drawing.Size(139, 171);
            this.guna2PictureBoxPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBoxPoster.TabIndex = 7;
            this.guna2PictureBoxPoster.TabStop = false;
            // 
            // flowLayoutPanelListTime
            // 
            this.flowLayoutPanelListTime.AutoScroll = true;
            this.flowLayoutPanelListTime.Location = new System.Drawing.Point(203, 161);
            this.flowLayoutPanelListTime.Name = "flowLayoutPanelListTime";
            this.flowLayoutPanelListTime.Size = new System.Drawing.Size(470, 60);
            this.flowLayoutPanelListTime.TabIndex = 9;
            // 
            // guna2HtmlLabelTitle
            // 
            this.guna2HtmlLabelTitle.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabelTitle.Font = new System.Drawing.Font("Cerebri Sans ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabelTitle.Location = new System.Drawing.Point(203, 30);
            this.guna2HtmlLabelTitle.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabelTitle.Name = "guna2HtmlLabelTitle";
            this.guna2HtmlLabelTitle.Size = new System.Drawing.Size(46, 28);
            this.guna2HtmlLabelTitle.TabIndex = 8;
            this.guna2HtmlLabelTitle.Text = "Title";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.guna2PanelAll;
            // 
            // ListItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2PanelAll);
            this.Font = new System.Drawing.Font("Cerebri Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(700, 250);
            this.guna2PanelAll.ResumeLayout(false);
            this.guna2PanelAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxPoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2PanelAll;
        private System.Windows.Forms.TextBox textBoxDescription;
        private Guna.UI2.WinForms.Guna2RatingStar guna2RatingStar;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBoxPoster;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelListTime;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabelTitle;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
