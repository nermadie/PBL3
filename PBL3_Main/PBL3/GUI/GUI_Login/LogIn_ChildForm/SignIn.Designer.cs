namespace PBL3.GUI.GUI_Login.LogIn_ChildForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxWarnPass = new System.Windows.Forms.TextBox();
            this.labelSignIn = new System.Windows.Forms.Label();
            this.textBoxWarnUser = new System.Windows.Forms.TextBox();
            this.panelPass = new System.Windows.Forms.Panel();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.labelNew = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelForgot = new System.Windows.Forms.Label();
            this.labelCreateAcc = new System.Windows.Forms.Label();
            this.panelUser = new System.Windows.Forms.Panel();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.iconButtonEye = new FontAwesome.Sharp.IconButton();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.pictureBoxPass = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPass)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxWarnPass
            // 
            this.textBoxWarnPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxWarnPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWarnPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWarnPass.ForeColor = System.Drawing.Color.OrangeRed;
            this.textBoxWarnPass.Location = new System.Drawing.Point(84, 189);
            this.textBoxWarnPass.Name = "textBoxWarnPass";
            this.textBoxWarnPass.ReadOnly = true;
            this.textBoxWarnPass.Size = new System.Drawing.Size(250, 18);
            this.textBoxWarnPass.TabIndex = 21;
            this.textBoxWarnPass.Text = "! Invalid Password";
            // 
            // labelSignIn
            // 
            this.labelSignIn.AutoSize = true;
            this.labelSignIn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignIn.ForeColor = System.Drawing.Color.White;
            this.labelSignIn.Location = new System.Drawing.Point(92, 28);
            this.labelSignIn.Name = "labelSignIn";
            this.labelSignIn.Size = new System.Drawing.Size(216, 32);
            this.labelSignIn.TabIndex = 17;
            this.labelSignIn.Text = "Sign in to Cinema";
            // 
            // textBoxWarnUser
            // 
            this.textBoxWarnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxWarnUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWarnUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWarnUser.ForeColor = System.Drawing.Color.OrangeRed;
            this.textBoxWarnUser.Location = new System.Drawing.Point(84, 120);
            this.textBoxWarnUser.Name = "textBoxWarnUser";
            this.textBoxWarnUser.ReadOnly = true;
            this.textBoxWarnUser.Size = new System.Drawing.Size(250, 18);
            this.textBoxWarnUser.TabIndex = 22;
            this.textBoxWarnUser.Text = "! Invalid Username/Email address";
            // 
            // panelPass
            // 
            this.panelPass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelPass.Location = new System.Drawing.Point(74, 180);
            this.panelPass.Name = "panelPass";
            this.panelPass.Size = new System.Drawing.Size(250, 1);
            this.panelPass.TabIndex = 15;
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(172)))));
            this.buttonSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignIn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonSignIn.Location = new System.Drawing.Point(85, 269);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(226, 35);
            this.buttonSignIn.TabIndex = 16;
            this.buttonSignIn.Text = "Sign in";
            this.buttonSignIn.UseVisualStyleBackColor = false;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            this.buttonSignIn.MouseHover += new System.EventHandler(this.buttonSignIn_MouseHover);
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxPass.HideSelection = false;
            this.textBoxPass.Location = new System.Drawing.Point(112, 152);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(182, 22);
            this.textBoxPass.TabIndex = 14;
            this.textBoxPass.TabStop = false;
            this.textBoxPass.Text = "Password";
            this.textBoxPass.Click += new System.EventHandler(this.textBoxPass_Click);
            // 
            // labelNew
            // 
            this.labelNew.AutoSize = true;
            this.labelNew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNew.ForeColor = System.Drawing.SystemColors.Info;
            this.labelNew.Location = new System.Drawing.Point(67, 348);
            this.labelNew.Name = "labelNew";
            this.labelNew.Size = new System.Drawing.Size(124, 21);
            this.labelNew.TabIndex = 18;
            this.labelNew.Text = "New to Cinema?";
            // 
            // textBoxUser
            // 
            this.textBoxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxUser.HideSelection = false;
            this.textBoxUser.Location = new System.Drawing.Point(112, 89);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(200, 22);
            this.textBoxUser.TabIndex = 11;
            this.textBoxUser.TabStop = false;
            this.textBoxUser.Text = "Username or email address";
            this.textBoxUser.Click += new System.EventHandler(this.textBoxUser_Click);
            // 
            // labelForgot
            // 
            this.labelForgot.AutoSize = true;
            this.labelForgot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelForgot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForgot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(137)))), ((int)(((byte)(228)))));
            this.labelForgot.Location = new System.Drawing.Point(79, 212);
            this.labelForgot.Name = "labelForgot";
            this.labelForgot.Size = new System.Drawing.Size(127, 21);
            this.labelForgot.TabIndex = 19;
            this.labelForgot.Text = "Forgot pasword?";
            this.labelForgot.Click += new System.EventHandler(this.labelForgot_Click);
            // 
            // labelCreateAcc
            // 
            this.labelCreateAcc.AutoSize = true;
            this.labelCreateAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCreateAcc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(137)))), ((int)(((byte)(228)))));
            this.labelCreateAcc.Location = new System.Drawing.Point(193, 348);
            this.labelCreateAcc.Name = "labelCreateAcc";
            this.labelCreateAcc.Size = new System.Drawing.Size(137, 21);
            this.labelCreateAcc.TabIndex = 20;
            this.labelCreateAcc.Text = "Create an account.";
            this.labelCreateAcc.Click += new System.EventHandler(this.labelCreateAcc_Click);
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelUser.ForeColor = System.Drawing.SystemColors.Control;
            this.panelUser.Location = new System.Drawing.Point(74, 117);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(250, 1);
            this.panelUser.TabIndex = 12;
            // 
            // iconButtonEye
            // 
            this.iconButtonEye.FlatAppearance.BorderSize = 0;
            this.iconButtonEye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconButtonEye.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonEye.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonEye.IconSize = 25;
            this.iconButtonEye.Location = new System.Drawing.Point(299, 157);
            this.iconButtonEye.Name = "iconButtonEye";
            this.iconButtonEye.Size = new System.Drawing.Size(25, 23);
            this.iconButtonEye.TabIndex = 23;
            this.iconButtonEye.UseVisualStyleBackColor = true;
            this.iconButtonEye.Click += new System.EventHandler(this.iconButtonEye_Click);
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pictureBoxUser.BackgroundImage = global::PBL3.Properties.Resources.man;
            this.pictureBoxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxUser.Location = new System.Drawing.Point(74, 87);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxUser.TabIndex = 10;
            this.pictureBoxUser.TabStop = false;
            // 
            // pictureBoxPass
            // 
            this.pictureBoxPass.BackgroundImage = global::PBL3.Properties.Resources.padlock;
            this.pictureBoxPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxPass.Location = new System.Drawing.Point(74, 150);
            this.pictureBoxPass.Name = "pictureBoxPass";
            this.pictureBoxPass.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxPass.TabIndex = 13;
            this.pictureBoxPass.TabStop = false;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.iconButtonEye);
            this.Controls.Add(this.textBoxWarnPass);
            this.Controls.Add(this.labelSignIn);
            this.Controls.Add(this.textBoxWarnUser);
            this.Controls.Add(this.panelPass);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.pictureBoxUser);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.labelNew);
            this.Controls.Add(this.pictureBoxPass);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.labelForgot);
            this.Controls.Add(this.labelCreateAcc);
            this.Controls.Add(this.panelUser);
            this.Name = "SignIn";
            this.Size = new System.Drawing.Size(400, 510);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SignIn_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButtonEye;
        private System.Windows.Forms.TextBox textBoxWarnPass;
        private System.Windows.Forms.Label labelSignIn;
        private System.Windows.Forms.TextBox textBoxWarnUser;
        private System.Windows.Forms.Panel panelPass;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label labelNew;
        private System.Windows.Forms.PictureBox pictureBoxPass;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelForgot;
        private System.Windows.Forms.Label labelCreateAcc;
        private System.Windows.Forms.Panel panelUser;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
    }
}
