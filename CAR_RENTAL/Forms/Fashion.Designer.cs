namespace CAR_RENTAL.Forms
{
    partial class Fashion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fashion));
            this.TimeText = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Text1 = new System.Windows.Forms.Label();
            this.TimeNow = new System.Windows.Forms.Timer(this.components);
            this.Text3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Text4 = new System.Windows.Forms.Label();
            this.Text6 = new System.Windows.Forms.Label();
            this.Text5 = new System.Windows.Forms.Label();
            this.Text13 = new System.Windows.Forms.Label();
            this.pricePerDayCar = new System.Windows.Forms.Label();
            this.classCar = new System.Windows.Forms.Label();
            this.Text7 = new System.Windows.Forms.Label();
            this.mileageCar = new System.Windows.Forms.Label();
            this.Text8 = new System.Windows.Forms.Label();
            this.countryCar = new System.Windows.Forms.Label();
            this.Text9 = new System.Windows.Forms.Label();
            this.modelCar = new System.Windows.Forms.Label();
            this.Text10 = new System.Windows.Forms.Label();
            this.brandCar = new System.Windows.Forms.Label();
            this.Text11 = new System.Windows.Forms.Label();
            this.Text12 = new System.Windows.Forms.Label();
            this.statusCar = new System.Windows.Forms.Label();
            this.Text18 = new System.Windows.Forms.Label();
            this.Text14 = new System.Windows.Forms.Label();
            this.Text17 = new System.Windows.Forms.Label();
            this.amountCar = new System.Windows.Forms.Label();
            this.amountFine = new System.Windows.Forms.Label();
            this.amountDriver = new System.Windows.Forms.Label();
            this.Text19 = new System.Windows.Forms.Label();
            this.amountAdditionalService = new System.Windows.Forms.Label();
            this.Text20 = new System.Windows.Forms.Label();
            this.Text15 = new System.Windows.Forms.Label();
            this.Text16 = new System.Windows.Forms.Label();
            this.nameAdditionalService = new System.Windows.Forms.Label();
            this.fullNameDriver = new System.Windows.Forms.Label();
            this.backMenuButton = new System.Windows.Forms.Button();
            this.pricePerDayDriver = new System.Windows.Forms.Label();
            this.Text21 = new System.Windows.Forms.Label();
            this.priceAdditionalService = new System.Windows.Forms.Label();
            this.Text22 = new System.Windows.Forms.Label();
            this.pictureCar = new System.Windows.Forms.PictureBox();
            this.statusDriver = new System.Windows.Forms.Label();
            this.Text24 = new System.Windows.Forms.Label();
            this.fineName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCar)).BeginInit();
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
            this.Text1.Location = new System.Drawing.Point(521, 45);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(344, 45);
            this.Text1.TabIndex = 21;
            this.Text1.Text = "Популярное в заказах";
            // 
            // TimeNow
            // 
            this.TimeNow.Enabled = true;
            this.TimeNow.Tick += new System.EventHandler(this.TimeNow_Tick);
            // 
            // Text3
            // 
            this.Text3.AutoSize = true;
            this.Text3.BackColor = System.Drawing.Color.Transparent;
            this.Text3.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text3.ForeColor = System.Drawing.Color.Black;
            this.Text3.Location = new System.Drawing.Point(12, 188);
            this.Text3.Name = "Text3";
            this.Text3.Size = new System.Drawing.Size(304, 45);
            this.Text3.TabIndex = 25;
            this.Text3.Text = "Заказанная машина";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(559, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 45);
            this.label1.TabIndex = 26;
            // 
            // Text4
            // 
            this.Text4.AutoSize = true;
            this.Text4.BackColor = System.Drawing.Color.Transparent;
            this.Text4.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text4.ForeColor = System.Drawing.Color.Black;
            this.Text4.Location = new System.Drawing.Point(366, 188);
            this.Text4.Name = "Text4";
            this.Text4.Size = new System.Drawing.Size(302, 45);
            this.Text4.TabIndex = 27;
            this.Text4.Text = "Полученный штраф";
            // 
            // Text6
            // 
            this.Text6.AutoSize = true;
            this.Text6.BackColor = System.Drawing.Color.Transparent;
            this.Text6.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text6.ForeColor = System.Drawing.Color.Black;
            this.Text6.Location = new System.Drawing.Point(1147, 188);
            this.Text6.Name = "Text6";
            this.Text6.Size = new System.Drawing.Size(225, 45);
            this.Text6.TabIndex = 28;
            this.Text6.Text = "Взятая услуга";
            // 
            // Text5
            // 
            this.Text5.AutoSize = true;
            this.Text5.BackColor = System.Drawing.Color.Transparent;
            this.Text5.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text5.ForeColor = System.Drawing.Color.Black;
            this.Text5.Location = new System.Drawing.Point(802, 188);
            this.Text5.Name = "Text5";
            this.Text5.Size = new System.Drawing.Size(294, 45);
            this.Text5.TabIndex = 29;
            this.Text5.Text = "Нанятый водитель";
            // 
            // Text13
            // 
            this.Text13.AutoSize = true;
            this.Text13.BackColor = System.Drawing.Color.Transparent;
            this.Text13.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text13.ForeColor = System.Drawing.Color.Black;
            this.Text13.Location = new System.Drawing.Point(14, 572);
            this.Text13.Name = "Text13";
            this.Text13.Size = new System.Drawing.Size(101, 33);
            this.Text13.TabIndex = 75;
            this.Text13.Text = "Статус:";
            // 
            // pricePerDayCar
            // 
            this.pricePerDayCar.AutoSize = true;
            this.pricePerDayCar.BackColor = System.Drawing.Color.Transparent;
            this.pricePerDayCar.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pricePerDayCar.ForeColor = System.Drawing.Color.Black;
            this.pricePerDayCar.Location = new System.Drawing.Point(129, 541);
            this.pricePerDayCar.Name = "pricePerDayCar";
            this.pricePerDayCar.Size = new System.Drawing.Size(27, 33);
            this.pricePerDayCar.TabIndex = 74;
            this.pricePerDayCar.Text = "0";
            // 
            // classCar
            // 
            this.classCar.AutoSize = true;
            this.classCar.BackColor = System.Drawing.Color.Transparent;
            this.classCar.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classCar.ForeColor = System.Drawing.Color.Black;
            this.classCar.Location = new System.Drawing.Point(78, 511);
            this.classCar.Name = "classCar";
            this.classCar.Size = new System.Drawing.Size(27, 33);
            this.classCar.TabIndex = 73;
            this.classCar.Text = "0";
            // 
            // Text7
            // 
            this.Text7.AutoSize = true;
            this.Text7.BackColor = System.Drawing.Color.Transparent;
            this.Text7.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text7.ForeColor = System.Drawing.Color.Black;
            this.Text7.Location = new System.Drawing.Point(14, 382);
            this.Text7.Name = "Text7";
            this.Text7.Size = new System.Drawing.Size(91, 33);
            this.Text7.TabIndex = 63;
            this.Text7.Text = "Марка:";
            // 
            // mileageCar
            // 
            this.mileageCar.AutoSize = true;
            this.mileageCar.BackColor = System.Drawing.Color.Transparent;
            this.mileageCar.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mileageCar.ForeColor = System.Drawing.Color.Black;
            this.mileageCar.Location = new System.Drawing.Point(96, 478);
            this.mileageCar.Name = "mileageCar";
            this.mileageCar.Size = new System.Drawing.Size(27, 33);
            this.mileageCar.TabIndex = 72;
            this.mileageCar.Text = "0";
            // 
            // Text8
            // 
            this.Text8.AutoSize = true;
            this.Text8.BackColor = System.Drawing.Color.Transparent;
            this.Text8.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text8.ForeColor = System.Drawing.Color.Black;
            this.Text8.Location = new System.Drawing.Point(14, 415);
            this.Text8.Name = "Text8";
            this.Text8.Size = new System.Drawing.Size(98, 33);
            this.Text8.TabIndex = 64;
            this.Text8.Text = "Модель:";
            // 
            // countryCar
            // 
            this.countryCar.AutoSize = true;
            this.countryCar.BackColor = System.Drawing.Color.Transparent;
            this.countryCar.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryCar.ForeColor = System.Drawing.Color.Black;
            this.countryCar.Location = new System.Drawing.Point(109, 445);
            this.countryCar.Name = "countryCar";
            this.countryCar.Size = new System.Drawing.Size(27, 33);
            this.countryCar.TabIndex = 71;
            this.countryCar.Text = "0";
            // 
            // Text9
            // 
            this.Text9.AutoSize = true;
            this.Text9.BackColor = System.Drawing.Color.Transparent;
            this.Text9.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text9.ForeColor = System.Drawing.Color.Black;
            this.Text9.Location = new System.Drawing.Point(14, 445);
            this.Text9.Name = "Text9";
            this.Text9.Size = new System.Drawing.Size(99, 33);
            this.Text9.TabIndex = 65;
            this.Text9.Text = "Страна:";
            // 
            // modelCar
            // 
            this.modelCar.AutoSize = true;
            this.modelCar.BackColor = System.Drawing.Color.Transparent;
            this.modelCar.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modelCar.ForeColor = System.Drawing.Color.Black;
            this.modelCar.Location = new System.Drawing.Point(109, 415);
            this.modelCar.Name = "modelCar";
            this.modelCar.Size = new System.Drawing.Size(27, 33);
            this.modelCar.TabIndex = 70;
            this.modelCar.Text = "0";
            // 
            // Text10
            // 
            this.Text10.AutoSize = true;
            this.Text10.BackColor = System.Drawing.Color.Transparent;
            this.Text10.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text10.ForeColor = System.Drawing.Color.Black;
            this.Text10.Location = new System.Drawing.Point(14, 478);
            this.Text10.Name = "Text10";
            this.Text10.Size = new System.Drawing.Size(92, 33);
            this.Text10.TabIndex = 66;
            this.Text10.Text = "Пробег:";
            // 
            // brandCar
            // 
            this.brandCar.AutoSize = true;
            this.brandCar.BackColor = System.Drawing.Color.Transparent;
            this.brandCar.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brandCar.ForeColor = System.Drawing.Color.Black;
            this.brandCar.Location = new System.Drawing.Point(96, 382);
            this.brandCar.Name = "brandCar";
            this.brandCar.Size = new System.Drawing.Size(27, 33);
            this.brandCar.TabIndex = 69;
            this.brandCar.Text = "0";
            // 
            // Text11
            // 
            this.Text11.AutoSize = true;
            this.Text11.BackColor = System.Drawing.Color.Transparent;
            this.Text11.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text11.ForeColor = System.Drawing.Color.Black;
            this.Text11.Location = new System.Drawing.Point(14, 511);
            this.Text11.Name = "Text11";
            this.Text11.Size = new System.Drawing.Size(70, 28);
            this.Text11.TabIndex = 67;
            this.Text11.Text = "Класс:";
            // 
            // Text12
            // 
            this.Text12.AutoSize = true;
            this.Text12.BackColor = System.Drawing.Color.Transparent;
            this.Text12.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text12.ForeColor = System.Drawing.Color.Black;
            this.Text12.Location = new System.Drawing.Point(14, 544);
            this.Text12.Name = "Text12";
            this.Text12.Size = new System.Drawing.Size(121, 28);
            this.Text12.TabIndex = 68;
            this.Text12.Text = "Цена в день:";
            // 
            // statusCar
            // 
            this.statusCar.AutoSize = true;
            this.statusCar.BackColor = System.Drawing.Color.Transparent;
            this.statusCar.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusCar.ForeColor = System.Drawing.Color.Black;
            this.statusCar.Location = new System.Drawing.Point(109, 572);
            this.statusCar.Name = "statusCar";
            this.statusCar.Size = new System.Drawing.Size(27, 33);
            this.statusCar.TabIndex = 76;
            this.statusCar.Text = "0";
            // 
            // Text18
            // 
            this.Text18.AutoSize = true;
            this.Text18.BackColor = System.Drawing.Color.Transparent;
            this.Text18.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text18.ForeColor = System.Drawing.Color.Black;
            this.Text18.Location = new System.Drawing.Point(12, 637);
            this.Text18.Name = "Text18";
            this.Text18.Size = new System.Drawing.Size(142, 33);
            this.Text18.TabIndex = 78;
            this.Text18.Text = "Количество:";
            // 
            // Text14
            // 
            this.Text14.AutoSize = true;
            this.Text14.BackColor = System.Drawing.Color.Transparent;
            this.Text14.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text14.ForeColor = System.Drawing.Color.Black;
            this.Text14.Location = new System.Drawing.Point(368, 233);
            this.Text14.Name = "Text14";
            this.Text14.Size = new System.Drawing.Size(166, 33);
            this.Text14.TabIndex = 80;
            this.Text14.Text = "Наименование:";
            // 
            // Text17
            // 
            this.Text17.AutoSize = true;
            this.Text17.BackColor = System.Drawing.Color.Transparent;
            this.Text17.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text17.ForeColor = System.Drawing.Color.Black;
            this.Text17.Location = new System.Drawing.Point(368, 637);
            this.Text17.Name = "Text17";
            this.Text17.Size = new System.Drawing.Size(142, 33);
            this.Text17.TabIndex = 81;
            this.Text17.Text = "Количество:";
            // 
            // amountCar
            // 
            this.amountCar.AutoSize = true;
            this.amountCar.BackColor = System.Drawing.Color.Transparent;
            this.amountCar.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountCar.ForeColor = System.Drawing.Color.Black;
            this.amountCar.Location = new System.Drawing.Point(151, 637);
            this.amountCar.Name = "amountCar";
            this.amountCar.Size = new System.Drawing.Size(27, 33);
            this.amountCar.TabIndex = 82;
            this.amountCar.Text = "0";
            // 
            // amountFine
            // 
            this.amountFine.AutoSize = true;
            this.amountFine.BackColor = System.Drawing.Color.Transparent;
            this.amountFine.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountFine.ForeColor = System.Drawing.Color.Black;
            this.amountFine.Location = new System.Drawing.Point(507, 637);
            this.amountFine.Name = "amountFine";
            this.amountFine.Size = new System.Drawing.Size(27, 33);
            this.amountFine.TabIndex = 83;
            this.amountFine.Text = "0";
            // 
            // amountDriver
            // 
            this.amountDriver.AutoSize = true;
            this.amountDriver.BackColor = System.Drawing.Color.Transparent;
            this.amountDriver.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountDriver.ForeColor = System.Drawing.Color.Black;
            this.amountDriver.Location = new System.Drawing.Point(943, 637);
            this.amountDriver.Name = "amountDriver";
            this.amountDriver.Size = new System.Drawing.Size(27, 33);
            this.amountDriver.TabIndex = 85;
            this.amountDriver.Text = "0";
            // 
            // Text19
            // 
            this.Text19.AutoSize = true;
            this.Text19.BackColor = System.Drawing.Color.Transparent;
            this.Text19.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text19.ForeColor = System.Drawing.Color.Black;
            this.Text19.Location = new System.Drawing.Point(804, 637);
            this.Text19.Name = "Text19";
            this.Text19.Size = new System.Drawing.Size(142, 33);
            this.Text19.TabIndex = 84;
            this.Text19.Text = "Количество:";
            // 
            // amountAdditionalService
            // 
            this.amountAdditionalService.AutoSize = true;
            this.amountAdditionalService.BackColor = System.Drawing.Color.Transparent;
            this.amountAdditionalService.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountAdditionalService.ForeColor = System.Drawing.Color.Black;
            this.amountAdditionalService.Location = new System.Drawing.Point(1282, 637);
            this.amountAdditionalService.Name = "amountAdditionalService";
            this.amountAdditionalService.Size = new System.Drawing.Size(27, 33);
            this.amountAdditionalService.TabIndex = 87;
            this.amountAdditionalService.Text = "0";
            // 
            // Text20
            // 
            this.Text20.AutoSize = true;
            this.Text20.BackColor = System.Drawing.Color.Transparent;
            this.Text20.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text20.ForeColor = System.Drawing.Color.Black;
            this.Text20.Location = new System.Drawing.Point(1149, 637);
            this.Text20.Name = "Text20";
            this.Text20.Size = new System.Drawing.Size(142, 33);
            this.Text20.TabIndex = 86;
            this.Text20.Text = "Количество:";
            // 
            // Text15
            // 
            this.Text15.AutoSize = true;
            this.Text15.BackColor = System.Drawing.Color.Transparent;
            this.Text15.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text15.ForeColor = System.Drawing.Color.Black;
            this.Text15.Location = new System.Drawing.Point(804, 233);
            this.Text15.Name = "Text15";
            this.Text15.Size = new System.Drawing.Size(177, 33);
            this.Text15.TabIndex = 88;
            this.Text15.Text = "ФИО водителя:";
            // 
            // Text16
            // 
            this.Text16.AutoSize = true;
            this.Text16.BackColor = System.Drawing.Color.Transparent;
            this.Text16.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text16.ForeColor = System.Drawing.Color.Black;
            this.Text16.Location = new System.Drawing.Point(1149, 233);
            this.Text16.Name = "Text16";
            this.Text16.Size = new System.Drawing.Size(115, 33);
            this.Text16.TabIndex = 89;
            this.Text16.Text = "Название:";
            // 
            // nameAdditionalService
            // 
            this.nameAdditionalService.AutoSize = true;
            this.nameAdditionalService.BackColor = System.Drawing.Color.Transparent;
            this.nameAdditionalService.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameAdditionalService.ForeColor = System.Drawing.Color.Black;
            this.nameAdditionalService.Location = new System.Drawing.Point(1149, 272);
            this.nameAdditionalService.Name = "nameAdditionalService";
            this.nameAdditionalService.Size = new System.Drawing.Size(27, 33);
            this.nameAdditionalService.TabIndex = 90;
            this.nameAdditionalService.Text = "0";
            // 
            // fullNameDriver
            // 
            this.fullNameDriver.AutoSize = true;
            this.fullNameDriver.BackColor = System.Drawing.Color.Transparent;
            this.fullNameDriver.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNameDriver.ForeColor = System.Drawing.Color.Black;
            this.fullNameDriver.Location = new System.Drawing.Point(804, 266);
            this.fullNameDriver.Name = "fullNameDriver";
            this.fullNameDriver.Size = new System.Drawing.Size(27, 33);
            this.fullNameDriver.TabIndex = 91;
            this.fullNameDriver.Text = "0";
            // 
            // backMenuButton
            // 
            this.backMenuButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.backMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backMenuButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backMenuButton.Location = new System.Drawing.Point(1156, 709);
            this.backMenuButton.Name = "backMenuButton";
            this.backMenuButton.Size = new System.Drawing.Size(222, 59);
            this.backMenuButton.TabIndex = 92;
            this.backMenuButton.Text = "В меню";
            this.backMenuButton.UseVisualStyleBackColor = true;
            this.backMenuButton.Click += new System.EventHandler(this.backMenuButton_Click);
            // 
            // pricePerDayDriver
            // 
            this.pricePerDayDriver.AutoSize = true;
            this.pricePerDayDriver.BackColor = System.Drawing.Color.Transparent;
            this.pricePerDayDriver.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pricePerDayDriver.ForeColor = System.Drawing.Color.Black;
            this.pricePerDayDriver.Location = new System.Drawing.Point(804, 332);
            this.pricePerDayDriver.Name = "pricePerDayDriver";
            this.pricePerDayDriver.Size = new System.Drawing.Size(27, 33);
            this.pricePerDayDriver.TabIndex = 94;
            this.pricePerDayDriver.Text = "0";
            // 
            // Text21
            // 
            this.Text21.AutoSize = true;
            this.Text21.BackColor = System.Drawing.Color.Transparent;
            this.Text21.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text21.ForeColor = System.Drawing.Color.Black;
            this.Text21.Location = new System.Drawing.Point(804, 299);
            this.Text21.Name = "Text21";
            this.Text21.Size = new System.Drawing.Size(137, 33);
            this.Text21.TabIndex = 93;
            this.Text21.Text = "Цена в день:";
            // 
            // priceAdditionalService
            // 
            this.priceAdditionalService.AutoSize = true;
            this.priceAdditionalService.BackColor = System.Drawing.Color.Transparent;
            this.priceAdditionalService.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceAdditionalService.ForeColor = System.Drawing.Color.Black;
            this.priceAdditionalService.Location = new System.Drawing.Point(1149, 338);
            this.priceAdditionalService.Name = "priceAdditionalService";
            this.priceAdditionalService.Size = new System.Drawing.Size(27, 33);
            this.priceAdditionalService.TabIndex = 96;
            this.priceAdditionalService.Text = "0";
            // 
            // Text22
            // 
            this.Text22.AutoSize = true;
            this.Text22.BackColor = System.Drawing.Color.Transparent;
            this.Text22.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text22.ForeColor = System.Drawing.Color.Black;
            this.Text22.Location = new System.Drawing.Point(1149, 299);
            this.Text22.Name = "Text22";
            this.Text22.Size = new System.Drawing.Size(72, 33);
            this.Text22.TabIndex = 95;
            this.Text22.Text = "Цена:";
            // 
            // pictureCar
            // 
            this.pictureCar.Location = new System.Drawing.Point(20, 233);
            this.pictureCar.Name = "pictureCar";
            this.pictureCar.Size = new System.Drawing.Size(250, 150);
            this.pictureCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCar.TabIndex = 97;
            this.pictureCar.TabStop = false;
            // 
            // statusDriver
            // 
            this.statusDriver.AutoSize = true;
            this.statusDriver.BackColor = System.Drawing.Color.Transparent;
            this.statusDriver.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusDriver.ForeColor = System.Drawing.Color.Black;
            this.statusDriver.Location = new System.Drawing.Point(804, 398);
            this.statusDriver.Name = "statusDriver";
            this.statusDriver.Size = new System.Drawing.Size(27, 33);
            this.statusDriver.TabIndex = 99;
            this.statusDriver.Text = "0";
            // 
            // Text24
            // 
            this.Text24.AutoSize = true;
            this.Text24.BackColor = System.Drawing.Color.Transparent;
            this.Text24.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text24.ForeColor = System.Drawing.Color.Black;
            this.Text24.Location = new System.Drawing.Point(804, 365);
            this.Text24.Name = "Text24";
            this.Text24.Size = new System.Drawing.Size(101, 33);
            this.Text24.TabIndex = 98;
            this.Text24.Text = "Статус:";
            // 
            // fineName
            // 
            this.fineName.BackColor = System.Drawing.Color.Transparent;
            this.fineName.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fineName.ForeColor = System.Drawing.Color.Black;
            this.fineName.Location = new System.Drawing.Point(368, 272);
            this.fineName.Name = "fineName";
            this.fineName.Size = new System.Drawing.Size(407, 352);
            this.fineName.TabIndex = 100;
            this.fineName.Text = "Полученный штраф";
            // 
            // Fashion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1384, 780);
            this.ControlBox = false;
            this.Controls.Add(this.fineName);
            this.Controls.Add(this.statusDriver);
            this.Controls.Add(this.Text24);
            this.Controls.Add(this.pictureCar);
            this.Controls.Add(this.priceAdditionalService);
            this.Controls.Add(this.Text22);
            this.Controls.Add(this.pricePerDayDriver);
            this.Controls.Add(this.Text21);
            this.Controls.Add(this.backMenuButton);
            this.Controls.Add(this.fullNameDriver);
            this.Controls.Add(this.nameAdditionalService);
            this.Controls.Add(this.Text16);
            this.Controls.Add(this.Text15);
            this.Controls.Add(this.amountAdditionalService);
            this.Controls.Add(this.Text20);
            this.Controls.Add(this.amountDriver);
            this.Controls.Add(this.Text19);
            this.Controls.Add(this.amountFine);
            this.Controls.Add(this.amountCar);
            this.Controls.Add(this.Text17);
            this.Controls.Add(this.Text14);
            this.Controls.Add(this.Text18);
            this.Controls.Add(this.statusCar);
            this.Controls.Add(this.Text13);
            this.Controls.Add(this.pricePerDayCar);
            this.Controls.Add(this.classCar);
            this.Controls.Add(this.Text7);
            this.Controls.Add(this.mileageCar);
            this.Controls.Add(this.Text8);
            this.Controls.Add(this.countryCar);
            this.Controls.Add(this.Text9);
            this.Controls.Add(this.modelCar);
            this.Controls.Add(this.Text10);
            this.Controls.Add(this.brandCar);
            this.Controls.Add(this.Text11);
            this.Controls.Add(this.Text12);
            this.Controls.Add(this.Text5);
            this.Controls.Add(this.Text6);
            this.Controls.Add(this.Text4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Text3);
            this.Controls.Add(this.TimeText);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Text1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fashion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"Прокаткомпарейшн\"";
            this.Load += new System.EventHandler(this.Fashion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeText;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.Timer TimeNow;
        private System.Windows.Forms.Label Text3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Text4;
        private System.Windows.Forms.Label Text6;
        private System.Windows.Forms.Label Text5;
        private System.Windows.Forms.Label Text13;
        private System.Windows.Forms.Label pricePerDayCar;
        private System.Windows.Forms.Label classCar;
        private System.Windows.Forms.Label Text7;
        private System.Windows.Forms.Label mileageCar;
        private System.Windows.Forms.Label Text8;
        private System.Windows.Forms.Label countryCar;
        private System.Windows.Forms.Label Text9;
        private System.Windows.Forms.Label modelCar;
        private System.Windows.Forms.Label Text10;
        private System.Windows.Forms.Label brandCar;
        private System.Windows.Forms.Label Text11;
        private System.Windows.Forms.Label Text12;
        private System.Windows.Forms.Label statusCar;
        private System.Windows.Forms.Label Text18;
        private System.Windows.Forms.Label Text14;
        private System.Windows.Forms.Label Text17;
        private System.Windows.Forms.Label amountCar;
        private System.Windows.Forms.Label amountFine;
        private System.Windows.Forms.Label amountDriver;
        private System.Windows.Forms.Label Text19;
        private System.Windows.Forms.Label amountAdditionalService;
        private System.Windows.Forms.Label Text20;
        private System.Windows.Forms.Label Text15;
        private System.Windows.Forms.Label Text16;
        private System.Windows.Forms.Label nameAdditionalService;
        private System.Windows.Forms.Label fullNameDriver;
        private System.Windows.Forms.Button backMenuButton;
        private System.Windows.Forms.Label pricePerDayDriver;
        private System.Windows.Forms.Label Text21;
        private System.Windows.Forms.Label priceAdditionalService;
        private System.Windows.Forms.Label Text22;
        private System.Windows.Forms.PictureBox pictureCar;
        private System.Windows.Forms.Label statusDriver;
        private System.Windows.Forms.Label Text24;
        private System.Windows.Forms.Label fineName;
    }
}