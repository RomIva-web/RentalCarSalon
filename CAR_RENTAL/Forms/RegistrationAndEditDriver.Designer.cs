namespace CAR_RENTAL.Forms
{
    partial class RegistrationAndEditDriver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationAndEditDriver));
            this.TimeText = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Text1 = new System.Windows.Forms.Label();
            this.TimeNow = new System.Windows.Forms.Timer(this.components);
            this.pricePerDay = new System.Windows.Forms.TextBox();
            this.fullNameDriver = new System.Windows.Forms.TextBox();
            this.Text2 = new System.Windows.Forms.Label();
            this.Text3 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addDriverButton = new System.Windows.Forms.Button();
            this.editDriverButton = new System.Windows.Forms.Button();
            this.workStart = new System.Windows.Forms.DateTimePicker();
            this.Text4 = new System.Windows.Forms.Label();
            this.Text5 = new System.Windows.Forms.Label();
            this.workEnd = new System.Windows.Forms.DateTimePicker();
            this.driverLicense = new System.Windows.Forms.TextBox();
            this.Text6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.Text1.Location = new System.Drawing.Point(503, 53);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(360, 45);
            this.Text1.TabIndex = 21;
            this.Text1.Text = "Регистрация водителя";
            // 
            // TimeNow
            // 
            this.TimeNow.Enabled = true;
            this.TimeNow.Tick += new System.EventHandler(this.TimeNow_Tick);
            // 
            // pricePerDay
            // 
            this.pricePerDay.BackColor = System.Drawing.Color.Beige;
            this.pricePerDay.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pricePerDay.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.pricePerDay.Location = new System.Drawing.Point(525, 605);
            this.pricePerDay.Name = "pricePerDay";
            this.pricePerDay.Size = new System.Drawing.Size(335, 34);
            this.pricePerDay.TabIndex = 62;
            this.pricePerDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pricePerDay_KeyPress);
            // 
            // fullNameDriver
            // 
            this.fullNameDriver.BackColor = System.Drawing.Color.Beige;
            this.fullNameDriver.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNameDriver.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.fullNameDriver.Location = new System.Drawing.Point(520, 223);
            this.fullNameDriver.MaxLength = 50;
            this.fullNameDriver.Name = "fullNameDriver";
            this.fullNameDriver.Size = new System.Drawing.Size(335, 34);
            this.fullNameDriver.TabIndex = 61;
            this.fullNameDriver.TextChanged += new System.EventHandler(this.fullNameDriver_TextChanged);
            // 
            // Text2
            // 
            this.Text2.AutoSize = true;
            this.Text2.BackColor = System.Drawing.Color.Transparent;
            this.Text2.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Text2.Location = new System.Drawing.Point(605, 557);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(191, 45);
            this.Text2.TabIndex = 60;
            this.Text2.Text = "Цена в день:";
            // 
            // Text3
            // 
            this.Text3.AutoSize = true;
            this.Text3.BackColor = System.Drawing.Color.Transparent;
            this.Text3.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Text3.Location = new System.Drawing.Point(567, 175);
            this.Text3.Name = "Text3";
            this.Text3.Size = new System.Drawing.Size(252, 45);
            this.Text3.TabIndex = 59;
            this.Text3.Text = "ФИО Водителя:";
            // 
            // cancelButton
            // 
            this.cancelButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(809, 671);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(300, 50);
            this.cancelButton.TabIndex = 64;
            this.cancelButton.Text = "Назад";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addDriverButton
            // 
            this.addDriverButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.addDriverButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addDriverButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDriverButton.Location = new System.Drawing.Point(288, 671);
            this.addDriverButton.Name = "addDriverButton";
            this.addDriverButton.Size = new System.Drawing.Size(300, 50);
            this.addDriverButton.TabIndex = 63;
            this.addDriverButton.Text = "Добавить";
            this.addDriverButton.UseVisualStyleBackColor = true;
            this.addDriverButton.Click += new System.EventHandler(this.addDriverButton_Click);
            // 
            // editDriverButton
            // 
            this.editDriverButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.editDriverButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editDriverButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editDriverButton.Location = new System.Drawing.Point(288, 671);
            this.editDriverButton.Name = "editDriverButton";
            this.editDriverButton.Size = new System.Drawing.Size(300, 50);
            this.editDriverButton.TabIndex = 65;
            this.editDriverButton.Text = "Изменить";
            this.editDriverButton.UseVisualStyleBackColor = true;
            this.editDriverButton.Click += new System.EventHandler(this.editDriverButton_Click);
            // 
            // workStart
            // 
            this.workStart.CalendarForeColor = System.Drawing.Color.DarkSlateGray;
            this.workStart.CalendarMonthBackground = System.Drawing.Color.Beige;
            this.workStart.CalendarTitleBackColor = System.Drawing.Color.Beige;
            this.workStart.CalendarTitleForeColor = System.Drawing.Color.DarkSlateGray;
            this.workStart.CalendarTrailingForeColor = System.Drawing.Color.DarkSlateGray;
            this.workStart.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic);
            this.workStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.workStart.Location = new System.Drawing.Point(520, 412);
            this.workStart.Name = "workStart";
            this.workStart.ShowUpDown = true;
            this.workStart.Size = new System.Drawing.Size(335, 34);
            this.workStart.TabIndex = 66;
            this.workStart.Value = new System.DateTime(2023, 5, 8, 0, 0, 0, 0);
            // 
            // Text4
            // 
            this.Text4.AutoSize = true;
            this.Text4.BackColor = System.Drawing.Color.Transparent;
            this.Text4.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Text4.Location = new System.Drawing.Point(569, 364);
            this.Text4.Name = "Text4";
            this.Text4.Size = new System.Drawing.Size(250, 45);
            this.Text4.TabIndex = 67;
            this.Text4.Text = "Начало работы:";
            // 
            // Text5
            // 
            this.Text5.AutoSize = true;
            this.Text5.BackColor = System.Drawing.Color.Transparent;
            this.Text5.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Text5.Location = new System.Drawing.Point(576, 464);
            this.Text5.Name = "Text5";
            this.Text5.Size = new System.Drawing.Size(232, 45);
            this.Text5.TabIndex = 69;
            this.Text5.Text = "Конец работы:";
            // 
            // workEnd
            // 
            this.workEnd.CalendarForeColor = System.Drawing.Color.DarkSlateGray;
            this.workEnd.CalendarMonthBackground = System.Drawing.Color.Beige;
            this.workEnd.CalendarTitleBackColor = System.Drawing.Color.Beige;
            this.workEnd.CalendarTitleForeColor = System.Drawing.Color.DarkSlateGray;
            this.workEnd.CalendarTrailingForeColor = System.Drawing.Color.DarkSlateGray;
            this.workEnd.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic);
            this.workEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.workEnd.Location = new System.Drawing.Point(520, 512);
            this.workEnd.Name = "workEnd";
            this.workEnd.ShowUpDown = true;
            this.workEnd.Size = new System.Drawing.Size(335, 34);
            this.workEnd.TabIndex = 68;
            this.workEnd.Value = new System.DateTime(2023, 5, 8, 0, 0, 0, 0);
            // 
            // driverLicense
            // 
            this.driverLicense.BackColor = System.Drawing.Color.Beige;
            this.driverLicense.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.driverLicense.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.driverLicense.Location = new System.Drawing.Point(522, 318);
            this.driverLicense.MaxLength = 10;
            this.driverLicense.Name = "driverLicense";
            this.driverLicense.Size = new System.Drawing.Size(335, 34);
            this.driverLicense.TabIndex = 71;
            this.driverLicense.TextChanged += new System.EventHandler(this.driverLicense_TextChanged);
            this.driverLicense.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.driverLicense_KeyPress);
            // 
            // Text6
            // 
            this.Text6.AutoSize = true;
            this.Text6.BackColor = System.Drawing.Color.Transparent;
            this.Text6.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Text6.Location = new System.Drawing.Point(469, 270);
            this.Text6.Name = "Text6";
            this.Text6.Size = new System.Drawing.Size(430, 45);
            this.Text6.TabIndex = 70;
            this.Text6.Text = "Водительское удостоверение:";
            // 
            // RegistrationAndEditDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1384, 780);
            this.ControlBox = false;
            this.Controls.Add(this.driverLicense);
            this.Controls.Add(this.Text6);
            this.Controls.Add(this.Text5);
            this.Controls.Add(this.workEnd);
            this.Controls.Add(this.Text4);
            this.Controls.Add(this.workStart);
            this.Controls.Add(this.editDriverButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addDriverButton);
            this.Controls.Add(this.pricePerDay);
            this.Controls.Add(this.fullNameDriver);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.Text3);
            this.Controls.Add(this.TimeText);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Text1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrationAndEditDriver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"Прокаткомпарейшн\"";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeText;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.Timer TimeNow;
        private System.Windows.Forms.TextBox pricePerDay;
        private System.Windows.Forms.TextBox fullNameDriver;
        private System.Windows.Forms.Label Text2;
        private System.Windows.Forms.Label Text3;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addDriverButton;
        private System.Windows.Forms.Button editDriverButton;
        private System.Windows.Forms.DateTimePicker workStart;
        private System.Windows.Forms.Label Text4;
        private System.Windows.Forms.Label Text5;
        private System.Windows.Forms.DateTimePicker workEnd;
        private System.Windows.Forms.TextBox driverLicense;
        private System.Windows.Forms.Label Text6;
    }
}