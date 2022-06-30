namespace PBL3.GUI.GUI_ChooseRole
{
    partial class ChooseRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseRole));
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelSignIn = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.buttonCus = new Guna.UI2.WinForms.Guna2GradientButton();
            this.buttonEm = new Guna.UI2.WinForms.Guna2GradientButton();
            this.buttonAd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.timerCusEnter = new System.Windows.Forms.Timer(this.components);
            this.timerCusLeave = new System.Windows.Forms.Timer(this.components);
            this.timerEmEnter = new System.Windows.Forms.Timer(this.components);
            this.timerEmLeave = new System.Windows.Forms.Timer(this.components);
            this.timerAdEnter = new System.Windows.Forms.Timer(this.components);
            this.timerAdLeave = new System.Windows.Forms.Timer(this.components);
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Controls.Add(this.buttonMinimize);
            this.panelTitle.Controls.Add(this.buttonClose);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(620, 28);
            this.panelTitle.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cerebri Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cinema";
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackgroundImage = global::PBL3.Properties.Resources.remove;
            this.buttonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimize.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonMinimize.Location = new System.Drawing.Point(564, 4);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(20, 20);
            this.buttonMinimize.TabIndex = 8;
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackgroundImage = global::PBL3.Properties.Resources.cancel1;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonClose.Location = new System.Drawing.Point(594, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(20, 20);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelSignIn
            // 
            this.labelSignIn.AutoSize = true;
            this.labelSignIn.Font = new System.Drawing.Font("Cerebri Sans Heavy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(172)))));
            this.labelSignIn.Location = new System.Drawing.Point(28, 55);
            this.labelSignIn.Name = "labelSignIn";
            this.labelSignIn.Size = new System.Drawing.Size(379, 34);
            this.labelSignIn.TabIndex = 18;
            this.labelSignIn.Text = "Hello, tell me who you are?";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panelTitle;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // buttonCus
            // 
            this.buttonCus.Animated = true;
            this.buttonCus.BorderRadius = 10;
            this.buttonCus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonCus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonCus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonCus.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonCus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonCus.Font = new System.Drawing.Font("Cerebri Sans Heavy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCus.ForeColor = System.Drawing.Color.White;
            this.buttonCus.Location = new System.Drawing.Point(0, 130);
            this.buttonCus.MaximumSize = new System.Drawing.Size(620, 120);
            this.buttonCus.MinimumSize = new System.Drawing.Size(0, 60);
            this.buttonCus.Name = "buttonCus";
            this.buttonCus.Size = new System.Drawing.Size(620, 60);
            this.buttonCus.TabIndex = 20;
            this.buttonCus.Text = "Customer";
            this.buttonCus.Click += new System.EventHandler(this.guna2GradientButtonCus_Click);
            this.buttonCus.MouseEnter += new System.EventHandler(this.guna2GradientButtonCus_MouseEnter);
            this.buttonCus.MouseLeave += new System.EventHandler(this.guna2GradientButtonCus_MouseLeave);
            // 
            // buttonEm
            // 
            this.buttonEm.Animated = true;
            this.buttonEm.BorderRadius = 10;
            this.buttonEm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonEm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonEm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonEm.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonEm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonEm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(151)))), ((int)(((byte)(86)))));
            this.buttonEm.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(240)))), ((int)(((byte)(162)))));
            this.buttonEm.Font = new System.Drawing.Font("Cerebri Sans Heavy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEm.ForeColor = System.Drawing.Color.White;
            this.buttonEm.Location = new System.Drawing.Point(0, 195);
            this.buttonEm.MaximumSize = new System.Drawing.Size(620, 120);
            this.buttonEm.MinimumSize = new System.Drawing.Size(620, 60);
            this.buttonEm.Name = "buttonEm";
            this.buttonEm.Size = new System.Drawing.Size(620, 60);
            this.buttonEm.TabIndex = 20;
            this.buttonEm.Text = "Employee";
            this.buttonEm.Click += new System.EventHandler(this.guna2GradientButtonEm_Click);
            this.buttonEm.MouseEnter += new System.EventHandler(this.buttonEm_MouseEnter);
            this.buttonEm.MouseLeave += new System.EventHandler(this.buttonEm_MouseLeave);
            // 
            // buttonAd
            // 
            this.buttonAd.Animated = true;
            this.buttonAd.BorderRadius = 10;
            this.buttonAd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAd.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAd.FillColor = System.Drawing.Color.Turquoise;
            this.buttonAd.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(216)))), ((int)(((byte)(251)))));
            this.buttonAd.Font = new System.Drawing.Font("Cerebri Sans Heavy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAd.ForeColor = System.Drawing.Color.White;
            this.buttonAd.Location = new System.Drawing.Point(0, 260);
            this.buttonAd.MaximumSize = new System.Drawing.Size(620, 120);
            this.buttonAd.MinimumSize = new System.Drawing.Size(620, 60);
            this.buttonAd.Name = "buttonAd";
            this.buttonAd.Size = new System.Drawing.Size(620, 60);
            this.buttonAd.TabIndex = 20;
            this.buttonAd.Text = "Administrator";
            this.buttonAd.Click += new System.EventHandler(this.guna2GradientButtonAd_Click);
            this.buttonAd.MouseEnter += new System.EventHandler(this.buttonAd_MouseEnter);
            this.buttonAd.MouseLeave += new System.EventHandler(this.buttonAd_MouseLeave);
            // 
            // timerCusEnter
            // 
            this.timerCusEnter.Interval = 5;
            this.timerCusEnter.Tick += new System.EventHandler(this.timerCusEnter_Tick);
            // 
            // timerCusLeave
            // 
            this.timerCusLeave.Interval = 5;
            this.timerCusLeave.Tick += new System.EventHandler(this.timerCusLeave_Tick);
            // 
            // timerEmEnter
            // 
            this.timerEmEnter.Interval = 5;
            this.timerEmEnter.Tick += new System.EventHandler(this.timerEmEnter_Tick);
            // 
            // timerEmLeave
            // 
            this.timerEmLeave.Interval = 10;
            this.timerEmLeave.Tick += new System.EventHandler(this.timerEmLeave_Tick);
            // 
            // timerAdEnter
            // 
            this.timerAdEnter.Interval = 5;
            this.timerAdEnter.Tick += new System.EventHandler(this.timerAdEnter_Tick);
            // 
            // timerAdLeave
            // 
            this.timerAdLeave.Interval = 5;
            this.timerAdLeave.Tick += new System.EventHandler(this.timerAdLeave_Tick);
            // 
            // ChooseRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(620, 385);
            this.Controls.Add(this.buttonAd);
            this.Controls.Add(this.buttonEm);
            this.Controls.Add(this.buttonCus);
            this.Controls.Add(this.labelSignIn);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "ChooseRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseRole";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelSignIn;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientButton buttonAd;
        private Guna.UI2.WinForms.Guna2GradientButton buttonEm;
        private Guna.UI2.WinForms.Guna2GradientButton buttonCus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerCusEnter;
        private System.Windows.Forms.Timer timerCusLeave;
        private System.Windows.Forms.Timer timerEmEnter;
        private System.Windows.Forms.Timer timerEmLeave;
        private System.Windows.Forms.Timer timerAdEnter;
        private System.Windows.Forms.Timer timerAdLeave;
    }
}