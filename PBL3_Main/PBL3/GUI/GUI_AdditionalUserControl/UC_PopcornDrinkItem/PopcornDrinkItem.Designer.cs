namespace PBL3.GUI.GUI_AdditionalUserControl.UC_PopcornDrinkItem
{
    partial class PopcornDrinkItem
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
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.panelPrice = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.labelPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.buttonTick = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2PictureBoxItem = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxItem)).BeginInit();
            this.SuspendLayout();
            //
            // textBoxTitle
            //
            this.textBoxTitle.BackColor = System.Drawing.Color.White;
            this.textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitle.Font = new System.Drawing.Font("Cerebri Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitle.Location = new System.Drawing.Point(11, 212);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.ReadOnly = true;
            this.textBoxTitle.Size = new System.Drawing.Size(185, 27);
            this.textBoxTitle.TabIndex = 4;
            this.textBoxTitle.Text = "[Title]";
            this.textBoxTitle.Click += new System.EventHandler(this.guna2PictureBoxItem_Click);
            //
            // panelPrice
            //
            this.panelPrice.BackColor = System.Drawing.Color.Transparent;
            this.panelPrice.BorderRadius = 8;
            this.panelPrice.Controls.Add(this.labelPrice);
            this.panelPrice.Controls.Add(this.label1);
            this.panelPrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.panelPrice.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.panelPrice.Location = new System.Drawing.Point(76, 243);
            this.panelPrice.Name = "panelPrice";
            this.panelPrice.Size = new System.Drawing.Size(128, 39);
            this.panelPrice.TabIndex = 5;
            //
            // labelPrice
            //
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Cerebri Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.Color.White;
            this.labelPrice.Location = new System.Drawing.Point(57, 9);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelPrice.Size = new System.Drawing.Size(56, 24);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Price";
            this.labelPrice.Click += new System.EventHandler(this.guna2PictureBoxItem_Click);
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cerebri Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "đ";
            //
            // guna2Elipse1
            //
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            //
            // buttonTick
            //
            this.buttonTick.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.buttonTick.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.buttonTick.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.buttonTick.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.buttonTick.DisabledState.ForeColor = System.Drawing.Color.White;
            this.buttonTick.Enabled = false;
            this.buttonTick.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.buttonTick.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.buttonTick.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonTick.ForeColor = System.Drawing.Color.White;
            this.buttonTick.Image = global::PBL3.Properties.Resources.check;
            this.buttonTick.Location = new System.Drawing.Point(0, 245);
            this.buttonTick.Name = "buttonTick";
            this.buttonTick.Size = new System.Drawing.Size(40, 40);
            this.buttonTick.TabIndex = 6;
            //
            // guna2PictureBoxItem
            //
            this.guna2PictureBoxItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PictureBoxItem.FillColor = System.Drawing.Color.LightCoral;
            this.guna2PictureBoxItem.ImageRotate = 0F;
            this.guna2PictureBoxItem.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBoxItem.Name = "guna2PictureBoxItem";
            this.guna2PictureBoxItem.Size = new System.Drawing.Size(207, 200);
            this.guna2PictureBoxItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBoxItem.TabIndex = 0;
            this.guna2PictureBoxItem.TabStop = false;
            this.guna2PictureBoxItem.Click += new System.EventHandler(this.guna2PictureBoxItem_Click);
            //
            // PopcornDrinkItem
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonTick);
            this.Controls.Add(this.panelPrice);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.guna2PictureBoxItem);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "PopcornDrinkItem";
            this.Size = new System.Drawing.Size(207, 285);
            this.Load += new System.EventHandler(this.PopcornDrinkItem_Load);
            this.Click += new System.EventHandler(this.guna2PictureBoxItem_Click);
            this.panelPrice.ResumeLayout(false);
            this.panelPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBoxItem;
        private System.Windows.Forms.TextBox textBoxTitle;
        private Guna.UI2.WinForms.Guna2GradientPanel panelPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientTileButton buttonTick;
    }
}
