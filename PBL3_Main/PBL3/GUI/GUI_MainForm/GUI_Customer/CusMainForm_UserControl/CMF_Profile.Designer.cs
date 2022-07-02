namespace PBL3.GUI.GUI_MainForm.GUI_Customer.CusMainForm_UserControl
{
    partial class CMF_Profile
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.labelEdit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxUser = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.buttonGetImage = new Guna.UI2.WinForms.Guna2Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelAI = new System.Windows.Forms.Label();
            this.textBoxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelBirth = new System.Windows.Forms.Label();
            this.radioButtonMale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioButtonFemale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.dateTimePickerBirth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.textBoxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labeChangePassword = new System.Windows.Forms.Label();
            this.textBoxCurrentPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelCurrentPassword = new System.Windows.Forms.Label();
            this.textBoxConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.buttonSave = new Guna.UI2.WinForms.Guna2Button();
            this.buttonCancel = new Guna.UI2.WinForms.Guna2Button();
            this.buttonChange = new Guna.UI2.WinForms.Guna2Button();
            this.panelChangePassword = new System.Windows.Forms.Panel();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.panelChangePassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.dateTimePickerBirth);
            this.guna2Panel1.Controls.Add(this.radioButtonFemale);
            this.guna2Panel1.Controls.Add(this.radioButtonMale);
            this.guna2Panel1.Controls.Add(this.labelBirth);
            this.guna2Panel1.Controls.Add(this.labelUsername);
            this.guna2Panel1.Controls.Add(this.labelAddress);
            this.guna2Panel1.Controls.Add(this.labelGender);
            this.guna2Panel1.Controls.Add(this.textBoxUsername);
            this.guna2Panel1.Controls.Add(this.labelPhone);
            this.guna2Panel1.Controls.Add(this.textBoxAddress);
            this.guna2Panel1.Controls.Add(this.labelName);
            this.guna2Panel1.Controls.Add(this.textBoxPhone);
            this.guna2Panel1.Controls.Add(this.textBoxName);
            this.guna2Panel1.Controls.Add(this.labeChangePassword);
            this.guna2Panel1.Controls.Add(this.labelAI);
            this.guna2Panel1.Controls.Add(this.labelInfo);
            this.guna2Panel1.Controls.Add(this.buttonChange);
            this.guna2Panel1.Controls.Add(this.buttonGetImage);
            this.guna2Panel1.Controls.Add(this.pictureBoxUser);
            this.guna2Panel1.Controls.Add(this.panelChangePassword);
            this.guna2Panel1.Location = new System.Drawing.Point(117, 110);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1013, 543);
            this.guna2Panel1.TabIndex = 0;
            // 
            // labelEdit
            // 
            this.labelEdit.AutoSize = true;
            this.labelEdit.Font = new System.Drawing.Font("Cerebri Sans Heavy", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdit.ForeColor = System.Drawing.Color.Green;
            this.labelEdit.Location = new System.Drawing.Point(135, 36);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.Size = new System.Drawing.Size(320, 47);
            this.labelEdit.TabIndex = 1;
            this.labelEdit.Text = "Edit your profile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 2;
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.ErrorImage = global::PBL3.Properties.Resources.user;
            this.pictureBoxUser.FillColor = System.Drawing.Color.LightCoral;
            this.pictureBoxUser.ImageRotate = 0F;
            this.pictureBoxUser.Location = new System.Drawing.Point(38, 21);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBoxUser.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUser.TabIndex = 3;
            this.pictureBoxUser.TabStop = false;
            // 
            // buttonGetImage
            // 
            this.buttonGetImage.Animated = true;
            this.buttonGetImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonGetImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonGetImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonGetImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonGetImage.FillColor = System.Drawing.Color.Green;
            this.buttonGetImage.Font = new System.Drawing.Font("Cerebri Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetImage.ForeColor = System.Drawing.Color.White;
            this.buttonGetImage.Location = new System.Drawing.Point(258, 129);
            this.buttonGetImage.Name = "buttonGetImage";
            this.buttonGetImage.Size = new System.Drawing.Size(180, 45);
            this.buttonGetImage.TabIndex = 4;
            this.buttonGetImage.Text = "CHOOSE A FILE";
            this.buttonGetImage.Click += new System.EventHandler(this.buttonGetImage_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Cerebri Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(254, 186);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(278, 19);
            this.labelInfo.TabIndex = 5;
            this.labelInfo.Text = "Acceptable *jpg, *.png and *.jpeg only!";
            // 
            // labelAI
            // 
            this.labelAI.AutoSize = true;
            this.labelAI.Font = new System.Drawing.Font("Cerebri Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAI.Location = new System.Drawing.Point(543, 54);
            this.labelAI.Name = "labelAI";
            this.labelAI.Size = new System.Drawing.Size(246, 24);
            this.labelAI.TabIndex = 6;
            this.labelAI.Text = "ACCOUNT INFORMATION";
            // 
            // textBoxName
            // 
            this.textBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxName.DefaultText = "";
            this.textBoxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxName.Font = new System.Drawing.Font("Cerebri Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxName.Location = new System.Drawing.Point(681, 102);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PasswordChar = '\0';
            this.textBoxName.PlaceholderText = "Name";
            this.textBoxName.SelectedText = "";
            this.textBoxName.Size = new System.Drawing.Size(263, 43);
            this.textBoxName.TabIndex = 7;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(557, 111);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(91, 21);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Your name";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPhone.DefaultText = "";
            this.textBoxPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPhone.Font = new System.Drawing.Font("Cerebri Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPhone.Location = new System.Drawing.Point(681, 167);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.PasswordChar = '\0';
            this.textBoxPhone.PlaceholderText = "Phone";
            this.textBoxPhone.SelectedText = "";
            this.textBoxPhone.Size = new System.Drawing.Size(263, 43);
            this.textBoxPhone.TabIndex = 7;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(557, 176);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(59, 21);
            this.labelPhone.TabIndex = 8;
            this.labelPhone.Text = "Phone";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxAddress.DefaultText = "";
            this.textBoxAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxAddress.Font = new System.Drawing.Font("Cerebri Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxAddress.Location = new System.Drawing.Point(681, 233);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.PasswordChar = '\0';
            this.textBoxAddress.PlaceholderText = "Address";
            this.textBoxAddress.SelectedText = "";
            this.textBoxAddress.Size = new System.Drawing.Size(263, 43);
            this.textBoxAddress.TabIndex = 7;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(557, 242);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(73, 21);
            this.labelAddress.TabIndex = 8;
            this.labelAddress.Text = "Address";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(557, 314);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(67, 21);
            this.labelGender.TabIndex = 8;
            this.labelGender.Text = "Gender";
            // 
            // labelBirth
            // 
            this.labelBirth.AutoSize = true;
            this.labelBirth.Location = new System.Drawing.Point(557, 380);
            this.labelBirth.Name = "labelBirth";
            this.labelBirth.Size = new System.Drawing.Size(47, 21);
            this.labelBirth.TabIndex = 8;
            this.labelBirth.Text = "Birth";
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.CheckedState.BorderColor = System.Drawing.Color.Green;
            this.radioButtonMale.CheckedState.BorderThickness = 0;
            this.radioButtonMale.CheckedState.FillColor = System.Drawing.Color.Green;
            this.radioButtonMale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioButtonMale.CheckedState.InnerOffset = -4;
            this.radioButtonMale.ForeColor = System.Drawing.Color.Green;
            this.radioButtonMale.Location = new System.Drawing.Point(681, 310);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(66, 25);
            this.radioButtonMale.TabIndex = 9;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonMale.UncheckedState.BorderThickness = 2;
            this.radioButtonMale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioButtonMale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonFemale.CheckedState.BorderThickness = 0;
            this.radioButtonFemale.CheckedState.FillColor = System.Drawing.Color.Green;
            this.radioButtonFemale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioButtonFemale.CheckedState.InnerOffset = -4;
            this.radioButtonFemale.ForeColor = System.Drawing.Color.LightSalmon;
            this.radioButtonFemale.Location = new System.Drawing.Point(805, 310);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(84, 25);
            this.radioButtonFemale.TabIndex = 9;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonFemale.UncheckedState.BorderThickness = 2;
            this.radioButtonFemale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioButtonFemale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.Checked = true;
            this.dateTimePickerBirth.FillColor = System.Drawing.Color.Green;
            this.dateTimePickerBirth.Font = new System.Drawing.Font("Cerebri Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBirth.ForeColor = System.Drawing.Color.White;
            this.dateTimePickerBirth.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerBirth.Location = new System.Drawing.Point(681, 370);
            this.dateTimePickerBirth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerBirth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(263, 43);
            this.dateTimePickerBirth.TabIndex = 10;
            this.dateTimePickerBirth.Value = new System.DateTime(2022, 7, 3, 3, 6, 19, 546);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxUsername.DefaultText = "[Username]";
            this.textBoxUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxUsername.Font = new System.Drawing.Font("Cerebri Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxUsername.Location = new System.Drawing.Point(681, 436);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.PasswordChar = '\0';
            this.textBoxUsername.PlaceholderText = "Address";
            this.textBoxUsername.ReadOnly = true;
            this.textBoxUsername.SelectedText = "";
            this.textBoxUsername.Size = new System.Drawing.Size(263, 43);
            this.textBoxUsername.TabIndex = 7;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(557, 445);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(87, 21);
            this.labelUsername.TabIndex = 8;
            this.labelUsername.Text = "Username";
            // 
            // labeChangePassword
            // 
            this.labeChangePassword.AutoSize = true;
            this.labeChangePassword.Font = new System.Drawing.Font("Cerebri Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeChangePassword.Location = new System.Drawing.Point(35, 252);
            this.labeChangePassword.Name = "labeChangePassword";
            this.labeChangePassword.Size = new System.Drawing.Size(208, 24);
            this.labeChangePassword.TabIndex = 6;
            this.labeChangePassword.Text = "CHANGE PASSWORD";
            // 
            // textBoxCurrentPassword
            // 
            this.textBoxCurrentPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCurrentPassword.DefaultText = "";
            this.textBoxCurrentPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxCurrentPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxCurrentPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxCurrentPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxCurrentPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxCurrentPassword.Font = new System.Drawing.Font("Cerebri Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCurrentPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxCurrentPassword.Location = new System.Drawing.Point(206, 24);
            this.textBoxCurrentPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCurrentPassword.Name = "textBoxCurrentPassword";
            this.textBoxCurrentPassword.PasswordChar = '•';
            this.textBoxCurrentPassword.PlaceholderText = "Current Password";
            this.textBoxCurrentPassword.SelectedText = "";
            this.textBoxCurrentPassword.Size = new System.Drawing.Size(263, 43);
            this.textBoxCurrentPassword.TabIndex = 7;
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNewPassword.DefaultText = "";
            this.textBoxNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxNewPassword.Font = new System.Drawing.Font("Cerebri Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxNewPassword.Location = new System.Drawing.Point(206, 89);
            this.textBoxNewPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PasswordChar = '•';
            this.textBoxNewPassword.PlaceholderText = "New Password";
            this.textBoxNewPassword.SelectedText = "";
            this.textBoxNewPassword.Size = new System.Drawing.Size(263, 43);
            this.textBoxNewPassword.TabIndex = 7;
            // 
            // labelCurrentPassword
            // 
            this.labelCurrentPassword.AutoSize = true;
            this.labelCurrentPassword.Location = new System.Drawing.Point(32, 33);
            this.labelCurrentPassword.Name = "labelCurrentPassword";
            this.labelCurrentPassword.Size = new System.Drawing.Size(148, 21);
            this.labelCurrentPassword.TabIndex = 8;
            this.labelCurrentPassword.Text = "Current Password";
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxConfirmPassword.DefaultText = "";
            this.textBoxConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxConfirmPassword.Font = new System.Drawing.Font("Cerebri Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(206, 155);
            this.textBoxConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.PasswordChar = '•';
            this.textBoxConfirmPassword.PlaceholderText = "Confirm Password";
            this.textBoxConfirmPassword.SelectedText = "";
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(263, 43);
            this.textBoxConfirmPassword.TabIndex = 7;
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Location = new System.Drawing.Point(32, 98);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(125, 21);
            this.labelNewPassword.TabIndex = 8;
            this.labelNewPassword.Text = "New Password";
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Location = new System.Drawing.Point(32, 164);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(152, 21);
            this.labelConfirmPassword.TabIndex = 8;
            this.labelConfirmPassword.Text = "Confirm Password";
            // 
            // buttonSave
            // 
            this.buttonSave.Animated = true;
            this.buttonSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSave.FillColor = System.Drawing.Color.Green;
            this.buttonSave.Font = new System.Drawing.Font("Cerebri Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(939, 659);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(180, 45);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Animated = true;
            this.buttonCancel.BorderThickness = 3;
            this.buttonCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonCancel.FillColor = System.Drawing.Color.Transparent;
            this.buttonCancel.Font = new System.Drawing.Font("Cerebri Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.Location = new System.Drawing.Point(741, 659);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(180, 45);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "CANCEL";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Animated = true;
            this.buttonChange.BorderThickness = 3;
            this.buttonChange.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonChange.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonChange.FillColor = System.Drawing.Color.Transparent;
            this.buttonChange.Font = new System.Drawing.Font("Cerebri Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChange.ForeColor = System.Drawing.Color.Black;
            this.buttonChange.Location = new System.Drawing.Point(258, 250);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(111, 26);
            this.buttonChange.TabIndex = 4;
            this.buttonChange.Text = "CHANGE";
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // panelChangePassword
            // 
            this.panelChangePassword.Controls.Add(this.labelNewPassword);
            this.panelChangePassword.Controls.Add(this.textBoxCurrentPassword);
            this.panelChangePassword.Controls.Add(this.textBoxNewPassword);
            this.panelChangePassword.Controls.Add(this.labelCurrentPassword);
            this.panelChangePassword.Controls.Add(this.textBoxConfirmPassword);
            this.panelChangePassword.Controls.Add(this.labelConfirmPassword);
            this.panelChangePassword.Location = new System.Drawing.Point(26, 282);
            this.panelChangePassword.Name = "panelChangePassword";
            this.panelChangePassword.Size = new System.Drawing.Size(497, 211);
            this.panelChangePassword.TabIndex = 11;
            // 
            // CMF_Profile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelEdit);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Font = new System.Drawing.Font("Cerebri Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CMF_Profile";
            this.Size = new System.Drawing.Size(1260, 750);
            this.Load += new System.EventHandler(this.CMF_Profile_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.panelChangePassword.ResumeLayout(false);
            this.panelChangePassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxName;
        private System.Windows.Forms.Label labelAI;
        private System.Windows.Forms.Label labelInfo;
        private Guna.UI2.WinForms.Guna2Button buttonGetImage;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBoxUser;
        private System.Windows.Forms.Label labelEdit;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerBirth;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonFemale;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonMale;
        private System.Windows.Forms.Label labelBirth;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelGender;
        private Guna.UI2.WinForms.Guna2TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPhone;
        private Guna.UI2.WinForms.Guna2TextBox textBoxAddress;
        private System.Windows.Forms.Label labelName;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPhone;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.Label labelNewPassword;
        private Guna.UI2.WinForms.Guna2TextBox textBoxConfirmPassword;
        private System.Windows.Forms.Label labelCurrentPassword;
        private Guna.UI2.WinForms.Guna2TextBox textBoxNewPassword;
        private Guna.UI2.WinForms.Guna2TextBox textBoxCurrentPassword;
        private System.Windows.Forms.Label labeChangePassword;
        private Guna.UI2.WinForms.Guna2Button buttonChange;
        private Guna.UI2.WinForms.Guna2Button buttonSave;
        private Guna.UI2.WinForms.Guna2Button buttonCancel;
        private System.Windows.Forms.Panel panelChangePassword;
    }
}
