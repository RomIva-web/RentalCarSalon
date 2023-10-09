namespace CAR_RENTAL.Forms
{
    partial class AddAndEditAdditionalService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAndEditAdditionalService));
            this.TimeText = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Text1 = new System.Windows.Forms.Label();
            this.TimeNow = new System.Windows.Forms.Timer(this.components);
            this.priceAdditionalService = new System.Windows.Forms.TextBox();
            this.nameAdditionalService = new System.Windows.Forms.TextBox();
            this.Text4 = new System.Windows.Forms.Label();
            this.Text3 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addAdditionalServiceButton = new System.Windows.Forms.Button();
            this.editAdditionalServiceButton = new System.Windows.Forms.Button();
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
            this.Text1.Location = new System.Drawing.Point(540, 45);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(296, 45);
            this.Text1.TabIndex = 21;
            this.Text1.Text = "Добавление услуги";
            // 
            // TimeNow
            // 
            this.TimeNow.Enabled = true;
            this.TimeNow.Tick += new System.EventHandler(this.TimeNow_Tick);
            // 
            // priceAdditionalService
            // 
            this.priceAdditionalService.BackColor = System.Drawing.Color.Beige;
            this.priceAdditionalService.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceAdditionalService.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.priceAdditionalService.Location = new System.Drawing.Point(530, 445);
            this.priceAdditionalService.Name = "priceAdditionalService";
            this.priceAdditionalService.Size = new System.Drawing.Size(335, 34);
            this.priceAdditionalService.TabIndex = 54;
            this.priceAdditionalService.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceAdditionalService_KeyPress);
            // 
            // nameAdditionalService
            // 
            this.nameAdditionalService.BackColor = System.Drawing.Color.Beige;
            this.nameAdditionalService.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameAdditionalService.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.nameAdditionalService.Location = new System.Drawing.Point(532, 337);
            this.nameAdditionalService.MaxLength = 30;
            this.nameAdditionalService.Name = "nameAdditionalService";
            this.nameAdditionalService.Size = new System.Drawing.Size(335, 34);
            this.nameAdditionalService.TabIndex = 53;
            this.nameAdditionalService.TextChanged += new System.EventHandler(this.nameAdditionalService_TextChanged);
            // 
            // Text4
            // 
            this.Text4.AutoSize = true;
            this.Text4.BackColor = System.Drawing.Color.Transparent;
            this.Text4.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Text4.Location = new System.Drawing.Point(579, 397);
            this.Text4.Name = "Text4";
            this.Text4.Size = new System.Drawing.Size(234, 45);
            this.Text4.TabIndex = 50;
            this.Text4.Text = "Цена за услугу:";
            // 
            // Text3
            // 
            this.Text3.AutoSize = true;
            this.Text3.BackColor = System.Drawing.Color.Transparent;
            this.Text3.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Text3.Location = new System.Drawing.Point(449, 289);
            this.Text3.Name = "Text3";
            this.Text3.Size = new System.Drawing.Size(495, 45);
            this.Text3.TabIndex = 49;
            this.Text3.Text = "Название дополнительной услуги:";
            // 
            // cancelButton
            // 
            this.cancelButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(808, 718);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(300, 50);
            this.cancelButton.TabIndex = 56;
            this.cancelButton.Text = "Назад";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addAdditionalServiceButton
            // 
            this.addAdditionalServiceButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.addAdditionalServiceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addAdditionalServiceButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAdditionalServiceButton.Location = new System.Drawing.Point(287, 718);
            this.addAdditionalServiceButton.Name = "addAdditionalServiceButton";
            this.addAdditionalServiceButton.Size = new System.Drawing.Size(300, 50);
            this.addAdditionalServiceButton.TabIndex = 55;
            this.addAdditionalServiceButton.Text = "Добавить";
            this.addAdditionalServiceButton.UseVisualStyleBackColor = true;
            this.addAdditionalServiceButton.Click += new System.EventHandler(this.addAdditionalServiceButton_Click);
            // 
            // editAdditionalServiceButton
            // 
            this.editAdditionalServiceButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.editAdditionalServiceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editAdditionalServiceButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editAdditionalServiceButton.Location = new System.Drawing.Point(287, 695);
            this.editAdditionalServiceButton.Name = "editAdditionalServiceButton";
            this.editAdditionalServiceButton.Size = new System.Drawing.Size(300, 50);
            this.editAdditionalServiceButton.TabIndex = 57;
            this.editAdditionalServiceButton.Text = "Изменить";
            this.editAdditionalServiceButton.UseVisualStyleBackColor = true;
            this.editAdditionalServiceButton.Click += new System.EventHandler(this.editAdditionalServiceButton_Click);
            // 
            // AddAndEditAdditionalService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1384, 780);
            this.ControlBox = false;
            this.Controls.Add(this.editAdditionalServiceButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addAdditionalServiceButton);
            this.Controls.Add(this.priceAdditionalService);
            this.Controls.Add(this.nameAdditionalService);
            this.Controls.Add(this.Text4);
            this.Controls.Add(this.Text3);
            this.Controls.Add(this.TimeText);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Text1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddAndEditAdditionalService";
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
        private System.Windows.Forms.TextBox priceAdditionalService;
        private System.Windows.Forms.TextBox nameAdditionalService;
        private System.Windows.Forms.Label Text4;
        private System.Windows.Forms.Label Text3;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addAdditionalServiceButton;
        private System.Windows.Forms.Button editAdditionalServiceButton;
    }
}