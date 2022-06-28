﻿namespace PBL3.GUI.GUI_Login
{
    partial class LogIn
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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelLogIn = new System.Windows.Forms.Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.panelTitle.Controls.Add(this.buttonMinimize);
            this.panelTitle.Controls.Add(this.buttonClose);
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(400, 28);
            this.panelTitle.TabIndex = 9;
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
            this.buttonMinimize.Location = new System.Drawing.Point(336, 4);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(20, 20);
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
            this.buttonClose.Location = new System.Drawing.Point(366, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(20, 20);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelLogIn
            // 
            this.panelLogIn.Location = new System.Drawing.Point(0, 240);
            this.panelLogIn.Name = "panelLogIn";
            this.panelLogIn.Size = new System.Drawing.Size(400, 510);
            this.panelLogIn.TabIndex = 10;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 1D;
            this.guna2DragControl1.TargetControl = this.panelTitle;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = global::PBL3.Properties.Resources.film;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Location = new System.Drawing.Point(140, 94);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(130, 130);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(400, 750);
            this.Controls.Add(this.panelLogIn);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.pictureBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "LogIn";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelLogIn;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
