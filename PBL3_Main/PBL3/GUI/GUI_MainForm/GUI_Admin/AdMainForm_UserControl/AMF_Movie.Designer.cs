namespace PBL3.GUI.GUI_MainForm.GUI_Admin.AdMainForm_UserControl
{
    partial class AMF_Movie
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2ButtonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.panelFeature = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.comboBoxSort = new Guna.UI2.WinForms.Guna2ComboBox();
            this.textBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ButtonSearch = new Guna.UI2.WinForms.Guna2Button();
            this.scrollBarShow = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.dataGridViewShow = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelFeature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).BeginInit();
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
            this.labelTitle.Size = new System.Drawing.Size(66, 25);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Movie";
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
            this.panelHeader.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::PBL3.Properties.Resources.clapperboard;
            this.pictureBox1.Location = new System.Drawing.Point(10, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            this.panelFeature.Controls.Add(this.guna2ButtonAdd);
            this.panelFeature.Controls.Add(this.guna2ButtonUpdate);
            this.panelFeature.Location = new System.Drawing.Point(793, 75);
            this.panelFeature.Name = "panelFeature";
            this.panelFeature.Size = new System.Drawing.Size(259, 42);
            this.panelFeature.TabIndex = 20;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxSort.BorderRadius = 15;
            this.comboBoxSort.CustomizableEdges.BottomLeft = false;
            this.comboBoxSort.CustomizableEdges.TopLeft = false;
            this.comboBoxSort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSort.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxSort.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxSort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxSort.ItemHeight = 25;
            this.comboBoxSort.Location = new System.Drawing.Point(597, 86);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(190, 31);
            this.comboBoxSort.TabIndex = 21;
            this.comboBoxSort.SelectedIndexChanged += new System.EventHandler(this.comboBoxSort_SelectedIndexChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.textBoxSearch.BorderRadius = 15;
            this.textBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSearch.CustomizableEdges.BottomRight = false;
            this.textBoxSearch.CustomizableEdges.TopRight = false;
            this.textBoxSearch.DefaultText = "";
            this.textBoxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxSearch.ForeColor = System.Drawing.Color.Silver;
            this.textBoxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSearch.Location = new System.Drawing.Point(29, 86);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PasswordChar = '\0';
            this.textBoxSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.textBoxSearch.PlaceholderText = "Search";
            this.textBoxSearch.SelectedText = "";
            this.textBoxSearch.Size = new System.Drawing.Size(273, 31);
            this.textBoxSearch.TabIndex = 17;
            // 
            // guna2ButtonSearch
            // 
            this.guna2ButtonSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonSearch.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonSearch.Location = new System.Drawing.Point(325, 78);
            this.guna2ButtonSearch.Name = "guna2ButtonSearch";
            this.guna2ButtonSearch.Size = new System.Drawing.Size(112, 45);
            this.guna2ButtonSearch.TabIndex = 22;
            this.guna2ButtonSearch.Text = "Search";
            this.guna2ButtonSearch.Click += new System.EventHandler(this.guna2ButtonSearch_Click);
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
            this.scrollBarShow.Location = new System.Drawing.Point(1040, 129);
            this.scrollBarShow.Minimum = 1;
            this.scrollBarShow.Name = "scrollBarShow";
            this.scrollBarShow.ScrollbarSize = 18;
            this.scrollBarShow.Size = new System.Drawing.Size(18, 517);
            this.scrollBarShow.TabIndex = 23;
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
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(43)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewShow.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewShow.Location = new System.Drawing.Point(29, 129);
            this.dataGridViewShow.Name = "dataGridViewShow";
            this.dataGridViewShow.ReadOnly = true;
            this.dataGridViewShow.RowTemplate.Height = 50;
            this.dataGridViewShow.Size = new System.Drawing.Size(1029, 517);
            this.dataGridViewShow.TabIndex = 24;
            // 
            // AMF_Movie
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.scrollBarShow);
            this.Controls.Add(this.dataGridViewShow);
            this.Controls.Add(this.guna2ButtonSearch);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelFeature);
            this.Controls.Add(this.comboBoxSort);
            this.Controls.Add(this.textBoxSearch);
            this.Name = "AMF_Movie";
            this.Size = new System.Drawing.Size(1088, 738);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelFeature.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private Guna.UI2.WinForms.Guna2GradientPanel panelHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonAdd;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonUpdate;
        private System.Windows.Forms.Panel panelFeature;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxSort;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSearch;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonSearch;
        private Guna.UI2.WinForms.Guna2VScrollBar scrollBarShow;
        private System.Windows.Forms.DataGridView dataGridViewShow;
    }
}
