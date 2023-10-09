namespace CAR_RENTAL.Forms
{
    partial class Drivers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Drivers));
            this.TimeText = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Text1 = new System.Windows.Forms.Label();
            this.TimeNow = new System.Windows.Forms.Timer(this.components);
            this.driverFullName = new System.Windows.Forms.TextBox();
            this.delDriverButton = new System.Windows.Forms.Button();
            this.addDriverButton = new System.Windows.Forms.Button();
            this.DriverBD = new System.Windows.Forms.DataGridView();
            this.idVoditel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIOClientBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverLicense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceDayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sortType = new System.Windows.Forms.ComboBox();
            this.BackMenu = new System.Windows.Forms.Button();
            this.editDriverButton = new System.Windows.Forms.Button();
            this.infoSearch1 = new System.Windows.Forms.Label();
            this.printReport = new System.Windows.Forms.Button();
            this.reportStart = new System.Windows.Forms.DateTimePicker();
            this.reportEnd = new System.Windows.Forms.DateTimePicker();
            this.Text2 = new System.Windows.Forms.Label();
            this.Text3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DriverBD)).BeginInit();
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
            this.Text1.Location = new System.Drawing.Point(597, 49);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(166, 45);
            this.Text1.TabIndex = 17;
            this.Text1.Text = "Водители";
            // 
            // TimeNow
            // 
            this.TimeNow.Enabled = true;
            this.TimeNow.Tick += new System.EventHandler(this.TimeNow_Tick);
            // 
            // driverFullName
            // 
            this.driverFullName.BackColor = System.Drawing.Color.Beige;
            this.driverFullName.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.driverFullName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.driverFullName.Location = new System.Drawing.Point(12, 452);
            this.driverFullName.MaxLength = 50;
            this.driverFullName.Name = "driverFullName";
            this.driverFullName.Size = new System.Drawing.Size(404, 43);
            this.driverFullName.TabIndex = 50;
            this.driverFullName.TextChanged += new System.EventHandler(this.driverFullName_TextChanged);
            this.driverFullName.Enter += new System.EventHandler(this.driverFullName_Enter);
            this.driverFullName.Leave += new System.EventHandler(this.driverFullName_Leave);
            // 
            // delDriverButton
            // 
            this.delDriverButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.delDriverButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delDriverButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delDriverButton.Location = new System.Drawing.Point(12, 359);
            this.delDriverButton.Name = "delDriverButton";
            this.delDriverButton.Size = new System.Drawing.Size(404, 59);
            this.delDriverButton.TabIndex = 46;
            this.delDriverButton.Text = "Увольнение водителя";
            this.delDriverButton.UseVisualStyleBackColor = true;
            this.delDriverButton.Visible = false;
            this.delDriverButton.Click += new System.EventHandler(this.delDriverButton_Click);
            // 
            // addDriverButton
            // 
            this.addDriverButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.addDriverButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addDriverButton.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addDriverButton.Location = new System.Drawing.Point(12, 282);
            this.addDriverButton.Name = "addDriverButton";
            this.addDriverButton.Size = new System.Drawing.Size(404, 59);
            this.addDriverButton.TabIndex = 45;
            this.addDriverButton.Text = "Регистрация водителя";
            this.addDriverButton.UseVisualStyleBackColor = true;
            this.addDriverButton.Visible = false;
            this.addDriverButton.Click += new System.EventHandler(this.addDriverButton_Click);
            // 
            // DriverBD
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.DriverBD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DriverBD.BackgroundColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DriverBD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DriverBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DriverBD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVoditel,
            this.FIOClientBD,
            this.driverLicense,
            this.PriceDayBD,
            this.workBegin,
            this.workEnd,
            this.statusBD});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DriverBD.DefaultCellStyle = dataGridViewCellStyle3;
            this.DriverBD.GridColor = System.Drawing.Color.Gray;
            this.DriverBD.Location = new System.Drawing.Point(422, 138);
            this.DriverBD.Name = "DriverBD";
            this.DriverBD.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DriverBD.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.DriverBD.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DriverBD.Size = new System.Drawing.Size(950, 516);
            this.DriverBD.TabIndex = 43;
            // 
            // idVoditel
            // 
            this.idVoditel.HeaderText = "Номер водителя";
            this.idVoditel.Name = "idVoditel";
            this.idVoditel.ReadOnly = true;
            this.idVoditel.Visible = false;
            // 
            // FIOClientBD
            // 
            this.FIOClientBD.HeaderText = "ФИО Водителя";
            this.FIOClientBD.Name = "FIOClientBD";
            this.FIOClientBD.ReadOnly = true;
            this.FIOClientBD.Width = 300;
            // 
            // driverLicense
            // 
            this.driverLicense.HeaderText = "Водительское удостоверение";
            this.driverLicense.Name = "driverLicense";
            this.driverLicense.ReadOnly = true;
            this.driverLicense.Width = 150;
            // 
            // PriceDayBD
            // 
            this.PriceDayBD.HeaderText = "Цена в день";
            this.PriceDayBD.Name = "PriceDayBD";
            this.PriceDayBD.ReadOnly = true;
            this.PriceDayBD.Width = 200;
            // 
            // workBegin
            // 
            this.workBegin.HeaderText = "Начинает работу";
            this.workBegin.Name = "workBegin";
            this.workBegin.ReadOnly = true;
            this.workBegin.Width = 120;
            // 
            // workEnd
            // 
            this.workEnd.HeaderText = "Заканчивает работу";
            this.workEnd.Name = "workEnd";
            this.workEnd.ReadOnly = true;
            this.workEnd.Width = 120;
            // 
            // statusBD
            // 
            this.statusBD.HeaderText = "Статус";
            this.statusBD.Name = "statusBD";
            this.statusBD.ReadOnly = true;
            this.statusBD.Width = 150;
            // 
            // sortType
            // 
            this.sortType.BackColor = System.Drawing.Color.Beige;
            this.sortType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortType.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortType.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.sortType.FormattingEnabled = true;
            this.sortType.Location = new System.Drawing.Point(12, 539);
            this.sortType.Name = "sortType";
            this.sortType.Size = new System.Drawing.Size(404, 47);
            this.sortType.TabIndex = 48;
            this.sortType.SelectedIndexChanged += new System.EventHandler(this.sortType_SelectedIndexChanged);
            // 
            // BackMenu
            // 
            this.BackMenu.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.BackMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackMenu.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackMenu.Location = new System.Drawing.Point(1150, 709);
            this.BackMenu.Name = "BackMenu";
            this.BackMenu.Size = new System.Drawing.Size(222, 59);
            this.BackMenu.TabIndex = 56;
            this.BackMenu.Text = "В меню";
            this.BackMenu.UseVisualStyleBackColor = true;
            this.BackMenu.Click += new System.EventHandler(this.BackMenu_Click);
            // 
            // editDriverButton
            // 
            this.editDriverButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.editDriverButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editDriverButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editDriverButton.Location = new System.Drawing.Point(12, 204);
            this.editDriverButton.Name = "editDriverButton";
            this.editDriverButton.Size = new System.Drawing.Size(404, 59);
            this.editDriverButton.TabIndex = 57;
            this.editDriverButton.Text = "Изменение водителя";
            this.editDriverButton.UseVisualStyleBackColor = true;
            this.editDriverButton.Visible = false;
            this.editDriverButton.Click += new System.EventHandler(this.editDriverButton_Click);
            // 
            // infoSearch1
            // 
            this.infoSearch1.AutoSize = true;
            this.infoSearch1.BackColor = System.Drawing.Color.Beige;
            this.infoSearch1.Font = new System.Drawing.Font("Monotype Corsiva", 23.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoSearch1.Location = new System.Drawing.Point(16, 455);
            this.infoSearch1.Name = "infoSearch1";
            this.infoSearch1.Size = new System.Drawing.Size(203, 38);
            this.infoSearch1.TabIndex = 68;
            this.infoSearch1.Text = "ФИО Водителя";
            this.infoSearch1.Click += new System.EventHandler(this.infoSearch1_Click);
            // 
            // printReport
            // 
            this.printReport.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.printReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.printReport.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printReport.Location = new System.Drawing.Point(422, 660);
            this.printReport.Name = "printReport";
            this.printReport.Size = new System.Drawing.Size(316, 43);
            this.printReport.TabIndex = 69;
            this.printReport.Text = "Распечатать отчёт";
            this.printReport.UseVisualStyleBackColor = true;
            this.printReport.Click += new System.EventHandler(this.printReport_Click);
            // 
            // reportStart
            // 
            this.reportStart.CalendarForeColor = System.Drawing.Color.DarkSlateGray;
            this.reportStart.CalendarMonthBackground = System.Drawing.Color.Beige;
            this.reportStart.CalendarTitleForeColor = System.Drawing.Color.DarkSlateGray;
            this.reportStart.CalendarTrailingForeColor = System.Drawing.Color.DarkSlateGray;
            this.reportStart.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportStart.Location = new System.Drawing.Point(769, 666);
            this.reportStart.Name = "reportStart";
            this.reportStart.Size = new System.Drawing.Size(253, 34);
            this.reportStart.TabIndex = 74;
            this.reportStart.ValueChanged += new System.EventHandler(this.reportStart_ValueChanged);
            // 
            // reportEnd
            // 
            this.reportEnd.CalendarForeColor = System.Drawing.Color.DarkSlateGray;
            this.reportEnd.CalendarMonthBackground = System.Drawing.Color.Beige;
            this.reportEnd.CalendarTitleForeColor = System.Drawing.Color.DarkSlateGray;
            this.reportEnd.CalendarTrailingForeColor = System.Drawing.Color.DarkSlateGray;
            this.reportEnd.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportEnd.Location = new System.Drawing.Point(1076, 666);
            this.reportEnd.Name = "reportEnd";
            this.reportEnd.Size = new System.Drawing.Size(253, 34);
            this.reportEnd.TabIndex = 75;
            this.reportEnd.ValueChanged += new System.EventHandler(this.reportEnd_ValueChanged);
            // 
            // Text2
            // 
            this.Text2.AutoSize = true;
            this.Text2.BackColor = System.Drawing.Color.Transparent;
            this.Text2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text2.Location = new System.Drawing.Point(739, 668);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(24, 28);
            this.Text2.TabIndex = 76;
            this.Text2.Text = "С";
            // 
            // Text3
            // 
            this.Text3.AutoSize = true;
            this.Text3.BackColor = System.Drawing.Color.Transparent;
            this.Text3.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text3.Location = new System.Drawing.Point(1028, 668);
            this.Text3.Name = "Text3";
            this.Text3.Size = new System.Drawing.Size(42, 28);
            this.Text3.TabIndex = 77;
            this.Text3.Text = "ПО";
            // 
            // Drivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1384, 780);
            this.ControlBox = false;
            this.Controls.Add(this.Text3);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.reportEnd);
            this.Controls.Add(this.reportStart);
            this.Controls.Add(this.printReport);
            this.Controls.Add(this.infoSearch1);
            this.Controls.Add(this.editDriverButton);
            this.Controls.Add(this.BackMenu);
            this.Controls.Add(this.driverFullName);
            this.Controls.Add(this.sortType);
            this.Controls.Add(this.delDriverButton);
            this.Controls.Add(this.addDriverButton);
            this.Controls.Add(this.DriverBD);
            this.Controls.Add(this.TimeText);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Text1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Drivers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"Прокаткомпарейшн\"";
            this.Load += new System.EventHandler(this.Drivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DriverBD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeText;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.Timer TimeNow;
        private System.Windows.Forms.TextBox driverFullName;
        private System.Windows.Forms.Button delDriverButton;
        private System.Windows.Forms.Button addDriverButton;
        private System.Windows.Forms.DataGridView DriverBD;
        private System.Windows.Forms.ComboBox sortType;
        private System.Windows.Forms.Button BackMenu;
        private System.Windows.Forms.Button editDriverButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVoditel;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIOClientBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverLicense;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceDayBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn workBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn workEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusBD;
        private System.Windows.Forms.Label infoSearch1;
        private System.Windows.Forms.Button printReport;
        private System.Windows.Forms.DateTimePicker reportStart;
        private System.Windows.Forms.DateTimePicker reportEnd;
        private System.Windows.Forms.Label Text2;
        private System.Windows.Forms.Label Text3;
    }
}