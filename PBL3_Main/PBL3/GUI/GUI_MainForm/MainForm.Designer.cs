namespace PBL3.GUI.GUI_MainForm
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButtonStatistic = new FontAwesome.Sharp.IconButton();
            this.iconButtonEmployee = new FontAwesome.Sharp.IconButton();
            this.iconButtonCustomer = new FontAwesome.Sharp.IconButton();
            this.iconButtonPCDrink = new FontAwesome.Sharp.IconButton();
            this.iconButtonRoom = new FontAwesome.Sharp.IconButton();
            this.iconButtonShowTime = new FontAwesome.Sharp.IconButton();
            this.iconButtonMovie = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.iconButtonStatistic);
            this.panelMenu.Controls.Add(this.iconButtonEmployee);
            this.panelMenu.Controls.Add(this.iconButtonCustomer);
            this.panelMenu.Controls.Add(this.iconButtonPCDrink);
            this.panelMenu.Controls.Add(this.iconButtonRoom);
            this.panelMenu.Controls.Add(this.iconButtonShowTime);
            this.panelMenu.Controls.Add(this.iconButtonMovie);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 741);
            this.panelMenu.TabIndex = 0;
            // 
            // iconButtonStatistic
            // 
            this.iconButtonStatistic.FlatAppearance.BorderSize = 0;
            this.iconButtonStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonStatistic.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonStatistic.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonStatistic.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.iconButtonStatistic.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonStatistic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonStatistic.IconSize = 32;
            this.iconButtonStatistic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonStatistic.Location = new System.Drawing.Point(0, 550);
            this.iconButtonStatistic.Name = "iconButtonStatistic";
            this.iconButtonStatistic.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonStatistic.Size = new System.Drawing.Size(220, 60);
            this.iconButtonStatistic.TabIndex = 1;
            this.iconButtonStatistic.Text = "Statistic";
            this.iconButtonStatistic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonStatistic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonStatistic.UseVisualStyleBackColor = true;
            this.iconButtonStatistic.Click += new System.EventHandler(this.iconButtonStatistic_Click);
            this.iconButtonStatistic.MouseEnter += new System.EventHandler(this.iconButtonDivision_MouseEnter);
            this.iconButtonStatistic.MouseLeave += new System.EventHandler(this.iconButtonDivision_MouseLeave);
            // 
            // iconButtonEmployee
            // 
            this.iconButtonEmployee.FlatAppearance.BorderSize = 0;
            this.iconButtonEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonEmployee.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonEmployee.IconChar = FontAwesome.Sharp.IconChar.PeopleCarry;
            this.iconButtonEmployee.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonEmployee.IconSize = 32;
            this.iconButtonEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonEmployee.Location = new System.Drawing.Point(0, 490);
            this.iconButtonEmployee.Name = "iconButtonEmployee";
            this.iconButtonEmployee.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonEmployee.Size = new System.Drawing.Size(220, 60);
            this.iconButtonEmployee.TabIndex = 1;
            this.iconButtonEmployee.Text = "Employee";
            this.iconButtonEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonEmployee.UseVisualStyleBackColor = true;
            this.iconButtonEmployee.Click += new System.EventHandler(this.iconButtonEmployee_Click);
            this.iconButtonEmployee.MouseEnter += new System.EventHandler(this.iconButtonDivision_MouseEnter);
            this.iconButtonEmployee.MouseLeave += new System.EventHandler(this.iconButtonDivision_MouseLeave);
            // 
            // iconButtonCustomer
            // 
            this.iconButtonCustomer.FlatAppearance.BorderSize = 0;
            this.iconButtonCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCustomer.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonCustomer.IconChar = FontAwesome.Sharp.IconChar.Child;
            this.iconButtonCustomer.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCustomer.IconSize = 32;
            this.iconButtonCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCustomer.Location = new System.Drawing.Point(0, 430);
            this.iconButtonCustomer.Name = "iconButtonCustomer";
            this.iconButtonCustomer.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonCustomer.Size = new System.Drawing.Size(220, 60);
            this.iconButtonCustomer.TabIndex = 1;
            this.iconButtonCustomer.Text = "Customer";
            this.iconButtonCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCustomer.UseVisualStyleBackColor = true;
            this.iconButtonCustomer.Click += new System.EventHandler(this.iconButtonCustomer_Click);
            this.iconButtonCustomer.MouseEnter += new System.EventHandler(this.iconButtonDivision_MouseEnter);
            this.iconButtonCustomer.MouseLeave += new System.EventHandler(this.iconButtonDivision_MouseLeave);
            // 
            // iconButtonPCDrink
            // 
            this.iconButtonPCDrink.FlatAppearance.BorderSize = 0;
            this.iconButtonPCDrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonPCDrink.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonPCDrink.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonPCDrink.IconChar = FontAwesome.Sharp.IconChar.Hamburger;
            this.iconButtonPCDrink.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonPCDrink.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonPCDrink.IconSize = 32;
            this.iconButtonPCDrink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonPCDrink.Location = new System.Drawing.Point(0, 370);
            this.iconButtonPCDrink.Name = "iconButtonPCDrink";
            this.iconButtonPCDrink.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonPCDrink.Size = new System.Drawing.Size(220, 60);
            this.iconButtonPCDrink.TabIndex = 1;
            this.iconButtonPCDrink.Text = "PopcornDrink";
            this.iconButtonPCDrink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonPCDrink.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonPCDrink.UseVisualStyleBackColor = true;
            this.iconButtonPCDrink.Click += new System.EventHandler(this.iconButtonPCDrink_Click);
            this.iconButtonPCDrink.MouseEnter += new System.EventHandler(this.iconButtonDivision_MouseEnter);
            this.iconButtonPCDrink.MouseLeave += new System.EventHandler(this.iconButtonDivision_MouseLeave);
            // 
            // iconButtonRoom
            // 
            this.iconButtonRoom.FlatAppearance.BorderSize = 0;
            this.iconButtonRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonRoom.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonRoom.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.iconButtonRoom.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonRoom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonRoom.IconSize = 32;
            this.iconButtonRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonRoom.Location = new System.Drawing.Point(0, 310);
            this.iconButtonRoom.Name = "iconButtonRoom";
            this.iconButtonRoom.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonRoom.Size = new System.Drawing.Size(220, 60);
            this.iconButtonRoom.TabIndex = 1;
            this.iconButtonRoom.Text = "Room";
            this.iconButtonRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonRoom.UseVisualStyleBackColor = true;
            this.iconButtonRoom.Click += new System.EventHandler(this.iconButtonRoom_Click);
            this.iconButtonRoom.MouseEnter += new System.EventHandler(this.iconButtonDivision_MouseEnter);
            this.iconButtonRoom.MouseLeave += new System.EventHandler(this.iconButtonDivision_MouseLeave);
            // 
            // iconButtonShowTime
            // 
            this.iconButtonShowTime.FlatAppearance.BorderSize = 0;
            this.iconButtonShowTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonShowTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonShowTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonShowTime.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.iconButtonShowTime.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonShowTime.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonShowTime.IconSize = 32;
            this.iconButtonShowTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonShowTime.Location = new System.Drawing.Point(0, 250);
            this.iconButtonShowTime.Name = "iconButtonShowTime";
            this.iconButtonShowTime.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonShowTime.Size = new System.Drawing.Size(220, 60);
            this.iconButtonShowTime.TabIndex = 1;
            this.iconButtonShowTime.Text = "ShowTime";
            this.iconButtonShowTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonShowTime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonShowTime.UseVisualStyleBackColor = true;
            this.iconButtonShowTime.Click += new System.EventHandler(this.iconButtonShowTime_Click);
            this.iconButtonShowTime.MouseEnter += new System.EventHandler(this.iconButtonDivision_MouseEnter);
            this.iconButtonShowTime.MouseLeave += new System.EventHandler(this.iconButtonDivision_MouseLeave);
            // 
            // iconButtonMovie
            // 
            this.iconButtonMovie.FlatAppearance.BorderSize = 0;
            this.iconButtonMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMovie.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonMovie.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonMovie.IconChar = FontAwesome.Sharp.IconChar.Film;
            this.iconButtonMovie.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonMovie.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMovie.IconSize = 32;
            this.iconButtonMovie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMovie.Location = new System.Drawing.Point(0, 190);
            this.iconButtonMovie.Name = "iconButtonMovie";
            this.iconButtonMovie.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonMovie.Size = new System.Drawing.Size(220, 60);
            this.iconButtonMovie.TabIndex = 1;
            this.iconButtonMovie.Text = "Movie";
            this.iconButtonMovie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMovie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonMovie.UseVisualStyleBackColor = true;
            this.iconButtonMovie.Click += new System.EventHandler(this.iconButtonMovie_Click);
            this.iconButtonMovie.MouseEnter += new System.EventHandler(this.iconButtonDivision_MouseEnter);
            this.iconButtonMovie.MouseLeave += new System.EventHandler(this.iconButtonDivision_MouseLeave);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = global::PBL3.Properties.Resources.LogoTest1;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Location = new System.Drawing.Point(14, 51);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(188, 73);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.buttonMinimize);
            this.panelTitleBar.Controls.Add(this.buttonMaximize);
            this.panelTitleBar.Controls.Add(this.buttonClose);
            this.panelTitleBar.Controls.Add(this.labelTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1064, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Image = global::PBL3.Properties.Resources.minimizemini;
            this.buttonMinimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMinimize.Location = new System.Drawing.Point(902, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(50, 30);
            this.buttonMinimize.TabIndex = 2;
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaximize.FlatAppearance.BorderSize = 0;
            this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize.Image = global::PBL3.Properties.Resources.maximizemini;
            this.buttonMaximize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMaximize.Location = new System.Drawing.Point(958, 0);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Size = new System.Drawing.Size(50, 30);
            this.buttonMaximize.TabIndex = 2;
            this.buttonMaximize.UseVisualStyleBackColor = true;
            this.buttonMaximize.Click += new System.EventHandler(this.buttonMaximize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = global::PBL3.Properties.Resources.closemini;
            this.buttonClose.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonClose.Location = new System.Drawing.Point(1014, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(50, 30);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            this.buttonClose.MouseEnter += new System.EventHandler(this.buttonClose_MouseEnter);
            this.buttonClose.MouseLeave += new System.EventHandler(this.buttonClose_MouseLeave);
            // 
            // labelTitleChildForm
            // 
            this.labelTitleChildForm.AutoSize = true;
            this.labelTitleChildForm.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitleChildForm.Location = new System.Drawing.Point(73, 27);
            this.labelTitleChildForm.Name = "labelTitleChildForm";
            this.labelTitleChildForm.Size = new System.Drawing.Size(72, 30);
            this.labelTitleChildForm.TabIndex = 1;
            this.labelTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.Gainsboro;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 40;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(30, 26);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1064, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1064, 657);
            this.panelDesktop.TabIndex = 3;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 741);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButtonMovie;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconButtonStatistic;
        private FontAwesome.Sharp.IconButton iconButtonEmployee;
        private FontAwesome.Sharp.IconButton iconButtonCustomer;
        private FontAwesome.Sharp.IconButton iconButtonPCDrink;
        private FontAwesome.Sharp.IconButton iconButtonRoom;
        private FontAwesome.Sharp.IconButton iconButtonShowTime;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label labelTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonMaximize;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}