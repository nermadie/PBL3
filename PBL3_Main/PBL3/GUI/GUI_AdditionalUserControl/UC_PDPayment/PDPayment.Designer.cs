namespace PBL3.GUI.GUI_AdditionalUserControl.UC_PDPayment
{
    partial class PDPayment
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.textBoxTitle = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // guna2Elipse1
            //
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            //
            // textBoxTitle
            //
            this.textBoxTitle.AutoSize = true;
            this.textBoxTitle.Font = new System.Drawing.Font("Cerebri Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitle.Location = new System.Drawing.Point(35, 19);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(54, 21);
            this.textBoxTitle.TabIndex = 0;
            this.textBoxTitle.Text = "label1";
            //
            // textBoxQuantity
            //
            this.textBoxQuantity.AutoSize = true;
            this.textBoxQuantity.Font = new System.Drawing.Font("Cerebri Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantity.Location = new System.Drawing.Point(333, 19);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(54, 21);
            this.textBoxQuantity.TabIndex = 0;
            this.textBoxQuantity.Text = "label1";
            //
            // PDPayment
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxTitle);
            this.Font = new System.Drawing.Font("Cerebri Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PDPayment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(397, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label textBoxQuantity;
        private System.Windows.Forms.Label textBoxTitle;
    }
}
