
namespace CAR_RENTAL
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Text1 = new System.Windows.Forms.Label();
            this.Text2 = new System.Windows.Forms.Label();
            this.catalogCarButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.fashionButton = new System.Windows.Forms.Button();
            this.Text3 = new System.Windows.Forms.Label();
            this.BanPassword = new System.Windows.Forms.Timer(this.components);
            this.Text4 = new System.Windows.Forms.Label();
            this.TimeNow = new System.Windows.Forms.Timer(this.components);
            this.Text5 = new System.Windows.Forms.Label();
            this.Text6 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.logInButton = new System.Windows.Forms.Button();
            this.HidePassword = new System.Windows.Forms.Button();
            this.TimeText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Text1
            // 
            this.Text1.AutoSize = true;
            this.Text1.BackColor = System.Drawing.Color.Transparent;
            this.Text1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text1.Location = new System.Drawing.Point(203, 39);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(939, 45);
            this.Text1.TabIndex = 0;
            this.Text1.Text = "Добро пожаловать в системе компании \"Прокаткомпарейшн\"";
            // 
            // Text2
            // 
            this.Text2.AutoSize = true;
            this.Text2.BackColor = System.Drawing.Color.Transparent;
            this.Text2.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text2.ForeColor = System.Drawing.Color.Black;
            this.Text2.Location = new System.Drawing.Point(741, 248);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(541, 225);
            this.Text2.TabIndex = 1;
            this.Text2.Text = "                   Здесь каталог машин\r\n\r\n\r\n\r\n        которые можно взять в прока" +
    "т!";
            // 
            // catalogCarButton
            // 
            this.catalogCarButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.catalogCarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.catalogCarButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catalogCarButton.Location = new System.Drawing.Point(777, 319);
            this.catalogCarButton.Name = "catalogCarButton";
            this.catalogCarButton.Size = new System.Drawing.Size(530, 91);
            this.catalogCarButton.TabIndex = 2;
            this.catalogCarButton.Text = "Каталог машин";
            this.catalogCarButton.UseVisualStyleBackColor = true;
            this.catalogCarButton.Click += new System.EventHandler(this.CatalogCarButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CAR_RENTAL.Properties.Resources.Logotip;
            this.pictureBox1.Location = new System.Drawing.Point(1241, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::CAR_RENTAL.Properties.Resources.Logotip;
            this.pictureBox2.Location = new System.Drawing.Point(0, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 115);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // fashionButton
            // 
            this.fashionButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.fashionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fashionButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fashionButton.Location = new System.Drawing.Point(94, 319);
            this.fashionButton.Name = "fashionButton";
            this.fashionButton.Size = new System.Drawing.Size(530, 91);
            this.fashionButton.TabIndex = 6;
            this.fashionButton.Text = "Популярное в заказах\r\n";
            this.fashionButton.UseVisualStyleBackColor = true;
            this.fashionButton.Click += new System.EventHandler(this.FashionButton_Click);
            // 
            // Text3
            // 
            this.Text3.AutoSize = true;
            this.Text3.BackColor = System.Drawing.Color.Transparent;
            this.Text3.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text3.ForeColor = System.Drawing.Color.Black;
            this.Text3.Location = new System.Drawing.Point(86, 248);
            this.Text3.Name = "Text3";
            this.Text3.Size = new System.Drawing.Size(556, 225);
            this.Text3.TabIndex = 5;
            this.Text3.Text = "            Здесь самые популярные\r\n\r\n\r\n\r\nуслуги, машины, штрафы и водители!";
            // 
            // BanPassword
            // 
            this.BanPassword.Tick += new System.EventHandler(this.BanPassword_Tick);
            // 
            // Text4
            // 
            this.Text4.AutoSize = true;
            this.Text4.BackColor = System.Drawing.Color.Transparent;
            this.Text4.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text4.ForeColor = System.Drawing.Color.Black;
            this.Text4.Location = new System.Drawing.Point(961, 549);
            this.Text4.Name = "Text4";
            this.Text4.Size = new System.Drawing.Size(278, 45);
            this.Text4.TabIndex = 7;
            this.Text4.Text = "Для сотрудников";
            // 
            // TimeNow
            // 
            this.TimeNow.Enabled = true;
            this.TimeNow.Tick += new System.EventHandler(this.TimeNow_Tick);
            // 
            // Text5
            // 
            this.Text5.AutoSize = true;
            this.Text5.BackColor = System.Drawing.Color.Transparent;
            this.Text5.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text5.ForeColor = System.Drawing.Color.Black;
            this.Text5.Location = new System.Drawing.Point(831, 605);
            this.Text5.Name = "Text5";
            this.Text5.Size = new System.Drawing.Size(115, 45);
            this.Text5.TabIndex = 8;
            this.Text5.Text = "Логин:";
            // 
            // Text6
            // 
            this.Text6.AutoSize = true;
            this.Text6.BackColor = System.Drawing.Color.Transparent;
            this.Text6.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text6.ForeColor = System.Drawing.Color.Black;
            this.Text6.Location = new System.Drawing.Point(812, 659);
            this.Text6.Name = "Text6";
            this.Text6.Size = new System.Drawing.Size(133, 45);
            this.Text6.TabIndex = 9;
            this.Text6.Text = "Пароль:";
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Beige;
            this.login.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.ForeColor = System.Drawing.Color.Black;
            this.login.Location = new System.Drawing.Point(946, 614);
            this.login.MaxLength = 50;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(368, 34);
            this.login.TabIndex = 10;
            this.login.Text = "admin";
            this.login.TextChanged += new System.EventHandler(this.login_TextChanged);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.Beige;
            this.password.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.ForeColor = System.Drawing.Color.Black;
            this.password.Location = new System.Drawing.Point(946, 668);
            this.password.MaxLength = 255;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(368, 34);
            this.password.TabIndex = 11;
            this.password.Text = "admin";
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(94, 659);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(392, 91);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // logInButton
            // 
            this.logInButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.logInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logInButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton.Location = new System.Drawing.Point(969, 717);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(265, 53);
            this.logInButton.TabIndex = 13;
            this.logInButton.Text = "Авторизация";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // HidePassword
            // 
            this.HidePassword.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.HidePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HidePassword.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HidePassword.Location = new System.Drawing.Point(1320, 666);
            this.HidePassword.Name = "HidePassword";
            this.HidePassword.Size = new System.Drawing.Size(38, 38);
            this.HidePassword.TabIndex = 14;
            this.HidePassword.Text = "*";
            this.HidePassword.UseVisualStyleBackColor = true;
            this.HidePassword.Click += new System.EventHandler(this.HidePassword_Click);
            // 
            // TimeText
            // 
            this.TimeText.AutoSize = true;
            this.TimeText.BackColor = System.Drawing.Color.Transparent;
            this.TimeText.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeText.Location = new System.Drawing.Point(669, 726);
            this.TimeText.Name = "TimeText";
            this.TimeText.Size = new System.Drawing.Size(37, 45);
            this.TimeText.TabIndex = 15;
            this.TimeText.Text = "1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1384, 780);
            this.ControlBox = false;
            this.Controls.Add(this.TimeText);
            this.Controls.Add(this.HidePassword);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.Text6);
            this.Controls.Add(this.Text5);
            this.Controls.Add(this.Text4);
            this.Controls.Add(this.fashionButton);
            this.Controls.Add(this.Text3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.catalogCarButton);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.Text1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"Прокаткомпарейшн\"";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.Label Text2;
        private System.Windows.Forms.Button catalogCarButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button fashionButton;
        private System.Windows.Forms.Label Text3;
        private System.Windows.Forms.Timer BanPassword;
        private System.Windows.Forms.Label Text4;
        private System.Windows.Forms.Timer TimeNow;
        private System.Windows.Forms.Label Text5;
        private System.Windows.Forms.Label Text6;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Button HidePassword;
        private System.Windows.Forms.Label TimeText;
    }
}

