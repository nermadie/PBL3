﻿namespace PBL3.GUI.GUI_Login.Login_Customer.LogIn_UserControl
{
    partial class ForgotPassword_Customer
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
            this.labelSignIn = new System.Windows.Forms.Label();
            this.textBoxWarnUser = new System.Windows.Forms.TextBox();
            this.panelUser = new System.Windows.Forms.Panel();
            this.buttonConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.textBoxUser = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.SuspendLayout();
            //
            // labelSignIn
            //
            this.labelSignIn.AutoSize = true;
            this.labelSignIn.Font = new System.Drawing.Font("Cerebri Sans Heavy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignIn.ForeColor = System.Drawing.Color.White;
            this.labelSignIn.Location = new System.Drawing.Point(93, 23);
            this.labelSignIn.Name = "labelSignIn";
            this.labelSignIn.Size = new System.Drawing.Size(214, 30);
            this.labelSignIn.TabIndex = 31;
            this.labelSignIn.Text = "Forgot Password";
            //
            // textBoxWarnUser
            //
            this.textBoxWarnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxWarnUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWarnUser.Font = new System.Drawing.Font("Cerebri Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWarnUser.ForeColor = System.Drawing.Color.OrangeRed;
            this.textBoxWarnUser.Location = new System.Drawing.Point(80, 115);
            this.textBoxWarnUser.Multiline = true;
            this.textBoxWarnUser.Name = "textBoxWarnUser";
            this.textBoxWarnUser.ReadOnly = true;
            this.textBoxWarnUser.Size = new System.Drawing.Size(250, 38);
            this.textBoxWarnUser.TabIndex = 36;
            this.textBoxWarnUser.Text = "! Invalid Username/Email address";
            //
            // panelUser
            //
            this.panelUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelUser.ForeColor = System.Drawing.SystemColors.Control;
            this.panelUser.Location = new System.Drawing.Point(70, 112);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(250, 1);
            this.panelUser.TabIndex = 26;
            //
            // buttonConfirm
            //
            this.buttonConfirm.Animated = true;
            this.buttonConfirm.BorderRadius = 5;
            this.buttonConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonConfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(172)))));
            this.buttonConfirm.Font = new System.Drawing.Font("Cerebri Sans Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.ForeColor = System.Drawing.Color.Black;
            this.buttonConfirm.Location = new System.Drawing.Point(95, 315);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(210, 35);
            this.buttonConfirm.TabIndex = 37;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            this.buttonConfirm.MouseHover += new System.EventHandler(this.buttonConfirm_MouseHover);
            //
            // pictureBoxUser
            //
            this.pictureBoxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pictureBoxUser.BackgroundImage = global::PBL3.Properties.Resources.man;
            this.pictureBoxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxUser.Location = new System.Drawing.Point(70, 82);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxUser.TabIndex = 24;
            this.pictureBoxUser.TabStop = false;
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
            this.textBoxUser.Location = new System.Drawing.Point(95, 82);
            this.textBoxUser.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.PasswordChar = '\0';
            this.textBoxUser.PlaceholderText = "Username/Email address";
            this.textBoxUser.SelectedText = "";
            this.textBoxUser.Size = new System.Drawing.Size(208, 26);
            this.textBoxUser.TabIndex = 47;
            this.textBoxUser.Click += new System.EventHandler(this.textBoxUser_Click);
            //
            // ForgotPassword_Customer
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.labelSignIn);
            this.Controls.Add(this.textBoxWarnUser);
            this.Controls.Add(this.pictureBoxUser);
            this.Controls.Add(this.panelUser);
            this.Name = "ForgotPassword_Customer";
            this.Size = new System.Drawing.Size(400, 510);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ForgotPassword_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSignIn;
        private System.Windows.Forms.TextBox textBoxWarnUser;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Panel panelUser;
        private Guna.UI2.WinForms.Guna2Button buttonConfirm;
        private Guna.UI2.WinForms.Guna2TextBox textBoxUser;
    }
}
