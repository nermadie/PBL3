namespace PBL3.GUI.GUI_Login.LogIn_ChildForm
{
    partial class SignUp
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
            this.labelSignUp = new System.Windows.Forms.Label();
            this.textBoxWarnPass = new System.Windows.Forms.TextBox();
            this.textBoxWarnUser = new System.Windows.Forms.TextBox();
            this.panelPass = new System.Windows.Forms.Panel();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.panelUser = new System.Windows.Forms.Panel();
            this.textBoxWarnConfirm = new System.Windows.Forms.TextBox();
            this.panelConfirm = new System.Windows.Forms.Panel();
            this.textBoxConfirm = new System.Windows.Forms.TextBox();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.checkBoxAgree = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.panelName = new System.Windows.Forms.Panel();
            this.pictureBoxName = new System.Windows.Forms.PictureBox();
            this.iconButtonEyeConfirm = new FontAwesome.Sharp.IconButton();
            this.pictureBoxConfirm = new System.Windows.Forms.PictureBox();
            this.iconButtonEyePass = new FontAwesome.Sharp.IconButton();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.pictureBoxPass = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPass)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSignUp
            // 
            this.labelSignUp.AutoSize = true;
            this.labelSignUp.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignUp.ForeColor = System.Drawing.Color.White;
            this.labelSignUp.Location = new System.Drawing.Point(88, 29);
            this.labelSignUp.Name = "labelSignUp";
            this.labelSignUp.Size = new System.Drawing.Size(224, 32);
            this.labelSignUp.TabIndex = 18;
            this.labelSignUp.Text = "Sign up to Cinema";
            // 
            // textBoxWarnPass
            // 
            this.textBoxWarnPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxWarnPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWarnPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWarnPass.ForeColor = System.Drawing.Color.OrangeRed;
            this.textBoxWarnPass.Location = new System.Drawing.Point(80, 172);
            this.textBoxWarnPass.Name = "textBoxWarnPass";
            this.textBoxWarnPass.ReadOnly = true;
            this.textBoxWarnPass.Size = new System.Drawing.Size(250, 18);
            this.textBoxWarnPass.TabIndex = 30;
            this.textBoxWarnPass.Text = "! Invalid Password";
            // 
            // textBoxWarnUser
            // 
            this.textBoxWarnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxWarnUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWarnUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWarnUser.ForeColor = System.Drawing.Color.OrangeRed;
            this.textBoxWarnUser.Location = new System.Drawing.Point(80, 113);
            this.textBoxWarnUser.Name = "textBoxWarnUser";
            this.textBoxWarnUser.ReadOnly = true;
            this.textBoxWarnUser.Size = new System.Drawing.Size(250, 18);
            this.textBoxWarnUser.TabIndex = 31;
            this.textBoxWarnUser.Text = "! Invalid Username/Email address";
            // 
            // panelPass
            // 
            this.panelPass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelPass.Location = new System.Drawing.Point(70, 168);
            this.panelPass.Name = "panelPass";
            this.panelPass.Size = new System.Drawing.Size(250, 1);
            this.panelPass.TabIndex = 29;
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxPass.HideSelection = false;
            this.textBoxPass.Location = new System.Drawing.Point(107, 142);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(182, 22);
            this.textBoxPass.TabIndex = 28;
            this.textBoxPass.TabStop = false;
            this.textBoxPass.Text = "Password";
            this.textBoxPass.Click += new System.EventHandler(this.textBoxPass_Click);
            // 
            // textBoxUser
            // 
            this.textBoxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxUser.HideSelection = false;
            this.textBoxUser.Location = new System.Drawing.Point(107, 84);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(200, 22);
            this.textBoxUser.TabIndex = 25;
            this.textBoxUser.TabStop = false;
            this.textBoxUser.Text = "Username or email address";
            this.textBoxUser.Click += new System.EventHandler(this.textBoxUser_Click);
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelUser.ForeColor = System.Drawing.SystemColors.Control;
            this.panelUser.Location = new System.Drawing.Point(70, 110);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(250, 1);
            this.panelUser.TabIndex = 26;
            // 
            // textBoxWarnConfirm
            // 
            this.textBoxWarnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxWarnConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWarnConfirm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWarnConfirm.ForeColor = System.Drawing.Color.OrangeRed;
            this.textBoxWarnConfirm.Location = new System.Drawing.Point(80, 230);
            this.textBoxWarnConfirm.Name = "textBoxWarnConfirm";
            this.textBoxWarnConfirm.ReadOnly = true;
            this.textBoxWarnConfirm.Size = new System.Drawing.Size(250, 18);
            this.textBoxWarnConfirm.TabIndex = 36;
            this.textBoxWarnConfirm.Text = "! Password does not match";
            // 
            // panelConfirm
            // 
            this.panelConfirm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelConfirm.Location = new System.Drawing.Point(70, 226);
            this.panelConfirm.Name = "panelConfirm";
            this.panelConfirm.Size = new System.Drawing.Size(250, 1);
            this.panelConfirm.TabIndex = 35;
            // 
            // textBoxConfirm
            // 
            this.textBoxConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxConfirm.HideSelection = false;
            this.textBoxConfirm.Location = new System.Drawing.Point(107, 200);
            this.textBoxConfirm.Name = "textBoxConfirm";
            this.textBoxConfirm.Size = new System.Drawing.Size(182, 22);
            this.textBoxConfirm.TabIndex = 34;
            this.textBoxConfirm.TabStop = false;
            this.textBoxConfirm.Text = "Confirm Password";
            this.textBoxConfirm.Click += new System.EventHandler(this.textBoxConfirm_Click);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(172)))));
            this.buttonSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignUp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonSignUp.Location = new System.Drawing.Point(87, 379);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(226, 35);
            this.buttonSignUp.TabIndex = 38;
            this.buttonSignUp.Text = "Sign up";
            this.buttonSignUp.UseVisualStyleBackColor = false;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // checkBoxAgree
            // 
            this.checkBoxAgree.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(137)))), ((int)(((byte)(228)))));
            this.checkBoxAgree.CheckedState.BorderRadius = 2;
            this.checkBoxAgree.CheckedState.BorderThickness = 0;
            this.checkBoxAgree.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(137)))), ((int)(((byte)(228)))));
            this.checkBoxAgree.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxAgree.Location = new System.Drawing.Point(70, 340);
            this.checkBoxAgree.Name = "checkBoxAgree";
            this.checkBoxAgree.Size = new System.Drawing.Size(15, 15);
            this.checkBoxAgree.TabIndex = 39;
            this.checkBoxAgree.Text = "abc checkbox";
            this.checkBoxAgree.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBoxAgree.UncheckedState.BorderRadius = 2;
            this.checkBoxAgree.UncheckedState.BorderThickness = 0;
            this.checkBoxAgree.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(94, 338);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 18);
            this.textBox1.TabIndex = 34;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "I agree to the ";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(137)))), ((int)(((byte)(228)))));
            this.textBox2.HideSelection = false;
            this.textBox2.Location = new System.Drawing.Point(178, 338);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 18);
            this.textBox2.TabIndex = 34;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "terms and conditions.";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxName.HideSelection = false;
            this.textBoxName.Location = new System.Drawing.Point(107, 259);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 22);
            this.textBoxName.TabIndex = 41;
            this.textBoxName.TabStop = false;
            this.textBoxName.Text = "What should we call you?";
            this.textBoxName.Click += new System.EventHandler(this.textBoxName_Click);
            // 
            // panelName
            // 
            this.panelName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelName.ForeColor = System.Drawing.SystemColors.Control;
            this.panelName.Location = new System.Drawing.Point(70, 285);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(250, 1);
            this.panelName.TabIndex = 42;
            // 
            // pictureBoxName
            // 
            this.pictureBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pictureBoxName.BackgroundImage = global::PBL3.Properties.Resources.man;
            this.pictureBoxName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxName.Image = global::PBL3.Properties.Resources.hello;
            this.pictureBoxName.Location = new System.Drawing.Point(70, 255);
            this.pictureBoxName.Name = "pictureBoxName";
            this.pictureBoxName.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxName.TabIndex = 40;
            this.pictureBoxName.TabStop = false;
            // 
            // iconButtonEyeConfirm
            // 
            this.iconButtonEyeConfirm.FlatAppearance.BorderSize = 0;
            this.iconButtonEyeConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonEyeConfirm.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconButtonEyeConfirm.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonEyeConfirm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonEyeConfirm.IconSize = 25;
            this.iconButtonEyeConfirm.Location = new System.Drawing.Point(295, 203);
            this.iconButtonEyeConfirm.Name = "iconButtonEyeConfirm";
            this.iconButtonEyeConfirm.Size = new System.Drawing.Size(25, 23);
            this.iconButtonEyeConfirm.TabIndex = 37;
            this.iconButtonEyeConfirm.UseVisualStyleBackColor = true;
            this.iconButtonEyeConfirm.Click += new System.EventHandler(this.iconButtonEyeConfirm_Click);
            // 
            // pictureBoxConfirm
            // 
            this.pictureBoxConfirm.BackgroundImage = global::PBL3.Properties.Resources.confirmation;
            this.pictureBoxConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxConfirm.Location = new System.Drawing.Point(70, 196);
            this.pictureBoxConfirm.Name = "pictureBoxConfirm";
            this.pictureBoxConfirm.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxConfirm.TabIndex = 33;
            this.pictureBoxConfirm.TabStop = false;
            // 
            // iconButtonEyePass
            // 
            this.iconButtonEyePass.FlatAppearance.BorderSize = 0;
            this.iconButtonEyePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonEyePass.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconButtonEyePass.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonEyePass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonEyePass.IconSize = 25;
            this.iconButtonEyePass.Location = new System.Drawing.Point(295, 145);
            this.iconButtonEyePass.Name = "iconButtonEyePass";
            this.iconButtonEyePass.Size = new System.Drawing.Size(25, 23);
            this.iconButtonEyePass.TabIndex = 32;
            this.iconButtonEyePass.UseVisualStyleBackColor = true;
            this.iconButtonEyePass.Click += new System.EventHandler(this.iconButtonEyePass_Click);
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pictureBoxUser.BackgroundImage = global::PBL3.Properties.Resources.man;
            this.pictureBoxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxUser.Location = new System.Drawing.Point(70, 80);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxUser.TabIndex = 24;
            this.pictureBoxUser.TabStop = false;
            // 
            // pictureBoxPass
            // 
            this.pictureBoxPass.BackgroundImage = global::PBL3.Properties.Resources.padlock;
            this.pictureBoxPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxPass.Location = new System.Drawing.Point(70, 138);
            this.pictureBoxPass.Name = "pictureBoxPass";
            this.pictureBoxPass.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxPass.TabIndex = 27;
            this.pictureBoxPass.TabStop = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.pictureBoxName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.panelName);
            this.Controls.Add(this.checkBoxAgree);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.iconButtonEyeConfirm);
            this.Controls.Add(this.textBoxWarnConfirm);
            this.Controls.Add(this.panelConfirm);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxConfirm);
            this.Controls.Add(this.pictureBoxConfirm);
            this.Controls.Add(this.iconButtonEyePass);
            this.Controls.Add(this.textBoxWarnPass);
            this.Controls.Add(this.textBoxWarnUser);
            this.Controls.Add(this.panelPass);
            this.Controls.Add(this.pictureBoxUser);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.pictureBoxPass);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.labelSignUp);
            this.Name = "SignUp";
            this.Size = new System.Drawing.Size(400, 510);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSignUp;
        private FontAwesome.Sharp.IconButton iconButtonEyePass;
        private System.Windows.Forms.TextBox textBoxWarnPass;
        private System.Windows.Forms.TextBox textBoxWarnUser;
        private System.Windows.Forms.Panel panelPass;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.PictureBox pictureBoxPass;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Panel panelUser;
        private FontAwesome.Sharp.IconButton iconButtonEyeConfirm;
        private System.Windows.Forms.TextBox textBoxWarnConfirm;
        private System.Windows.Forms.Panel panelConfirm;
        private System.Windows.Forms.TextBox textBoxConfirm;
        private System.Windows.Forms.PictureBox pictureBoxConfirm;
        private System.Windows.Forms.Button buttonSignUp;
        private Guna.UI2.WinForms.Guna2CustomCheckBox checkBoxAgree;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBoxName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Panel panelName;
    }
}
