namespace CAR_RENTAL.Forms
{
    partial class AddAndEditRentalCar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAndEditRentalCar));
            this.TimeText = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Text1 = new System.Windows.Forms.Label();
            this.TimeNow = new System.Windows.Forms.Timer(this.components);
            this.DriverBD = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverLicense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdditionalServiceBD = new System.Windows.Forms.DataGridView();
            this.nameYclygiBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car = new System.Windows.Forms.ComboBox();
            this.Text2 = new System.Windows.Forms.Label();
            this.client = new System.Windows.Forms.ComboBox();
            this.Text3 = new System.Windows.Forms.Label();
            this.rentalCarReturn = new System.Windows.Forms.DateTimePicker();
            this.rentalCarTake = new System.Windows.Forms.DateTimePicker();
            this.Text4 = new System.Windows.Forms.Label();
            this.Text5 = new System.Windows.Forms.Label();
            this.editRentalCarButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addCarButton = new System.Windows.Forms.Button();
            this.addRentalCarButton = new System.Windows.Forms.Button();
            this.infoClientButton = new System.Windows.Forms.Button();
            this.itogSumma = new System.Windows.Forms.Label();
            this.Text6 = new System.Windows.Forms.Label();
            this.additionalServices = new System.Windows.Forms.ComboBox();
            this.drivers = new System.Windows.Forms.ComboBox();
            this.addAdditionalService = new System.Windows.Forms.Button();
            this.delAdditionalService = new System.Windows.Forms.Button();
            this.delDriver = new System.Windows.Forms.Button();
            this.addDriver = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.itogSummaAS = new System.Windows.Forms.Label();
            this.Text7 = new System.Windows.Forms.Label();
            this.statusPayment = new System.Windows.Forms.ComboBox();
            this.Text8 = new System.Windows.Forms.Label();
            this.statusAdditionalPayment = new System.Windows.Forms.ComboBox();
            this.Text9 = new System.Windows.Forms.Label();
            this.statusRentalCar = new System.Windows.Forms.ComboBox();
            this.Text10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DriverBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdditionalServiceBD)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeText
            // 
            this.TimeText.AutoSize = true;
            this.TimeText.BackColor = System.Drawing.Color.Transparent;
            this.TimeText.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeText.Location = new System.Drawing.Point(652, 729);
            this.TimeText.Name = "TimeText";
            this.TimeText.Size = new System.Drawing.Size(37, 45);
            this.TimeText.TabIndex = 24;
            this.TimeText.Text = "1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::CAR_RENTAL.Properties.Resources.Logotip;
            this.pictureBox2.Location = new System.Drawing.Point(6, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 115);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CAR_RENTAL.Properties.Resources.Logotip;
            this.pictureBox1.Location = new System.Drawing.Point(1247, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Text1
            // 
            this.Text1.AutoSize = true;
            this.Text1.BackColor = System.Drawing.Color.Transparent;
            this.Text1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text1.Location = new System.Drawing.Point(512, 45);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(434, 45);
            this.Text1.TabIndex = 21;
            this.Text1.Text = "Добавление заказа проката";
            // 
            // TimeNow
            // 
            this.TimeNow.Enabled = true;
            this.TimeNow.Tick += new System.EventHandler(this.TimeNow_Tick);
            // 
            // DriverBD
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.DriverBD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DriverBD.BackgroundColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DriverBD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DriverBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DriverBD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.driverLicense,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DriverBD.DefaultCellStyle = dataGridViewCellStyle3;
            this.DriverBD.GridColor = System.Drawing.Color.Gray;
            this.DriverBD.Location = new System.Drawing.Point(960, 129);
            this.DriverBD.Name = "DriverBD";
            this.DriverBD.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DriverBD.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.DriverBD.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DriverBD.Size = new System.Drawing.Size(418, 378);
            this.DriverBD.TabIndex = 72;
            this.DriverBD.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DriverBD_RowsAdded);
            this.DriverBD.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DriverBD_RowsRemoved);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО Водителя";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 275;
            // 
            // driverLicense
            // 
            this.driverLicense.HeaderText = "Водительское удостоверение";
            this.driverLicense.Name = "driverLicense";
            this.driverLicense.ReadOnly = true;
            this.driverLicense.Width = 175;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // AdditionalServiceBD
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.AdditionalServiceBD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.AdditionalServiceBD.BackgroundColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AdditionalServiceBD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.AdditionalServiceBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdditionalServiceBD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameYclygiBD,
            this.priceBD});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AdditionalServiceBD.DefaultCellStyle = dataGridViewCellStyle8;
            this.AdditionalServiceBD.GridColor = System.Drawing.Color.Gray;
            this.AdditionalServiceBD.Location = new System.Drawing.Point(611, 129);
            this.AdditionalServiceBD.Name = "AdditionalServiceBD";
            this.AdditionalServiceBD.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AdditionalServiceBD.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.AdditionalServiceBD.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.AdditionalServiceBD.Size = new System.Drawing.Size(343, 378);
            this.AdditionalServiceBD.TabIndex = 71;
            this.AdditionalServiceBD.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.AdditionalServiceBD_RowsAdded);
            this.AdditionalServiceBD.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.AdditionalServiceBD_RowsRemoved);
            // 
            // nameYclygiBD
            // 
            this.nameYclygiBD.HeaderText = "Название Услуги";
            this.nameYclygiBD.Name = "nameYclygiBD";
            this.nameYclygiBD.ReadOnly = true;
            this.nameYclygiBD.Width = 200;
            // 
            // priceBD
            // 
            this.priceBD.HeaderText = "Цена";
            this.priceBD.Name = "priceBD";
            this.priceBD.ReadOnly = true;
            // 
            // car
            // 
            this.car.BackColor = System.Drawing.Color.Beige;
            this.car.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.car.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.car.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.car.FormattingEnabled = true;
            this.car.Location = new System.Drawing.Point(6, 151);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(549, 33);
            this.car.TabIndex = 74;
            this.car.SelectedIndexChanged += new System.EventHandler(this.car_SelectedIndexChanged);
            // 
            // Text2
            // 
            this.Text2.AutoSize = true;
            this.Text2.BackColor = System.Drawing.Color.Transparent;
            this.Text2.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text2.ForeColor = System.Drawing.Color.Black;
            this.Text2.Location = new System.Drawing.Point(22, 116);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(115, 36);
            this.Text2.TabIndex = 73;
            this.Text2.Text = "Машина:";
            // 
            // client
            // 
            this.client.BackColor = System.Drawing.Color.Beige;
            this.client.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.client.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.client.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.client.FormattingEnabled = true;
            this.client.Location = new System.Drawing.Point(6, 226);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(549, 33);
            this.client.TabIndex = 76;
            // 
            // Text3
            // 
            this.Text3.AutoSize = true;
            this.Text3.BackColor = System.Drawing.Color.Transparent;
            this.Text3.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text3.ForeColor = System.Drawing.Color.Black;
            this.Text3.Location = new System.Drawing.Point(29, 187);
            this.Text3.Name = "Text3";
            this.Text3.Size = new System.Drawing.Size(108, 36);
            this.Text3.TabIndex = 75;
            this.Text3.Text = "Клиент:";
            // 
            // rentalCarReturn
            // 
            this.rentalCarReturn.CalendarForeColor = System.Drawing.Color.DarkSlateGray;
            this.rentalCarReturn.CalendarMonthBackground = System.Drawing.Color.Beige;
            this.rentalCarReturn.CalendarTitleForeColor = System.Drawing.Color.DarkSlateGray;
            this.rentalCarReturn.CalendarTrailingForeColor = System.Drawing.Color.DarkSlateGray;
            this.rentalCarReturn.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rentalCarReturn.Location = new System.Drawing.Point(6, 375);
            this.rentalCarReturn.Name = "rentalCarReturn";
            this.rentalCarReturn.Size = new System.Drawing.Size(549, 31);
            this.rentalCarReturn.TabIndex = 78;
            this.rentalCarReturn.ValueChanged += new System.EventHandler(this.rentalCarReturn_ValueChanged);
            // 
            // rentalCarTake
            // 
            this.rentalCarTake.CalendarFont = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rentalCarTake.CalendarForeColor = System.Drawing.Color.DarkSlateGray;
            this.rentalCarTake.CalendarMonthBackground = System.Drawing.Color.Beige;
            this.rentalCarTake.CalendarTitleForeColor = System.Drawing.Color.DarkSlateGray;
            this.rentalCarTake.CalendarTrailingForeColor = System.Drawing.Color.DarkSlateGray;
            this.rentalCarTake.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rentalCarTake.Location = new System.Drawing.Point(6, 301);
            this.rentalCarTake.Name = "rentalCarTake";
            this.rentalCarTake.Size = new System.Drawing.Size(549, 31);
            this.rentalCarTake.TabIndex = 77;
            this.rentalCarTake.ValueChanged += new System.EventHandler(this.rentalCarTake_ValueChanged);
            // 
            // Text4
            // 
            this.Text4.AutoSize = true;
            this.Text4.BackColor = System.Drawing.Color.Transparent;
            this.Text4.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text4.ForeColor = System.Drawing.Color.Black;
            this.Text4.Location = new System.Drawing.Point(79, 262);
            this.Text4.Name = "Text4";
            this.Text4.Size = new System.Drawing.Size(58, 36);
            this.Text4.TabIndex = 79;
            this.Text4.Text = "От:";
            // 
            // Text5
            // 
            this.Text5.AutoSize = true;
            this.Text5.BackColor = System.Drawing.Color.Transparent;
            this.Text5.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text5.ForeColor = System.Drawing.Color.Black;
            this.Text5.Location = new System.Drawing.Point(82, 336);
            this.Text5.Name = "Text5";
            this.Text5.Size = new System.Drawing.Size(55, 36);
            this.Text5.TabIndex = 80;
            this.Text5.Text = "До:";
            // 
            // editRentalCarButton
            // 
            this.editRentalCarButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.editRentalCarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editRentalCarButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editRentalCarButton.Location = new System.Drawing.Point(269, 718);
            this.editRentalCarButton.Name = "editRentalCarButton";
            this.editRentalCarButton.Size = new System.Drawing.Size(300, 50);
            this.editRentalCarButton.TabIndex = 83;
            this.editRentalCarButton.Text = "Изменить";
            this.editRentalCarButton.UseVisualStyleBackColor = true;
            this.editRentalCarButton.Click += new System.EventHandler(this.editRentalCarButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(790, 718);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(300, 50);
            this.cancelButton.TabIndex = 82;
            this.cancelButton.Text = "Назад";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addCarButton
            // 
            this.addCarButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.addCarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addCarButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCarButton.Location = new System.Drawing.Point(269, 718);
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Size = new System.Drawing.Size(300, 50);
            this.addCarButton.TabIndex = 81;
            this.addCarButton.Text = "Добавить";
            this.addCarButton.UseVisualStyleBackColor = true;
            // 
            // addRentalCarButton
            // 
            this.addRentalCarButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.addRentalCarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addRentalCarButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRentalCarButton.Location = new System.Drawing.Point(269, 718);
            this.addRentalCarButton.Name = "addRentalCarButton";
            this.addRentalCarButton.Size = new System.Drawing.Size(300, 50);
            this.addRentalCarButton.TabIndex = 84;
            this.addRentalCarButton.Text = "Добавить";
            this.addRentalCarButton.UseVisualStyleBackColor = true;
            this.addRentalCarButton.Click += new System.EventHandler(this.addRentalCarButton_Click);
            // 
            // infoClientButton
            // 
            this.infoClientButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.infoClientButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.infoClientButton.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoClientButton.Location = new System.Drawing.Point(561, 219);
            this.infoClientButton.Name = "infoClientButton";
            this.infoClientButton.Size = new System.Drawing.Size(25, 40);
            this.infoClientButton.TabIndex = 86;
            this.infoClientButton.Text = "I";
            this.infoClientButton.UseVisualStyleBackColor = true;
            this.infoClientButton.Click += new System.EventHandler(this.infoClientButton_Click);
            // 
            // itogSumma
            // 
            this.itogSumma.AutoSize = true;
            this.itogSumma.BackColor = System.Drawing.Color.Transparent;
            this.itogSumma.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itogSumma.Location = new System.Drawing.Point(288, 409);
            this.itogSumma.Name = "itogSumma";
            this.itogSumma.Size = new System.Drawing.Size(28, 36);
            this.itogSumma.TabIndex = 88;
            this.itogSumma.Text = "0";
            // 
            // Text6
            // 
            this.Text6.AutoSize = true;
            this.Text6.BackColor = System.Drawing.Color.Transparent;
            this.Text6.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text6.Location = new System.Drawing.Point(86, 409);
            this.Text6.Name = "Text6";
            this.Text6.Size = new System.Drawing.Size(208, 36);
            this.Text6.TabIndex = 87;
            this.Text6.Text = "Итоговая сумма:";
            // 
            // additionalServices
            // 
            this.additionalServices.BackColor = System.Drawing.Color.Beige;
            this.additionalServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.additionalServices.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.additionalServices.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.additionalServices.FormattingEnabled = true;
            this.additionalServices.Location = new System.Drawing.Point(611, 513);
            this.additionalServices.Name = "additionalServices";
            this.additionalServices.Size = new System.Drawing.Size(343, 23);
            this.additionalServices.TabIndex = 89;
            // 
            // drivers
            // 
            this.drivers.BackColor = System.Drawing.Color.Beige;
            this.drivers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drivers.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drivers.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.drivers.FormattingEnabled = true;
            this.drivers.Location = new System.Drawing.Point(960, 513);
            this.drivers.Name = "drivers";
            this.drivers.Size = new System.Drawing.Size(418, 23);
            this.drivers.TabIndex = 90;
            // 
            // addAdditionalService
            // 
            this.addAdditionalService.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.addAdditionalService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addAdditionalService.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addAdditionalService.Location = new System.Drawing.Point(611, 542);
            this.addAdditionalService.Name = "addAdditionalService";
            this.addAdditionalService.Size = new System.Drawing.Size(343, 39);
            this.addAdditionalService.TabIndex = 91;
            this.addAdditionalService.Text = "Добавить";
            this.addAdditionalService.UseVisualStyleBackColor = true;
            this.addAdditionalService.Click += new System.EventHandler(this.addAdditionalService_Click);
            // 
            // delAdditionalService
            // 
            this.delAdditionalService.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.delAdditionalService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delAdditionalService.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delAdditionalService.Location = new System.Drawing.Point(611, 587);
            this.delAdditionalService.Name = "delAdditionalService";
            this.delAdditionalService.Size = new System.Drawing.Size(343, 39);
            this.delAdditionalService.TabIndex = 92;
            this.delAdditionalService.Text = "Удалить";
            this.delAdditionalService.UseVisualStyleBackColor = true;
            this.delAdditionalService.Click += new System.EventHandler(this.delAdditionalService_Click);
            // 
            // delDriver
            // 
            this.delDriver.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.delDriver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delDriver.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delDriver.Location = new System.Drawing.Point(960, 587);
            this.delDriver.Name = "delDriver";
            this.delDriver.Size = new System.Drawing.Size(418, 39);
            this.delDriver.TabIndex = 94;
            this.delDriver.Text = "Удалить";
            this.delDriver.UseVisualStyleBackColor = true;
            this.delDriver.Click += new System.EventHandler(this.delDriver_Click);
            // 
            // addDriver
            // 
            this.addDriver.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.addDriver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addDriver.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addDriver.Location = new System.Drawing.Point(960, 542);
            this.addDriver.Name = "addDriver";
            this.addDriver.Size = new System.Drawing.Size(418, 39);
            this.addDriver.TabIndex = 93;
            this.addDriver.Text = "Добавить";
            this.addDriver.UseVisualStyleBackColor = true;
            this.addDriver.Click += new System.EventHandler(this.addDriver_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status.ForeColor = System.Drawing.Color.Green;
            this.status.Location = new System.Drawing.Point(561, 139);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 45);
            this.status.TabIndex = 95;
            this.status.Click += new System.EventHandler(this.status_Click);
            // 
            // itogSummaAS
            // 
            this.itogSummaAS.AutoSize = true;
            this.itogSummaAS.BackColor = System.Drawing.Color.Transparent;
            this.itogSummaAS.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itogSummaAS.Location = new System.Drawing.Point(1033, 642);
            this.itogSummaAS.Name = "itogSummaAS";
            this.itogSummaAS.Size = new System.Drawing.Size(36, 45);
            this.itogSummaAS.TabIndex = 97;
            this.itogSummaAS.Text = "0";
            // 
            // Text7
            // 
            this.Text7.AutoSize = true;
            this.Text7.BackColor = System.Drawing.Color.Transparent;
            this.Text7.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text7.Location = new System.Drawing.Point(782, 642);
            this.Text7.Name = "Text7";
            this.Text7.Size = new System.Drawing.Size(261, 45);
            this.Text7.TabIndex = 96;
            this.Text7.Text = "Сумма за услуги:";
            // 
            // statusPayment
            // 
            this.statusPayment.BackColor = System.Drawing.Color.Beige;
            this.statusPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusPayment.Enabled = false;
            this.statusPayment.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusPayment.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.statusPayment.FormattingEnabled = true;
            this.statusPayment.Location = new System.Drawing.Point(6, 480);
            this.statusPayment.Name = "statusPayment";
            this.statusPayment.Size = new System.Drawing.Size(549, 33);
            this.statusPayment.TabIndex = 99;
            // 
            // Text8
            // 
            this.Text8.AutoSize = true;
            this.Text8.BackColor = System.Drawing.Color.Transparent;
            this.Text8.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text8.ForeColor = System.Drawing.Color.Black;
            this.Text8.Location = new System.Drawing.Point(22, 445);
            this.Text8.Name = "Text8";
            this.Text8.Size = new System.Drawing.Size(300, 36);
            this.Text8.TabIndex = 98;
            this.Text8.Text = "Статус основной оплаты:";
            // 
            // statusAdditionalPayment
            // 
            this.statusAdditionalPayment.BackColor = System.Drawing.Color.Beige;
            this.statusAdditionalPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusAdditionalPayment.Enabled = false;
            this.statusAdditionalPayment.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusAdditionalPayment.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.statusAdditionalPayment.FormattingEnabled = true;
            this.statusAdditionalPayment.Location = new System.Drawing.Point(6, 548);
            this.statusAdditionalPayment.Name = "statusAdditionalPayment";
            this.statusAdditionalPayment.Size = new System.Drawing.Size(549, 33);
            this.statusAdditionalPayment.TabIndex = 101;
            this.statusAdditionalPayment.SelectedIndexChanged += new System.EventHandler(this.statusAdditionalPayment_SelectedIndexChanged);
            // 
            // Text9
            // 
            this.Text9.AutoSize = true;
            this.Text9.BackColor = System.Drawing.Color.Transparent;
            this.Text9.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text9.ForeColor = System.Drawing.Color.Black;
            this.Text9.Location = new System.Drawing.Point(22, 513);
            this.Text9.Name = "Text9";
            this.Text9.Size = new System.Drawing.Size(380, 36);
            this.Text9.TabIndex = 100;
            this.Text9.Text = "Статус дополнительной оплаты:";
            // 
            // statusRentalCar
            // 
            this.statusRentalCar.BackColor = System.Drawing.Color.Beige;
            this.statusRentalCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusRentalCar.Enabled = false;
            this.statusRentalCar.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusRentalCar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.statusRentalCar.FormattingEnabled = true;
            this.statusRentalCar.Location = new System.Drawing.Point(6, 617);
            this.statusRentalCar.Name = "statusRentalCar";
            this.statusRentalCar.Size = new System.Drawing.Size(549, 33);
            this.statusRentalCar.TabIndex = 103;
            // 
            // Text10
            // 
            this.Text10.AutoSize = true;
            this.Text10.BackColor = System.Drawing.Color.Transparent;
            this.Text10.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text10.ForeColor = System.Drawing.Color.Black;
            this.Text10.Location = new System.Drawing.Point(22, 582);
            this.Text10.Name = "Text10";
            this.Text10.Size = new System.Drawing.Size(206, 36);
            this.Text10.TabIndex = 102;
            this.Text10.Text = "Статус машины:";
            // 
            // AddAndEditRentalCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1384, 780);
            this.ControlBox = false;
            this.Controls.Add(this.statusRentalCar);
            this.Controls.Add(this.Text10);
            this.Controls.Add(this.statusAdditionalPayment);
            this.Controls.Add(this.Text9);
            this.Controls.Add(this.statusPayment);
            this.Controls.Add(this.Text8);
            this.Controls.Add(this.itogSummaAS);
            this.Controls.Add(this.Text7);
            this.Controls.Add(this.status);
            this.Controls.Add(this.delDriver);
            this.Controls.Add(this.addDriver);
            this.Controls.Add(this.delAdditionalService);
            this.Controls.Add(this.addAdditionalService);
            this.Controls.Add(this.drivers);
            this.Controls.Add(this.additionalServices);
            this.Controls.Add(this.itogSumma);
            this.Controls.Add(this.Text6);
            this.Controls.Add(this.infoClientButton);
            this.Controls.Add(this.addRentalCarButton);
            this.Controls.Add(this.editRentalCarButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addCarButton);
            this.Controls.Add(this.Text5);
            this.Controls.Add(this.Text4);
            this.Controls.Add(this.rentalCarReturn);
            this.Controls.Add(this.rentalCarTake);
            this.Controls.Add(this.client);
            this.Controls.Add(this.Text3);
            this.Controls.Add(this.car);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.DriverBD);
            this.Controls.Add(this.AdditionalServiceBD);
            this.Controls.Add(this.TimeText);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Text1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddAndEditRentalCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"Прокаткомпарейшн\"";
            this.Load += new System.EventHandler(this.AddAndEditRentalCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DriverBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdditionalServiceBD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeText;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.Timer TimeNow;
        private System.Windows.Forms.DataGridView DriverBD;
        private System.Windows.Forms.DataGridView AdditionalServiceBD;
        private System.Windows.Forms.ComboBox car;
        private System.Windows.Forms.Label Text2;
        private System.Windows.Forms.ComboBox client;
        private System.Windows.Forms.Label Text3;
        private System.Windows.Forms.DateTimePicker rentalCarReturn;
        private System.Windows.Forms.DateTimePicker rentalCarTake;
        private System.Windows.Forms.Label Text4;
        private System.Windows.Forms.Label Text5;
        private System.Windows.Forms.Button editRentalCarButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addCarButton;
        private System.Windows.Forms.Button addRentalCarButton;
        private System.Windows.Forms.Button infoClientButton;
        private System.Windows.Forms.Label itogSumma;
        private System.Windows.Forms.Label Text6;
        private System.Windows.Forms.ComboBox additionalServices;
        private System.Windows.Forms.ComboBox drivers;
        private System.Windows.Forms.Button addAdditionalService;
        private System.Windows.Forms.Button delAdditionalService;
        private System.Windows.Forms.Button delDriver;
        private System.Windows.Forms.Button addDriver;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameYclygiBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceBD;
        private System.Windows.Forms.Label itogSummaAS;
        private System.Windows.Forms.Label Text7;
        private System.Windows.Forms.ComboBox statusPayment;
        private System.Windows.Forms.Label Text8;
        private System.Windows.Forms.ComboBox statusAdditionalPayment;
        private System.Windows.Forms.Label Text9;
        private System.Windows.Forms.ComboBox statusRentalCar;
        private System.Windows.Forms.Label Text10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverLicense;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}