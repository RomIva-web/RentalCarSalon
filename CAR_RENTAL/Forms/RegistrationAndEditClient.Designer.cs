namespace CAR_RENTAL.Forms
{
    partial class RegistrationAndEditClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationAndEditClient));
            this.TimeText = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Text1 = new System.Windows.Forms.Label();
            this.TimeNow = new System.Windows.Forms.Timer(this.components);
            this.Text4 = new System.Windows.Forms.Label();
            this.birthday = new System.Windows.Forms.DateTimePicker();
            this.numPassport = new System.Windows.Forms.TextBox();
            this.Text6 = new System.Windows.Forms.Label();
            this.numDriverLicense = new System.Windows.Forms.TextBox();
            this.fullNameClient = new System.Windows.Forms.TextBox();
            this.Text7 = new System.Windows.Forms.Label();
            this.Text5 = new System.Windows.Forms.Label();
            this.Text3 = new System.Windows.Forms.Label();
            this.extendsDriverLicense = new System.Windows.Forms.CheckBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addClientButton = new System.Windows.Forms.Button();
            this.editClientButton = new System.Windows.Forms.Button();
            this.clearDriverLicenseButton = new System.Windows.Forms.Button();
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
            this.Text1.Location = new System.Drawing.Point(485, 58);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(361, 45);
            this.Text1.TabIndex = 21;
            this.Text1.Text = "Регистрация клиентов";
            // 
            // TimeNow
            // 
            this.TimeNow.Enabled = true;
            this.TimeNow.Tick += new System.EventHandler(this.TimeNow_Tick);
            // 
            // Text4
            // 
            this.Text4.AutoSize = true;
            this.Text4.BackColor = System.Drawing.Color.Transparent;
            this.Text4.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Text4.Location = new System.Drawing.Point(333, 307);
            this.Text4.Name = "Text4";
            this.Text4.Size = new System.Drawing.Size(569, 45);
            this.Text4.TabIndex = 78;
            this.Text4.Text = "Наличие водительского удостоверения:";
            // 
            // birthday
            // 
            this.birthday.CalendarForeColor = System.Drawing.Color.DarkSlateGray;
            this.birthday.CalendarMonthBackground = System.Drawing.Color.Beige;
            this.birthday.CalendarTitleForeColor = System.Drawing.Color.DarkSlateGray;
            this.birthday.CalendarTrailingForeColor = System.Drawing.Color.DarkSlateGray;
            this.birthday.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthday.Location = new System.Drawing.Point(567, 207);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(335, 34);
            this.birthday.TabIndex = 77;
            this.birthday.Value = new System.DateTime(2006, 1, 1, 0, 0, 0, 0);
            this.birthday.ValueChanged += new System.EventHandler(this.birthday_ValueChanged);
            // 
            // numPassport
            // 
            this.numPassport.BackColor = System.Drawing.Color.Beige;
            this.numPassport.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numPassport.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.numPassport.Location = new System.Drawing.Point(567, 270);
            this.numPassport.MaxLength = 10;
            this.numPassport.Name = "numPassport";
            this.numPassport.Size = new System.Drawing.Size(335, 34);
            this.numPassport.TabIndex = 76;
            this.numPassport.TextChanged += new System.EventHandler(this.numPassport_TextChanged);
            this.numPassport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numPassport_KeyPress);
            // 
            // Text6
            // 
            this.Text6.AutoSize = true;
            this.Text6.BackColor = System.Drawing.Color.Transparent;
            this.Text6.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Text6.Location = new System.Drawing.Point(323, 200);
            this.Text6.Name = "Text6";
            this.Text6.Size = new System.Drawing.Size(253, 45);
            this.Text6.TabIndex = 75;
            this.Text6.Text = "Дата рождения:";
            // 
            // numDriverLicense
            // 
            this.numDriverLicense.BackColor = System.Drawing.Color.Beige;
            this.numDriverLicense.Enabled = false;
            this.numDriverLicense.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numDriverLicense.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.numDriverLicense.Location = new System.Drawing.Point(567, 409);
            this.numDriverLicense.MaxLength = 10;
            this.numDriverLicense.Name = "numDriverLicense";
            this.numDriverLicense.Size = new System.Drawing.Size(335, 34);
            this.numDriverLicense.TabIndex = 74;
            this.numDriverLicense.TextChanged += new System.EventHandler(this.numDriverLicense_TextChanged);
            this.numDriverLicense.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numDriverLicense_KeyPress);
            // 
            // fullNameClient
            // 
            this.fullNameClient.BackColor = System.Drawing.Color.Beige;
            this.fullNameClient.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNameClient.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.fullNameClient.Location = new System.Drawing.Point(567, 150);
            this.fullNameClient.MaxLength = 50;
            this.fullNameClient.Name = "fullNameClient";
            this.fullNameClient.Size = new System.Drawing.Size(335, 34);
            this.fullNameClient.TabIndex = 72;
            this.fullNameClient.TextChanged += new System.EventHandler(this.fullNameClient_TextChanged);
            // 
            // Text7
            // 
            this.Text7.AutoSize = true;
            this.Text7.BackColor = System.Drawing.Color.Transparent;
            this.Text7.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Text7.Location = new System.Drawing.Point(361, 361);
            this.Text7.Name = "Text7";
            this.Text7.Size = new System.Drawing.Size(541, 45);
            this.Text7.TabIndex = 71;
            this.Text7.Text = "Номер водительского удостоверения:";
            // 
            // Text5
            // 
            this.Text5.AutoSize = true;
            this.Text5.BackColor = System.Drawing.Color.Transparent;
            this.Text5.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Text5.Location = new System.Drawing.Point(313, 259);
            this.Text5.Name = "Text5";
            this.Text5.Size = new System.Drawing.Size(263, 45);
            this.Text5.TabIndex = 70;
            this.Text5.Text = "Номер паспорта:";
            // 
            // Text3
            // 
            this.Text3.AutoSize = true;
            this.Text3.BackColor = System.Drawing.Color.Transparent;
            this.Text3.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Text3.Location = new System.Drawing.Point(336, 141);
            this.Text3.Name = "Text3";
            this.Text3.Size = new System.Drawing.Size(240, 45);
            this.Text3.TabIndex = 68;
            this.Text3.Text = "ФИО Клиента:";
            // 
            // extendsDriverLicense
            // 
            this.extendsDriverLicense.AutoSize = true;
            this.extendsDriverLicense.BackColor = System.Drawing.Color.Beige;
            this.extendsDriverLicense.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.extendsDriverLicense.Location = new System.Drawing.Point(898, 327);
            this.extendsDriverLicense.Name = "extendsDriverLicense";
            this.extendsDriverLicense.Size = new System.Drawing.Size(15, 14);
            this.extendsDriverLicense.TabIndex = 79;
            this.extendsDriverLicense.UseVisualStyleBackColor = false;
            this.extendsDriverLicense.CheckedChanged += new System.EventHandler(this.extendsDriverLicense_CheckedChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(794, 676);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(300, 50);
            this.cancelButton.TabIndex = 81;
            this.cancelButton.Text = "Назад";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addClientButton
            // 
            this.addClientButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.addClientButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addClientButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClientButton.Location = new System.Drawing.Point(273, 676);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(300, 50);
            this.addClientButton.TabIndex = 80;
            this.addClientButton.Text = "Добавить";
            this.addClientButton.UseVisualStyleBackColor = true;
            this.addClientButton.Visible = false;
            this.addClientButton.Click += new System.EventHandler(this.addClientButton_Click);
            // 
            // editClientButton
            // 
            this.editClientButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.editClientButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editClientButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editClientButton.Location = new System.Drawing.Point(273, 676);
            this.editClientButton.Name = "editClientButton";
            this.editClientButton.Size = new System.Drawing.Size(300, 50);
            this.editClientButton.TabIndex = 82;
            this.editClientButton.Text = "Изменить";
            this.editClientButton.UseVisualStyleBackColor = true;
            this.editClientButton.Visible = false;
            this.editClientButton.Click += new System.EventHandler(this.editClientButton_Click);
            // 
            // clearDriverLicenseButton
            // 
            this.clearDriverLicenseButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.clearDriverLicenseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearDriverLicenseButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearDriverLicenseButton.Location = new System.Drawing.Point(908, 397);
            this.clearDriverLicenseButton.Name = "clearDriverLicenseButton";
            this.clearDriverLicenseButton.Size = new System.Drawing.Size(262, 50);
            this.clearDriverLicenseButton.TabIndex = 83;
            this.clearDriverLicenseButton.Text = "Очистка номера";
            this.clearDriverLicenseButton.UseVisualStyleBackColor = true;
            this.clearDriverLicenseButton.Click += new System.EventHandler(this.clearDriverLicenseButton_Click);
            // 
            // RegistrationAndEditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1384, 780);
            this.ControlBox = false;
            this.Controls.Add(this.clearDriverLicenseButton);
            this.Controls.Add(this.editClientButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addClientButton);
            this.Controls.Add(this.extendsDriverLicense);
            this.Controls.Add(this.Text4);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.numPassport);
            this.Controls.Add(this.Text6);
            this.Controls.Add(this.numDriverLicense);
            this.Controls.Add(this.fullNameClient);
            this.Controls.Add(this.Text7);
            this.Controls.Add(this.Text5);
            this.Controls.Add(this.Text3);
            this.Controls.Add(this.TimeText);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Text1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrationAndEditClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"Прокаткомпарейшн\"";
            this.Load += new System.EventHandler(this.RegistrationAndEditClient_Load);
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
        private System.Windows.Forms.Label Text4;
        private System.Windows.Forms.DateTimePicker birthday;
        private System.Windows.Forms.TextBox numPassport;
        private System.Windows.Forms.Label Text6;
        private System.Windows.Forms.TextBox numDriverLicense;
        private System.Windows.Forms.TextBox fullNameClient;
        private System.Windows.Forms.Label Text7;
        private System.Windows.Forms.Label Text5;
        private System.Windows.Forms.Label Text3;
        private System.Windows.Forms.CheckBox extendsDriverLicense;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addClientButton;
        private System.Windows.Forms.Button editClientButton;
        private System.Windows.Forms.Button clearDriverLicenseButton;
    }
}