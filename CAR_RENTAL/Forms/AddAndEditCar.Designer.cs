namespace CAR_RENTAL.Forms
{
    partial class AddAndEditCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAndEditCar));
            this.TimeText = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Text1 = new System.Windows.Forms.Label();
            this.TimeNow = new System.Windows.Forms.Timer(this.components);
            this.addCarButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.Text2 = new System.Windows.Forms.Label();
            this.addNewCountryButton = new System.Windows.Forms.Button();
            this.newCountryName = new System.Windows.Forms.TextBox();
            this.Text3 = new System.Windows.Forms.Label();
            this.Text4 = new System.Windows.Forms.Label();
            this.Text5 = new System.Windows.Forms.Label();
            this.Text7 = new System.Windows.Forms.Label();
            this.brand = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.TextBox();
            this.pricePerDay = new System.Windows.Forms.TextBox();
            this.countryName = new System.Windows.Forms.ComboBox();
            this.carImage = new System.Windows.Forms.PictureBox();
            this.takeWayPictureButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.Text6 = new System.Windows.Forms.Label();
            this.mileage = new System.Windows.Forms.TextBox();
            this.editCarButton = new System.Windows.Forms.Button();
            this.statusCatalogCar = new System.Windows.Forms.ComboBox();
            this.Text8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carImage)).BeginInit();
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
            this.Text1.Location = new System.Drawing.Point(503, 45);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(326, 45);
            this.Text1.TabIndex = 21;
            this.Text1.Text = "Добавление машины";
            // 
            // TimeNow
            // 
            this.TimeNow.Enabled = true;
            this.TimeNow.Tick += new System.EventHandler(this.TimeNow_Tick);
            // 
            // addCarButton
            // 
            this.addCarButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.addCarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addCarButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCarButton.Location = new System.Drawing.Point(279, 663);
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Size = new System.Drawing.Size(300, 50);
            this.addCarButton.TabIndex = 25;
            this.addCarButton.Text = "Добавить";
            this.addCarButton.UseVisualStyleBackColor = true;
            this.addCarButton.Click += new System.EventHandler(this.addCarButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(800, 663);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(300, 50);
            this.cancelButton.TabIndex = 26;
            this.cancelButton.Text = "Назад";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Text2
            // 
            this.Text2.AutoSize = true;
            this.Text2.BackColor = System.Drawing.Color.Transparent;
            this.Text2.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Text2.Location = new System.Drawing.Point(98, 148);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(127, 45);
            this.Text2.TabIndex = 27;
            this.Text2.Text = "Страна";
            // 
            // addNewCountryButton
            // 
            this.addNewCountryButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.addNewCountryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addNewCountryButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewCountryButton.Location = new System.Drawing.Point(22, 269);
            this.addNewCountryButton.Name = "addNewCountryButton";
            this.addNewCountryButton.Size = new System.Drawing.Size(300, 50);
            this.addNewCountryButton.TabIndex = 28;
            this.addNewCountryButton.Text = "Добавить";
            this.addNewCountryButton.UseVisualStyleBackColor = true;
            this.addNewCountryButton.Click += new System.EventHandler(this.addNewCountryButton_Click);
            // 
            // newCountryName
            // 
            this.newCountryName.BackColor = System.Drawing.Color.Beige;
            this.newCountryName.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newCountryName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.newCountryName.Location = new System.Drawing.Point(22, 215);
            this.newCountryName.MaxLength = 50;
            this.newCountryName.Name = "newCountryName";
            this.newCountryName.Size = new System.Drawing.Size(300, 34);
            this.newCountryName.TabIndex = 29;
            this.newCountryName.TextChanged += new System.EventHandler(this.newCountryName_TextChanged);
            // 
            // Text3
            // 
            this.Text3.AutoSize = true;
            this.Text3.BackColor = System.Drawing.Color.Transparent;
            this.Text3.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Text3.Location = new System.Drawing.Point(426, 168);
            this.Text3.Name = "Text3";
            this.Text3.Size = new System.Drawing.Size(125, 45);
            this.Text3.TabIndex = 30;
            this.Text3.Text = "Марка:";
            // 
            // Text4
            // 
            this.Text4.AutoSize = true;
            this.Text4.BackColor = System.Drawing.Color.Transparent;
            this.Text4.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Text4.Location = new System.Drawing.Point(414, 226);
            this.Text4.Name = "Text4";
            this.Text4.Size = new System.Drawing.Size(135, 45);
            this.Text4.TabIndex = 31;
            this.Text4.Text = "Модель:";
            // 
            // Text5
            // 
            this.Text5.AutoSize = true;
            this.Text5.BackColor = System.Drawing.Color.Transparent;
            this.Text5.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Text5.Location = new System.Drawing.Point(414, 288);
            this.Text5.Name = "Text5";
            this.Text5.Size = new System.Drawing.Size(137, 45);
            this.Text5.TabIndex = 32;
            this.Text5.Text = "Страна:";
            // 
            // Text7
            // 
            this.Text7.AutoSize = true;
            this.Text7.BackColor = System.Drawing.Color.Transparent;
            this.Text7.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Text7.Location = new System.Drawing.Point(360, 411);
            this.Text7.Name = "Text7";
            this.Text7.Size = new System.Drawing.Size(191, 45);
            this.Text7.TabIndex = 35;
            this.Text7.Text = "Цена в день:";
            // 
            // brand
            // 
            this.brand.BackColor = System.Drawing.Color.Beige;
            this.brand.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brand.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.brand.Location = new System.Drawing.Point(544, 177);
            this.brand.MaxLength = 30;
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(335, 34);
            this.brand.TabIndex = 36;
            this.brand.TextChanged += new System.EventHandler(this.brand_TextChanged);
            // 
            // model
            // 
            this.model.BackColor = System.Drawing.Color.Beige;
            this.model.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.model.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.model.Location = new System.Drawing.Point(544, 237);
            this.model.MaxLength = 30;
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(335, 34);
            this.model.TabIndex = 37;
            this.model.TextChanged += new System.EventHandler(this.model_TextChanged);
            // 
            // pricePerDay
            // 
            this.pricePerDay.BackColor = System.Drawing.Color.Beige;
            this.pricePerDay.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pricePerDay.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.pricePerDay.Location = new System.Drawing.Point(546, 420);
            this.pricePerDay.Name = "pricePerDay";
            this.pricePerDay.Size = new System.Drawing.Size(335, 34);
            this.pricePerDay.TabIndex = 39;
            this.pricePerDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pricePerDay_KeyPress);
            // 
            // countryName
            // 
            this.countryName.BackColor = System.Drawing.Color.Beige;
            this.countryName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryName.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.countryName.FormattingEnabled = true;
            this.countryName.Location = new System.Drawing.Point(544, 297);
            this.countryName.Name = "countryName";
            this.countryName.Size = new System.Drawing.Size(335, 36);
            this.countryName.TabIndex = 40;
            // 
            // carImage
            // 
            this.carImage.Location = new System.Drawing.Point(1026, 215);
            this.carImage.Name = "carImage";
            this.carImage.Size = new System.Drawing.Size(300, 200);
            this.carImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carImage.TabIndex = 44;
            this.carImage.TabStop = false;
            // 
            // takeWayPictureButton
            // 
            this.takeWayPictureButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.takeWayPictureButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.takeWayPictureButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeWayPictureButton.Location = new System.Drawing.Point(992, 437);
            this.takeWayPictureButton.Name = "takeWayPictureButton";
            this.takeWayPictureButton.Size = new System.Drawing.Size(367, 66);
            this.takeWayPictureButton.TabIndex = 45;
            this.takeWayPictureButton.Text = "Загрузить фотографию";
            this.takeWayPictureButton.UseVisualStyleBackColor = true;
            this.takeWayPictureButton.Click += new System.EventHandler(this.takeWayPictureButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.infoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.infoButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoButton.Location = new System.Drawing.Point(936, 445);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(50, 50);
            this.infoButton.TabIndex = 46;
            this.infoButton.Text = "i";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // Text6
            // 
            this.Text6.AutoSize = true;
            this.Text6.BackColor = System.Drawing.Color.Transparent;
            this.Text6.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Text6.Location = new System.Drawing.Point(424, 350);
            this.Text6.Name = "Text6";
            this.Text6.Size = new System.Drawing.Size(127, 45);
            this.Text6.TabIndex = 47;
            this.Text6.Text = "Пробег:";
            // 
            // mileage
            // 
            this.mileage.BackColor = System.Drawing.Color.Beige;
            this.mileage.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mileage.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.mileage.Location = new System.Drawing.Point(546, 359);
            this.mileage.Name = "mileage";
            this.mileage.Size = new System.Drawing.Size(335, 34);
            this.mileage.TabIndex = 48;
            this.mileage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mileage_KeyPress);
            // 
            // editCarButton
            // 
            this.editCarButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.editCarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editCarButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCarButton.Location = new System.Drawing.Point(279, 663);
            this.editCarButton.Name = "editCarButton";
            this.editCarButton.Size = new System.Drawing.Size(300, 50);
            this.editCarButton.TabIndex = 49;
            this.editCarButton.Text = "Изменить";
            this.editCarButton.UseVisualStyleBackColor = true;
            this.editCarButton.Click += new System.EventHandler(this.editCarButton_Click);
            // 
            // statusCatalogCar
            // 
            this.statusCatalogCar.BackColor = System.Drawing.Color.Beige;
            this.statusCatalogCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusCatalogCar.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusCatalogCar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.statusCatalogCar.FormattingEnabled = true;
            this.statusCatalogCar.Location = new System.Drawing.Point(546, 480);
            this.statusCatalogCar.Name = "statusCatalogCar";
            this.statusCatalogCar.Size = new System.Drawing.Size(335, 36);
            this.statusCatalogCar.TabIndex = 51;
            // 
            // Text8
            // 
            this.Text8.AutoSize = true;
            this.Text8.BackColor = System.Drawing.Color.Transparent;
            this.Text8.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Text8.Location = new System.Drawing.Point(245, 471);
            this.Text8.Name = "Text8";
            this.Text8.Size = new System.Drawing.Size(306, 45);
            this.Text8.TabIndex = 50;
            this.Text8.Text = "Состояние машины:";
            // 
            // AddAndEditCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1384, 780);
            this.ControlBox = false;
            this.Controls.Add(this.statusCatalogCar);
            this.Controls.Add(this.Text8);
            this.Controls.Add(this.editCarButton);
            this.Controls.Add(this.mileage);
            this.Controls.Add(this.Text6);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.takeWayPictureButton);
            this.Controls.Add(this.carImage);
            this.Controls.Add(this.countryName);
            this.Controls.Add(this.pricePerDay);
            this.Controls.Add(this.model);
            this.Controls.Add(this.brand);
            this.Controls.Add(this.Text7);
            this.Controls.Add(this.Text5);
            this.Controls.Add(this.Text4);
            this.Controls.Add(this.Text3);
            this.Controls.Add(this.newCountryName);
            this.Controls.Add(this.addNewCountryButton);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addCarButton);
            this.Controls.Add(this.TimeText);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Text1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddAndEditCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"Прокаткомпарейшн\"";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeText;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.Timer TimeNow;
        private System.Windows.Forms.Button addCarButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label Text2;
        private System.Windows.Forms.Button addNewCountryButton;
        private System.Windows.Forms.TextBox newCountryName;
        private System.Windows.Forms.Label Text3;
        private System.Windows.Forms.Label Text4;
        private System.Windows.Forms.Label Text5;
        private System.Windows.Forms.Label Text7;
        private System.Windows.Forms.TextBox brand;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.TextBox pricePerDay;
        private System.Windows.Forms.ComboBox countryName;
        private System.Windows.Forms.PictureBox carImage;
        private System.Windows.Forms.Button takeWayPictureButton;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Label Text6;
        private System.Windows.Forms.TextBox mileage;
        private System.Windows.Forms.Button editCarButton;
        private System.Windows.Forms.ComboBox statusCatalogCar;
        private System.Windows.Forms.Label Text8;
    }
}