namespace PBL3.GUI.GUI_Login
{
    partial class SignIn
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
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.panelUser = new System.Windows.Forms.Panel();
            this.panelPass = new System.Windows.Forms.Panel();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.labelSignIn = new System.Windows.Forms.Label();
            this.labelForgotPass = new System.Windows.Forms.Label();
            this.labelCreateACC = new System.Windows.Forms.Label();
            this.labelNewtoCinema = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxWarnPass = new System.Windows.Forms.TextBox();
            this.textBoxWarnUser = new System.Windows.Forms.TextBox();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.pictureBoxPass = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelSignIn = new System.Windows.Forms.Panel();
            this.buttonEye = new FontAwesome.Sharp.IconButton();
            this.buttonEyeSlash = new FontAwesome.Sharp.IconButton();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelSignIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxUser
            // 
            this.textBoxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxUser.HideSelection = false;
            this.textBoxUser.Location = new System.Drawing.Point(115, 93);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(220, 22);
            this.textBoxUser.TabIndex = 1;
            this.textBoxUser.TabStop = false;
            this.textBoxUser.Text = "Username or email address";
            this.textBoxUser.Click += new System.EventHandler(this.tbUser_Click);
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelUser.ForeColor = System.Drawing.SystemColors.Control;
            this.panelUser.Location = new System.Drawing.Point(78, 119);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(250, 1);
            this.panelUser.TabIndex = 2;
            // 
            // panelPass
            // 
            this.panelPass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelPass.Location = new System.Drawing.Point(78, 182);
            this.panelPass.Name = "panelPass";
            this.panelPass.Size = new System.Drawing.Size(250, 1);
            this.panelPass.TabIndex = 5;
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxPass.HideSelection = false;
            this.textBoxPass.Location = new System.Drawing.Point(115, 156);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(213, 22);
            this.textBoxPass.TabIndex = 4;
            this.textBoxPass.TabStop = false;
            this.textBoxPass.Text = "Password";
            this.textBoxPass.Click += new System.EventHandler(this.tbPass_Click);
            this.textBoxPass.TextChanged += new System.EventHandler(this.tbPass_TextChanged);
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(172)))));
            this.buttonSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignIn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonSignIn.Location = new System.Drawing.Point(89, 271);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(226, 35);
            this.buttonSignIn.TabIndex = 6;
            this.buttonSignIn.Text = "Sign in";
            this.buttonSignIn.UseVisualStyleBackColor = false;
            this.buttonSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // labelSignIn
            // 
            this.labelSignIn.AutoSize = true;
            this.labelSignIn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignIn.ForeColor = System.Drawing.Color.White;
            this.labelSignIn.Location = new System.Drawing.Point(95, 30);
            this.labelSignIn.Name = "labelSignIn";
            this.labelSignIn.Size = new System.Drawing.Size(216, 32);
            this.labelSignIn.TabIndex = 7;
            this.labelSignIn.Text = "Sign in to Cinema";
            // 
            // labelForgotPass
            // 
            this.labelForgotPass.AutoSize = true;
            this.labelForgotPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelForgotPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForgotPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(137)))), ((int)(((byte)(228)))));
            this.labelForgotPass.Location = new System.Drawing.Point(83, 214);
            this.labelForgotPass.Name = "labelForgotPass";
            this.labelForgotPass.Size = new System.Drawing.Size(127, 21);
            this.labelForgotPass.TabIndex = 7;
            this.labelForgotPass.Text = "Forgot pasword?";
            this.labelForgotPass.Click += new System.EventHandler(this.lbForgotPass_Click);
            // 
            // labelCreateACC
            // 
            this.labelCreateACC.AutoSize = true;
            this.labelCreateACC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCreateACC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateACC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(137)))), ((int)(((byte)(228)))));
            this.labelCreateACC.Location = new System.Drawing.Point(197, 350);
            this.labelCreateACC.Name = "labelCreateACC";
            this.labelCreateACC.Size = new System.Drawing.Size(137, 21);
            this.labelCreateACC.TabIndex = 7;
            this.labelCreateACC.Text = "Create an account.";
            this.labelCreateACC.Click += new System.EventHandler(this.lbCreateACC_Click);
            // 
            // labelNewtoCinema
            // 
            this.labelNewtoCinema.AutoSize = true;
            this.labelNewtoCinema.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewtoCinema.ForeColor = System.Drawing.SystemColors.Info;
            this.labelNewtoCinema.Location = new System.Drawing.Point(71, 350);
            this.labelNewtoCinema.Name = "labelNewtoCinema";
            this.labelNewtoCinema.Size = new System.Drawing.Size(124, 21);
            this.labelNewtoCinema.TabIndex = 7;
            this.labelNewtoCinema.Text = "New to Cinema?";
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.buttonMinimize);
            this.panelTitle.Controls.Add(this.buttonClose);
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(400, 50);
            this.panelTitle.TabIndex = 9;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackgroundImage = global::PBL3.Properties.Resources.minimize;
            this.buttonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimize.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonMinimize.Location = new System.Drawing.Point(336, 11);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(24, 24);
            this.buttonMinimize.TabIndex = 8;
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackgroundImage = global::PBL3.Properties.Resources.close;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonClose.Location = new System.Drawing.Point(366, 11);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(24, 24);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // textBoxWarnPass
            // 
            this.textBoxWarnPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxWarnPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWarnPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWarnPass.ForeColor = System.Drawing.Color.OrangeRed;
            this.textBoxWarnPass.Location = new System.Drawing.Point(88, 191);
            this.textBoxWarnPass.Name = "textBoxWarnPass";
            this.textBoxWarnPass.ReadOnly = true;
            this.textBoxWarnPass.Size = new System.Drawing.Size(250, 18);
            this.textBoxWarnPass.TabIndex = 8;
            this.textBoxWarnPass.Text = "! Invalid Username/Email address";
            // 
            // textBoxWarnUser
            // 
            this.textBoxWarnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxWarnUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWarnUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWarnUser.ForeColor = System.Drawing.Color.OrangeRed;
            this.textBoxWarnUser.Location = new System.Drawing.Point(88, 122);
            this.textBoxWarnUser.Name = "textBoxWarnUser";
            this.textBoxWarnUser.ReadOnly = true;
            this.textBoxWarnUser.Size = new System.Drawing.Size(250, 18);
            this.textBoxWarnUser.TabIndex = 8;
            this.textBoxWarnUser.Text = "! Invalid Username/Email address";
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pictureBoxUser.BackgroundImage = global::PBL3.Properties.Resources.man;
            this.pictureBoxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxUser.Location = new System.Drawing.Point(78, 89);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxUser.TabIndex = 0;
            this.pictureBoxUser.TabStop = false;
            // 
            // pictureBoxPass
            // 
            this.pictureBoxPass.BackgroundImage = global::PBL3.Properties.Resources.padlock;
            this.pictureBoxPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxPass.Location = new System.Drawing.Point(78, 152);
            this.pictureBoxPass.Name = "pictureBoxPass";
            this.pictureBoxPass.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxPass.TabIndex = 3;
            this.pictureBoxPass.TabStop = false;
            this.pictureBoxPass.Click += new System.EventHandler(this.pbPass_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = global::PBL3.Properties.Resources.film;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Location = new System.Drawing.Point(139, 56);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(130, 130);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelSignIn
            // 
            this.panelSignIn.Controls.Add(this.buttonEye);
            this.panelSignIn.Controls.Add(this.buttonEyeSlash);
            this.panelSignIn.Controls.Add(this.textBoxWarnPass);
            this.panelSignIn.Controls.Add(this.textBoxWarnUser);
            this.panelSignIn.Controls.Add(this.labelSignIn);
            this.panelSignIn.Controls.Add(this.pictureBoxUser);
            this.panelSignIn.Controls.Add(this.labelNewtoCinema);
            this.panelSignIn.Controls.Add(this.textBoxUser);
            this.panelSignIn.Controls.Add(this.labelCreateACC);
            this.panelSignIn.Controls.Add(this.panelUser);
            this.panelSignIn.Controls.Add(this.labelForgotPass);
            this.panelSignIn.Controls.Add(this.pictureBoxPass);
            this.panelSignIn.Controls.Add(this.textBoxPass);
            this.panelSignIn.Controls.Add(this.buttonSignIn);
            this.panelSignIn.Controls.Add(this.panelPass);
            this.panelSignIn.Location = new System.Drawing.Point(0, 198);
            this.panelSignIn.Name = "panelSignIn";
            this.panelSignIn.Size = new System.Drawing.Size(400, 510);
            this.panelSignIn.TabIndex = 10;
            // 
            // buttonEye
            // 
            this.buttonEye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.buttonEye.IconColor = System.Drawing.Color.WhiteSmoke;
            this.buttonEye.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonEye.IconSize = 22;
            this.buttonEye.Location = new System.Drawing.Point(306, 158);
            this.buttonEye.Name = "buttonEye";
            this.buttonEye.Size = new System.Drawing.Size(22, 22);
            this.buttonEye.TabIndex = 9;
            this.buttonEye.UseVisualStyleBackColor = true;
            this.buttonEye.Click += new System.EventHandler(this.buttonEye_Click);
            // 
            // buttonEyeSlash
            // 
            this.buttonEyeSlash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEyeSlash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonEyeSlash.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.buttonEyeSlash.IconColor = System.Drawing.Color.WhiteSmoke;
            this.buttonEyeSlash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonEyeSlash.IconSize = 22;
            this.buttonEyeSlash.Location = new System.Drawing.Point(306, 157);
            this.buttonEyeSlash.Name = "buttonEyeSlash";
            this.buttonEyeSlash.Size = new System.Drawing.Size(22, 22);
            this.buttonEyeSlash.TabIndex = 9;
            this.buttonEyeSlash.UseVisualStyleBackColor = true;
            this.buttonEyeSlash.Click += new System.EventHandler(this.buttonEyeSlash_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(400, 709);
            this.Controls.Add(this.panelSignIn);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.pictureBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelSignIn.ResumeLayout(false);
            this.panelSignIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Panel panelPass;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.PictureBox pictureBoxPass;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Label labelSignIn;
        private System.Windows.Forms.Label labelForgotPass;
        private System.Windows.Forms.Label labelCreateACC;
        private System.Windows.Forms.Label labelNewtoCinema;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TextBox textBoxWarnUser;
        private System.Windows.Forms.TextBox textBoxWarnPass;
        private System.Windows.Forms.Panel panelSignIn;
        private FontAwesome.Sharp.IconButton buttonEye;
        private FontAwesome.Sharp.IconButton buttonEyeSlash;
    }
}

