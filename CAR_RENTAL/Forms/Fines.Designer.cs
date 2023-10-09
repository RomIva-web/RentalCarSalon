namespace CAR_RENTAL.Forms
{
    partial class Fines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fines));
            this.TimeText = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Text1 = new System.Windows.Forms.Label();
            this.TimeNow = new System.Windows.Forms.Timer(this.components);
            this.fineEnd = new System.Windows.Forms.DateTimePicker();
            this.fineStart = new System.Windows.Forms.DateTimePicker();
            this.intruderName = new System.Windows.Forms.TextBox();
            this.sortType = new System.Windows.Forms.ComboBox();
            this.filtrDateButton = new System.Windows.Forms.Button();
            this.addFineButton = new System.Windows.Forms.Button();
            this.editFineButton = new System.Windows.Forms.Button();
            this.backMenuButton = new System.Windows.Forms.Button();
            this.FineBD = new System.Windows.Forms.DataGridView();
            this.idShtrafsBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idZakazaBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIOIntruderBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientOfVoditelBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNameShtrafaBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_takeBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceShtrafBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delFineButton = new System.Windows.Forms.Button();
            this.Text2 = new System.Windows.Forms.Label();
            this.infoSearch1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FineBD)).BeginInit();
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
            this.Text1.Location = new System.Drawing.Point(620, 54);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(161, 45);
            this.Text1.TabIndex = 17;
            this.Text1.Text = "Штрафы";
            // 
            // TimeNow
            // 
            this.TimeNow.Enabled = true;
            this.TimeNow.Tick += new System.EventHandler(this.TimeNow_Tick);
            // 
            // fineEnd
            // 
            this.fineEnd.CalendarForeColor = System.Drawing.Color.DarkSlateGray;
            this.fineEnd.CalendarMonthBackground = System.Drawing.Color.Beige;
            this.fineEnd.CalendarTitleForeColor = System.Drawing.Color.DarkSlateGray;
            this.fineEnd.CalendarTrailingForeColor = System.Drawing.Color.DarkSlateGray;
            this.fineEnd.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fineEnd.Location = new System.Drawing.Point(27, 573);
            this.fineEnd.Name = "fineEnd";
            this.fineEnd.Size = new System.Drawing.Size(318, 43);
            this.fineEnd.TabIndex = 53;
            this.fineEnd.ValueChanged += new System.EventHandler(this.shtrafEnd_ValueChanged);
            // 
            // fineStart
            // 
            this.fineStart.CalendarForeColor = System.Drawing.Color.DarkSlateGray;
            this.fineStart.CalendarMonthBackground = System.Drawing.Color.Beige;
            this.fineStart.CalendarTitleForeColor = System.Drawing.Color.DarkSlateGray;
            this.fineStart.CalendarTrailingForeColor = System.Drawing.Color.DarkSlateGray;
            this.fineStart.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fineStart.Location = new System.Drawing.Point(27, 515);
            this.fineStart.Name = "fineStart";
            this.fineStart.Size = new System.Drawing.Size(318, 43);
            this.fineStart.TabIndex = 52;
            this.fineStart.ValueChanged += new System.EventHandler(this.shtrafStart_ValueChanged);
            // 
            // intruderName
            // 
            this.intruderName.BackColor = System.Drawing.Color.Beige;
            this.intruderName.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.intruderName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.intruderName.Location = new System.Drawing.Point(27, 365);
            this.intruderName.MaxLength = 50;
            this.intruderName.Name = "intruderName";
            this.intruderName.Size = new System.Drawing.Size(318, 43);
            this.intruderName.TabIndex = 51;
            this.intruderName.TextChanged += new System.EventHandler(this.clientName_TextChanged);
            this.intruderName.Enter += new System.EventHandler(this.intruderName_Enter);
            this.intruderName.Leave += new System.EventHandler(this.intruderName_Leave);
            // 
            // sortType
            // 
            this.sortType.BackColor = System.Drawing.Color.Beige;
            this.sortType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortType.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortType.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.sortType.FormattingEnabled = true;
            this.sortType.Location = new System.Drawing.Point(27, 429);
            this.sortType.Name = "sortType";
            this.sortType.Size = new System.Drawing.Size(318, 47);
            this.sortType.TabIndex = 49;
            this.sortType.SelectedIndexChanged += new System.EventHandler(this.sortType_SelectedIndexChanged);
            // 
            // filtrDateButton
            // 
            this.filtrDateButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.filtrDateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filtrDateButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtrDateButton.Location = new System.Drawing.Point(27, 638);
            this.filtrDateButton.Name = "filtrDateButton";
            this.filtrDateButton.Size = new System.Drawing.Size(318, 59);
            this.filtrDateButton.TabIndex = 48;
            this.filtrDateButton.Text = "Фильтр по времени";
            this.filtrDateButton.UseVisualStyleBackColor = true;
            this.filtrDateButton.Click += new System.EventHandler(this.filtrDateButton_Click);
            // 
            // addFineButton
            // 
            this.addFineButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.addFineButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addFineButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFineButton.Location = new System.Drawing.Point(27, 206);
            this.addFineButton.Name = "addFineButton";
            this.addFineButton.Size = new System.Drawing.Size(318, 59);
            this.addFineButton.TabIndex = 46;
            this.addFineButton.Text = "Добавление штрафа";
            this.addFineButton.UseVisualStyleBackColor = true;
            this.addFineButton.Visible = false;
            this.addFineButton.Click += new System.EventHandler(this.addFineButton_Click);
            // 
            // editFineButton
            // 
            this.editFineButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.editFineButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editFineButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editFineButton.Location = new System.Drawing.Point(27, 128);
            this.editFineButton.Name = "editFineButton";
            this.editFineButton.Size = new System.Drawing.Size(318, 59);
            this.editFineButton.TabIndex = 45;
            this.editFineButton.Text = "Изменение штрафа";
            this.editFineButton.UseVisualStyleBackColor = true;
            this.editFineButton.Visible = false;
            this.editFineButton.Click += new System.EventHandler(this.editFineButton_Click);
            // 
            // backMenuButton
            // 
            this.backMenuButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.backMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backMenuButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backMenuButton.Location = new System.Drawing.Point(1156, 715);
            this.backMenuButton.Name = "backMenuButton";
            this.backMenuButton.Size = new System.Drawing.Size(222, 59);
            this.backMenuButton.TabIndex = 44;
            this.backMenuButton.Text = "В меню";
            this.backMenuButton.UseVisualStyleBackColor = true;
            this.backMenuButton.Click += new System.EventHandler(this.backMenuButton_Click);
            // 
            // FineBD
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.FineBD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.FineBD.BackgroundColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FineBD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.FineBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FineBD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idShtrafsBD,
            this.idZakazaBD,
            this.FIOIntruderBD,
            this.ClientOfVoditelBD,
            this.idNameShtrafaBD,
            this.date_takeBD,
            this.priceShtrafBD});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FineBD.DefaultCellStyle = dataGridViewCellStyle3;
            this.FineBD.GridColor = System.Drawing.Color.Gray;
            this.FineBD.Location = new System.Drawing.Point(395, 128);
            this.FineBD.Name = "FineBD";
            this.FineBD.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FineBD.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.FineBD.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.FineBD.Size = new System.Drawing.Size(968, 516);
            this.FineBD.TabIndex = 43;
            // 
            // idShtrafsBD
            // 
            this.idShtrafsBD.HeaderText = "idShtrafs";
            this.idShtrafsBD.Name = "idShtrafsBD";
            this.idShtrafsBD.ReadOnly = true;
            this.idShtrafsBD.Visible = false;
            // 
            // idZakazaBD
            // 
            this.idZakazaBD.HeaderText = "Номер проката";
            this.idZakazaBD.Name = "idZakazaBD";
            this.idZakazaBD.ReadOnly = true;
            this.idZakazaBD.Visible = false;
            // 
            // FIOIntruderBD
            // 
            this.FIOIntruderBD.HeaderText = "ФИО Нарушителя";
            this.FIOIntruderBD.Name = "FIOIntruderBD";
            this.FIOIntruderBD.ReadOnly = true;
            this.FIOIntruderBD.Width = 300;
            // 
            // ClientOfVoditelBD
            // 
            this.ClientOfVoditelBD.HeaderText = "По чьей вине";
            this.ClientOfVoditelBD.Name = "ClientOfVoditelBD";
            this.ClientOfVoditelBD.ReadOnly = true;
            // 
            // idNameShtrafaBD
            // 
            this.idNameShtrafaBD.HeaderText = "Причина штрафа";
            this.idNameShtrafaBD.Name = "idNameShtrafaBD";
            this.idNameShtrafaBD.ReadOnly = true;
            this.idNameShtrafaBD.Width = 1600;
            // 
            // date_takeBD
            // 
            this.date_takeBD.HeaderText = "Дата получения";
            this.date_takeBD.Name = "date_takeBD";
            this.date_takeBD.ReadOnly = true;
            // 
            // priceShtrafBD
            // 
            this.priceShtrafBD.HeaderText = "Стоимость штрафа";
            this.priceShtrafBD.Name = "priceShtrafBD";
            this.priceShtrafBD.ReadOnly = true;
            this.priceShtrafBD.Width = 75;
            // 
            // delFineButton
            // 
            this.delFineButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.delFineButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delFineButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delFineButton.Location = new System.Drawing.Point(27, 283);
            this.delFineButton.Name = "delFineButton";
            this.delFineButton.Size = new System.Drawing.Size(318, 59);
            this.delFineButton.TabIndex = 47;
            this.delFineButton.Text = "Удаление штрафа";
            this.delFineButton.UseVisualStyleBackColor = true;
            this.delFineButton.Visible = false;
            this.delFineButton.Click += new System.EventHandler(this.delFineButton_Click);
            // 
            // Text2
            // 
            this.Text2.AutoSize = true;
            this.Text2.BackColor = System.Drawing.Color.Transparent;
            this.Text2.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text2.ForeColor = System.Drawing.Color.Red;
            this.Text2.Location = new System.Drawing.Point(77, 700);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(192, 45);
            this.Text2.TabIndex = 57;
            this.Text2.Text = "Не активен";
            this.Text2.TextChanged += new System.EventHandler(this.Text2_TextChanged);
            // 
            // infoSearch1
            // 
            this.infoSearch1.AutoSize = true;
            this.infoSearch1.BackColor = System.Drawing.Color.Beige;
            this.infoSearch1.Font = new System.Drawing.Font("Monotype Corsiva", 23.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoSearch1.Location = new System.Drawing.Point(31, 369);
            this.infoSearch1.Name = "infoSearch1";
            this.infoSearch1.Size = new System.Drawing.Size(240, 38);
            this.infoSearch1.TabIndex = 68;
            this.infoSearch1.Text = "ФИО Нарушителя";
            this.infoSearch1.Click += new System.EventHandler(this.infoSearch1_Click);
            // 
            // Fines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1384, 780);
            this.ControlBox = false;
            this.Controls.Add(this.infoSearch1);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.fineEnd);
            this.Controls.Add(this.fineStart);
            this.Controls.Add(this.intruderName);
            this.Controls.Add(this.sortType);
            this.Controls.Add(this.filtrDateButton);
            this.Controls.Add(this.delFineButton);
            this.Controls.Add(this.addFineButton);
            this.Controls.Add(this.editFineButton);
            this.Controls.Add(this.backMenuButton);
            this.Controls.Add(this.FineBD);
            this.Controls.Add(this.TimeText);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Text1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"Прокаткомпарейшн\"";
            this.Load += new System.EventHandler(this.Strafs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FineBD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeText;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.Timer TimeNow;
        private System.Windows.Forms.DateTimePicker fineEnd;
        private System.Windows.Forms.DateTimePicker fineStart;
        private System.Windows.Forms.TextBox intruderName;
        private System.Windows.Forms.ComboBox sortType;
        private System.Windows.Forms.Button filtrDateButton;
        private System.Windows.Forms.Button addFineButton;
        private System.Windows.Forms.Button editFineButton;
        private System.Windows.Forms.Button backMenuButton;
        private System.Windows.Forms.DataGridView FineBD;
        private System.Windows.Forms.Button delFineButton;
        private System.Windows.Forms.Label Text2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idShtrafsBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn idZakazaBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIOIntruderBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientOfVoditelBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNameShtrafaBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_takeBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceShtrafBD;
        private System.Windows.Forms.Label infoSearch1;
    }
}