namespace CAR_RENTAL.Forms
{
    partial class AddAndEditFine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAndEditFine));
            this.TimeText = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Text1 = new System.Windows.Forms.Label();
            this.TimeNow = new System.Windows.Forms.Timer(this.components);
            this.Text6 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.Text7 = new System.Windows.Forms.Label();
            this.Text5 = new System.Windows.Forms.Label();
            this.Text4 = new System.Windows.Forms.Label();
            this.Text3 = new System.Windows.Forms.Label();
            this.newFineName = new System.Windows.Forms.TextBox();
            this.addNewFineName = new System.Windows.Forms.Button();
            this.Text2 = new System.Windows.Forms.Label();
            this.fineReceipt = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.fineName = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addFineButton = new System.Windows.Forms.Button();
            this.FIOIntruder = new System.Windows.Forms.ComboBox();
            this.brand = new System.Windows.Forms.ComboBox();
            this.model = new System.Windows.Forms.ComboBox();
            this.editFineButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
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
            this.Text1.Location = new System.Drawing.Point(527, 50);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(323, 45);
            this.Text1.TabIndex = 21;
            this.Text1.Text = "Добавление штрафа";
            // 
            // TimeNow
            // 
            this.TimeNow.Enabled = true;
            this.TimeNow.Tick += new System.EventHandler(this.TimeNow_Tick);
            // 
            // Text6
            // 
            this.Text6.AutoSize = true;
            this.Text6.BackColor = System.Drawing.Color.Transparent;
            this.Text6.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Text6.Location = new System.Drawing.Point(322, 272);
            this.Text6.Name = "Text6";
            this.Text6.Size = new System.Drawing.Size(235, 45);
            this.Text6.TabIndex = 59;
            this.Text6.Text = "Дата штрафа:";
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.Color.Beige;
            this.price.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.price.Location = new System.Drawing.Point(546, 337);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(335, 34);
            this.price.TabIndex = 55;
            this.price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_KeyPress);
            // 
            // Text7
            // 
            this.Text7.AutoSize = true;
            this.Text7.BackColor = System.Drawing.Color.Transparent;
            this.Text7.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Text7.Location = new System.Drawing.Point(452, 328);
            this.Text7.Name = "Text7";
            this.Text7.Size = new System.Drawing.Size(101, 45);
            this.Text7.TabIndex = 52;
            this.Text7.Text = "Цена:";
            // 
            // Text5
            // 
            this.Text5.AutoSize = true;
            this.Text5.BackColor = System.Drawing.Color.Transparent;
            this.Text5.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Text5.Location = new System.Drawing.Point(418, 505);
            this.Text5.Name = "Text5";
            this.Text5.Size = new System.Drawing.Size(135, 45);
            this.Text5.TabIndex = 51;
            this.Text5.Text = "Модель:";
            // 
            // Text4
            // 
            this.Text4.AutoSize = true;
            this.Text4.BackColor = System.Drawing.Color.Transparent;
            this.Text4.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Text4.Location = new System.Drawing.Point(428, 443);
            this.Text4.Name = "Text4";
            this.Text4.Size = new System.Drawing.Size(125, 45);
            this.Text4.TabIndex = 50;
            this.Text4.Text = "Марка:";
            // 
            // Text3
            // 
            this.Text3.AutoSize = true;
            this.Text3.BackColor = System.Drawing.Color.Transparent;
            this.Text3.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Text3.Location = new System.Drawing.Point(258, 385);
            this.Text3.Name = "Text3";
            this.Text3.Size = new System.Drawing.Size(295, 45);
            this.Text3.TabIndex = 49;
            this.Text3.Text = "ФИО Нарушителя:";
            // 
            // newFineName
            // 
            this.newFineName.BackColor = System.Drawing.Color.Beige;
            this.newFineName.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newFineName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.newFineName.Location = new System.Drawing.Point(924, 325);
            this.newFineName.MaxLength = 255;
            this.newFineName.Name = "newFineName";
            this.newFineName.Size = new System.Drawing.Size(439, 34);
            this.newFineName.TabIndex = 63;
            this.newFineName.TextChanged += new System.EventHandler(this.newFineName_TextChanged);
            // 
            // addNewFineName
            // 
            this.addNewFineName.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.addNewFineName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addNewFineName.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewFineName.Location = new System.Drawing.Point(1000, 365);
            this.addNewFineName.Name = "addNewFineName";
            this.addNewFineName.Size = new System.Drawing.Size(300, 50);
            this.addNewFineName.TabIndex = 62;
            this.addNewFineName.Text = "Добавить";
            this.addNewFineName.UseVisualStyleBackColor = true;
            this.addNewFineName.Click += new System.EventHandler(this.addNewFineName_Click);
            // 
            // Text2
            // 
            this.Text2.AutoSize = true;
            this.Text2.BackColor = System.Drawing.Color.Transparent;
            this.Text2.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Text2.Location = new System.Drawing.Point(992, 265);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(302, 45);
            this.Text2.TabIndex = 61;
            this.Text2.Text = "Новый вид штрафа:";
            // 
            // fineReceipt
            // 
            this.fineReceipt.CalendarForeColor = System.Drawing.Color.DarkSlateGray;
            this.fineReceipt.CalendarMonthBackground = System.Drawing.Color.Beige;
            this.fineReceipt.CalendarTitleForeColor = System.Drawing.Color.DarkSlateGray;
            this.fineReceipt.CalendarTrailingForeColor = System.Drawing.Color.DarkSlateGray;
            this.fineReceipt.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fineReceipt.Location = new System.Drawing.Point(546, 279);
            this.fineReceipt.Name = "fineReceipt";
            this.fineReceipt.Size = new System.Drawing.Size(335, 34);
            this.fineReceipt.TabIndex = 65;
            this.fineReceipt.ValueChanged += new System.EventHandler(this.fineReceipt_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(634, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 45);
            this.label1.TabIndex = 66;
            this.label1.Text = "Штраф:";
            // 
            // fineName
            // 
            this.fineName.BackColor = System.Drawing.Color.Beige;
            this.fineName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fineName.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fineName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.fineName.FormattingEnabled = true;
            this.fineName.Location = new System.Drawing.Point(34, 199);
            this.fineName.Name = "fineName";
            this.fineName.Size = new System.Drawing.Size(1329, 36);
            this.fineName.TabIndex = 67;
            // 
            // cancelButton
            // 
            this.cancelButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(787, 691);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(300, 50);
            this.cancelButton.TabIndex = 69;
            this.cancelButton.Text = "Назад";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addFineButton
            // 
            this.addFineButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.addFineButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addFineButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFineButton.Location = new System.Drawing.Point(266, 691);
            this.addFineButton.Name = "addFineButton";
            this.addFineButton.Size = new System.Drawing.Size(300, 50);
            this.addFineButton.TabIndex = 68;
            this.addFineButton.Text = "Добавить";
            this.addFineButton.UseVisualStyleBackColor = true;
            this.addFineButton.Click += new System.EventHandler(this.addFineButton_Click);
            // 
            // FIOIntruder
            // 
            this.FIOIntruder.BackColor = System.Drawing.Color.Beige;
            this.FIOIntruder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FIOIntruder.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOIntruder.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FIOIntruder.FormattingEnabled = true;
            this.FIOIntruder.Location = new System.Drawing.Point(546, 392);
            this.FIOIntruder.Name = "FIOIntruder";
            this.FIOIntruder.Size = new System.Drawing.Size(335, 36);
            this.FIOIntruder.TabIndex = 70;
            this.FIOIntruder.SelectedIndexChanged += new System.EventHandler(this.FIOIntruder_SelectedIndexChanged);
            // 
            // brand
            // 
            this.brand.BackColor = System.Drawing.Color.Beige;
            this.brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brand.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brand.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.brand.FormattingEnabled = true;
            this.brand.Location = new System.Drawing.Point(546, 452);
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(335, 36);
            this.brand.TabIndex = 71;
            this.brand.SelectedIndexChanged += new System.EventHandler(this.brand_SelectedIndexChanged);
            // 
            // model
            // 
            this.model.BackColor = System.Drawing.Color.Beige;
            this.model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.model.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.model.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.model.FormattingEnabled = true;
            this.model.Location = new System.Drawing.Point(546, 514);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(335, 36);
            this.model.TabIndex = 72;
            // 
            // editFineButton
            // 
            this.editFineButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.editFineButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editFineButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editFineButton.Location = new System.Drawing.Point(266, 691);
            this.editFineButton.Name = "editFineButton";
            this.editFineButton.Size = new System.Drawing.Size(300, 50);
            this.editFineButton.TabIndex = 73;
            this.editFineButton.Text = "Изменить";
            this.editFineButton.UseVisualStyleBackColor = true;
            this.editFineButton.Click += new System.EventHandler(this.editFineButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.infoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.infoButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoButton.Location = new System.Drawing.Point(782, 143);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(43, 50);
            this.infoButton.TabIndex = 74;
            this.infoButton.Text = "I";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Visible = false;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // AddAndEditFine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1384, 780);
            this.ControlBox = false;
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.editFineButton);
            this.Controls.Add(this.model);
            this.Controls.Add(this.brand);
            this.Controls.Add(this.FIOIntruder);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addFineButton);
            this.Controls.Add(this.fineName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fineReceipt);
            this.Controls.Add(this.newFineName);
            this.Controls.Add(this.addNewFineName);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.Text6);
            this.Controls.Add(this.price);
            this.Controls.Add(this.Text7);
            this.Controls.Add(this.Text5);
            this.Controls.Add(this.Text4);
            this.Controls.Add(this.Text3);
            this.Controls.Add(this.TimeText);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Text1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddAndEditFine";
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
        private System.Windows.Forms.Label Text6;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label Text7;
        private System.Windows.Forms.Label Text5;
        private System.Windows.Forms.Label Text4;
        private System.Windows.Forms.Label Text3;
        private System.Windows.Forms.TextBox newFineName;
        private System.Windows.Forms.Button addNewFineName;
        private System.Windows.Forms.Label Text2;
        private System.Windows.Forms.DateTimePicker fineReceipt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox fineName;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addFineButton;
        private System.Windows.Forms.ComboBox FIOIntruder;
        private System.Windows.Forms.ComboBox brand;
        private System.Windows.Forms.ComboBox model;
        private System.Windows.Forms.Button editFineButton;
        private System.Windows.Forms.Button infoButton;
    }
}