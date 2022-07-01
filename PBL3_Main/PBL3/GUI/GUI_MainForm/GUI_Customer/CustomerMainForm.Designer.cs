﻿using System.Windows.Forms;

namespace PBL3.GUI.GUI_MainForm.GUI_Customer
{
    partial class CustomerMainForm
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
                Application.Exit();
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
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMainForm));
            this.shadowPanelPopup = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.buttonEdit = new Guna.UI2.WinForms.Guna2Button();
            this.panelTitle = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBoxMin = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBoxMax = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2TransitionOpenPopup = new Guna.UI2.WinForms.Guna2Transition();
            this.panelNav = new Guna.UI2.WinForms.Guna2Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.guna2TransitionClosePopup = new Guna.UI2.WinForms.Guna2Transition();
            this.buttonClosePopup = new Guna.UI2.WinForms.Guna2Button();
            this.buttonHistory = new Guna.UI2.WinForms.Guna2Button();
            this.buttonHelp = new Guna.UI2.WinForms.Guna2Button();
            this.buttonShowtimes = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.buttonMovies = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.buttonPopDrinks = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.ButtonTickets = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.buttonPurchased = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.textBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.circlePictureBoxOpenPopup = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.circlePictureBoxUser = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBoxLogo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.shadowPanelPopup.SuspendLayout();
            this.panelTitle.SuspendLayout();
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
            this.shadowPanelPopup.Controls.Add(this.buttonHistory);
            this.shadowPanelPopup.Controls.Add(this.buttonHelp);
            this.shadowPanelPopup.Controls.Add(this.buttonEdit);
            this.guna2TransitionClosePopup.SetDecoration(this.shadowPanelPopup, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TransitionOpenPopup.SetDecoration(this.shadowPanelPopup, Guna.UI2.AnimatorNS.DecorationType.None);
            this.shadowPanelPopup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.shadowPanelPopup.Location = new System.Drawing.Point(72, 758);
            this.shadowPanelPopup.Name = "shadowPanelPopup";
            this.shadowPanelPopup.Radius = 10;
            this.shadowPanelPopup.ShadowColor = System.Drawing.Color.Black;
            this.shadowPanelPopup.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.shadowPanelPopup.Size = new System.Drawing.Size(292, 57);
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
            this.buttonEdit.Location = new System.Drawing.Point(115, 7);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(116, 32);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Edit profile";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.White;
            this.panelTitle.Controls.Add(this.buttonShowtimes);
            this.panelTitle.Controls.Add(this.buttonMovies);
            this.panelTitle.Controls.Add(this.buttonPopDrinks);
            this.panelTitle.Controls.Add(this.ButtonTickets);
            this.panelTitle.Controls.Add(this.buttonPurchased);
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
            // guna2TransitionOpenPopup
            // 
            this.guna2TransitionOpenPopup.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.guna2TransitionOpenPopup.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.guna2TransitionOpenPopup.DefaultAnimation = animation2;
            this.guna2TransitionOpenPopup.TimeStep = 0.05F;
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
            // guna2TransitionClosePopup
            // 
            this.guna2TransitionClosePopup.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.guna2TransitionClosePopup.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2TransitionClosePopup.DefaultAnimation = animation1;
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
            this.buttonClosePopup.Location = new System.Drawing.Point(264, 16);
            this.buttonClosePopup.Name = "buttonClosePopup";
            this.buttonClosePopup.Size = new System.Drawing.Size(15, 15);
            this.buttonClosePopup.TabIndex = 4;
            this.buttonClosePopup.Click += new System.EventHandler(this.buttonClosePopup_Click);
            // 
            // buttonHistory
            // 
            this.buttonHistory.Animated = true;
            this.buttonHistory.BackgroundImage = global::PBL3.Properties.Resources.parchment;
            this.buttonHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TransitionClosePopup.SetDecoration(this.buttonHistory, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TransitionOpenPopup.SetDecoration(this.buttonHistory, Guna.UI2.AnimatorNS.DecorationType.None);
            this.buttonHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonHistory.FillColor = System.Drawing.Color.Transparent;
            this.buttonHistory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonHistory.ForeColor = System.Drawing.Color.White;
            this.buttonHistory.Location = new System.Drawing.Point(69, 7);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(32, 32);
            this.buttonHistory.TabIndex = 4;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Animated = true;
            this.buttonHelp.BackgroundImage = global::PBL3.Properties.Resources.help_desk;
            this.buttonHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TransitionClosePopup.SetDecoration(this.buttonHelp, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TransitionOpenPopup.SetDecoration(this.buttonHelp, Guna.UI2.AnimatorNS.DecorationType.None);
            this.buttonHelp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonHelp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonHelp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonHelp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonHelp.FillColor = System.Drawing.Color.Transparent;
            this.buttonHelp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonHelp.ForeColor = System.Drawing.Color.White;
            this.buttonHelp.Location = new System.Drawing.Point(23, 7);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(32, 32);
            this.buttonHelp.TabIndex = 4;
            // 
            // buttonShowtimes
            // 
            this.buttonShowtimes.Animated = true;
            this.buttonShowtimes.BorderRadius = 10;
            this.buttonShowtimes.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.buttonShowtimes.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.buttonShowtimes.CheckedState.Image = global::PBL3.Properties.Resources.movie_ticket_color;
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
            this.buttonShowtimes.ImageSize = new System.Drawing.Size(35, 35);
            this.buttonShowtimes.Location = new System.Drawing.Point(51, 0);
            this.buttonShowtimes.Name = "buttonShowtimes";
            this.buttonShowtimes.Size = new System.Drawing.Size(140, 75);
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
            this.buttonMovies.ImageSize = new System.Drawing.Size(35, 35);
            this.buttonMovies.Location = new System.Drawing.Point(197, 0);
            this.buttonMovies.Name = "buttonMovies";
            this.buttonMovies.Size = new System.Drawing.Size(140, 75);
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
            this.buttonPopDrinks.ImageSize = new System.Drawing.Size(35, 35);
            this.buttonPopDrinks.Location = new System.Drawing.Point(343, 0);
            this.buttonPopDrinks.Name = "buttonPopDrinks";
            this.buttonPopDrinks.Size = new System.Drawing.Size(140, 75);
            this.buttonPopDrinks.TabIndex = 1;
            this.buttonPopDrinks.Text = "Popcorn/Drinks";
            this.buttonPopDrinks.Click += new System.EventHandler(this.buttonPopDrinks_Click);
            // 
            // ButtonTickets
            // 
            this.ButtonTickets.Animated = true;
            this.ButtonTickets.BorderRadius = 10;
            this.ButtonTickets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TransitionClosePopup.SetDecoration(this.ButtonTickets, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TransitionOpenPopup.SetDecoration(this.ButtonTickets, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ButtonTickets.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonTickets.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonTickets.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonTickets.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonTickets.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonTickets.FillColor = System.Drawing.Color.Empty;
            this.ButtonTickets.FillColor2 = System.Drawing.Color.Empty;
            this.ButtonTickets.Font = new System.Drawing.Font("Cerebri Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTickets.ForeColor = System.Drawing.Color.Black;
            this.ButtonTickets.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ButtonTickets.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.ButtonTickets.HoverState.ForeColor = System.Drawing.Color.White;
            this.ButtonTickets.HoverState.Image = global::PBL3.Properties.Resources.movie_ticket_color;
            this.ButtonTickets.Image = global::PBL3.Properties.Resources.movie_ticket;
            this.ButtonTickets.ImageSize = new System.Drawing.Size(40, 40);
            this.ButtonTickets.Location = new System.Drawing.Point(635, 0);
            this.ButtonTickets.Name = "ButtonTickets";
            this.ButtonTickets.Size = new System.Drawing.Size(140, 75);
            this.ButtonTickets.TabIndex = 1;
            this.ButtonTickets.Text = "Tickets";
            this.ButtonTickets.Click += new System.EventHandler(this.buttonTickets_Click);
            // 
            // buttonPurchased
            // 
            this.buttonPurchased.Animated = true;
            this.buttonPurchased.BorderRadius = 10;
            this.buttonPurchased.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TransitionClosePopup.SetDecoration(this.buttonPurchased, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TransitionOpenPopup.SetDecoration(this.buttonPurchased, Guna.UI2.AnimatorNS.DecorationType.None);
            this.buttonPurchased.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonPurchased.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonPurchased.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonPurchased.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonPurchased.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonPurchased.FillColor = System.Drawing.Color.Empty;
            this.buttonPurchased.FillColor2 = System.Drawing.Color.Empty;
            this.buttonPurchased.Font = new System.Drawing.Font("Cerebri Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPurchased.ForeColor = System.Drawing.Color.Black;
            this.buttonPurchased.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.buttonPurchased.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.buttonPurchased.HoverState.ForeColor = System.Drawing.Color.White;
            this.buttonPurchased.HoverState.Image = global::PBL3.Properties.Resources.checklist_color;
            this.buttonPurchased.Image = global::PBL3.Properties.Resources.checklist;
            this.buttonPurchased.ImageSize = new System.Drawing.Size(35, 35);
            this.buttonPurchased.Location = new System.Drawing.Point(489, 0);
            this.buttonPurchased.Name = "buttonPurchased";
            this.buttonPurchased.Size = new System.Drawing.Size(140, 75);
            this.buttonPurchased.TabIndex = 1;
            this.buttonPurchased.Text = "Purchased";
            this.buttonPurchased.Click += new System.EventHandler(this.buttonTickets_Click);
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
            this.textBoxSearch.Location = new System.Drawing.Point(782, 18);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PasswordChar = '\0';
            this.textBoxSearch.PlaceholderText = "Search";
            this.textBoxSearch.SelectedText = "";
            this.textBoxSearch.Size = new System.Drawing.Size(325, 37);
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
            this.circlePictureBoxUser.Image = global::PBL3.Properties.Resources.user;
            this.circlePictureBoxUser.ImageRotate = 0F;
            this.circlePictureBoxUser.Location = new System.Drawing.Point(30, 713);
            this.circlePictureBoxUser.Name = "circlePictureBoxUser";
            this.circlePictureBoxUser.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.circlePictureBoxUser.Size = new System.Drawing.Size(32, 32);
            this.circlePictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circlePictureBoxUser.TabIndex = 1;
            this.circlePictureBoxUser.TabStop = false;
            // 
            // guna2CirclePictureBoxLogo
            // 
            this.guna2CirclePictureBoxLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TransitionClosePopup.SetDecoration(this.guna2CirclePictureBoxLogo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TransitionOpenPopup.SetDecoration(this.guna2CirclePictureBoxLogo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2CirclePictureBoxLogo.Image = global::PBL3.Properties.Resources.film;
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
            // CustomerMainForm
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
            this.Name = "CustomerMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserMainForm";
            this.shadowPanelPopup.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2GradientTileButton buttonPurchased;
        private Guna.UI2.WinForms.Guna2GradientTileButton buttonMovies;
        private Guna.UI2.WinForms.Guna2GradientTileButton buttonPopDrinks;
        private Guna.UI2.WinForms.Guna2CirclePictureBox circlePictureBoxUser;
        private Guna.UI2.WinForms.Guna2GradientTileButton buttonShowtimes;
        private Guna.UI2.WinForms.Guna2CirclePictureBox circlePictureBoxOpenPopup;
        private Guna.UI2.WinForms.Guna2ShadowPanel shadowPanelPopup;
        private Guna.UI2.WinForms.Guna2Button buttonHistory;
        private Guna.UI2.WinForms.Guna2Button buttonHelp;
        private Guna.UI2.WinForms.Guna2Button buttonEdit;
        private Guna.UI2.WinForms.Guna2Button buttonClosePopup;
        private Guna.UI2.WinForms.Guna2Transition guna2TransitionOpenPopup;
        private Guna.UI2.WinForms.Guna2Transition guna2TransitionClosePopup;
        private Guna.UI2.WinForms.Guna2Panel panelNav;
        private Panel panelCenter;
        private Guna.UI2.WinForms.Guna2GradientTileButton ButtonTickets;
    }
}