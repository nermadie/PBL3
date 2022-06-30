namespace PBL3.GUI.GUI_MainForm.GUI_Customer.CusMainForm_UserControl
{
    partial class Tickets
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
            this.dateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.flowLayoutPanelListST = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelActor = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxActor = new System.Windows.Forms.TextBox();
            this.labelRateTitle = new System.Windows.Forms.Label();
            this.labelRateNum = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBoxStar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelReleaseDate = new System.Windows.Forms.Label();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.labelReleaseDateValue = new System.Windows.Forms.Label();
            this.labelDurationValue = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxStar)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Checked = true;
            this.dateTimePicker.FillColor = System.Drawing.Color.LightSalmon;
            this.dateTimePicker.Font = new System.Drawing.Font("Cerebri Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePicker.Location = new System.Drawing.Point(990, 24);
            this.dateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(241, 36);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.Value = new System.DateTime(2022, 6, 30, 15, 19, 35, 219);
            // 
            // flowLayoutPanelListST
            // 
            this.flowLayoutPanelListST.AutoScroll = true;
            this.flowLayoutPanelListST.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelListST.Location = new System.Drawing.Point(453, 72);
            this.flowLayoutPanelListST.Name = "flowLayoutPanelListST";
            this.flowLayoutPanelListST.Size = new System.Drawing.Size(778, 631);
            this.flowLayoutPanelListST.TabIndex = 1;
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.BindingContainer = this.flowLayoutPanelListST;
            this.guna2VScrollBar1.InUpdate = false;
            this.guna2VScrollBar1.LargeChange = 10;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(1213, 72);
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.ScrollbarSize = 18;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(18, 631);
            this.guna2VScrollBar1.TabIndex = 2;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.labelDurationValue);
            this.guna2Panel1.Controls.Add(this.labelReleaseDateValue);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.guna2PictureBoxStar);
            this.guna2Panel1.Controls.Add(this.textBox1);
            this.guna2Panel1.Controls.Add(this.textBoxCategory);
            this.guna2Panel1.Controls.Add(this.textBoxActor);
            this.guna2Panel1.Controls.Add(this.textBoxDescription);
            this.guna2Panel1.Controls.Add(this.labelRateNum);
            this.guna2Panel1.Controls.Add(this.labelDuration);
            this.guna2Panel1.Controls.Add(this.labelCategory);
            this.guna2Panel1.Controls.Add(this.labelReleaseDate);
            this.guna2Panel1.Controls.Add(this.labelRateTitle);
            this.guna2Panel1.Controls.Add(this.labelActor);
            this.guna2Panel1.Location = new System.Drawing.Point(65, 135);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(346, 568);
            this.guna2Panel1.TabIndex = 3;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.Font = new System.Drawing.Font("Cerebri Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(31, 263);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(285, 96);
            this.textBoxDescription.TabIndex = 2;
            this.textBoxDescription.Text = "[Description]";
            // 
            // labelActor
            // 
            this.labelActor.AutoSize = true;
            this.labelActor.Font = new System.Drawing.Font("Cerebri Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActor.Location = new System.Drawing.Point(27, 362);
            this.labelActor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelActor.Name = "labelActor";
            this.labelActor.Size = new System.Drawing.Size(53, 21);
            this.labelActor.TabIndex = 1;
            this.labelActor.Text = "Actor";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Cerebri Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(25, 177);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(295, 80);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Dolor deleniti";
            // 
            // textBoxActor
            // 
            this.textBoxActor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxActor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxActor.Font = new System.Drawing.Font("Cerebri Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxActor.Location = new System.Drawing.Point(31, 386);
            this.textBoxActor.Multiline = true;
            this.textBoxActor.Name = "textBoxActor";
            this.textBoxActor.Size = new System.Drawing.Size(285, 44);
            this.textBoxActor.TabIndex = 2;
            this.textBoxActor.Text = "[Actor]";
            // 
            // labelRateTitle
            // 
            this.labelRateTitle.AutoSize = true;
            this.labelRateTitle.Font = new System.Drawing.Font("Cerebri Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRateTitle.Location = new System.Drawing.Point(254, 34);
            this.labelRateTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelRateTitle.Name = "labelRateTitle";
            this.labelRateTitle.Size = new System.Drawing.Size(44, 21);
            this.labelRateTitle.TabIndex = 1;
            this.labelRateTitle.Text = "Rate";
            // 
            // labelRateNum
            // 
            this.labelRateNum.AutoSize = true;
            this.labelRateNum.Font = new System.Drawing.Font("Cerebri Sans Heavy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRateNum.Location = new System.Drawing.Point(254, 55);
            this.labelRateNum.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelRateNum.Name = "labelRateNum";
            this.labelRateNum.Size = new System.Drawing.Size(45, 26);
            this.labelRateNum.TabIndex = 1;
            this.labelRateNum.Text = "5.0";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.RosyBrown;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(89, 24);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(215, 281);
            this.guna2PictureBox1.TabIndex = 4;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2PictureBoxStar
            // 
            this.guna2PictureBoxStar.Image = global::PBL3.Properties.Resources.star;
            this.guna2PictureBoxStar.ImageRotate = 0F;
            this.guna2PictureBoxStar.Location = new System.Drawing.Point(297, 52);
            this.guna2PictureBoxStar.Name = "guna2PictureBoxStar";
            this.guna2PictureBoxStar.Size = new System.Drawing.Size(24, 24);
            this.guna2PictureBoxStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBoxStar.TabIndex = 4;
            this.guna2PictureBoxStar.TabStop = false;
            // 
            // labelReleaseDate
            // 
            this.labelReleaseDate.AutoSize = true;
            this.labelReleaseDate.Font = new System.Drawing.Font("Cerebri Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReleaseDate.Location = new System.Drawing.Point(27, 508);
            this.labelReleaseDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelReleaseDate.Name = "labelReleaseDate";
            this.labelReleaseDate.Size = new System.Drawing.Size(109, 21);
            this.labelReleaseDate.TabIndex = 1;
            this.labelReleaseDate.Text = "Release Date";
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCategory.Font = new System.Drawing.Font("Cerebri Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCategory.Location = new System.Drawing.Point(31, 461);
            this.textBoxCategory.Multiline = true;
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(285, 44);
            this.textBoxCategory.TabIndex = 2;
            this.textBoxCategory.Text = "[Category]";
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Font = new System.Drawing.Font("Cerebri Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuration.Location = new System.Drawing.Point(193, 508);
            this.labelDuration.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(78, 21);
            this.labelDuration.TabIndex = 1;
            this.labelDuration.Text = "Duration";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Cerebri Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.Location = new System.Drawing.Point(27, 437);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(81, 21);
            this.labelCategory.TabIndex = 1;
            this.labelCategory.Text = "Category";
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.LightSalmon;
            this.guna2Button1.Font = new System.Drawing.Font("Cerebri Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(252, 110);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(82, 48);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "More Detail";
            // 
            // labelReleaseDateValue
            // 
            this.labelReleaseDateValue.AutoSize = true;
            this.labelReleaseDateValue.Font = new System.Drawing.Font("Cerebri Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReleaseDateValue.Location = new System.Drawing.Point(37, 529);
            this.labelReleaseDateValue.Name = "labelReleaseDateValue";
            this.labelReleaseDateValue.Size = new System.Drawing.Size(113, 21);
            this.labelReleaseDateValue.TabIndex = 6;
            this.labelReleaseDateValue.Text = "[Release Date]";
            // 
            // labelDurationValue
            // 
            this.labelDurationValue.AutoSize = true;
            this.labelDurationValue.Font = new System.Drawing.Font("Cerebri Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDurationValue.Location = new System.Drawing.Point(204, 529);
            this.labelDurationValue.Name = "labelDurationValue";
            this.labelDurationValue.Size = new System.Drawing.Size(80, 21);
            this.labelDurationValue.TabIndex = 6;
            this.labelDurationValue.Text = "[Duration]";
            // 
            // Tickets
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.guna2VScrollBar1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.flowLayoutPanelListST);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "Tickets";
            this.Size = new System.Drawing.Size(1260, 750);
            this.Load += new System.EventHandler(this.Tickets_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxStar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelListST;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelActor;
        private System.Windows.Forms.TextBox textBoxActor;
        private System.Windows.Forms.Label labelRateNum;
        private System.Windows.Forms.Label labelRateTitle;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBoxStar;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.Label labelReleaseDate;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelDurationValue;
        private System.Windows.Forms.Label labelReleaseDateValue;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
