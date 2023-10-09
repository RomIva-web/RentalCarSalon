
namespace CAR_RENTAL.Forms
{
    partial class Cars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cars));
            this.TimeNow = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Text1 = new System.Windows.Forms.Label();
            this.TimeText = new System.Windows.Forms.Label();
            this.brandSearch = new System.Windows.Forms.TextBox();
            this.sortType = new System.Windows.Forms.ComboBox();
            this.delCarButton = new System.Windows.Forms.Button();
            this.addCarButton = new System.Windows.Forms.Button();
            this.editCarButton = new System.Windows.Forms.Button();
            this.backMenuButton = new System.Windows.Forms.Button();
            this.CarBD = new System.Windows.Forms.DataGridView();
            this.IdCarBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCatalogCar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probegBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countrySearch = new System.Windows.Forms.ComboBox();
            this.modelSearch = new System.Windows.Forms.TextBox();
            this.infoSearch1 = new System.Windows.Forms.Label();
            this.infoSearch2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarBD)).BeginInit();
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
            this.pictureBox2.Location = new System.Drawing.Point(6, 4);
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
            this.pictureBox1.Location = new System.Drawing.Point(1247, 4);
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
            this.Text1.Location = new System.Drawing.Point(652, 44);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(153, 45);
            this.Text1.TabIndex = 5;
            this.Text1.Text = "Машины";
            // 
            // TimeText
            // 
            this.TimeText.AutoSize = true;
            this.TimeText.BackColor = System.Drawing.Color.Transparent;
            this.TimeText.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeText.Location = new System.Drawing.Point(652, 726);
            this.TimeText.Name = "TimeText";
            this.TimeText.Size = new System.Drawing.Size(37, 45);
            this.TimeText.TabIndex = 16;
            this.TimeText.Text = "1";
            // 
            // brandSearch
            // 
            this.brandSearch.BackColor = System.Drawing.Color.Beige;
            this.brandSearch.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brandSearch.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.brandSearch.Location = new System.Drawing.Point(41, 376);
            this.brandSearch.MaxLength = 30;
            this.brandSearch.Name = "brandSearch";
            this.brandSearch.Size = new System.Drawing.Size(318, 43);
            this.brandSearch.TabIndex = 51;
            this.brandSearch.TextChanged += new System.EventHandler(this.brandSearch_TextChanged);
            this.brandSearch.Enter += new System.EventHandler(this.brandSearch_Enter);
            this.brandSearch.Leave += new System.EventHandler(this.brandSearch_Leave);
            // 
            // sortType
            // 
            this.sortType.BackColor = System.Drawing.Color.Beige;
            this.sortType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortType.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortType.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.sortType.FormattingEnabled = true;
            this.sortType.Location = new System.Drawing.Point(41, 568);
            this.sortType.Name = "sortType";
            this.sortType.Size = new System.Drawing.Size(318, 47);
            this.sortType.TabIndex = 50;
            this.sortType.SelectedIndexChanged += new System.EventHandler(this.sortType_SelectedIndexChanged);
            // 
            // delCarButton
            // 
            this.delCarButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.delCarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delCarButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delCarButton.Location = new System.Drawing.Point(41, 299);
            this.delCarButton.Name = "delCarButton";
            this.delCarButton.Size = new System.Drawing.Size(318, 59);
            this.delCarButton.TabIndex = 48;
            this.delCarButton.Text = "Удаление машины";
            this.delCarButton.UseVisualStyleBackColor = true;
            this.delCarButton.Visible = false;
            this.delCarButton.Click += new System.EventHandler(this.delCarButton_Click);
            // 
            // addCarButton
            // 
            this.addCarButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.addCarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addCarButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCarButton.Location = new System.Drawing.Point(41, 222);
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Size = new System.Drawing.Size(318, 59);
            this.addCarButton.TabIndex = 47;
            this.addCarButton.Text = "Добавление машины";
            this.addCarButton.UseVisualStyleBackColor = true;
            this.addCarButton.Visible = false;
            this.addCarButton.Click += new System.EventHandler(this.addCarButton_Click);
            // 
            // editCarButton
            // 
            this.editCarButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.editCarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editCarButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCarButton.Location = new System.Drawing.Point(41, 144);
            this.editCarButton.Name = "editCarButton";
            this.editCarButton.Size = new System.Drawing.Size(318, 59);
            this.editCarButton.TabIndex = 46;
            this.editCarButton.Text = "Изменение машины";
            this.editCarButton.UseVisualStyleBackColor = true;
            this.editCarButton.Visible = false;
            this.editCarButton.Click += new System.EventHandler(this.editCarButton_Click);
            // 
            // backMenuButton
            // 
            this.backMenuButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.backMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backMenuButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backMenuButton.Location = new System.Drawing.Point(1150, 706);
            this.backMenuButton.Name = "backMenuButton";
            this.backMenuButton.Size = new System.Drawing.Size(222, 59);
            this.backMenuButton.TabIndex = 45;
            this.backMenuButton.Text = "В меню";
            this.backMenuButton.UseVisualStyleBackColor = true;
            this.backMenuButton.Click += new System.EventHandler(this.backMenuButton_Click);
            // 
            // CarBD
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.CarBD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CarBD.BackgroundColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CarBD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CarBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarBD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCarBD,
            this.markaBD,
            this.modelBD,
            this.countryBD,
            this.classBD,
            this.statusCatalogCar,
            this.probegBD,
            this.priceBD});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CarBD.DefaultCellStyle = dataGridViewCellStyle3;
            this.CarBD.GridColor = System.Drawing.Color.Gray;
            this.CarBD.Location = new System.Drawing.Point(409, 144);
            this.CarBD.Name = "CarBD";
            this.CarBD.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CarBD.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.CarBD.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.CarBD.Size = new System.Drawing.Size(918, 516);
            this.CarBD.TabIndex = 44;
            // 
            // IdCarBD
            // 
            this.IdCarBD.HeaderText = "id";
            this.IdCarBD.Name = "IdCarBD";
            this.IdCarBD.ReadOnly = true;
            this.IdCarBD.Visible = false;
            // 
            // markaBD
            // 
            this.markaBD.HeaderText = "Марка";
            this.markaBD.Name = "markaBD";
            this.markaBD.ReadOnly = true;
            this.markaBD.Width = 200;
            // 
            // modelBD
            // 
            this.modelBD.HeaderText = "Модель";
            this.modelBD.Name = "modelBD";
            this.modelBD.ReadOnly = true;
            this.modelBD.Width = 200;
            // 
            // countryBD
            // 
            this.countryBD.HeaderText = "Страна";
            this.countryBD.Name = "countryBD";
            this.countryBD.ReadOnly = true;
            this.countryBD.Width = 175;
            // 
            // classBD
            // 
            this.classBD.HeaderText = "Класс";
            this.classBD.Name = "classBD";
            this.classBD.ReadOnly = true;
            // 
            // statusCatalogCar
            // 
            this.statusCatalogCar.HeaderText = "Состояние машины";
            this.statusCatalogCar.Name = "statusCatalogCar";
            this.statusCatalogCar.ReadOnly = true;
            // 
            // probegBD
            // 
            this.probegBD.HeaderText = "Пробег";
            this.probegBD.Name = "probegBD";
            this.probegBD.ReadOnly = true;
            // 
            // priceBD
            // 
            this.priceBD.HeaderText = "Цена в день";
            this.priceBD.Name = "priceBD";
            this.priceBD.ReadOnly = true;
            // 
            // countrySearch
            // 
            this.countrySearch.BackColor = System.Drawing.Color.Beige;
            this.countrySearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countrySearch.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countrySearch.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.countrySearch.FormattingEnabled = true;
            this.countrySearch.Location = new System.Drawing.Point(41, 504);
            this.countrySearch.Name = "countrySearch";
            this.countrySearch.Size = new System.Drawing.Size(318, 47);
            this.countrySearch.TabIndex = 58;
            this.countrySearch.SelectedIndexChanged += new System.EventHandler(this.countrySearch_SelectedIndexChanged);
            // 
            // modelSearch
            // 
            this.modelSearch.BackColor = System.Drawing.Color.Beige;
            this.modelSearch.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modelSearch.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.modelSearch.Location = new System.Drawing.Point(41, 442);
            this.modelSearch.MaxLength = 30;
            this.modelSearch.Name = "modelSearch";
            this.modelSearch.Size = new System.Drawing.Size(318, 43);
            this.modelSearch.TabIndex = 52;
            this.modelSearch.TextChanged += new System.EventHandler(this.modelSearch_TextChanged);
            this.modelSearch.Enter += new System.EventHandler(this.modelSearch_Enter);
            this.modelSearch.Leave += new System.EventHandler(this.modelSearch_Leave);
            // 
            // infoSearch1
            // 
            this.infoSearch1.AutoSize = true;
            this.infoSearch1.BackColor = System.Drawing.Color.Beige;
            this.infoSearch1.Font = new System.Drawing.Font("Monotype Corsiva", 23.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoSearch1.Location = new System.Drawing.Point(45, 380);
            this.infoSearch1.Name = "infoSearch1";
            this.infoSearch1.Size = new System.Drawing.Size(97, 38);
            this.infoSearch1.TabIndex = 67;
            this.infoSearch1.Text = "Марка";
            this.infoSearch1.Click += new System.EventHandler(this.infoSearch1_Click);
            // 
            // infoSearch2
            // 
            this.infoSearch2.AutoSize = true;
            this.infoSearch2.BackColor = System.Drawing.Color.Beige;
            this.infoSearch2.Font = new System.Drawing.Font("Monotype Corsiva", 23.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoSearch2.Location = new System.Drawing.Point(42, 446);
            this.infoSearch2.Name = "infoSearch2";
            this.infoSearch2.Size = new System.Drawing.Size(104, 38);
            this.infoSearch2.TabIndex = 68;
            this.infoSearch2.Text = "Модель";
            this.infoSearch2.Click += new System.EventHandler(this.infoSearch2_Click);
            // 
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1384, 780);
            this.ControlBox = false;
            this.Controls.Add(this.infoSearch2);
            this.Controls.Add(this.infoSearch1);
            this.Controls.Add(this.countrySearch);
            this.Controls.Add(this.modelSearch);
            this.Controls.Add(this.brandSearch);
            this.Controls.Add(this.sortType);
            this.Controls.Add(this.delCarButton);
            this.Controls.Add(this.addCarButton);
            this.Controls.Add(this.editCarButton);
            this.Controls.Add(this.backMenuButton);
            this.Controls.Add(this.CarBD);
            this.Controls.Add(this.TimeText);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Text1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"Прокаткомпарейшн\"";
            this.Load += new System.EventHandler(this.Cars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarBD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TimeNow;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.Label TimeText;
        private System.Windows.Forms.TextBox brandSearch;
        private System.Windows.Forms.ComboBox sortType;
        private System.Windows.Forms.Button delCarButton;
        private System.Windows.Forms.Button addCarButton;
        private System.Windows.Forms.Button editCarButton;
        private System.Windows.Forms.Button backMenuButton;
        private System.Windows.Forms.DataGridView CarBD;
        private System.Windows.Forms.ComboBox countrySearch;
        private System.Windows.Forms.TextBox modelSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCarBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn classBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusCatalogCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn probegBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceBD;
        private System.Windows.Forms.Label infoSearch1;
        private System.Windows.Forms.Label infoSearch2;
    }
}