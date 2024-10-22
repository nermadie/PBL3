using System.Windows.Forms;

namespace PBL3.GUI.GUI_MainForm.GUI_Employee
{
    partial class EmployeeMainForm
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
            Guna.UI2.AnimatorNS.Animation animation4 = new Guna.UI2.AnimatorNS.Animation();
            Guna.UI2.AnimatorNS.Animation animation3 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeMainForm));
            this.shadowPanelPopup = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.buttonEdit = new Guna.UI2.WinForms.Guna2Button();
            this.panelTitle = new Guna.UI2.WinForms.Guna2Panel();
            this.panelPrint = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelCheck = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.labelCheck = new System.Windows.Forms.Label();
            this.panelBuyTicket = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPrintTicket = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2ControlBoxMin = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBoxMax = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelNav = new Guna.UI2.WinForms.Guna2Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.guna2TransitionOpenPopup = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2TransitionClosePopup = new Guna.UI2.WinForms.Guna2Transition();
            this.buttonClosePopup = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonLogout = new Guna.UI2.WinForms.Guna2Button();
            this.buttonShowtimes = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.buttonMovies = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.buttonPopDrinks = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.buttonPayment = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.buttonCheckCode = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.buttonCart = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.textBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.circlePictureBoxOpenPopup = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.circlePictureBoxUser = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBoxLogo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.shadowPanelPopup.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panelPrint.SuspendLayout();
            this.panelCheck.SuspendLayout();
            this.panelBuyTicket.SuspendLayout();
            this.panelNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circlePictureBoxOpenPopup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circlePictureBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            //
            // shadowPanelPopup
            //
            this.shadowPanelPopup.BackColor = System.Drawing.Color.Transparent;
            this.shadowPanelPopup.Controls.Add(this.buttonClosePopup);
            this.shadowPanelPopup.Controls.Add(this.guna2ButtonLogout);
            this.shadowPanelPopup.Controls.Add(this.buttonEdit);
            this.guna2TransitionClosePopup.SetDecoration(this.shadowPanelPopup, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TransitionOpenPopup.SetDecoration(this.shadowPanelPopup, Guna.UI2.AnimatorNS.DecorationType.None);
            this.shadowPanelPopup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.shadowPanelPopup.Location = new System.Drawing.Point(72, 758);
            this.shadowPanelPopup.Name = "shadowPanelPopup";
            this.shadowPanelPopup.Radius = 10;
            this.shadowPanelPopup.ShadowColor = System.Drawing.Color.Black;
            this.shadowPanelPopup.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.shadowPanelPopup.Size = new System.Drawing.Size(228, 57);
            this.shadowPanelPopup.TabIndex = 0;
            //
            // buttonEdit
            //
            this.buttonEdit.Animated = true;
            this.buttonEdit.BorderRadius = 5;
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TransitionClosePopup.SetDecoration(this.buttonEdit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TransitionOpenPopup.SetDecoration(this.buttonEdit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.buttonEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(196)))), ((int)(((byte)(138)))));
            this.buttonEdit.Font = new System.Drawing.Font("Cerebri Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(25, 8);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(116, 32);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Edit profile";
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            //
            // panelTitle
            //
            this.panelTitle.BackColor = System.Drawing.Color.White;
            this.panelTitle.Controls.Add(this.panelPrint);
            this.panelTitle.Controls.Add(this.panelCheck);
            this.panelTitle.Controls.Add(this.panelBuyTicket);
            this.panelTitle.Controls.Add(this.buttonShowtimes);
            this.panelTitle.Controls.Add(this.buttonMovies);
            this.panelTitle.Controls.Add(this.buttonPopDrinks);
            this.panelTitle.Controls.Add(this.buttonPayment);
            this.panelTitle.Controls.Add(this.buttonPrintTicket);
            this.panelTitle.Controls.Add(this.buttonCheckCode);
            this.panelTitle.Controls.Add(this.buttonCart);
            this.panelTitle.Controls.Add(this.textBoxSearch);
            this.panelTitle.Controls.Add(this.guna2ControlBoxMin);
            this.panelTitle.Controls.Add(this.guna2ControlBoxMax);
            this.panelTitle.Controls.Add(this.guna2ControlBoxClose);
            this.guna2TransitionClosePopup.SetDecoration(this.panelTitle, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TransitionOpenPopup.SetDecoration(this.panelTitle, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(90, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.ShadowDecoration.BorderRadius = 10;
            this.panelTitle.Size = new System.Drawing.Size(1260, 75);
            this.panelTitle.TabIndex = 1;
            //
            // panelPrint
            //
            this.panelPrint.BorderRadius = 7;
            this.panelPrint.Controls.Add(this.label3);
            this.guna2TransitionClosePopup.SetDecoration(this.panelPrint, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TransitionOpenPopup.SetDecoration(this.panelPrint, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(233)))), ((int)(((byte)(214)))));
            this.panelPrint.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(174)))), ((int)(((byte)(230)))));
            this.panelPrint.Location = new System.Drawing.Point(895, 0);
            this.panelPrint.Name = "panelPrint";
            this.panelPrint.Size = new System.Drawing.Size(140, 23);
            this.panelPrint.TabIndex = 8;
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.guna2TransitionOpenPopup.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TransitionClosePopup.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Cerebri Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Print Ticket";
            //
            // panelCheck
            //
            this.panelCheck.BorderRadius = 7;
            this.panelCheck.Controls.Add(this.labelCheck);
            this.guna2TransitionClosePopup.SetDecoration(this.panelCheck, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TransitionOpenPopup.SetDecoration(this.panelCheck, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelCheck.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(124)))));
            this.panelCheck.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(50)))), ((int)(((byte)(95)))));
            this.panelCheck.Location = new System.Drawing.Point(749, 0);
            this.panelCheck.Name = "panelCheck";
            this.panelCheck.Size = new System.Drawing.Size(140, 23);
            this.panelCheck.TabIndex = 7;
            //
            // labelCheck
            //
            this.labelCheck.AutoSize = true;
            this.labelCheck.BackColor = System.Drawing.Color.Transparent;
            this.guna2TransitionOpenPopup.SetDecoration(this.labelCheck, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TransitionClosePopup.SetDecoration(this.labelCheck, Guna.UI2.AnimatorNS.DecorationType.None);
            this.labelCheck.Font = new System.Drawing.Font("Cerebri Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheck.ForeColor = System.Drawing.Color.White;
            this.labelCheck.Location = new System.Drawing.Point(41, 0);
            this.labelCheck.Name = "labelCheck";
            this.labelCheck.Size = new System.Drawing.Size(59, 21);
            this.labelCheck.TabIndex = 0;
            this.labelCheck.Text = "Check";
            //
            // panelBuyTicket
            //
            this.panelBuyTicket.BorderRadius = 7;
            this.panelBuyTicket.Controls.Add(this.label1);
            this.guna2TransitionClosePopup.SetDecoration(this.panelBuyTicket, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TransitionOpenPopup.SetDecoration(this.panelBuyTicket, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelBuyTicket.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panelBuyTicket.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.panelBuyTicket.Location = new System.Drawing.Point(19, 0);
            this.panelBuyTicket.Name = "panelBuyTicket";
            this.panelBuyTicket.Size = new System.Drawing.Size(724, 23);
            this.panelBuyTicket.TabIndex = 6;
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.guna2TransitionOpenPopup.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TransitionClosePopup.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Cerebri Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(259, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buy tickets at the counter";
            //
            // buttonPrintTicket
            //
            this.buttonPrintTicket.Animated = true;
            this.buttonPrintTicket.BorderRadius = 10;
            this.buttonPrintTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TransitionClosePopup.SetDecoration(this.buttonPrintTicket, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TransitionOpenPopup.SetDecoration(this.buttonPrintTicket, Guna.UI2.AnimatorNS.DecorationType.None);
            this.buttonPrintTicket.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonPrintTicket.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonPrintTicket.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonPrintTicket.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonPrintTicket.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.buttonPrintTicket.FillColor = System.Drawing.Color.Empty;
            this.buttonPrintTicket.FillColor2 = System.Drawing.Color.Empty;
            this.buttonPrintTicket.Font = new System.Drawing.Font("Cerebri Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintTicket.ForeColor = System.Drawing.Color.Black;
            this.buttonPrintTicket.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(233)))), ((int)(((byte)(214)))));
            this.buttonPrintTicket.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(174)))), ((int)(((byte)(230)))));
            this.buttonPrintTicket.HoverState.ForeColor = System.Drawing.Color.White;
            this.buttonPrintTicket.HoverState.Image = global::PBL3.Properties.Resources.printer_color;
            this.buttonPrintTicket.Image = global::PBL3.Properties.Resources.printer;
            this.buttonPrintTicket.ImageSize = new System.Drawing.Size(24, 24);
            this.buttonPrintTicket.Location = new System.Drawing.Point(895, 18);
            this.buttonPrintTicket.Name = "buttonPrintTicket";
            this.buttonPrintTicket.Size = new System.Drawing.Size(140, 57);
            this.buttonPrintTicket.TabIndex = 1;
            this.buttonPrintTicket.Text = "Print Ticket";
            this.buttonPrintTicket.Click += new System.EventHandler(this.buttonPrintTicket_Click);
            //
            // guna2ControlBoxMin
            //
            this.guna2ControlBoxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBoxMin.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBoxMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBoxMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TransitionClosePopup.SetDecoration(this.guna2ControlBoxMin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TransitionOpenPopup.SetDecoration(this.guna2ControlBoxMin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBoxMin.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBoxMin.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBoxMin.Location = new System.Drawing.Point(1113, 0);
            this.guna2ControlBoxMin.Name = "guna2ControlBoxMin";
            this.guna2ControlBoxMin.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBoxMin.TabIndex = 4;
            //
            // guna2ControlBoxMax
            //
            this.guna2ControlBoxMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBoxMax.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBoxMax.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBoxMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TransitionClosePopup.SetDecoration(this.guna2ControlBoxMax, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TransitionOpenPopup.SetDecoration(this.guna2ControlBoxMax, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBoxMax.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBoxMax.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBoxMax.Location = new System.Drawing.Point(1164, 0);
            this.guna2ControlBoxMax.Name = "guna2ControlBoxMax";
            this.guna2ControlBoxMax.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBoxMax.TabIndex = 4;
            //
            // guna2ControlBoxClose
            //
            this.guna2ControlBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TransitionClosePopup.SetDecoration(this.guna2ControlBoxClose, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TransitionOpenPopup.SetDecoration(this.guna2ControlBoxClose, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBoxClose.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBoxClose.ForeColor = System.Drawing.Color.Black;
            this.guna2ControlBoxClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2ControlBoxClose.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBoxClose.Location = new System.Drawing.Point(1215, 0);
            this.guna2ControlBoxClose.Name = "guna2ControlBoxClose";
            this.guna2ControlBoxClose.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBoxClose.TabIndex = 4;
            this.guna2ControlBoxClose.Click += new System.EventHandler(this.guna2ControlBoxClose_Click);
            //
            // guna2Elipse1
            //
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            //
            // guna2ShadowForm1
            //
            this.guna2ShadowForm1.TargetForm = this;
            //
            // guna2DragControl1
            //
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panelTitle;
            this.guna2DragControl1.UseTransparentDrag = true;
            //
            // panelNav
            //
            this.panelNav.BackColor = System.Drawing.Color.White;
            this.panelNav.Controls.Add(this.circlePictureBoxOpenPopup);
            this.panelNav.Controls.Add(this.circlePictureBoxUser);
            this.panelNav.Controls.Add(this.guna2CirclePictureBoxLogo);
            this.guna2TransitionClosePopup.SetDecoration(this.panelNav, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TransitionOpenPopup.SetDecoration(this.panelNav, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Margin = new System.Windows.Forms.Padding(4);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(90, 825);
            this.panelNav.TabIndex = 0;
            //
            // panelCenter
            //
            this.guna2TransitionClosePopup.SetDecoration(this.panelCenter, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TransitionOpenPopup.SetDecoration(this.panelCenter, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(90, 75);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1260, 750);
            this.panelCenter.TabIndex = 2;
            //
            // guna2TransitionOpenPopup
            //
            this.guna2TransitionOpenPopup.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.guna2TransitionOpenPopup.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.guna2TransitionOpenPopup.DefaultAnimation = animation4;
            this.guna2TransitionOpenPopup.TimeStep = 0.05F;
            //
            // guna2TransitionClosePopup
            //
            this.guna2TransitionClosePopup.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.guna2TransitionClosePopup.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.guna2TransitionClosePopup.DefaultAnimation = animation3;
            this.guna2TransitionClosePopup.TimeStep = 0.05F;
            //
            // buttonClosePopup
            //
            this.buttonClosePopup.Animated = true;
            this.buttonClosePopup.BackgroundImage = global::PBL3.Properties.Resources.record;
            this.buttonClosePopup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClosePopup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TransitionClosePopup.SetDecoration(this.buttonClosePopup, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TransitionOpenPopup.SetDecoration(this.buttonClosePopup, Guna.UI2.AnimatorNS.DecorationType.None);
            this.buttonClosePopup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonClosePopup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonClosePopup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonClosePopup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonClosePopup.FillColor = System.Drawing.Color.Transparent;
            this.buttonClosePopup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonClosePopup.ForeColor = System.Drawing.Color.White;
            this.buttonClosePopup.Location = new System.Drawing.Point(199, 17);
            this.buttonClosePopup.Name = "buttonClosePopup";
            this.buttonClosePopup.Size = new System.Drawing.Size(15, 15);
            this.buttonClosePopup.TabIndex = 4;
            this.buttonClosePopup.Click += new System.EventHandler(this.buttonClosePopup_Click);
            //
            // guna2ButtonLogout
            //
            this.guna2ButtonLogout.Animated = true;
            this.guna2ButtonLogout.BackgroundImage = global::PBL3.Properties.Resources.logout;
            this.guna2ButtonLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2ButtonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TransitionClosePopup.SetDecoration(this.guna2ButtonLogout, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TransitionOpenPopup.SetDecoration(this.guna2ButtonLogout, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ButtonLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonLogout.FillColor = System.Drawing.Color.Transparent;
            this.guna2ButtonLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonLogout.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonLogout.Location = new System.Drawing.Point(158, 11);
            this.guna2ButtonLogout.Name = "guna2ButtonLogout";
            this.guna2ButtonLogout.Size = new System.Drawing.Size(27, 27);
            this.guna2ButtonLogout.TabIndex = 4;
            this.guna2ButtonLogout.Click += new System.EventHandler(this.guna2ButtonLogout_Click);
            //
            // buttonShowtimes
            //
            this.buttonShowtimes.Animated = true;
            this.buttonShowtimes.BorderRadius = 10;
            this.buttonShowtimes.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.buttonShowtimes.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.buttonShowtimes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TransitionClosePopup.SetDecoration(this.buttonShowtimes, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TransitionOpenPopup.SetDecoration(this.buttonShowtimes, Guna.UI2.AnimatorNS.DecorationType.None);
            this.buttonShowtimes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonShowtimes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonShowtimes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonShowtimes.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonShowtimes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonShowtimes.FillColor = System.Drawing.Color.Empty;
            this.buttonShowtimes.FillColor2 = System.Drawing.Color.Empty;
            this.buttonShowtimes.Font = new System.Drawing.Font("Cerebri Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowtimes.ForeColor = System.Drawing.Color.Black;
            this.buttonShowtimes.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.buttonShowtimes.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.buttonShowtimes.HoverState.ForeColor = System.Drawing.Color.White;
            this.buttonShowtimes.HoverState.Image = global::PBL3.Properties.Resources.showtime_color;
            this.buttonShowtimes.Image = global::PBL3.Properties.Resources.showtime;
            this.buttonShowtimes.ImageSize = new System.Drawing.Size(24, 24);
            this.buttonShowtimes.Location = new System.Drawing.Point(19, 18);
            this.buttonShowtimes.Name = "buttonShowtimes";
            this.buttonShowtimes.Size = new System.Drawing.Size(140, 57);
            this.buttonShowtimes.TabIndex = 1;
            this.buttonShowtimes.Text = "Showtimes";
            this.buttonShowtimes.Click += new System.EventHandler(this.buttonShowtimes_Click);
            //
            // buttonMovies
            //
            this.buttonMovies.Animated = true;
            this.buttonMovies.BorderRadius = 10;
            this.buttonMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TransitionClosePopup.SetDecoration(this.buttonMovies, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TransitionOpenPopup.SetDecoration(this.buttonMovies, Guna.UI2.AnimatorNS.DecorationType.None);
            this.buttonMovies.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonMovies.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonMovies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonMovies.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonMovies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonMovies.FillColor = System.Drawing.Color.Empty;
            this.buttonMovies.FillColor2 = System.Drawing.Color.Empty;
            this.buttonMovies.Font = new System.Drawing.Font("Cerebri Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMovies.ForeColor = System.Drawing.Color.Black;
            this.buttonMovies.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.buttonMovies.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.buttonMovies.HoverState.ForeColor = System.Drawing.Color.White;
            this.buttonMovies.HoverState.Image = global::PBL3.Properties.Resources.movie_color;
            this.buttonMovies.Image = global::PBL3.Properties.Resources.movie;
            this.buttonMovies.ImageSize = new System.Drawing.Size(24, 24);
            this.buttonMovies.Location = new System.Drawing.Point(165, 18);
            this.buttonMovies.Name = "buttonMovies";
            this.buttonMovies.Size = new System.Drawing.Size(140, 57);
            this.buttonMovies.TabIndex = 1;
            this.buttonMovies.Text = "Movies";
            this.buttonMovies.Click += new System.EventHandler(this.buttonMovies_Click);
            //
            // buttonPopDrinks
            //
            this.buttonPopDrinks.Animated = true;
            this.buttonPopDrinks.BorderRadius = 10;
            this.buttonPopDrinks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TransitionClosePopup.SetDecoration(this.buttonPopDrinks, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TransitionOpenPopup.SetDecoration(this.buttonPopDrinks, Guna.UI2.AnimatorNS.DecorationType.None);
            this.buttonPopDrinks.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonPopDrinks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonPopDrinks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonPopDrinks.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonPopDrinks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonPopDrinks.FillColor = System.Drawing.Color.Empty;
            this.buttonPopDrinks.FillColor2 = System.Drawing.Color.Empty;
            this.buttonPopDrinks.Font = new System.Drawing.Font("Cerebri Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPopDrinks.ForeColor = System.Drawing.Color.Black;
            this.buttonPopDrinks.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.buttonPopDrinks.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.buttonPopDrinks.HoverState.ForeColor = System.Drawing.Color.White;
            this.buttonPopDrinks.HoverState.Image = global::PBL3.Properties.Resources.popcorn_color;
            this.buttonPopDrinks.Image = global::PBL3.Properties.Resources.popcorn;
            this.buttonPopDrinks.ImageSize = new System.Drawing.Size(24, 24);
            this.buttonPopDrinks.Location = new System.Drawing.Point(311, 18);
            this.buttonPopDrinks.Name = "buttonPopDrinks";
            this.buttonPopDrinks.Size = new System.Drawing.Size(140, 57);
            this.buttonPopDrinks.TabIndex = 1;
            this.buttonPopDrinks.Text = "Popcorn/Drinks";
            this.buttonPopDrinks.Click += new System.EventHandler(this.buttonPopDrinks_Click);
            //
            // buttonPayment
            //
            this.buttonPayment.Animated = true;
            this.buttonPayment.BorderRadius = 10;
            this.buttonPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TransitionClosePopup.SetDecoration(this.buttonPayment, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TransitionOpenPopup.SetDecoration(this.buttonPayment, Guna.UI2.AnimatorNS.DecorationType.None);
            this.buttonPayment.DisabledState.BorderColor = System.Drawing.Color.White;
            this.buttonPayment.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonPayment.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonPayment.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.buttonPayment.FillColor = System.Drawing.Color.Empty;
            this.buttonPayment.FillColor2 = System.Drawing.Color.Empty;
            this.buttonPayment.Font = new System.Drawing.Font("Cerebri Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPayment.ForeColor = System.Drawing.Color.Black;
            this.buttonPayment.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.buttonPayment.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.buttonPayment.HoverState.ForeColor = System.Drawing.Color.White;
            this.buttonPayment.HoverState.Image = global::PBL3.Properties.Resources.cashless_payment_color;
            this.buttonPayment.Image = global::PBL3.Properties.Resources.cashless_payment;
            this.buttonPayment.ImageSize = new System.Drawing.Size(24, 24);
            this.buttonPayment.Location = new System.Drawing.Point(603, 18);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(140, 57);
            this.buttonPayment.TabIndex = 1;
            this.buttonPayment.Text = "Payment";
            //
            // buttonCheckCode
            //
            this.buttonCheckCode.Animated = true;
            this.buttonCheckCode.BorderRadius = 10;
            this.buttonCheckCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TransitionClosePopup.SetDecoration(this.buttonCheckCode, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TransitionOpenPopup.SetDecoration(this.buttonCheckCode, Guna.UI2.AnimatorNS.DecorationType.None);
            this.buttonCheckCode.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonCheckCode.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonCheckCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonCheckCode.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonCheckCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonCheckCode.FillColor = System.Drawing.Color.Empty;
            this.buttonCheckCode.FillColor2 = System.Drawing.Color.Empty;
            this.buttonCheckCode.Font = new System.Drawing.Font("Cerebri Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckCode.ForeColor = System.Drawing.Color.Black;
            this.buttonCheckCode.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(124)))));
            this.buttonCheckCode.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(50)))), ((int)(((byte)(95)))));
            this.buttonCheckCode.HoverState.ForeColor = System.Drawing.Color.White;
            this.buttonCheckCode.HoverState.Image = global::PBL3.Properties.Resources.code_color;
            this.buttonCheckCode.Image = global::PBL3.Properties.Resources.code;
            this.buttonCheckCode.ImageSize = new System.Drawing.Size(24, 24);
            this.buttonCheckCode.Location = new System.Drawing.Point(749, 18);
            this.buttonCheckCode.Name = "buttonCheckCode";
            this.buttonCheckCode.Size = new System.Drawing.Size(140, 57);
            this.buttonCheckCode.TabIndex = 1;
            this.buttonCheckCode.Text = "Check Code";
            this.buttonCheckCode.Click += new System.EventHandler(this.buttonCheckCode_Click);
            //
            // buttonCart
            //
            this.buttonCart.Animated = true;
            this.buttonCart.BorderRadius = 10;
            this.buttonCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TransitionClosePopup.SetDecoration(this.buttonCart, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TransitionOpenPopup.SetDecoration(this.buttonCart, Guna.UI2.AnimatorNS.DecorationType.None);
            this.buttonCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonCart.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonCart.FillColor = System.Drawing.Color.Empty;
            this.buttonCart.FillColor2 = System.Drawing.Color.Empty;
            this.buttonCart.Font = new System.Drawing.Font("Cerebri Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCart.ForeColor = System.Drawing.Color.Black;
            this.buttonCart.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.buttonCart.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.buttonCart.HoverState.ForeColor = System.Drawing.Color.White;
            this.buttonCart.HoverState.Image = global::PBL3.Properties.Resources.shopping_cart_color;
            this.buttonCart.Image = global::PBL3.Properties.Resources.shopping_cart;
            this.buttonCart.ImageSize = new System.Drawing.Size(24, 24);
            this.buttonCart.Location = new System.Drawing.Point(457, 18);
            this.buttonCart.Name = "buttonCart";
            this.buttonCart.Size = new System.Drawing.Size(140, 57);
            this.buttonCart.TabIndex = 1;
            this.buttonCart.Text = "Cart";
            this.buttonCart.Click += new System.EventHandler(this.buttonCart_Click);
            //
            // textBoxSearch
            //
            this.textBoxSearch.BorderRadius = 18;
            this.textBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TransitionClosePopup.SetDecoration(this.textBoxSearch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TransitionOpenPopup.SetDecoration(this.textBoxSearch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.textBoxSearch.DefaultText = "";
            this.textBoxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSearch.Font = new System.Drawing.Font("Cerebri Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSearch.IconLeft = global::PBL3.Properties.Resources.search_symbol;
            this.textBoxSearch.Location = new System.Drawing.Point(1076, 36);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PasswordChar = '\0';
            this.textBoxSearch.PlaceholderText = "Search";
            this.textBoxSearch.SelectedText = "";
            this.textBoxSearch.Size = new System.Drawing.Size(171, 32);
            this.textBoxSearch.TabIndex = 5;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            //
            // circlePictureBoxOpenPopup
            //
            this.guna2TransitionClosePopup.SetDecoration(this.circlePictureBoxOpenPopup, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TransitionOpenPopup.SetDecoration(this.circlePictureBoxOpenPopup, Guna.UI2.AnimatorNS.DecorationType.None);
            this.circlePictureBoxOpenPopup.Image = global::PBL3.Properties.Resources.next;
            this.circlePictureBoxOpenPopup.ImageRotate = 0F;
            this.circlePictureBoxOpenPopup.Location = new System.Drawing.Point(30, 766);
            this.circlePictureBoxOpenPopup.Name = "circlePictureBoxOpenPopup";
            this.circlePictureBoxOpenPopup.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.circlePictureBoxOpenPopup.Size = new System.Drawing.Size(32, 32);
            this.circlePictureBoxOpenPopup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circlePictureBoxOpenPopup.TabIndex = 1;
            this.circlePictureBoxOpenPopup.TabStop = false;
            this.circlePictureBoxOpenPopup.Click += new System.EventHandler(this.circlePictureBoxOpenPopup_Click);
            //
            // circlePictureBoxUser
            //
            this.guna2TransitionClosePopup.SetDecoration(this.circlePictureBoxUser, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TransitionOpenPopup.SetDecoration(this.circlePictureBoxUser, Guna.UI2.AnimatorNS.DecorationType.None);
            this.circlePictureBoxUser.ErrorImage = global::PBL3.Properties.Resources.user;
            this.circlePictureBoxUser.Image = global::PBL3.Properties.Resources.user;
            this.circlePictureBoxUser.ImageRotate = 0F;
            this.circlePictureBoxUser.Location = new System.Drawing.Point(19, 693);
            this.circlePictureBoxUser.Name = "circlePictureBoxUser";
            this.circlePictureBoxUser.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.circlePictureBoxUser.Size = new System.Drawing.Size(55, 55);
            this.circlePictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circlePictureBoxUser.TabIndex = 1;
            this.circlePictureBoxUser.TabStop = false;
            //
            // guna2CirclePictureBoxLogo
            //
            this.guna2CirclePictureBoxLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TransitionClosePopup.SetDecoration(this.guna2CirclePictureBoxLogo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TransitionOpenPopup.SetDecoration(this.guna2CirclePictureBoxLogo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2CirclePictureBoxLogo.Image = global::PBL3.Properties.Resources.Employee_Icon;
            this.guna2CirclePictureBoxLogo.ImageRotate = 0F;
            this.guna2CirclePictureBoxLogo.Location = new System.Drawing.Point(21, 12);
            this.guna2CirclePictureBoxLogo.Name = "guna2CirclePictureBoxLogo";
            this.guna2CirclePictureBoxLogo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBoxLogo.Size = new System.Drawing.Size(50, 50);
            this.guna2CirclePictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBoxLogo.TabIndex = 0;
            this.guna2CirclePictureBoxLogo.TabStop = false;
            this.guna2CirclePictureBoxLogo.Click += new System.EventHandler(this.guna2CirclePictureBoxLogo_Click);
            //
            // EmployeeMainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 825);
            this.Controls.Add(this.shadowPanelPopup);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelNav);
            this.guna2TransitionClosePopup.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TransitionOpenPopup.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Cerebri Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserMainForm";
            this.shadowPanelPopup.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelPrint.ResumeLayout(false);
            this.panelPrint.PerformLayout();
            this.panelCheck.ResumeLayout(false);
            this.panelCheck.PerformLayout();
            this.panelBuyTicket.ResumeLayout(false);
            this.panelBuyTicket.PerformLayout();
            this.panelNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circlePictureBoxOpenPopup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circlePictureBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panelTitle;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBoxMin;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBoxMax;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBoxClose;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSearch;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBoxLogo;
        private Guna.UI2.WinForms.Guna2GradientTileButton buttonCart;
        private Guna.UI2.WinForms.Guna2GradientTileButton buttonMovies;
        private Guna.UI2.WinForms.Guna2GradientTileButton buttonPopDrinks;
        private Guna.UI2.WinForms.Guna2CirclePictureBox circlePictureBoxUser;
        private Guna.UI2.WinForms.Guna2GradientTileButton buttonShowtimes;
        private Guna.UI2.WinForms.Guna2CirclePictureBox circlePictureBoxOpenPopup;
        private Guna.UI2.WinForms.Guna2ShadowPanel shadowPanelPopup;
        private Guna.UI2.WinForms.Guna2Button buttonEdit;
        private Guna.UI2.WinForms.Guna2Button buttonClosePopup;
        private Guna.UI2.WinForms.Guna2Panel panelNav;
        private Panel panelCenter;
        private Guna.UI2.WinForms.Guna2GradientTileButton buttonPayment;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonLogout;
        private Guna.UI2.WinForms.Guna2GradientPanel panelBuyTicket;
        private Label label1;
        private Guna.UI2.WinForms.Guna2GradientPanel panelCheck;
        private Label labelCheck;
        private Guna.UI2.WinForms.Guna2GradientPanel panelPrint;
        private Label label3;
        private Guna.UI2.WinForms.Guna2GradientTileButton buttonPrintTicket;
        private Guna.UI2.WinForms.Guna2GradientTileButton buttonCheckCode;
        private Guna.UI2.WinForms.Guna2Transition guna2TransitionOpenPopup;
        private Guna.UI2.WinForms.Guna2Transition guna2TransitionClosePopup;
    }
}