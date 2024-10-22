namespace PBL3.GUI.GUI_AdditionalUserControl.UC_MovieItem
{
    partial class MovieItem
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
            this.labelRelease = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pictureBoxPoster = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).BeginInit();
            this.SuspendLayout();
            //
            // guna2Elipse1
            //
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            //
            // labelRelease
            //
            this.labelRelease.AutoSize = true;
            this.labelRelease.Font = new System.Drawing.Font("Cerebri Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRelease.ForeColor = System.Drawing.Color.Gray;
            this.labelRelease.Location = new System.Drawing.Point(5, 352);
            this.labelRelease.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelRelease.Name = "labelRelease";
            this.labelRelease.Size = new System.Drawing.Size(109, 21);
            this.labelRelease.TabIndex = 0;
            this.labelRelease.Text = "[ReleaseDate]";
            //
            // labelDuration
            //
            this.labelDuration.AutoSize = true;
            this.labelDuration.Font = new System.Drawing.Font("Cerebri Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuration.ForeColor = System.Drawing.Color.Gray;
            this.labelDuration.Location = new System.Drawing.Point(125, 352);
            this.labelDuration.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelDuration.Size = new System.Drawing.Size(80, 21);
            this.labelDuration.TabIndex = 0;
            this.labelDuration.Text = "[Duration]";
            this.labelDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // textBoxTitle
            //
            this.textBoxTitle.BackColor = System.Drawing.Color.White;
            this.textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitle.Font = new System.Drawing.Font("Cerebri Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitle.Location = new System.Drawing.Point(9, 317);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.ReadOnly = true;
            this.textBoxTitle.Size = new System.Drawing.Size(185, 27);
            this.textBoxTitle.TabIndex = 2;
            this.textBoxTitle.Text = "[Title]";
            this.textBoxTitle.Click += new System.EventHandler(this.textBoxTitle_Click);
            //
            // guna2Elipse2
            //
            this.guna2Elipse2.BorderRadius = 15;
            this.guna2Elipse2.TargetControl = this.pictureBoxPoster;
            //
            // pictureBoxPoster
            //
            this.pictureBoxPoster.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxPoster.ImageRotate = 0F;
            this.pictureBoxPoster.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPoster.Name = "pictureBoxPoster";
            this.pictureBoxPoster.Size = new System.Drawing.Size(200, 315);
            this.pictureBoxPoster.TabIndex = 1;
            this.pictureBoxPoster.TabStop = false;
            this.pictureBoxPoster.Click += new System.EventHandler(this.pictureBoxPoster_Click);
            //
            // MovieItem
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.pictureBoxPoster);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.labelRelease);
            this.Font = new System.Drawing.Font("Cerebri Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MovieItem";
            this.Size = new System.Drawing.Size(200, 389);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label labelRelease;
        private System.Windows.Forms.Label labelDuration;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxPoster;
        private System.Windows.Forms.TextBox textBoxTitle;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}
