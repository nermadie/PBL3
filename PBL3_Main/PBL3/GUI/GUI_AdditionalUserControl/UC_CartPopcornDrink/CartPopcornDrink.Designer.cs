namespace PBL3.GUI.GUI_AdditionalUserControl.UC_CartPopcornDrink
{
    partial class CartPopcornDrink
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
            this.guna2NumericUpDown1 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.panelPrice = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.labelPrice = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pictureBoxRemove = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).BeginInit();
            this.panelPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2NumericUpDown1
            // 
            this.guna2NumericUpDown1.BackColor = System.Drawing.Color.Transparent;
            this.guna2NumericUpDown1.BorderColor = System.Drawing.Color.Tomato;
            this.guna2NumericUpDown1.BorderRadius = 5;
            this.guna2NumericUpDown1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2NumericUpDown1.Font = new System.Drawing.Font("Cerebri Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2NumericUpDown1.ForeColor = System.Drawing.Color.Black;
            this.guna2NumericUpDown1.Location = new System.Drawing.Point(259, 29);
            this.guna2NumericUpDown1.Name = "guna2NumericUpDown1";
            this.guna2NumericUpDown1.Size = new System.Drawing.Size(90, 39);
            this.guna2NumericUpDown1.TabIndex = 0;
            this.guna2NumericUpDown1.UpDownButtonFillColor = System.Drawing.Color.Tomato;
            this.guna2NumericUpDown1.UpDownButtonForeColor = System.Drawing.Color.White;
            this.guna2NumericUpDown1.ValueChanged += new System.EventHandler(this.guna2NumericUpDown1_ValueChanged);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.Color.White;
            this.textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitle.Font = new System.Drawing.Font("Cerebri Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitle.Location = new System.Drawing.Point(68, 12);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.ReadOnly = true;
            this.textBoxTitle.Size = new System.Drawing.Size(185, 25);
            this.textBoxTitle.TabIndex = 5;
            this.textBoxTitle.Text = "[Title]";
            // 
            // panelPrice
            // 
            this.panelPrice.BackColor = System.Drawing.Color.Transparent;
            this.panelPrice.BorderRadius = 8;
            this.panelPrice.Controls.Add(this.labelPrice);
            this.panelPrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.panelPrice.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.panelPrice.Location = new System.Drawing.Point(68, 45);
            this.panelPrice.Name = "panelPrice";
            this.panelPrice.Size = new System.Drawing.Size(117, 35);
            this.panelPrice.TabIndex = 6;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Cerebri Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.Color.White;
            this.labelPrice.Location = new System.Drawing.Point(5, 6);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPrice.Size = new System.Drawing.Size(49, 21);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Price";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // pictureBoxRemove
            // 
            this.pictureBoxRemove.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRemove.Image = global::PBL3.Properties.Resources.delete;
            this.pictureBoxRemove.Location = new System.Drawing.Point(15, 32);
            this.pictureBoxRemove.Name = "pictureBoxRemove";
            this.pictureBoxRemove.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxRemove.TabIndex = 7;
            this.pictureBoxRemove.TabStop = false;
            this.pictureBoxRemove.Click += new System.EventHandler(this.pictureBoxRemove_Click);
            // 
            // CartPopcornDrink
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBoxRemove);
            this.Controls.Add(this.panelPrice);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.guna2NumericUpDown1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "CartPopcornDrink";
            this.Size = new System.Drawing.Size(393, 93);
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).EndInit();
            this.panelPrice.ResumeLayout(false);
            this.panelPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown1;
        private System.Windows.Forms.TextBox textBoxTitle;
        private Guna.UI2.WinForms.Guna2GradientPanel panelPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.PictureBox pictureBoxRemove;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
