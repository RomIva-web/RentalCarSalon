
namespace CAR_RENTAL.Forms
{
    partial class MenuForEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForEmployee));
            this.TimeNow = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Text1 = new System.Windows.Forms.Label();
            this.TimeText = new System.Windows.Forms.Label();
            this.employeesButton = new System.Windows.Forms.Button();
            this.carsButton = new System.Windows.Forms.Button();
            this.additionalServicesButton = new System.Windows.Forms.Button();
            this.rentalCarsButton = new System.Windows.Forms.Button();
            this.finesButton = new System.Windows.Forms.Button();
            this.clientsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.backMenuButton = new System.Windows.Forms.Button();
            this.driversButton = new System.Windows.Forms.Button();
            this.typeCarDamageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeNow
            // 
            this.TimeNow.Enabled = true;
            this.TimeNow.Tick += new System.EventHandler(this.TimeNow_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::CAR_RENTAL.Properties.Resources.Logotip;
            this.pictureBox2.Location = new System.Drawing.Point(7, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 115);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CAR_RENTAL.Properties.Resources.Logotip;
            this.pictureBox1.Location = new System.Drawing.Point(1248, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Text1
            // 
            this.Text1.AutoSize = true;
            this.Text1.BackColor = System.Drawing.Color.Transparent;
            this.Text1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text1.Location = new System.Drawing.Point(510, 54);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(364, 45);
            this.Text1.TabIndex = 5;
            this.Text1.Text = "Меню для сотрудников";
            // 
            // TimeText
            // 
            this.TimeText.AutoSize = true;
            this.TimeText.BackColor = System.Drawing.Color.Transparent;
            this.TimeText.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeText.Location = new System.Drawing.Point(636, 726);
            this.TimeText.Name = "TimeText";
            this.TimeText.Size = new System.Drawing.Size(37, 45);
            this.TimeText.TabIndex = 16;
            this.TimeText.Text = "1";
            // 
            // employeesButton
            // 
            this.employeesButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.employeesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.employeesButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesButton.Location = new System.Drawing.Point(735, 570);
            this.employeesButton.Name = "employeesButton";
            this.employeesButton.Size = new System.Drawing.Size(530, 91);
            this.employeesButton.TabIndex = 17;
            this.employeesButton.Text = "Сотрудники";
            this.employeesButton.UseVisualStyleBackColor = true;
            this.employeesButton.Visible = false;
            this.employeesButton.Click += new System.EventHandler(this.employeesButton_Click);
            // 
            // carsButton
            // 
            this.carsButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.carsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carsButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carsButton.Location = new System.Drawing.Point(124, 296);
            this.carsButton.Name = "carsButton";
            this.carsButton.Size = new System.Drawing.Size(530, 91);
            this.carsButton.TabIndex = 18;
            this.carsButton.Text = "Машины";
            this.carsButton.UseVisualStyleBackColor = true;
            this.carsButton.Visible = false;
            this.carsButton.Click += new System.EventHandler(this.carsButton_Click);
            // 
            // additionalServicesButton
            // 
            this.additionalServicesButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.additionalServicesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.additionalServicesButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionalServicesButton.Location = new System.Drawing.Point(735, 154);
            this.additionalServicesButton.Name = "additionalServicesButton";
            this.additionalServicesButton.Size = new System.Drawing.Size(530, 91);
            this.additionalServicesButton.TabIndex = 19;
            this.additionalServicesButton.Text = "Дополнительные услуги";
            this.additionalServicesButton.UseVisualStyleBackColor = true;
            this.additionalServicesButton.Visible = false;
            this.additionalServicesButton.Click += new System.EventHandler(this.additionalServicesButton_Click);
            // 
            // rentalCarsButton
            // 
            this.rentalCarsButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.rentalCarsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rentalCarsButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalCarsButton.Location = new System.Drawing.Point(124, 154);
            this.rentalCarsButton.Name = "rentalCarsButton";
            this.rentalCarsButton.Size = new System.Drawing.Size(530, 91);
            this.rentalCarsButton.TabIndex = 19;
            this.rentalCarsButton.Text = "Прокаты";
            this.rentalCarsButton.UseVisualStyleBackColor = true;
            this.rentalCarsButton.Visible = false;
            this.rentalCarsButton.Click += new System.EventHandler(this.rentalCarsButton_Click);
            // 
            // finesButton
            // 
            this.finesButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.finesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.finesButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finesButton.Location = new System.Drawing.Point(735, 434);
            this.finesButton.Name = "finesButton";
            this.finesButton.Size = new System.Drawing.Size(530, 91);
            this.finesButton.TabIndex = 20;
            this.finesButton.Text = "Штрафы";
            this.finesButton.UseVisualStyleBackColor = true;
            this.finesButton.Visible = false;
            this.finesButton.Click += new System.EventHandler(this.finesButton_Click);
            // 
            // clientsButton
            // 
            this.clientsButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.clientsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clientsButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsButton.Location = new System.Drawing.Point(124, 434);
            this.clientsButton.Name = "clientsButton";
            this.clientsButton.Size = new System.Drawing.Size(530, 91);
            this.clientsButton.TabIndex = 21;
            this.clientsButton.Text = "Клиенты";
            this.clientsButton.UseVisualStyleBackColor = true;
            this.clientsButton.Visible = false;
            this.clientsButton.Click += new System.EventHandler(this.clientsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(879, 680);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(233, 91);
            this.exitButton.TabIndex = 22;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // backMenuButton
            // 
            this.backMenuButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.backMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backMenuButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backMenuButton.Location = new System.Drawing.Point(269, 680);
            this.backMenuButton.Name = "backMenuButton";
            this.backMenuButton.Size = new System.Drawing.Size(233, 91);
            this.backMenuButton.TabIndex = 23;
            this.backMenuButton.Text = "На главную";
            this.backMenuButton.UseVisualStyleBackColor = true;
            this.backMenuButton.Click += new System.EventHandler(this.backMenuButton_Click);
            // 
            // driversButton
            // 
            this.driversButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.driversButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.driversButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driversButton.Location = new System.Drawing.Point(735, 296);
            this.driversButton.Name = "driversButton";
            this.driversButton.Size = new System.Drawing.Size(530, 91);
            this.driversButton.TabIndex = 24;
            this.driversButton.Text = "Водители";
            this.driversButton.UseVisualStyleBackColor = true;
            this.driversButton.Visible = false;
            this.driversButton.Click += new System.EventHandler(this.driversButton_Click);
            // 
            // typeCarDamageButton
            // 
            this.typeCarDamageButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.typeCarDamageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.typeCarDamageButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeCarDamageButton.Location = new System.Drawing.Point(124, 570);
            this.typeCarDamageButton.Name = "typeCarDamageButton";
            this.typeCarDamageButton.Size = new System.Drawing.Size(530, 91);
            this.typeCarDamageButton.TabIndex = 25;
            this.typeCarDamageButton.Text = "Типы повреждений";
            this.typeCarDamageButton.UseVisualStyleBackColor = true;
            this.typeCarDamageButton.Visible = false;
            this.typeCarDamageButton.Click += new System.EventHandler(this.typeCarDamageButton_Click);
            // 
            // MenuForEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1384, 780);
            this.ControlBox = false;
            this.Controls.Add(this.typeCarDamageButton);
            this.Controls.Add(this.driversButton);
            this.Controls.Add(this.backMenuButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clientsButton);
            this.Controls.Add(this.finesButton);
            this.Controls.Add(this.rentalCarsButton);
            this.Controls.Add(this.additionalServicesButton);
            this.Controls.Add(this.carsButton);
            this.Controls.Add(this.employeesButton);
            this.Controls.Add(this.TimeText);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Text1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuForEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ООО \"Прокаткомпарейшн\"";
            this.Load += new System.EventHandler(this.MenuForEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TimeNow;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.Label TimeText;
        private System.Windows.Forms.Button employeesButton;
        private System.Windows.Forms.Button carsButton;
        private System.Windows.Forms.Button additionalServicesButton;
        private System.Windows.Forms.Button rentalCarsButton;
        private System.Windows.Forms.Button finesButton;
        private System.Windows.Forms.Button clientsButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button backMenuButton;
        private System.Windows.Forms.Button driversButton;
        private System.Windows.Forms.Button typeCarDamageButton;
    }
}