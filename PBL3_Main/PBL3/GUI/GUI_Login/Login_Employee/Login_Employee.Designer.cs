namespace PBL3.GUI.GUI_Login.Login_Employee
{
    partial class Login_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Employee));
            this.panelTitle = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.labelSignIn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSignIn = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxWarnPass = new System.Windows.Forms.TextBox();
            this.textBoxWarnUser = new System.Windows.Forms.TextBox();
            this.panelPass = new System.Windows.Forms.Panel();
            this.panelUser = new System.Windows.Forms.Panel();
            this.textBoxForgot = new System.Windows.Forms.TextBox();
            this.labelForgot = new System.Windows.Forms.Label();
            this.iconButtonEye = new FontAwesome.Sharp.IconButton();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.pictureBoxPass = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.textBoxPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            //
            // panelTitle
            //
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.panelTitle.Controls.Add(this.buttonBack);
            this.panelTitle.Controls.Add(this.buttonMinimize);
            this.panelTitle.Controls.Add(this.buttonClose);
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(400, 28);
            this.panelTitle.TabIndex = 9;
            //
            // buttonBack
            //
            this.buttonBack.BackgroundImage = global::PBL3.Properties.Resources.left_arrow2;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonBack.Location = new System.Drawing.Point(13, 5);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(20, 20);
            this.buttonBack.TabIndex = 40;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            //
            // buttonMinimize
            //
            this.buttonMinimize.BackgroundImage = global::PBL3.Properties.Resources.remove2;
            this.buttonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimize.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonMinimize.Location = new System.Drawing.Point(336, 4);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(20, 20);
            this.buttonMinimize.TabIndex = 8;
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            //
            // buttonClose
            //
            this.buttonClose.BackgroundImage = global::PBL3.Properties.Resources.cancel3;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonClose.Location = new System.Drawing.Point(366, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(20, 20);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.btnClose_Click);
            //
            // guna2DragControl1
            //
            this.guna2DragControl1.DockIndicatorTransparencyValue = 1D;
            this.guna2DragControl1.TargetControl = this.panelTitle;
            this.guna2DragControl1.UseTransparentDrag = true;
            //
            // guna2Elipse1
            //
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            //
            // labelSignIn
            //
            this.labelSignIn.AutoSize = true;
            this.labelSignIn.Font = new System.Drawing.Font("Cerebri Sans Heavy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignIn.ForeColor = System.Drawing.Color.White;
            this.labelSignIn.Location = new System.Drawing.Point(153, 310);
            this.labelSignIn.Name = "labelSignIn";
            this.labelSignIn.Size = new System.Drawing.Size(95, 30);
            this.labelSignIn.TabIndex = 18;
            this.labelSignIn.Text = "Sign in";
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cerebri Sans Heavy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(174)))), ((int)(((byte)(95)))));
            this.label1.Location = new System.Drawing.Point(135, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "Employee";
            //
            // buttonSignIn
            //
            this.buttonSignIn.Animated = true;
            this.buttonSignIn.BorderRadius = 5;
            this.buttonSignIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSignIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSignIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSignIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSignIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(174)))), ((int)(((byte)(95)))));
            this.buttonSignIn.Font = new System.Drawing.Font("Cerebri Sans Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignIn.ForeColor = System.Drawing.Color.Black;
            this.buttonSignIn.Location = new System.Drawing.Point(95, 544);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(210, 35);
            this.buttonSignIn.TabIndex = 38;
            this.buttonSignIn.Text = "Sign In";
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            this.buttonSignIn.MouseHover += new System.EventHandler(this.buttonSignIn_MouseHover);
            //
            // textBoxWarnPass
            //
            this.textBoxWarnPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxWarnPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWarnPass.Font = new System.Drawing.Font("Cerebri Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWarnPass.ForeColor = System.Drawing.Color.OrangeRed;
            this.textBoxWarnPass.Location = new System.Drawing.Point(80, 465);
            this.textBoxWarnPass.Multiline = true;
            this.textBoxWarnPass.Name = "textBoxWarnPass";
            this.textBoxWarnPass.ReadOnly = true;
            this.textBoxWarnPass.Size = new System.Drawing.Size(250, 37);
            this.textBoxWarnPass.TabIndex = 35;
            this.textBoxWarnPass.Text = "! Invalid Password";
            //
            // textBoxWarnUser
            //
            this.textBoxWarnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxWarnUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWarnUser.Font = new System.Drawing.Font("Cerebri Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWarnUser.ForeColor = System.Drawing.Color.OrangeRed;
            this.textBoxWarnUser.Location = new System.Drawing.Point(80, 391);
            this.textBoxWarnUser.Multiline = true;
            this.textBoxWarnUser.Name = "textBoxWarnUser";
            this.textBoxWarnUser.ReadOnly = true;
            this.textBoxWarnUser.Size = new System.Drawing.Size(250, 35);
            this.textBoxWarnUser.TabIndex = 36;
            this.textBoxWarnUser.Text = "! Invalid Username/Email address";
            //
            // panelPass
            //
            this.panelPass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelPass.Location = new System.Drawing.Point(70, 461);
            this.panelPass.Name = "panelPass";
            this.panelPass.Size = new System.Drawing.Size(250, 1);
            this.panelPass.TabIndex = 30;
            //
            // panelUser
            //
            this.panelUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelUser.ForeColor = System.Drawing.SystemColors.Control;
            this.panelUser.Location = new System.Drawing.Point(70, 386);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(250, 1);
            this.panelUser.TabIndex = 27;
            //
            // textBoxForgot
            //
            this.textBoxForgot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxForgot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxForgot.Font = new System.Drawing.Font("Cerebri Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxForgot.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxForgot.HideSelection = false;
            this.textBoxForgot.Location = new System.Drawing.Point(70, 597);
            this.textBoxForgot.Multiline = true;
            this.textBoxForgot.Name = "textBoxForgot";
            this.textBoxForgot.Size = new System.Drawing.Size(235, 93);
            this.textBoxForgot.TabIndex = 29;
            this.textBoxForgot.TabStop = false;
            this.textBoxForgot.Text = "For security, if you forgot your account. Please contact to your manager for more" +
    " information. Hotline: 0775513097";
            //
            // labelForgot
            //
            this.labelForgot.AutoSize = true;
            this.labelForgot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelForgot.Font = new System.Drawing.Font("Cerebri Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForgot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(151)))), ((int)(((byte)(86)))));
            this.labelForgot.Location = new System.Drawing.Point(76, 505);
            this.labelForgot.Name = "labelForgot";
            this.labelForgot.Size = new System.Drawing.Size(129, 21);
            this.labelForgot.TabIndex = 39;
            this.labelForgot.Text = "Forgot pasword?";
            this.labelForgot.Click += new System.EventHandler(this.labelForgot_Click);
            //
            // iconButtonEye
            //
            this.iconButtonEye.FlatAppearance.BorderSize = 0;
            this.iconButtonEye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconButtonEye.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonEye.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonEye.IconSize = 25;
            this.iconButtonEye.Location = new System.Drawing.Point(295, 438);
            this.iconButtonEye.Name = "iconButtonEye";
            this.iconButtonEye.Size = new System.Drawing.Size(25, 23);
            this.iconButtonEye.TabIndex = 37;
            this.iconButtonEye.UseVisualStyleBackColor = true;
            this.iconButtonEye.Click += new System.EventHandler(this.iconButtonEye_Click);
            //
            // pictureBoxUser
            //
            this.pictureBoxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pictureBoxUser.BackgroundImage = global::PBL3.Properties.Resources.employee;
            this.pictureBoxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxUser.Location = new System.Drawing.Point(70, 356);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxUser.TabIndex = 25;
            this.pictureBoxUser.TabStop = false;
            //
            // pictureBoxPass
            //
            this.pictureBoxPass.BackgroundImage = global::PBL3.Properties.Resources.key;
            this.pictureBoxPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxPass.Location = new System.Drawing.Point(70, 431);
            this.pictureBoxPass.Name = "pictureBoxPass";
            this.pictureBoxPass.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxPass.TabIndex = 28;
            this.pictureBoxPass.TabStop = false;
            //
            // pictureBoxLogo
            //
            this.pictureBoxLogo.BackgroundImage = global::PBL3.Properties.Resources.Employee_Icon;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Location = new System.Drawing.Point(135, 94);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(130, 130);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            //
            // textBoxPass
            //
            this.textBoxPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxPass.BorderThickness = 0;
            this.textBoxPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPass.DefaultText = "";
            this.textBoxPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPass.Font = new System.Drawing.Font("Cerebri Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPass.Location = new System.Drawing.Point(95, 431);
            this.textBoxPass.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '\0';
            this.textBoxPass.PlaceholderText = "Password";
            this.textBoxPass.SelectedText = "";
            this.textBoxPass.Size = new System.Drawing.Size(208, 26);
            this.textBoxPass.TabIndex = 47;
            this.textBoxPass.Click += new System.EventHandler(this.textBoxPass_Click);
            //
            // textBoxUser
            //
            this.textBoxUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxUser.BorderThickness = 0;
            this.textBoxUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxUser.DefaultText = "";
            this.textBoxUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxUser.Font = new System.Drawing.Font("Cerebri Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxUser.Location = new System.Drawing.Point(95, 357);
            this.textBoxUser.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.PasswordChar = '\0';
            this.textBoxUser.PlaceholderText = "Username/Email address";
            this.textBoxUser.SelectedText = "";
            this.textBoxUser.Size = new System.Drawing.Size(208, 26);
            this.textBoxUser.TabIndex = 48;
            this.textBoxUser.Click += new System.EventHandler(this.textBoxUser_Click);
            //
            // Login_Employee
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(400, 750);
            this.Controls.Add(this.iconButtonEye);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.labelForgot);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.textBoxWarnPass);
            this.Controls.Add(this.textBoxWarnUser);
            this.Controls.Add(this.panelPass);
            this.Controls.Add(this.pictureBoxUser);
            this.Controls.Add(this.textBoxForgot);
            this.Controls.Add(this.pictureBoxPass);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSignIn);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.pictureBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Login_Employee";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LogIn_KeyDown);
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSignIn;
        private Guna.UI2.WinForms.Guna2Button buttonSignIn;
        private FontAwesome.Sharp.IconButton iconButtonEye;
        private System.Windows.Forms.TextBox textBoxWarnPass;
        private System.Windows.Forms.TextBox textBoxWarnUser;
        private System.Windows.Forms.Panel panelPass;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.PictureBox pictureBoxPass;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.TextBox textBoxForgot;
        private System.Windows.Forms.Label labelForgot;
        private System.Windows.Forms.Button buttonBack;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPass;
        private Guna.UI2.WinForms.Guna2TextBox textBoxUser;
    }
}