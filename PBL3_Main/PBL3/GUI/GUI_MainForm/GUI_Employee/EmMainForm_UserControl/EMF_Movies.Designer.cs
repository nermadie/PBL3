namespace PBL3.GUI.GUI_MainForm.GUI_Employee.EmMainForm_UserControl
{
    partial class EMF_Movies
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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.guna2ComboBoxSortBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ComboBoxCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.textBoxSortBy = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.guna2PanelSort = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ElipsePanelSort = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Location = new System.Drawing.Point(253, 55);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(923, 626);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.BindingContainer = this.flowLayoutPanel;
            this.guna2VScrollBar1.InUpdate = false;
            this.guna2VScrollBar1.LargeChange = 10;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(1158, 55);
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.ScrollbarSize = 18;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(18, 626);
            this.guna2VScrollBar1.TabIndex = 0;
            // 
            // guna2ComboBoxSortBy
            // 
            this.guna2ComboBoxSortBy.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBoxSortBy.BorderRadius = 10;
            this.guna2ComboBoxSortBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBoxSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBoxSortBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBoxSortBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBoxSortBy.Font = new System.Drawing.Font("Cerebri Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ComboBoxSortBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBoxSortBy.ItemHeight = 35;
            this.guna2ComboBoxSortBy.Items.AddRange(new object[] {
            "Latest",
            "Popular"});
            this.guna2ComboBoxSortBy.Location = new System.Drawing.Point(57, 119);
            this.guna2ComboBoxSortBy.Name = "guna2ComboBoxSortBy";
            this.guna2ComboBoxSortBy.Size = new System.Drawing.Size(158, 41);
            this.guna2ComboBoxSortBy.TabIndex = 1;
            this.guna2ComboBoxSortBy.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBoxTime_SelectedIndexChanged);
            // 
            // guna2ComboBoxCategory
            // 
            this.guna2ComboBoxCategory.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBoxCategory.BorderRadius = 10;
            this.guna2ComboBoxCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBoxCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBoxCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBoxCategory.Font = new System.Drawing.Font("Cerebri Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ComboBoxCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBoxCategory.ItemHeight = 35;
            this.guna2ComboBoxCategory.Location = new System.Drawing.Point(57, 203);
            this.guna2ComboBoxCategory.Name = "guna2ComboBoxCategory";
            this.guna2ComboBoxCategory.Size = new System.Drawing.Size(158, 41);
            this.guna2ComboBoxCategory.TabIndex = 2;
            this.guna2ComboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBoxCategory_SelectedIndexChanged);
            // 
            // textBoxSortBy
            // 
            this.textBoxSortBy.BackColor = System.Drawing.Color.White;
            this.textBoxSortBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSortBy.Font = new System.Drawing.Font("Cerebri Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSortBy.Location = new System.Drawing.Point(44, 86);
            this.textBoxSortBy.Name = "textBoxSortBy";
            this.textBoxSortBy.ReadOnly = true;
            this.textBoxSortBy.Size = new System.Drawing.Size(185, 27);
            this.textBoxSortBy.TabIndex = 3;
            this.textBoxSortBy.Text = "Sort by:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Cerebri Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(44, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(185, 27);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Category:";
            // 
            // guna2PanelSort
            // 
            this.guna2PanelSort.BackColor = System.Drawing.Color.White;
            this.guna2PanelSort.Location = new System.Drawing.Point(22, 74);
            this.guna2PanelSort.Name = "guna2PanelSort";
            this.guna2PanelSort.Size = new System.Drawing.Size(218, 230);
            this.guna2PanelSort.TabIndex = 4;
            // 
            // guna2ElipsePanelSort
            // 
            this.guna2ElipsePanelSort.BorderRadius = 20;
            this.guna2ElipsePanelSort.TargetControl = this.guna2PanelSort;
            // 
            // EMF_Movies
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxSortBy);
            this.Controls.Add(this.guna2VScrollBar1);
            this.Controls.Add(this.guna2ComboBoxCategory);
            this.Controls.Add(this.guna2ComboBoxSortBy);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.guna2PanelSort);
            this.Name = "EMF_Movies";
            this.Size = new System.Drawing.Size(1260, 750);
            this.Load += new System.EventHandler(this.Movies_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBoxSortBy;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBoxCategory;
        private System.Windows.Forms.TextBox textBoxSortBy;
        private System.Windows.Forms.TextBox textBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelSort;
        private Guna.UI2.WinForms.Guna2Elipse guna2ElipsePanelSort;
    }
}
