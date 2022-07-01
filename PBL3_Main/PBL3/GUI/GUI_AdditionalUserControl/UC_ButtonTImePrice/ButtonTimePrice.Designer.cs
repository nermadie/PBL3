namespace PBL3.GUI.GUI_AdditionalUserControl.UC_ButtonTimePrice
{
    partial class ButtonTimePrice
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
            this.guna2ButtonTimePrice = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2ButtonTimePrice
            // 
            this.guna2ButtonTimePrice.BorderRadius = 5;
            this.guna2ButtonTimePrice.BorderThickness = 1;
            this.guna2ButtonTimePrice.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonTimePrice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonTimePrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonTimePrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonTimePrice.FillColor = System.Drawing.Color.Transparent;
            this.guna2ButtonTimePrice.Font = new System.Drawing.Font("Cerebri Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonTimePrice.ForeColor = System.Drawing.Color.Black;
            this.guna2ButtonTimePrice.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.guna2ButtonTimePrice.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonTimePrice.Location = new System.Drawing.Point(0, 0);
            this.guna2ButtonTimePrice.Name = "guna2ButtonTimePrice";
            this.guna2ButtonTimePrice.Size = new System.Drawing.Size(71, 48);
            this.guna2ButtonTimePrice.TabIndex = 0;
            this.guna2ButtonTimePrice.Text = "12:00 45K";
            this.guna2ButtonTimePrice.Click += new System.EventHandler(this.guna2Button1TimePrice_Click);
            // 
            // ButtonTimePrice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2ButtonTimePrice);
            this.Name = "ButtonTimePrice";
            this.Size = new System.Drawing.Size(71, 48);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button guna2ButtonTimePrice;
    }
}
