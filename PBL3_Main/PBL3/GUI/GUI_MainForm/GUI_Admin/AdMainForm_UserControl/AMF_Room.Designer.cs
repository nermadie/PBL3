namespace PBL3.GUI.GUI_MainForm.GUI_Admin.AdMainForm_UserControl
{
    partial class AMF_Room
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelHeader = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2ButtonRemove = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.panelFeature = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.scrollBarShow = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.dataGridViewShow = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            this.panelFeature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(234)))));
            this.labelTitle.Location = new System.Drawing.Point(48, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(62, 25);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Room";
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1088, 47);
            this.panelHeader.TabIndex = 22;
            // 
            // guna2ButtonRemove
            // 
            this.guna2ButtonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ButtonRemove.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(234)))));
            this.guna2ButtonRemove.BorderRadius = 16;
            this.guna2ButtonRemove.BorderThickness = 2;
            this.guna2ButtonRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ButtonRemove.CustomizableEdges.BottomLeft = false;
            this.guna2ButtonRemove.CustomizableEdges.TopLeft = false;
            this.guna2ButtonRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonRemove.FillColor = System.Drawing.Color.White;
            this.guna2ButtonRemove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ButtonRemove.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(234)))));
            this.guna2ButtonRemove.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(234)))));
            this.guna2ButtonRemove.Location = new System.Drawing.Point(171, 3);
            this.guna2ButtonRemove.Name = "guna2ButtonRemove";
            this.guna2ButtonRemove.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(234)))));
            this.guna2ButtonRemove.Size = new System.Drawing.Size(85, 36);
            this.guna2ButtonRemove.TabIndex = 5;
            this.guna2ButtonRemove.Text = "Remove";
            this.guna2ButtonRemove.Click += new System.EventHandler(this.guna2ButtonRemove_Click);
            // 
            // guna2ButtonAdd
            // 
            this.guna2ButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ButtonAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(234)))));
            this.guna2ButtonAdd.BorderRadius = 16;
            this.guna2ButtonAdd.BorderThickness = 2;
            this.guna2ButtonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ButtonAdd.CustomizableEdges.BottomRight = false;
            this.guna2ButtonAdd.CustomizableEdges.TopRight = false;
            this.guna2ButtonAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonAdd.FillColor = System.Drawing.Color.White;
            this.guna2ButtonAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ButtonAdd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(234)))));
            this.guna2ButtonAdd.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(234)))));
            this.guna2ButtonAdd.Location = new System.Drawing.Point(23, 3);
            this.guna2ButtonAdd.Name = "guna2ButtonAdd";
            this.guna2ButtonAdd.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(234)))));
            this.guna2ButtonAdd.Size = new System.Drawing.Size(60, 36);
            this.guna2ButtonAdd.TabIndex = 3;
            this.guna2ButtonAdd.Text = "Add";
            this.guna2ButtonAdd.Click += new System.EventHandler(this.guna2ButtonAdd_Click);
            // 
            // guna2ButtonUpdate
            // 
            this.guna2ButtonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ButtonUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(234)))));
            this.guna2ButtonUpdate.BorderRadius = 18;
            this.guna2ButtonUpdate.BorderThickness = 2;
            this.guna2ButtonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ButtonUpdate.CustomizableEdges.BottomLeft = false;
            this.guna2ButtonUpdate.CustomizableEdges.BottomRight = false;
            this.guna2ButtonUpdate.CustomizableEdges.TopLeft = false;
            this.guna2ButtonUpdate.CustomizableEdges.TopRight = false;
            this.guna2ButtonUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonUpdate.FillColor = System.Drawing.Color.White;
            this.guna2ButtonUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ButtonUpdate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(234)))));
            this.guna2ButtonUpdate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(234)))));
            this.guna2ButtonUpdate.Location = new System.Drawing.Point(84, 3);
            this.guna2ButtonUpdate.Name = "guna2ButtonUpdate";
            this.guna2ButtonUpdate.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(234)))));
            this.guna2ButtonUpdate.Size = new System.Drawing.Size(86, 36);
            this.guna2ButtonUpdate.TabIndex = 4;
            this.guna2ButtonUpdate.Text = "Update";
            this.guna2ButtonUpdate.Click += new System.EventHandler(this.guna2ButtonUpdate_Click);
            // 
            // panelFeature
            // 
            this.panelFeature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFeature.Controls.Add(this.guna2ButtonRemove);
            this.panelFeature.Controls.Add(this.guna2ButtonAdd);
            this.panelFeature.Controls.Add(this.guna2ButtonUpdate);
            this.panelFeature.Location = new System.Drawing.Point(784, 89);
            this.panelFeature.Name = "panelFeature";
            this.panelFeature.Size = new System.Drawing.Size(259, 42);
            this.panelFeature.TabIndex = 26;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // scrollBarShow
            // 
            this.scrollBarShow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scrollBarShow.BackColor = System.Drawing.Color.White;
            this.scrollBarShow.BindingContainer = this.dataGridViewShow;
            this.scrollBarShow.BorderColor = System.Drawing.Color.Gray;
            this.scrollBarShow.BorderRadius = 7;
            this.scrollBarShow.FillColor = System.Drawing.Color.White;
            this.scrollBarShow.InUpdate = false;
            this.scrollBarShow.LargeChange = 10;
            this.scrollBarShow.Location = new System.Drawing.Point(1041, 137);
            this.scrollBarShow.Minimum = 1;
            this.scrollBarShow.Name = "scrollBarShow";
            this.scrollBarShow.ScrollbarSize = 18;
            this.scrollBarShow.Size = new System.Drawing.Size(18, 517);
            this.scrollBarShow.TabIndex = 21;
            this.scrollBarShow.ThumbColor = System.Drawing.Color.Gray;
            this.scrollBarShow.ThumbSize = 40F;
            this.scrollBarShow.Value = 1;
            // 
            // dataGridViewShow
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.dataGridViewShow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewShow.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewShow.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewShow.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewShow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewShow.ColumnHeadersHeight = 25;
            this.dataGridViewShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(43)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewShow.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewShow.Location = new System.Drawing.Point(30, 137);
            this.dataGridViewShow.Name = "dataGridViewShow";
            this.dataGridViewShow.ReadOnly = true;
            this.dataGridViewShow.RowTemplate.Height = 50;
            this.dataGridViewShow.Size = new System.Drawing.Size(1029, 517);
            this.dataGridViewShow.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::PBL3.Properties.Resources.cinema;
            this.pictureBox1.Location = new System.Drawing.Point(10, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // AMF_Room
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.scrollBarShow);
            this.Controls.Add(this.dataGridViewShow);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelFeature);
            this.Name = "AMF_Room";
            this.Size = new System.Drawing.Size(1088, 738);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFeature.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private Guna.UI2.WinForms.Guna2GradientPanel panelHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonRemove;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonAdd;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonUpdate;
        private System.Windows.Forms.Panel panelFeature;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private Guna.UI2.WinForms.Guna2VScrollBar scrollBarShow;
        private System.Windows.Forms.DataGridView dataGridViewShow;
    }
}
