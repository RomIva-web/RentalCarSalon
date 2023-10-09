namespace CAR_RENTAL.Forms
{
    partial class RegistrationAndEditEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationAndEditEmployee));
            this.TimeText = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Text1 = new System.Windows.Forms.Label();
            this.TimeNow = new System.Windows.Forms.Timer(this.components);
            this.login = new System.Windows.Forms.TextBox();
            this.Text6 = new System.Windows.Forms.Label();
            this.numberPhone = new System.Windows.Forms.TextBox();
            this.Text8 = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.ComboBox();
            this.password = new System.Windows.Forms.TextBox();
            this.fullNameEmployee = new System.Windows.Forms.TextBox();
            this.Text7 = new System.Windows.Forms.Label();
            this.Text5 = new System.Windows.Forms.Label();
            this.Text4 = new System.Windows.Forms.Label();
            this.birthday = new System.Windows.Forms.DateTimePicker();
            this.Text2 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.hidePasswordButton = new System.Windows.Forms.Button();
            this.Text10 = new System.Windows.Forms.Label();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.hideConfirmPasswordButton = new System.Windows.Forms.Button();
            this.editEmployeeButton = new System.Windows.Forms.Button();
            this.infoPasswordButton = new System.Windows.Forms.Button();
            this.Text11 = new System.Windows.Forms.Label();
            this.Text12 = new System.Windows.Forms.Label();
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
            this.Text1.Location = new System.Drawing.Point(471, 58);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(409, 45);
            this.Text1.TabIndex = 21;
            this.Text1.Text = "Регистрация сотрудников";
            // 
            // TimeNow
            // 
            this.TimeNow.Enabled = true;
            this.TimeNow.Tick += new System.EventHandler(this.TimeNow_Tick);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Beige;
            this.login.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.login.Location = new System.Drawing.Point(598, 345);
            this.login.MaxLength = 50;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(335, 34);
            this.login.TabIndex = 58;
            this.login.TextChanged += new System.EventHandler(this.login_TextChanged);
            // 
            // Text6
            // 
            this.Text6.AutoSize = true;
            this.Text6.BackColor = System.Drawing.Color.Transparent;
            this.Text6.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Text6.Location = new System.Drawing.Point(492, 336);
            this.Text6.Name = "Text6";
            this.Text6.Size = new System.Drawing.Size(115, 45);
            this.Text6.TabIndex = 57;
            this.Text6.Text = "Логин:";
            // 
            // numberPhone
            // 
            this.numberPhone.BackColor = System.Drawing.Color.Beige;
            this.numberPhone.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberPhone.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.numberPhone.Location = new System.Drawing.Point(598, 527);
            this.numberPhone.MaxLength = 12;
            this.numberPhone.Name = "numberPhone";
            this.numberPhone.Size = new System.Drawing.Size(335, 34);
            this.numberPhone.TabIndex = 56;
            this.numberPhone.TextChanged += new System.EventHandler(this.numberPhone_TextChanged);
            this.numberPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPhone_KeyPress);
            // 
            // Text8
            // 
            this.Text8.AutoSize = true;
            this.Text8.BackColor = System.Drawing.Color.Transparent;
            this.Text8.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Text8.Location = new System.Drawing.Point(444, 518);
            this.Text8.Name = "Text8";
            this.Text8.Size = new System.Drawing.Size(161, 45);
            this.Text8.TabIndex = 55;
            this.Text8.Text = "Телефон:";
            // 
            // role
            // 
            this.role.BackColor = System.Drawing.Color.Beige;
            this.role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.role.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.role.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.role.FormattingEnabled = true;
            this.role.Location = new System.Drawing.Point(598, 585);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(335, 36);
            this.role.TabIndex = 54;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.Beige;
            this.password.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.password.Location = new System.Drawing.Point(598, 406);
            this.password.MaxLength = 255;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(335, 34);
            this.password.TabIndex = 53;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // fullNameEmployee
            // 
            this.fullNameEmployee.BackColor = System.Drawing.Color.Beige;
            this.fullNameEmployee.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNameEmployee.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.fullNameEmployee.Location = new System.Drawing.Point(598, 223);
            this.fullNameEmployee.MaxLength = 50;
            this.fullNameEmployee.Name = "fullNameEmployee";
            this.fullNameEmployee.Size = new System.Drawing.Size(335, 34);
            this.fullNameEmployee.TabIndex = 52;
            this.fullNameEmployee.TextChanged += new System.EventHandler(this.fullNameEmployee_TextChanged);
            // 
            // Text7
            // 
            this.Text7.AutoSize = true;
            this.Text7.BackColor = System.Drawing.Color.Transparent;
            this.Text7.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Text7.Location = new System.Drawing.Point(472, 397);
            this.Text7.Name = "Text7";
            this.Text7.Size = new System.Drawing.Size(133, 45);
            this.Text7.TabIndex = 51;
            this.Text7.Text = "Пароль:";
            // 
            // Text5
            // 
            this.Text5.AutoSize = true;
            this.Text5.BackColor = System.Drawing.Color.Transparent;
            this.Text5.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Text5.Location = new System.Drawing.Point(413, 576);
            this.Text5.Name = "Text5";
            this.Text5.Size = new System.Drawing.Size(194, 45);
            this.Text5.TabIndex = 50;
            this.Text5.Text = "Должность:";
            // 
            // Text4
            // 
            this.Text4.AutoSize = true;
            this.Text4.BackColor = System.Drawing.Color.Transparent;
            this.Text4.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Text4.Location = new System.Drawing.Point(322, 212);
            this.Text4.Name = "Text4";
            this.Text4.Size = new System.Drawing.Size(283, 45);
            this.Text4.TabIndex = 49;
            this.Text4.Text = "ФИО Сотрудника:";
            // 
            // birthday
            // 
            this.birthday.CalendarForeColor = System.Drawing.Color.DarkSlateGray;
            this.birthday.CalendarMonthBackground = System.Drawing.Color.Beige;
            this.birthday.CalendarTitleForeColor = System.Drawing.Color.DarkSlateGray;
            this.birthday.CalendarTrailingForeColor = System.Drawing.Color.DarkSlateGray;
            this.birthday.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthday.Location = new System.Drawing.Point(598, 283);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(335, 34);
            this.birthday.TabIndex = 67;
            // 
            // Text2
            // 
            this.Text2.AutoSize = true;
            this.Text2.BackColor = System.Drawing.Color.Transparent;
            this.Text2.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Text2.Location = new System.Drawing.Point(352, 276);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(253, 45);
            this.Text2.TabIndex = 66;
            this.Text2.Text = "Дата рождения:";
            // 
            // cancelButton
            // 
            this.cancelButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(800, 682);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(300, 50);
            this.cancelButton.TabIndex = 69;
            this.cancelButton.Text = "Назад";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.addEmployeeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addEmployeeButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeButton.Location = new System.Drawing.Point(279, 682);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(300, 50);
            this.addEmployeeButton.TabIndex = 68;
            this.addEmployeeButton.Text = "Добавить";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // hidePasswordButton
            // 
            this.hidePasswordButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.hidePasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hidePasswordButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hidePasswordButton.Location = new System.Drawing.Point(939, 404);
            this.hidePasswordButton.Name = "hidePasswordButton";
            this.hidePasswordButton.Size = new System.Drawing.Size(38, 38);
            this.hidePasswordButton.TabIndex = 70;
            this.hidePasswordButton.Text = "*";
            this.hidePasswordButton.UseVisualStyleBackColor = true;
            this.hidePasswordButton.Click += new System.EventHandler(this.HidePassword_Click);
            // 
            // Text10
            // 
            this.Text10.AutoSize = true;
            this.Text10.BackColor = System.Drawing.Color.Transparent;
            this.Text10.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Text10.Location = new System.Drawing.Point(276, 456);
            this.Text10.Name = "Text10";
            this.Text10.Size = new System.Drawing.Size(322, 45);
            this.Text10.TabIndex = 71;
            this.Text10.Text = "Подтвердите пароль:";
            // 
            // confirmPassword
            // 
            this.confirmPassword.BackColor = System.Drawing.Color.Beige;
            this.confirmPassword.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmPassword.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.confirmPassword.Location = new System.Drawing.Point(598, 467);
            this.confirmPassword.MaxLength = 255;
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.PasswordChar = '*';
            this.confirmPassword.Size = new System.Drawing.Size(335, 34);
            this.confirmPassword.TabIndex = 72;
            this.confirmPassword.TextChanged += new System.EventHandler(this.confirmPassword_TextChanged);
            // 
            // hideConfirmPasswordButton
            // 
            this.hideConfirmPasswordButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.hideConfirmPasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hideConfirmPasswordButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideConfirmPasswordButton.Location = new System.Drawing.Point(939, 463);
            this.hideConfirmPasswordButton.Name = "hideConfirmPasswordButton";
            this.hideConfirmPasswordButton.Size = new System.Drawing.Size(38, 38);
            this.hideConfirmPasswordButton.TabIndex = 73;
            this.hideConfirmPasswordButton.Text = "*";
            this.hideConfirmPasswordButton.UseVisualStyleBackColor = true;
            this.hideConfirmPasswordButton.Click += new System.EventHandler(this.hideConfirmPasswordButton_Click);
            // 
            // editEmployeeButton
            // 
            this.editEmployeeButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.editEmployeeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editEmployeeButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editEmployeeButton.Location = new System.Drawing.Point(279, 682);
            this.editEmployeeButton.Name = "editEmployeeButton";
            this.editEmployeeButton.Size = new System.Drawing.Size(300, 50);
            this.editEmployeeButton.TabIndex = 74;
            this.editEmployeeButton.Text = "Изменить";
            this.editEmployeeButton.UseVisualStyleBackColor = true;
            this.editEmployeeButton.Click += new System.EventHandler(this.editEmployeeButton_Click);
            // 
            // infoPasswordButton
            // 
            this.infoPasswordButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.infoPasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.infoPasswordButton.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoPasswordButton.Location = new System.Drawing.Point(983, 397);
            this.infoPasswordButton.Name = "infoPasswordButton";
            this.infoPasswordButton.Size = new System.Drawing.Size(38, 47);
            this.infoPasswordButton.TabIndex = 75;
            this.infoPasswordButton.Text = "I";
            this.infoPasswordButton.UseVisualStyleBackColor = true;
            this.infoPasswordButton.Click += new System.EventHandler(this.infoPasswordButton_Click);
            // 
            // Text11
            // 
            this.Text11.AutoSize = true;
            this.Text11.BackColor = System.Drawing.Color.Transparent;
            this.Text11.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text11.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Text11.Location = new System.Drawing.Point(159, 460);
            this.Text11.Name = "Text11";
            this.Text11.Size = new System.Drawing.Size(438, 45);
            this.Text11.TabIndex = 76;
            this.Text11.Text = "Подтвердите старый пароль:";
            // 
            // Text12
            // 
            this.Text12.AutoSize = true;
            this.Text12.BackColor = System.Drawing.Color.Transparent;
            this.Text12.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text12.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Text12.Location = new System.Drawing.Point(253, 397);
            this.Text12.Name = "Text12";
            this.Text12.Size = new System.Drawing.Size(344, 45);
            this.Text12.TabIndex = 77;
            this.Text12.Text = "Введите новый пароль:";
            // 
            // RegistrationAndEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1384, 780);
            this.ControlBox = false;
            this.Controls.Add(this.Text12);
            this.Controls.Add(this.Text11);
            this.Controls.Add(this.infoPasswordButton);
            this.Controls.Add(this.editEmployeeButton);
            this.Controls.Add(this.hideConfirmPasswordButton);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.Text10);
            this.Controls.Add(this.hidePasswordButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addEmployeeButton);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.login);
            this.Controls.Add(this.Text6);
            this.Controls.Add(this.numberPhone);
            this.Controls.Add(this.Text8);
            this.Controls.Add(this.role);
            this.Controls.Add(this.password);
            this.Controls.Add(this.fullNameEmployee);
            this.Controls.Add(this.Text7);
            this.Controls.Add(this.Text5);
            this.Controls.Add(this.Text4);
            this.Controls.Add(this.TimeText);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Text1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrationAndEditEmployee";
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
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label Text6;
        private System.Windows.Forms.TextBox numberPhone;
        private System.Windows.Forms.Label Text8;
        private System.Windows.Forms.ComboBox role;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox fullNameEmployee;
        private System.Windows.Forms.Label Text7;
        private System.Windows.Forms.Label Text5;
        private System.Windows.Forms.Label Text4;
        private System.Windows.Forms.DateTimePicker birthday;
        private System.Windows.Forms.Label Text2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Button hidePasswordButton;
        private System.Windows.Forms.Label Text10;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.Button hideConfirmPasswordButton;
        private System.Windows.Forms.Button editEmployeeButton;
        private System.Windows.Forms.Button infoPasswordButton;
        private System.Windows.Forms.Label Text11;
        private System.Windows.Forms.Label Text12;
    }
}