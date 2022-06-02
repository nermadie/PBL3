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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitleChildForm = new System.Windows.Forms.Label();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimise = new System.Windows.Forms.PictureBox();
            this.pictureBoxRestoreDown = new System.Windows.Forms.PictureBox();
            this.iconPictureBoxCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.pictureBoxCancel = new System.Windows.Forms.PictureBox();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButtonViewDetails = new FontAwesome.Sharp.IconButton();
            this.iconButtonMovies = new FontAwesome.Sharp.IconButton();
            this.iconButtonBooking = new FontAwesome.Sharp.IconButton();
            this.buttonHome = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestoreDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.iconButton5);
            this.panelMenu.Controls.Add(this.iconButton4);
            this.panelMenu.Controls.Add(this.iconButtonViewDetails);
            this.panelMenu.Controls.Add(this.iconButtonMovies);
            this.panelMenu.Controls.Add(this.iconButtonBooking);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 538);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.buttonHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.pictureBoxMinimise);
            this.panelTitleBar.Controls.Add(this.pictureBoxRestoreDown);
            this.panelTitleBar.Controls.Add(this.labelTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconPictureBoxCurrentChildForm);
            this.panelTitleBar.Controls.Add(this.pictureBoxCancel);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(855, 80);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // labelTitleChildForm
            // 
            this.labelTitleChildForm.AutoSize = true;
            this.labelTitleChildForm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitleChildForm.Location = new System.Drawing.Point(55, 29);
            this.labelTitleChildForm.Name = "labelTitleChildForm";
            this.labelTitleChildForm.Size = new System.Drawing.Size(43, 17);
            this.labelTitleChildForm.TabIndex = 1;
            this.labelTitleChildForm.Text = "Home";
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 80);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(855, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 89);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(855, 449);
            this.panelDesktop.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::PBL3.Properties.Resources.logo4;
            this.pictureBox1.Location = new System.Drawing.Point(277, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // pictureBoxMinimise
            // 
            this.pictureBoxMinimise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMinimise.Image = global::PBL3.Properties.Resources.minimize1;
            this.pictureBoxMinimise.Location = new System.Drawing.Point(793, 6);
            this.pictureBoxMinimise.Name = "pictureBoxMinimise";
            this.pictureBoxMinimise.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxMinimise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimise.TabIndex = 1;
            this.pictureBoxMinimise.TabStop = false;
            this.pictureBoxMinimise.Click += new System.EventHandler(this.pictureBoxMinimise_Click);
            // 
            // pictureBoxRestoreDown
            // 
            this.pictureBoxRestoreDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRestoreDown.Image = global::PBL3.Properties.Resources.restore;
            this.pictureBoxRestoreDown.Location = new System.Drawing.Point(813, 6);
            this.pictureBoxRestoreDown.Name = "pictureBoxRestoreDown";
            this.pictureBoxRestoreDown.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxRestoreDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRestoreDown.TabIndex = 1;
            this.pictureBoxRestoreDown.TabStop = false;
            this.pictureBoxRestoreDown.Click += new System.EventHandler(this.pictureBoxRestoreDown_Click);
            // 
            // iconPictureBoxCurrentChildForm
            // 
            this.iconPictureBoxCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconPictureBoxCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconPictureBoxCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconPictureBoxCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconPictureBoxCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxCurrentChildForm.Location = new System.Drawing.Point(17, 22);
            this.iconPictureBoxCurrentChildForm.Name = "iconPictureBoxCurrentChildForm";
            this.iconPictureBoxCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBoxCurrentChildForm.TabIndex = 0;
            this.iconPictureBoxCurrentChildForm.TabStop = false;
            // 
            // pictureBoxCancel
            // 
            this.pictureBoxCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCancel.Image = global::PBL3.Properties.Resources.cancel;
            this.pictureBoxCancel.Location = new System.Drawing.Point(833, 6);
            this.pictureBoxCancel.Name = "pictureBoxCancel";
            this.pictureBoxCancel.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCancel.TabIndex = 1;
            this.pictureBoxCancel.TabStop = false;
            this.pictureBoxCancel.Click += new System.EventHandler(this.pictureBoxCancel_Click);
            // 
            // iconButton5
            // 
            this.iconButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.iconButton5.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 32;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(0, 380);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton5.Size = new System.Drawing.Size(220, 60);
            this.iconButton5.TabIndex = 5;
            this.iconButton5.Text = "iconButton5";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = true;
            // 
            // iconButton4
            // 
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.iconButton4.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 32;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(0, 320);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton4.Size = new System.Drawing.Size(220, 60);
            this.iconButton4.TabIndex = 4;
            this.iconButton4.Text = "iconButton4";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // iconButtonViewDetails
            // 
            this.iconButtonViewDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonViewDetails.FlatAppearance.BorderSize = 0;
            this.iconButtonViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonViewDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonViewDetails.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonViewDetails.IconChar = FontAwesome.Sharp.IconChar.StreetView;
            this.iconButtonViewDetails.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonViewDetails.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonViewDetails.IconSize = 32;
            this.iconButtonViewDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonViewDetails.Location = new System.Drawing.Point(0, 260);
            this.iconButtonViewDetails.Name = "iconButtonViewDetails";
            this.iconButtonViewDetails.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonViewDetails.Size = new System.Drawing.Size(220, 60);
            this.iconButtonViewDetails.TabIndex = 3;
            this.iconButtonViewDetails.Text = "View Details";
            this.iconButtonViewDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonViewDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonViewDetails.UseVisualStyleBackColor = true;
            this.iconButtonViewDetails.Click += new System.EventHandler(this.iconButtonViewDetails_Click);
            // 
            // iconButtonMovies
            // 
            this.iconButtonMovies.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonMovies.FlatAppearance.BorderSize = 0;
            this.iconButtonMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMovies.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonMovies.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonMovies.IconChar = FontAwesome.Sharp.IconChar.Film;
            this.iconButtonMovies.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonMovies.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMovies.IconSize = 32;
            this.iconButtonMovies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMovies.Location = new System.Drawing.Point(0, 200);
            this.iconButtonMovies.Name = "iconButtonMovies";
            this.iconButtonMovies.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonMovies.Size = new System.Drawing.Size(220, 60);
            this.iconButtonMovies.TabIndex = 2;
            this.iconButtonMovies.Text = "Movies";
            this.iconButtonMovies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMovies.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonMovies.UseVisualStyleBackColor = true;
            this.iconButtonMovies.Click += new System.EventHandler(this.iconButtonMovies_Click);
            // 
            // iconButtonBooking
            // 
            this.iconButtonBooking.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonBooking.FlatAppearance.BorderSize = 0;
            this.iconButtonBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonBooking.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonBooking.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonBooking.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.iconButtonBooking.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonBooking.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonBooking.IconSize = 32;
            this.iconButtonBooking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonBooking.Location = new System.Drawing.Point(0, 140);
            this.iconButtonBooking.Name = "iconButtonBooking";
            this.iconButtonBooking.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonBooking.Size = new System.Drawing.Size(220, 60);
            this.iconButtonBooking.TabIndex = 1;
            this.iconButtonBooking.Text = "Booking ";
            this.iconButtonBooking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonBooking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonBooking.UseVisualStyleBackColor = true;
            this.iconButtonBooking.Click += new System.EventHandler(this.iconButtonBooking_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Image = global::PBL3.Properties.Resources.logo4;
            this.buttonHome.Location = new System.Drawing.Point(0, 0);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(217, 140);
            this.buttonHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonHome.TabIndex = 0;
            this.buttonHome.TabStop = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 538);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestoreDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButtonViewDetails;
        private FontAwesome.Sharp.IconButton iconButtonMovies;
        private FontAwesome.Sharp.IconButton iconButtonBooking;
        private System.Windows.Forms.PictureBox buttonHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxCurrentChildForm;
        private System.Windows.Forms.Label labelTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxMinimise;
        private System.Windows.Forms.PictureBox pictureBoxRestoreDown;
        private System.Windows.Forms.PictureBox pictureBoxCancel;
    }
}