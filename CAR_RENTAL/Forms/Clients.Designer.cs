namespace CAR_RENTAL.Forms
{
    partial class Clients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clients));
            this.TimeText = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Text1 = new System.Windows.Forms.Label();
            this.TimeNow = new System.Windows.Forms.Timer(this.components);
            this.searchFullNameClient = new System.Windows.Forms.TextBox();
            this.delClientButton = new System.Windows.Forms.Button();
            this.addClientButton = new System.Windows.Forms.Button();
            this.editClientButton = new System.Windows.Forms.Button();
            this.backMenuButton = new System.Windows.Forms.Button();
            this.ClientBD = new System.Windows.Forms.DataGridView();
            this.idClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIOClientBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayClientBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasportBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoditPravaNalichBD = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.VoditPravaBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchPassport = new System.Windows.Forms.TextBox();
            this.infoSearch1 = new System.Windows.Forms.Label();
            this.infoSearch2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBD)).BeginInit();
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
            this.Text1.Location = new System.Drawing.Point(594, 40);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(160, 45);
            this.Text1.TabIndex = 21;
            this.Text1.Text = "Клиенты";
            // 
            // TimeNow
            // 
            this.TimeNow.Enabled = true;
            this.TimeNow.Tick += new System.EventHandler(this.TimeNow_Tick);
            // 
            // searchFullNameClient
            // 
            this.searchFullNameClient.BackColor = System.Drawing.Color.Beige;
            this.searchFullNameClient.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchFullNameClient.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.searchFullNameClient.Location = new System.Drawing.Point(29, 408);
            this.searchFullNameClient.MaxLength = 50;
            this.searchFullNameClient.Name = "searchFullNameClient";
            this.searchFullNameClient.Size = new System.Drawing.Size(318, 43);
            this.searchFullNameClient.TabIndex = 51;
            this.searchFullNameClient.TextChanged += new System.EventHandler(this.searchFullNameClient_TextChanged);
            this.searchFullNameClient.Enter += new System.EventHandler(this.searchFullNameClient_Enter);
            this.searchFullNameClient.Leave += new System.EventHandler(this.searchFullNameClient_Leave);
            // 
            // delClientButton
            // 
            this.delClientButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.delClientButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delClientButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delClientButton.Location = new System.Drawing.Point(29, 309);
            this.delClientButton.Name = "delClientButton";
            this.delClientButton.Size = new System.Drawing.Size(318, 59);
            this.delClientButton.TabIndex = 47;
            this.delClientButton.Text = "Удаление клиента";
            this.delClientButton.UseVisualStyleBackColor = true;
            this.delClientButton.Visible = false;
            this.delClientButton.Click += new System.EventHandler(this.delClientButton_Click);
            // 
            // addClientButton
            // 
            this.addClientButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.addClientButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addClientButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClientButton.Location = new System.Drawing.Point(29, 232);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(318, 59);
            this.addClientButton.TabIndex = 46;
            this.addClientButton.Text = "Добавление клиента";
            this.addClientButton.UseVisualStyleBackColor = true;
            this.addClientButton.Visible = false;
            this.addClientButton.Click += new System.EventHandler(this.addClientButton_Click);
            // 
            // editClientButton
            // 
            this.editClientButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.editClientButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editClientButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editClientButton.Location = new System.Drawing.Point(29, 154);
            this.editClientButton.Name = "editClientButton";
            this.editClientButton.Size = new System.Drawing.Size(318, 59);
            this.editClientButton.TabIndex = 45;
            this.editClientButton.Text = "Изменение клиента";
            this.editClientButton.UseVisualStyleBackColor = true;
            this.editClientButton.Visible = false;
            this.editClientButton.Click += new System.EventHandler(this.editClientButton_Click);
            // 
            // backMenuButton
            // 
            this.backMenuButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.backMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backMenuButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backMenuButton.Location = new System.Drawing.Point(1138, 716);
            this.backMenuButton.Name = "backMenuButton";
            this.backMenuButton.Size = new System.Drawing.Size(222, 59);
            this.backMenuButton.TabIndex = 44;
            this.backMenuButton.Text = "В меню";
            this.backMenuButton.UseVisualStyleBackColor = true;
            this.backMenuButton.Click += new System.EventHandler(this.backMenuButton_Click);
            // 
            // ClientBD
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.ClientBD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ClientBD.BackgroundColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientBD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ClientBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientBD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClient,
            this.FIOClientBD,
            this.birthdayClientBD,
            this.pasportBD,
            this.VoditPravaNalichBD,
            this.VoditPravaBD});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClientBD.DefaultCellStyle = dataGridViewCellStyle3;
            this.ClientBD.GridColor = System.Drawing.Color.Gray;
            this.ClientBD.Location = new System.Drawing.Point(397, 154);
            this.ClientBD.Name = "ClientBD";
            this.ClientBD.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientBD.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.ClientBD.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ClientBD.Size = new System.Drawing.Size(944, 516);
            this.ClientBD.TabIndex = 43;
            // 
            // idClient
            // 
            this.idClient.HeaderText = "id";
            this.idClient.Name = "idClient";
            this.idClient.ReadOnly = true;
            this.idClient.Visible = false;
            // 
            // FIOClientBD
            // 
            this.FIOClientBD.HeaderText = "ФИО Клиента";
            this.FIOClientBD.Name = "FIOClientBD";
            this.FIOClientBD.ReadOnly = true;
            this.FIOClientBD.Width = 300;
            // 
            // birthdayClientBD
            // 
            this.birthdayClientBD.HeaderText = "Дата Рождения";
            this.birthdayClientBD.Name = "birthdayClientBD";
            this.birthdayClientBD.ReadOnly = true;
            this.birthdayClientBD.Width = 150;
            // 
            // pasportBD
            // 
            this.pasportBD.HeaderText = "Паспорт";
            this.pasportBD.Name = "pasportBD";
            this.pasportBD.ReadOnly = true;
            this.pasportBD.Width = 150;
            // 
            // VoditPravaNalichBD
            // 
            this.VoditPravaNalichBD.HeaderText = "Наличие Водительского Удостоверения";
            this.VoditPravaNalichBD.Name = "VoditPravaNalichBD";
            this.VoditPravaNalichBD.ReadOnly = true;
            this.VoditPravaNalichBD.Width = 140;
            // 
            // VoditPravaBD
            // 
            this.VoditPravaBD.HeaderText = "Водительское Удостоверение";
            this.VoditPravaBD.Name = "VoditPravaBD";
            this.VoditPravaBD.ReadOnly = true;
            this.VoditPravaBD.Width = 140;
            // 
            // searchPassport
            // 
            this.searchPassport.BackColor = System.Drawing.Color.Beige;
            this.searchPassport.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchPassport.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.searchPassport.Location = new System.Drawing.Point(29, 483);
            this.searchPassport.MaxLength = 10;
            this.searchPassport.Name = "searchPassport";
            this.searchPassport.Size = new System.Drawing.Size(318, 43);
            this.searchPassport.TabIndex = 56;
            this.searchPassport.TextChanged += new System.EventHandler(this.searchPassport_TextChanged);
            this.searchPassport.Enter += new System.EventHandler(this.searchPassport_Enter);
            this.searchPassport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchPassport_KeyPress);
            this.searchPassport.Leave += new System.EventHandler(this.searchPassport_Leave);
            // 
            // infoSearch1
            // 
            this.infoSearch1.AutoSize = true;
            this.infoSearch1.BackColor = System.Drawing.Color.Beige;
            this.infoSearch1.Font = new System.Drawing.Font("Monotype Corsiva", 23.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoSearch1.Location = new System.Drawing.Point(31, 412);
            this.infoSearch1.Name = "infoSearch1";
            this.infoSearch1.Size = new System.Drawing.Size(192, 38);
            this.infoSearch1.TabIndex = 68;
            this.infoSearch1.Text = "ФИО Клиента";
            this.infoSearch1.Click += new System.EventHandler(this.infoSearch1_Click);
            // 
            // infoSearch2
            // 
            this.infoSearch2.AutoSize = true;
            this.infoSearch2.BackColor = System.Drawing.Color.Beige;
            this.infoSearch2.Font = new System.Drawing.Font("Monotype Corsiva", 23.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoSearch2.Location = new System.Drawing.Point(31, 487);
            this.infoSearch2.Name = "infoSearch2";
            this.infoSearch2.Size = new System.Drawing.Size(121, 38);
            this.infoSearch2.TabIndex = 69;
            this.infoSearch2.Text = "Паспорт";
            this.infoSearch2.Click += new System.EventHandler(this.infoSearch2_Click);
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1384, 780);
            this.ControlBox = false;
            this.Controls.Add(this.infoSearch2);
            this.Controls.Add(this.infoSearch1);
            this.Controls.Add(this.searchPassport);
            this.Controls.Add(this.searchFullNameClient);
            this.Controls.Add(this.delClientButton);
            this.Controls.Add(this.addClientButton);
            this.Controls.Add(this.editClientButton);
            this.Controls.Add(this.backMenuButton);
            this.Controls.Add(this.ClientBD);
            this.Controls.Add(this.TimeText);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Text1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Clients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"Прокаткомпарейшн\"";
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeText;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.Timer TimeNow;
        private System.Windows.Forms.TextBox searchFullNameClient;
        private System.Windows.Forms.Button delClientButton;
        private System.Windows.Forms.Button addClientButton;
        private System.Windows.Forms.Button editClientButton;
        private System.Windows.Forms.Button backMenuButton;
        private System.Windows.Forms.DataGridView ClientBD;
        private System.Windows.Forms.TextBox searchPassport;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIOClientBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayClientBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn pasportBD;
        private System.Windows.Forms.DataGridViewCheckBoxColumn VoditPravaNalichBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoditPravaBD;
        private System.Windows.Forms.Label infoSearch1;
        private System.Windows.Forms.Label infoSearch2;
    }
}