namespace CAR_RENTAL.Forms
{
    partial class RentalCars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentalCars));
            this.TimeText = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Text1 = new System.Windows.Forms.Label();
            this.TimeNow = new System.Windows.Forms.Timer(this.components);
            this.RentalCarBD = new System.Windows.Forms.DataGridView();
            this.idCarBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_takeBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_return = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusAdditionalPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusRentalCar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItogPriceBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalPricePay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backMenuButton = new System.Windows.Forms.Button();
            this.checkRentalCarButton = new System.Windows.Forms.Button();
            this.addRentalCarButton = new System.Windows.Forms.Button();
            this.delRentalCarButton = new System.Windows.Forms.Button();
            this.filtrDateButton = new System.Windows.Forms.Button();
            this.sortType = new System.Windows.Forms.ComboBox();
            this.brandSearch = new System.Windows.Forms.TextBox();
            this.fullNameSearch = new System.Windows.Forms.TextBox();
            this.rentalCarTake = new System.Windows.Forms.DateTimePicker();
            this.rentalCarReturn = new System.Windows.Forms.DateTimePicker();
            this.editRentalCarButton = new System.Windows.Forms.Button();
            this.Text2 = new System.Windows.Forms.Label();
            this.modelSearch = new System.Windows.Forms.TextBox();
            this.printContractIssuedCarButton = new System.Windows.Forms.Button();
            this.printContractReturnCarButton = new System.Windows.Forms.Button();
            this.addAndEditTypeCarDamageOnRentalCarButton = new System.Windows.Forms.Button();
            this.checkContractIssuedCarButton = new System.Windows.Forms.Button();
            this.checkContractReturnCarButton = new System.Windows.Forms.Button();
            this.infoSearch1 = new System.Windows.Forms.Label();
            this.infoSearch2 = new System.Windows.Forms.Label();
            this.infoSearch3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentalCarBD)).BeginInit();
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
            this.TimeText.TabIndex = 20;
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
            this.pictureBox2.TabIndex = 19;
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
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Text1
            // 
            this.Text1.AutoSize = true;
            this.Text1.BackColor = System.Drawing.Color.Transparent;
            this.Text1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text1.Location = new System.Drawing.Point(588, 44);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(161, 45);
            this.Text1.TabIndex = 17;
            this.Text1.Text = "Прокаты";
            // 
            // TimeNow
            // 
            this.TimeNow.Enabled = true;
            this.TimeNow.Tick += new System.EventHandler(this.TimeNow_Tick);
            // 
            // RentalCarBD
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.RentalCarBD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.RentalCarBD.BackgroundColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RentalCarBD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.RentalCarBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentalCarBD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCarBD,
            this.CarBD,
            this.ClientBD,
            this.Date_takeBD,
            this.Date_return,
            this.statusPayment,
            this.statusAdditionalPayment,
            this.statusRentalCar,
            this.ItogPriceBD,
            this.rentalPricePay});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RentalCarBD.DefaultCellStyle = dataGridViewCellStyle3;
            this.RentalCarBD.GridColor = System.Drawing.Color.Gray;
            this.RentalCarBD.Location = new System.Drawing.Point(304, 119);
            this.RentalCarBD.Name = "RentalCarBD";
            this.RentalCarBD.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RentalCarBD.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.RentalCarBD.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.RentalCarBD.Size = new System.Drawing.Size(1068, 516);
            this.RentalCarBD.TabIndex = 21;
            // 
            // idCarBD
            // 
            this.idCarBD.HeaderText = "Номер Машины";
            this.idCarBD.Name = "idCarBD";
            this.idCarBD.ReadOnly = true;
            this.idCarBD.Visible = false;
            // 
            // CarBD
            // 
            this.CarBD.HeaderText = "Машина";
            this.CarBD.Name = "CarBD";
            this.CarBD.ReadOnly = true;
            this.CarBD.Width = 200;
            // 
            // ClientBD
            // 
            this.ClientBD.HeaderText = "Клиент";
            this.ClientBD.Name = "ClientBD";
            this.ClientBD.ReadOnly = true;
            this.ClientBD.Width = 300;
            // 
            // Date_takeBD
            // 
            this.Date_takeBD.HeaderText = "Дата Аренды";
            this.Date_takeBD.Name = "Date_takeBD";
            this.Date_takeBD.ReadOnly = true;
            this.Date_takeBD.Width = 150;
            // 
            // Date_return
            // 
            this.Date_return.HeaderText = "Дата Возврата";
            this.Date_return.Name = "Date_return";
            this.Date_return.ReadOnly = true;
            this.Date_return.Width = 150;
            // 
            // statusPayment
            // 
            this.statusPayment.HeaderText = "Статус основной оплаты";
            this.statusPayment.Name = "statusPayment";
            this.statusPayment.ReadOnly = true;
            this.statusPayment.Width = 175;
            // 
            // statusAdditionalPayment
            // 
            this.statusAdditionalPayment.HeaderText = "Статус дополнительной оплаты";
            this.statusAdditionalPayment.Name = "statusAdditionalPayment";
            this.statusAdditionalPayment.ReadOnly = true;
            this.statusAdditionalPayment.Width = 350;
            // 
            // statusRentalCar
            // 
            this.statusRentalCar.HeaderText = "Статус машины";
            this.statusRentalCar.Name = "statusRentalCar";
            this.statusRentalCar.ReadOnly = true;
            this.statusRentalCar.Width = 150;
            // 
            // ItogPriceBD
            // 
            this.ItogPriceBD.HeaderText = "Цена на данный момент";
            this.ItogPriceBD.Name = "ItogPriceBD";
            this.ItogPriceBD.ReadOnly = true;
            this.ItogPriceBD.Width = 125;
            // 
            // rentalPricePay
            // 
            this.rentalPricePay.HeaderText = "Цена оплачена";
            this.rentalPricePay.Name = "rentalPricePay";
            this.rentalPricePay.ReadOnly = true;
            this.rentalPricePay.Width = 125;
            // 
            // backMenuButton
            // 
            this.backMenuButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.backMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backMenuButton.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backMenuButton.Location = new System.Drawing.Point(1222, 722);
            this.backMenuButton.Name = "backMenuButton";
            this.backMenuButton.Size = new System.Drawing.Size(150, 50);
            this.backMenuButton.TabIndex = 30;
            this.backMenuButton.Text = "В меню";
            this.backMenuButton.UseVisualStyleBackColor = true;
            this.backMenuButton.Click += new System.EventHandler(this.BackMenu_Click);
            // 
            // checkRentalCarButton
            // 
            this.checkRentalCarButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.checkRentalCarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkRentalCarButton.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkRentalCarButton.Location = new System.Drawing.Point(12, 659);
            this.checkRentalCarButton.Name = "checkRentalCarButton";
            this.checkRentalCarButton.Size = new System.Drawing.Size(286, 50);
            this.checkRentalCarButton.TabIndex = 31;
            this.checkRentalCarButton.Text = "Просмотр заказа";
            this.checkRentalCarButton.UseVisualStyleBackColor = true;
            this.checkRentalCarButton.Visible = false;
            this.checkRentalCarButton.Click += new System.EventHandler(this.checkRentalCarButton_Click);
            // 
            // addRentalCarButton
            // 
            this.addRentalCarButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.addRentalCarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addRentalCarButton.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addRentalCarButton.Location = new System.Drawing.Point(12, 175);
            this.addRentalCarButton.Name = "addRentalCarButton";
            this.addRentalCarButton.Size = new System.Drawing.Size(286, 50);
            this.addRentalCarButton.TabIndex = 32;
            this.addRentalCarButton.Text = "Добавление заказа";
            this.addRentalCarButton.UseVisualStyleBackColor = true;
            this.addRentalCarButton.Visible = false;
            this.addRentalCarButton.Click += new System.EventHandler(this.addRentalCarButton_Click);
            // 
            // delRentalCarButton
            // 
            this.delRentalCarButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.delRentalCarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delRentalCarButton.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delRentalCarButton.Location = new System.Drawing.Point(12, 231);
            this.delRentalCarButton.Name = "delRentalCarButton";
            this.delRentalCarButton.Size = new System.Drawing.Size(286, 50);
            this.delRentalCarButton.TabIndex = 33;
            this.delRentalCarButton.Text = "Удаление заказа";
            this.delRentalCarButton.UseVisualStyleBackColor = true;
            this.delRentalCarButton.Visible = false;
            this.delRentalCarButton.Click += new System.EventHandler(this.delRentalCarButton_Click);
            // 
            // filtrDateButton
            // 
            this.filtrDateButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.filtrDateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filtrDateButton.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filtrDateButton.Location = new System.Drawing.Point(12, 567);
            this.filtrDateButton.Name = "filtrDateButton";
            this.filtrDateButton.Size = new System.Drawing.Size(286, 50);
            this.filtrDateButton.TabIndex = 34;
            this.filtrDateButton.Text = "Фильтр по времени";
            this.filtrDateButton.UseVisualStyleBackColor = true;
            this.filtrDateButton.Click += new System.EventHandler(this.filtrDateButton_Click);
            // 
            // sortType
            // 
            this.sortType.BackColor = System.Drawing.Color.Beige;
            this.sortType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortType.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortType.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.sortType.FormattingEnabled = true;
            this.sortType.Location = new System.Drawing.Point(12, 425);
            this.sortType.Name = "sortType";
            this.sortType.Size = new System.Drawing.Size(286, 44);
            this.sortType.TabIndex = 35;
            this.sortType.SelectedIndexChanged += new System.EventHandler(this.sortType_SelectedIndexChanged);
            // 
            // brandSearch
            // 
            this.brandSearch.BackColor = System.Drawing.Color.Beige;
            this.brandSearch.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brandSearch.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.brandSearch.Location = new System.Drawing.Point(12, 287);
            this.brandSearch.MaxLength = 30;
            this.brandSearch.Name = "brandSearch";
            this.brandSearch.Size = new System.Drawing.Size(286, 40);
            this.brandSearch.TabIndex = 36;
            this.brandSearch.TextChanged += new System.EventHandler(this.brandSearch_TextChanged);
            this.brandSearch.Enter += new System.EventHandler(this.brandSearch_Enter);
            this.brandSearch.Leave += new System.EventHandler(this.brandSearch_Leave);
            // 
            // fullNameSearch
            // 
            this.fullNameSearch.BackColor = System.Drawing.Color.Beige;
            this.fullNameSearch.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNameSearch.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.fullNameSearch.Location = new System.Drawing.Point(12, 379);
            this.fullNameSearch.MaxLength = 50;
            this.fullNameSearch.Name = "fullNameSearch";
            this.fullNameSearch.Size = new System.Drawing.Size(286, 40);
            this.fullNameSearch.TabIndex = 37;
            this.fullNameSearch.TextChanged += new System.EventHandler(this.fullNameSearch_TextChanged);
            this.fullNameSearch.Enter += new System.EventHandler(this.fullNameSearch_Enter);
            this.fullNameSearch.Leave += new System.EventHandler(this.fullNameSearch_Leave);
            // 
            // rentalCarTake
            // 
            this.rentalCarTake.CalendarForeColor = System.Drawing.Color.DarkSlateGray;
            this.rentalCarTake.CalendarMonthBackground = System.Drawing.Color.Beige;
            this.rentalCarTake.CalendarTitleForeColor = System.Drawing.Color.DarkSlateGray;
            this.rentalCarTake.CalendarTrailingForeColor = System.Drawing.Color.DarkSlateGray;
            this.rentalCarTake.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rentalCarTake.Location = new System.Drawing.Point(12, 475);
            this.rentalCarTake.Name = "rentalCarTake";
            this.rentalCarTake.Size = new System.Drawing.Size(286, 40);
            this.rentalCarTake.TabIndex = 38;
            this.rentalCarTake.ValueChanged += new System.EventHandler(this.rentalCarTake_ValueChanged);
            // 
            // rentalCarReturn
            // 
            this.rentalCarReturn.CalendarForeColor = System.Drawing.Color.DarkSlateGray;
            this.rentalCarReturn.CalendarMonthBackground = System.Drawing.Color.Beige;
            this.rentalCarReturn.CalendarTitleForeColor = System.Drawing.Color.DarkSlateGray;
            this.rentalCarReturn.CalendarTrailingForeColor = System.Drawing.Color.DarkSlateGray;
            this.rentalCarReturn.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rentalCarReturn.Location = new System.Drawing.Point(12, 521);
            this.rentalCarReturn.Name = "rentalCarReturn";
            this.rentalCarReturn.Size = new System.Drawing.Size(286, 40);
            this.rentalCarReturn.TabIndex = 39;
            this.rentalCarReturn.ValueChanged += new System.EventHandler(this.rentalCarReturn_ValueChanged);
            // 
            // editRentalCarButton
            // 
            this.editRentalCarButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.editRentalCarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editRentalCarButton.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editRentalCarButton.Location = new System.Drawing.Point(12, 119);
            this.editRentalCarButton.Name = "editRentalCarButton";
            this.editRentalCarButton.Size = new System.Drawing.Size(286, 50);
            this.editRentalCarButton.TabIndex = 43;
            this.editRentalCarButton.Text = "Изменение заказа";
            this.editRentalCarButton.UseVisualStyleBackColor = true;
            this.editRentalCarButton.Visible = false;
            this.editRentalCarButton.Click += new System.EventHandler(this.editRentalCarButton_Click);
            // 
            // Text2
            // 
            this.Text2.AutoSize = true;
            this.Text2.BackColor = System.Drawing.Color.Transparent;
            this.Text2.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text2.ForeColor = System.Drawing.Color.Red;
            this.Text2.Location = new System.Drawing.Point(80, 620);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(151, 36);
            this.Text2.TabIndex = 58;
            this.Text2.Text = "Не активен";
            this.Text2.TextChanged += new System.EventHandler(this.Text2_TextChanged);
            // 
            // modelSearch
            // 
            this.modelSearch.BackColor = System.Drawing.Color.Beige;
            this.modelSearch.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modelSearch.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.modelSearch.Location = new System.Drawing.Point(12, 333);
            this.modelSearch.MaxLength = 30;
            this.modelSearch.Name = "modelSearch";
            this.modelSearch.Size = new System.Drawing.Size(286, 40);
            this.modelSearch.TabIndex = 59;
            this.modelSearch.TextChanged += new System.EventHandler(this.modelSearch_TextChanged);
            this.modelSearch.Enter += new System.EventHandler(this.modelSearch_Enter);
            this.modelSearch.Leave += new System.EventHandler(this.modelSearch_Leave);
            // 
            // printContractIssuedCarButton
            // 
            this.printContractIssuedCarButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.printContractIssuedCarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.printContractIssuedCarButton.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printContractIssuedCarButton.Location = new System.Drawing.Point(304, 636);
            this.printContractIssuedCarButton.Name = "printContractIssuedCarButton";
            this.printContractIssuedCarButton.Size = new System.Drawing.Size(390, 40);
            this.printContractIssuedCarButton.TabIndex = 61;
            this.printContractIssuedCarButton.Text = "Распечатать договор выдачи машины";
            this.printContractIssuedCarButton.UseVisualStyleBackColor = true;
            this.printContractIssuedCarButton.Click += new System.EventHandler(this.printContractIssuedCarButton_Click);
            // 
            // printContractReturnCarButton
            // 
            this.printContractReturnCarButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.printContractReturnCarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.printContractReturnCarButton.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printContractReturnCarButton.Location = new System.Drawing.Point(696, 636);
            this.printContractReturnCarButton.Name = "printContractReturnCarButton";
            this.printContractReturnCarButton.Size = new System.Drawing.Size(390, 40);
            this.printContractReturnCarButton.TabIndex = 62;
            this.printContractReturnCarButton.Text = "Распечатать договор возврата машины";
            this.printContractReturnCarButton.UseVisualStyleBackColor = true;
            this.printContractReturnCarButton.Click += new System.EventHandler(this.printContractReturnCarButton_Click);
            // 
            // addAndEditTypeCarDamageOnRentalCarButton
            // 
            this.addAndEditTypeCarDamageOnRentalCarButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.addAndEditTypeCarDamageOnRentalCarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addAndEditTypeCarDamageOnRentalCarButton.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addAndEditTypeCarDamageOnRentalCarButton.Location = new System.Drawing.Point(1092, 636);
            this.addAndEditTypeCarDamageOnRentalCarButton.Name = "addAndEditTypeCarDamageOnRentalCarButton";
            this.addAndEditTypeCarDamageOnRentalCarButton.Size = new System.Drawing.Size(280, 80);
            this.addAndEditTypeCarDamageOnRentalCarButton.TabIndex = 63;
            this.addAndEditTypeCarDamageOnRentalCarButton.Text = "Изменение повреждений машины";
            this.addAndEditTypeCarDamageOnRentalCarButton.UseVisualStyleBackColor = true;
            this.addAndEditTypeCarDamageOnRentalCarButton.Click += new System.EventHandler(this.addAndEditTypeCarDamageOnRentalCarButton_Click);
            // 
            // checkContractIssuedCarButton
            // 
            this.checkContractIssuedCarButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.checkContractIssuedCarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkContractIssuedCarButton.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkContractIssuedCarButton.Location = new System.Drawing.Point(304, 682);
            this.checkContractIssuedCarButton.Name = "checkContractIssuedCarButton";
            this.checkContractIssuedCarButton.Size = new System.Drawing.Size(390, 40);
            this.checkContractIssuedCarButton.TabIndex = 64;
            this.checkContractIssuedCarButton.Text = "Просмотр договора выдачи машины";
            this.checkContractIssuedCarButton.UseVisualStyleBackColor = true;
            this.checkContractIssuedCarButton.Click += new System.EventHandler(this.checkContractIssuedCarButton_Click);
            // 
            // checkContractReturnCarButton
            // 
            this.checkContractReturnCarButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.checkContractReturnCarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkContractReturnCarButton.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkContractReturnCarButton.Location = new System.Drawing.Point(696, 682);
            this.checkContractReturnCarButton.Name = "checkContractReturnCarButton";
            this.checkContractReturnCarButton.Size = new System.Drawing.Size(390, 40);
            this.checkContractReturnCarButton.TabIndex = 65;
            this.checkContractReturnCarButton.Text = "Просмотр договора возврата машины";
            this.checkContractReturnCarButton.UseVisualStyleBackColor = true;
            this.checkContractReturnCarButton.Click += new System.EventHandler(this.checkContractReturnCarButton_Click);
            // 
            // infoSearch1
            // 
            this.infoSearch1.AutoSize = true;
            this.infoSearch1.BackColor = System.Drawing.Color.Beige;
            this.infoSearch1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoSearch1.Location = new System.Drawing.Point(12, 288);
            this.infoSearch1.Name = "infoSearch1";
            this.infoSearch1.Size = new System.Drawing.Size(89, 36);
            this.infoSearch1.TabIndex = 68;
            this.infoSearch1.Text = "Марка";
            this.infoSearch1.Click += new System.EventHandler(this.infoSearch1_Click);
            // 
            // infoSearch2
            // 
            this.infoSearch2.AutoSize = true;
            this.infoSearch2.BackColor = System.Drawing.Color.Beige;
            this.infoSearch2.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoSearch2.Location = new System.Drawing.Point(12, 336);
            this.infoSearch2.Name = "infoSearch2";
            this.infoSearch2.Size = new System.Drawing.Size(97, 36);
            this.infoSearch2.TabIndex = 69;
            this.infoSearch2.Text = "Модель";
            this.infoSearch2.Click += new System.EventHandler(this.infoSearch2_Click);
            // 
            // infoSearch3
            // 
            this.infoSearch3.AutoSize = true;
            this.infoSearch3.BackColor = System.Drawing.Color.Beige;
            this.infoSearch3.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoSearch3.Location = new System.Drawing.Point(12, 382);
            this.infoSearch3.Name = "infoSearch3";
            this.infoSearch3.Size = new System.Drawing.Size(178, 36);
            this.infoSearch3.TabIndex = 70;
            this.infoSearch3.Text = "ФИО Клиента";
            this.infoSearch3.Click += new System.EventHandler(this.infoSearch3_Click);
            // 
            // RentalCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1384, 780);
            this.ControlBox = false;
            this.Controls.Add(this.infoSearch3);
            this.Controls.Add(this.infoSearch2);
            this.Controls.Add(this.infoSearch1);
            this.Controls.Add(this.checkContractReturnCarButton);
            this.Controls.Add(this.checkContractIssuedCarButton);
            this.Controls.Add(this.addAndEditTypeCarDamageOnRentalCarButton);
            this.Controls.Add(this.printContractReturnCarButton);
            this.Controls.Add(this.printContractIssuedCarButton);
            this.Controls.Add(this.modelSearch);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.editRentalCarButton);
            this.Controls.Add(this.rentalCarReturn);
            this.Controls.Add(this.rentalCarTake);
            this.Controls.Add(this.fullNameSearch);
            this.Controls.Add(this.brandSearch);
            this.Controls.Add(this.sortType);
            this.Controls.Add(this.filtrDateButton);
            this.Controls.Add(this.delRentalCarButton);
            this.Controls.Add(this.addRentalCarButton);
            this.Controls.Add(this.checkRentalCarButton);
            this.Controls.Add(this.backMenuButton);
            this.Controls.Add(this.TimeText);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Text1);
            this.Controls.Add(this.RentalCarBD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RentalCars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"Прокаткомпарейшн\"";
            this.Load += new System.EventHandler(this.RentalCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentalCarBD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeText;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.Timer TimeNow;
        private System.Windows.Forms.DataGridView RentalCarBD;
        private System.Windows.Forms.Button backMenuButton;
        private System.Windows.Forms.Button checkRentalCarButton;
        private System.Windows.Forms.Button addRentalCarButton;
        private System.Windows.Forms.Button delRentalCarButton;
        private System.Windows.Forms.Button filtrDateButton;
        private System.Windows.Forms.ComboBox sortType;
        private System.Windows.Forms.TextBox brandSearch;
        private System.Windows.Forms.TextBox fullNameSearch;
        private System.Windows.Forms.DateTimePicker rentalCarTake;
        private System.Windows.Forms.DateTimePicker rentalCarReturn;
        private System.Windows.Forms.Button editRentalCarButton;
        private System.Windows.Forms.Label Text2;
        private System.Windows.Forms.TextBox modelSearch;
        private System.Windows.Forms.Button printContractIssuedCarButton;
        private System.Windows.Forms.Button printContractReturnCarButton;
        private System.Windows.Forms.Button addAndEditTypeCarDamageOnRentalCarButton;
        private System.Windows.Forms.Button checkContractIssuedCarButton;
        private System.Windows.Forms.Button checkContractReturnCarButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCarBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_takeBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_return;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusAdditionalPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusRentalCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItogPriceBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalPricePay;
        private System.Windows.Forms.Label infoSearch1;
        private System.Windows.Forms.Label infoSearch2;
        private System.Windows.Forms.Label infoSearch3;
    }
}