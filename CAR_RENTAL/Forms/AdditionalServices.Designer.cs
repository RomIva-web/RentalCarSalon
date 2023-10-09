namespace CAR_RENTAL.Forms
{
    partial class AdditionalServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdditionalServices));
            this.TimeNow = new System.Windows.Forms.Timer(this.components);
            this.TimeText = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Text1 = new System.Windows.Forms.Label();
            this.backMenuButton = new System.Windows.Forms.Button();
            this.additionalServiceName = new System.Windows.Forms.TextBox();
            this.sortType = new System.Windows.Forms.ComboBox();
            this.delAdditionalServiceButton = new System.Windows.Forms.Button();
            this.addAdditionalServiceButton = new System.Windows.Forms.Button();
            this.AdditionalServiceBD = new System.Windows.Forms.DataGridView();
            this.idYclygiBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameYclygiBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editAdditionalServiceButton = new System.Windows.Forms.Button();
            this.infoSearch1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdditionalServiceBD)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeNow
            // 
            this.TimeNow.Enabled = true;
            this.TimeNow.Tick += new System.EventHandler(this.TimeNow_Tick);
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
            this.Text1.Location = new System.Drawing.Point(634, 54);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(126, 45);
            this.Text1.TabIndex = 17;
            this.Text1.Text = "Услуги";
            // 
            // backMenuButton
            // 
            this.backMenuButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.backMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backMenuButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backMenuButton.Location = new System.Drawing.Point(1156, 715);
            this.backMenuButton.Name = "backMenuButton";
            this.backMenuButton.Size = new System.Drawing.Size(222, 59);
            this.backMenuButton.TabIndex = 64;
            this.backMenuButton.Text = "В меню";
            this.backMenuButton.UseVisualStyleBackColor = true;
            this.backMenuButton.Click += new System.EventHandler(this.backMenuButton_Click);
            // 
            // additionalServiceName
            // 
            this.additionalServiceName.BackColor = System.Drawing.Color.Beige;
            this.additionalServiceName.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.additionalServiceName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.additionalServiceName.Location = new System.Drawing.Point(116, 453);
            this.additionalServiceName.MaxLength = 40;
            this.additionalServiceName.Name = "additionalServiceName";
            this.additionalServiceName.Size = new System.Drawing.Size(334, 43);
            this.additionalServiceName.TabIndex = 61;
            this.additionalServiceName.TextChanged += new System.EventHandler(this.AdditionalServiceName_TextChanged);
            this.additionalServiceName.Enter += new System.EventHandler(this.additionalServiceName_Enter);
            this.additionalServiceName.Leave += new System.EventHandler(this.additionalServiceName_Leave);
            // 
            // sortType
            // 
            this.sortType.BackColor = System.Drawing.Color.Beige;
            this.sortType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortType.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortType.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.sortType.FormattingEnabled = true;
            this.sortType.Location = new System.Drawing.Point(116, 540);
            this.sortType.Name = "sortType";
            this.sortType.Size = new System.Drawing.Size(334, 47);
            this.sortType.TabIndex = 60;
            this.sortType.SelectedIndexChanged += new System.EventHandler(this.sortType_SelectedIndexChanged);
            // 
            // delAdditionalServiceButton
            // 
            this.delAdditionalServiceButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.delAdditionalServiceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delAdditionalServiceButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delAdditionalServiceButton.Location = new System.Drawing.Point(116, 360);
            this.delAdditionalServiceButton.Name = "delAdditionalServiceButton";
            this.delAdditionalServiceButton.Size = new System.Drawing.Size(334, 59);
            this.delAdditionalServiceButton.TabIndex = 59;
            this.delAdditionalServiceButton.Text = "Удаление услуги";
            this.delAdditionalServiceButton.UseVisualStyleBackColor = true;
            this.delAdditionalServiceButton.Visible = false;
            this.delAdditionalServiceButton.Click += new System.EventHandler(this.delAdditionalServiceButton_Click);
            // 
            // addAdditionalServiceButton
            // 
            this.addAdditionalServiceButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.addAdditionalServiceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addAdditionalServiceButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAdditionalServiceButton.Location = new System.Drawing.Point(116, 283);
            this.addAdditionalServiceButton.Name = "addAdditionalServiceButton";
            this.addAdditionalServiceButton.Size = new System.Drawing.Size(334, 59);
            this.addAdditionalServiceButton.TabIndex = 58;
            this.addAdditionalServiceButton.Text = "Добавление услуги";
            this.addAdditionalServiceButton.UseVisualStyleBackColor = true;
            this.addAdditionalServiceButton.Visible = false;
            this.addAdditionalServiceButton.Click += new System.EventHandler(this.addAdditionalServiceButton_Click);
            // 
            // AdditionalServiceBD
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.AdditionalServiceBD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AdditionalServiceBD.BackgroundColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AdditionalServiceBD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AdditionalServiceBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdditionalServiceBD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idYclygiBD,
            this.nameYclygiBD,
            this.priceBD});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AdditionalServiceBD.DefaultCellStyle = dataGridViewCellStyle3;
            this.AdditionalServiceBD.GridColor = System.Drawing.Color.Gray;
            this.AdditionalServiceBD.Location = new System.Drawing.Point(529, 152);
            this.AdditionalServiceBD.Name = "AdditionalServiceBD";
            this.AdditionalServiceBD.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AdditionalServiceBD.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.AdditionalServiceBD.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.AdditionalServiceBD.Size = new System.Drawing.Size(544, 516);
            this.AdditionalServiceBD.TabIndex = 57;
            // 
            // idYclygiBD
            // 
            this.idYclygiBD.HeaderText = "Номер услуги";
            this.idYclygiBD.Name = "idYclygiBD";
            this.idYclygiBD.ReadOnly = true;
            this.idYclygiBD.Visible = false;
            // 
            // nameYclygiBD
            // 
            this.nameYclygiBD.HeaderText = "Название Услуги";
            this.nameYclygiBD.Name = "nameYclygiBD";
            this.nameYclygiBD.ReadOnly = true;
            this.nameYclygiBD.Width = 300;
            // 
            // priceBD
            // 
            this.priceBD.HeaderText = "Цена";
            this.priceBD.Name = "priceBD";
            this.priceBD.ReadOnly = true;
            this.priceBD.Width = 200;
            // 
            // editAdditionalServiceButton
            // 
            this.editAdditionalServiceButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.editAdditionalServiceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editAdditionalServiceButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editAdditionalServiceButton.Location = new System.Drawing.Point(116, 205);
            this.editAdditionalServiceButton.Name = "editAdditionalServiceButton";
            this.editAdditionalServiceButton.Size = new System.Drawing.Size(334, 59);
            this.editAdditionalServiceButton.TabIndex = 65;
            this.editAdditionalServiceButton.Text = "Изменение услуги";
            this.editAdditionalServiceButton.UseVisualStyleBackColor = true;
            this.editAdditionalServiceButton.Visible = false;
            this.editAdditionalServiceButton.Click += new System.EventHandler(this.editAdditionalServiceButton_Click);
            // 
            // infoSearch1
            // 
            this.infoSearch1.AutoSize = true;
            this.infoSearch1.BackColor = System.Drawing.Color.Beige;
            this.infoSearch1.Font = new System.Drawing.Font("Monotype Corsiva", 23.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoSearch1.Location = new System.Drawing.Point(119, 456);
            this.infoSearch1.Name = "infoSearch1";
            this.infoSearch1.Size = new System.Drawing.Size(206, 38);
            this.infoSearch1.TabIndex = 66;
            this.infoSearch1.Text = "Название услуги";
            this.infoSearch1.Click += new System.EventHandler(this.infoSearch1_Click);
            // 
            // AdditionalServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1384, 780);
            this.ControlBox = false;
            this.Controls.Add(this.infoSearch1);
            this.Controls.Add(this.editAdditionalServiceButton);
            this.Controls.Add(this.backMenuButton);
            this.Controls.Add(this.additionalServiceName);
            this.Controls.Add(this.sortType);
            this.Controls.Add(this.delAdditionalServiceButton);
            this.Controls.Add(this.addAdditionalServiceButton);
            this.Controls.Add(this.AdditionalServiceBD);
            this.Controls.Add(this.TimeText);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Text1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdditionalServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"Прокаткомпарейшн\"";
            this.Load += new System.EventHandler(this.AdditionalServices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdditionalServiceBD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TimeNow;
        private System.Windows.Forms.Label TimeText;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.Button backMenuButton;
        private System.Windows.Forms.TextBox additionalServiceName;
        private System.Windows.Forms.ComboBox sortType;
        private System.Windows.Forms.Button delAdditionalServiceButton;
        private System.Windows.Forms.Button addAdditionalServiceButton;
        private System.Windows.Forms.DataGridView AdditionalServiceBD;
        private System.Windows.Forms.Button editAdditionalServiceButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idYclygiBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameYclygiBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceBD;
        private System.Windows.Forms.Label infoSearch1;
    }
}