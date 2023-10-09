
namespace CAR_RENTAL.Forms
{
    partial class EditTypeCarDamageOnRentalCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTypeCarDamageOnRentalCar));
            this.delTypeCarDamage = new System.Windows.Forms.Button();
            this.addTypeCarDamage = new System.Windows.Forms.Button();
            this.typeCarDamages = new System.Windows.Forms.ComboBox();
            this.editTypeCarDamageOnRentalCarButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addCarButton = new System.Windows.Forms.Button();
            this.TimeText = new System.Windows.Forms.Label();
            this.TimeNow = new System.Windows.Forms.Timer(this.components);
            this.TypeCarDamagesBD = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Text1 = new System.Windows.Forms.Label();
            this.idTypeCarDamageBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTypeCarDamageBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itogPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Text3 = new System.Windows.Forms.Label();
            this.Text2 = new System.Windows.Forms.Label();
            this.Text4 = new System.Windows.Forms.Label();
            this.Text5 = new System.Windows.Forms.Label();
            this.amountTypeCarDamage = new System.Windows.Forms.TextBox();
            this.priceTypeCarDamage = new System.Windows.Forms.Label();
            this.itogPriceTypeCarDamage = new System.Windows.Forms.Label();
            this.fullPriceTypeCarDamages = new System.Windows.Forms.Label();
            this.Text6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TypeCarDamagesBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // delTypeCarDamage
            // 
            this.delTypeCarDamage.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.delTypeCarDamage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delTypeCarDamage.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delTypeCarDamage.Location = new System.Drawing.Point(69, 530);
            this.delTypeCarDamage.Name = "delTypeCarDamage";
            this.delTypeCarDamage.Size = new System.Drawing.Size(605, 39);
            this.delTypeCarDamage.TabIndex = 96;
            this.delTypeCarDamage.Text = "Удалить";
            this.delTypeCarDamage.UseVisualStyleBackColor = true;
            this.delTypeCarDamage.Click += new System.EventHandler(this.delTypeCarDamage_Click);
            // 
            // addTypeCarDamage
            // 
            this.addTypeCarDamage.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.addTypeCarDamage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addTypeCarDamage.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTypeCarDamage.Location = new System.Drawing.Point(69, 485);
            this.addTypeCarDamage.Name = "addTypeCarDamage";
            this.addTypeCarDamage.Size = new System.Drawing.Size(605, 39);
            this.addTypeCarDamage.TabIndex = 95;
            this.addTypeCarDamage.Text = "Добавить";
            this.addTypeCarDamage.UseVisualStyleBackColor = true;
            this.addTypeCarDamage.Click += new System.EventHandler(this.addTypeCarDamage_Click);
            // 
            // typeCarDamages
            // 
            this.typeCarDamages.BackColor = System.Drawing.Color.Beige;
            this.typeCarDamages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCarDamages.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeCarDamages.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.typeCarDamages.FormattingEnabled = true;
            this.typeCarDamages.Location = new System.Drawing.Point(69, 246);
            this.typeCarDamages.Name = "typeCarDamages";
            this.typeCarDamages.Size = new System.Drawing.Size(605, 36);
            this.typeCarDamages.TabIndex = 94;
            this.typeCarDamages.SelectedIndexChanged += new System.EventHandler(this.typeCarDamages_SelectedIndexChanged);
            // 
            // editTypeCarDamageOnRentalCarButton
            // 
            this.editTypeCarDamageOnRentalCarButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.editTypeCarDamageOnRentalCarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editTypeCarDamageOnRentalCarButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTypeCarDamageOnRentalCarButton.Location = new System.Drawing.Point(296, 718);
            this.editTypeCarDamageOnRentalCarButton.Name = "editTypeCarDamageOnRentalCarButton";
            this.editTypeCarDamageOnRentalCarButton.Size = new System.Drawing.Size(300, 50);
            this.editTypeCarDamageOnRentalCarButton.TabIndex = 100;
            this.editTypeCarDamageOnRentalCarButton.Text = "Изменить";
            this.editTypeCarDamageOnRentalCarButton.UseVisualStyleBackColor = true;
            this.editTypeCarDamageOnRentalCarButton.Click += new System.EventHandler(this.editTypeCarDamageOnRentalCarButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(817, 718);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(300, 50);
            this.cancelButton.TabIndex = 99;
            this.cancelButton.Text = "Назад";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addCarButton
            // 
            this.addCarButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.addCarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addCarButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCarButton.Location = new System.Drawing.Point(296, 718);
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Size = new System.Drawing.Size(300, 50);
            this.addCarButton.TabIndex = 98;
            this.addCarButton.Text = "Добавить";
            this.addCarButton.UseVisualStyleBackColor = true;
            // 
            // TimeText
            // 
            this.TimeText.AutoSize = true;
            this.TimeText.BackColor = System.Drawing.Color.Transparent;
            this.TimeText.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeText.Location = new System.Drawing.Point(679, 729);
            this.TimeText.Name = "TimeText";
            this.TimeText.Size = new System.Drawing.Size(37, 45);
            this.TimeText.TabIndex = 97;
            this.TimeText.Text = "1";
            // 
            // TimeNow
            // 
            this.TimeNow.Enabled = true;
            this.TimeNow.Tick += new System.EventHandler(this.TimeNow_Tick);
            // 
            // TypeCarDamagesBD
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.TypeCarDamagesBD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TypeCarDamagesBD.BackgroundColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TypeCarDamagesBD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TypeCarDamagesBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TypeCarDamagesBD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTypeCarDamageBD,
            this.nameTypeCarDamageBD,
            this.amount,
            this.priceBD,
            this.itogPrice});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TypeCarDamagesBD.DefaultCellStyle = dataGridViewCellStyle3;
            this.TypeCarDamagesBD.GridColor = System.Drawing.Color.Gray;
            this.TypeCarDamagesBD.Location = new System.Drawing.Point(714, 151);
            this.TypeCarDamagesBD.Name = "TypeCarDamagesBD";
            this.TypeCarDamagesBD.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TypeCarDamagesBD.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.TypeCarDamagesBD.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.TypeCarDamagesBD.Size = new System.Drawing.Size(599, 466);
            this.TypeCarDamagesBD.TabIndex = 102;
            this.TypeCarDamagesBD.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.TypeCarDamagesBD_RowsAdded);
            this.TypeCarDamagesBD.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.TypeCarDamagesBD_RowsRemoved);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::CAR_RENTAL.Properties.Resources.Logotip;
            this.pictureBox2.Location = new System.Drawing.Point(7, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 115);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 105;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CAR_RENTAL.Properties.Resources.Logotip;
            this.pictureBox1.Location = new System.Drawing.Point(1248, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 104;
            this.pictureBox1.TabStop = false;
            // 
            // Text1
            // 
            this.Text1.AutoSize = true;
            this.Text1.BackColor = System.Drawing.Color.Transparent;
            this.Text1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text1.Location = new System.Drawing.Point(421, 35);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(541, 45);
            this.Text1.TabIndex = 103;
            this.Text1.Text = "Изменение повреждений на прокат";
            // 
            // idTypeCarDamageBD
            // 
            this.idTypeCarDamageBD.HeaderText = "Номер типа повреждения";
            this.idTypeCarDamageBD.Name = "idTypeCarDamageBD";
            this.idTypeCarDamageBD.ReadOnly = true;
            this.idTypeCarDamageBD.Visible = false;
            // 
            // nameTypeCarDamageBD
            // 
            this.nameTypeCarDamageBD.HeaderText = "Название типа повреждения";
            this.nameTypeCarDamageBD.Name = "nameTypeCarDamageBD";
            this.nameTypeCarDamageBD.ReadOnly = true;
            this.nameTypeCarDamageBD.Width = 250;
            // 
            // amount
            // 
            this.amount.HeaderText = "Количество";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // priceBD
            // 
            this.priceBD.HeaderText = "Цена";
            this.priceBD.Name = "priceBD";
            this.priceBD.ReadOnly = true;
            // 
            // itogPrice
            // 
            this.itogPrice.HeaderText = "Общая стоимость";
            this.itogPrice.Name = "itogPrice";
            this.itogPrice.ReadOnly = true;
            // 
            // Text3
            // 
            this.Text3.AutoSize = true;
            this.Text3.BackColor = System.Drawing.Color.Transparent;
            this.Text3.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text3.ForeColor = System.Drawing.Color.Black;
            this.Text3.Location = new System.Drawing.Point(218, 370);
            this.Text3.Name = "Text3";
            this.Text3.Size = new System.Drawing.Size(287, 45);
            this.Text3.TabIndex = 108;
            this.Text3.Text = "Цена повреждения:";
            // 
            // Text2
            // 
            this.Text2.AutoSize = true;
            this.Text2.BackColor = System.Drawing.Color.Transparent;
            this.Text2.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text2.ForeColor = System.Drawing.Color.Black;
            this.Text2.Location = new System.Drawing.Point(236, 198);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(285, 45);
            this.Text2.TabIndex = 106;
            this.Text2.Text = "Тип повреждения:";
            // 
            // Text4
            // 
            this.Text4.AutoSize = true;
            this.Text4.BackColor = System.Drawing.Color.Transparent;
            this.Text4.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text4.ForeColor = System.Drawing.Color.Black;
            this.Text4.Location = new System.Drawing.Point(183, 285);
            this.Text4.Name = "Text4";
            this.Text4.Size = new System.Drawing.Size(382, 45);
            this.Text4.TabIndex = 110;
            this.Text4.Text = "Количество повреждений:";
            // 
            // Text5
            // 
            this.Text5.AutoSize = true;
            this.Text5.BackColor = System.Drawing.Color.Transparent;
            this.Text5.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text5.ForeColor = System.Drawing.Color.Black;
            this.Text5.Location = new System.Drawing.Point(31, 426);
            this.Text5.Name = "Text5";
            this.Text5.Size = new System.Drawing.Size(474, 45);
            this.Text5.TabIndex = 111;
            this.Text5.Text = "Общая стоимость повреждения:";
            // 
            // amountTypeCarDamage
            // 
            this.amountTypeCarDamage.BackColor = System.Drawing.Color.Beige;
            this.amountTypeCarDamage.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountTypeCarDamage.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.amountTypeCarDamage.Location = new System.Drawing.Point(69, 333);
            this.amountTypeCarDamage.Name = "amountTypeCarDamage";
            this.amountTypeCarDamage.Size = new System.Drawing.Size(605, 34);
            this.amountTypeCarDamage.TabIndex = 107;
            this.amountTypeCarDamage.TextChanged += new System.EventHandler(this.amountTypeCarDamage_TextChanged);
            this.amountTypeCarDamage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amountTypeCarDamage_KeyPress);
            // 
            // priceTypeCarDamage
            // 
            this.priceTypeCarDamage.AutoSize = true;
            this.priceTypeCarDamage.BackColor = System.Drawing.Color.Transparent;
            this.priceTypeCarDamage.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTypeCarDamage.ForeColor = System.Drawing.Color.Black;
            this.priceTypeCarDamage.Location = new System.Drawing.Point(511, 370);
            this.priceTypeCarDamage.Name = "priceTypeCarDamage";
            this.priceTypeCarDamage.Size = new System.Drawing.Size(36, 45);
            this.priceTypeCarDamage.TabIndex = 112;
            this.priceTypeCarDamage.Text = "0";
            // 
            // itogPriceTypeCarDamage
            // 
            this.itogPriceTypeCarDamage.AutoSize = true;
            this.itogPriceTypeCarDamage.BackColor = System.Drawing.Color.Transparent;
            this.itogPriceTypeCarDamage.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itogPriceTypeCarDamage.ForeColor = System.Drawing.Color.Black;
            this.itogPriceTypeCarDamage.Location = new System.Drawing.Point(511, 426);
            this.itogPriceTypeCarDamage.Name = "itogPriceTypeCarDamage";
            this.itogPriceTypeCarDamage.Size = new System.Drawing.Size(36, 45);
            this.itogPriceTypeCarDamage.TabIndex = 113;
            this.itogPriceTypeCarDamage.Text = "0";
            // 
            // fullPriceTypeCarDamages
            // 
            this.fullPriceTypeCarDamages.AutoSize = true;
            this.fullPriceTypeCarDamages.BackColor = System.Drawing.Color.Transparent;
            this.fullPriceTypeCarDamages.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullPriceTypeCarDamages.ForeColor = System.Drawing.Color.Black;
            this.fullPriceTypeCarDamages.Location = new System.Drawing.Point(1169, 620);
            this.fullPriceTypeCarDamages.Name = "fullPriceTypeCarDamages";
            this.fullPriceTypeCarDamages.Size = new System.Drawing.Size(36, 45);
            this.fullPriceTypeCarDamages.TabIndex = 115;
            this.fullPriceTypeCarDamages.Text = "0";
            // 
            // Text6
            // 
            this.Text6.AutoSize = true;
            this.Text6.BackColor = System.Drawing.Color.Transparent;
            this.Text6.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text6.ForeColor = System.Drawing.Color.Black;
            this.Text6.Location = new System.Drawing.Point(706, 620);
            this.Text6.Name = "Text6";
            this.Text6.Size = new System.Drawing.Size(474, 45);
            this.Text6.TabIndex = 114;
            this.Text6.Text = "Общая стоимость повреждения:";
            // 
            // EditTypeCarDamageOnRentalCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1384, 780);
            this.ControlBox = false;
            this.Controls.Add(this.fullPriceTypeCarDamages);
            this.Controls.Add(this.Text6);
            this.Controls.Add(this.itogPriceTypeCarDamage);
            this.Controls.Add(this.priceTypeCarDamage);
            this.Controls.Add(this.Text5);
            this.Controls.Add(this.Text4);
            this.Controls.Add(this.Text3);
            this.Controls.Add(this.amountTypeCarDamage);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Text1);
            this.Controls.Add(this.TypeCarDamagesBD);
            this.Controls.Add(this.editTypeCarDamageOnRentalCarButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addCarButton);
            this.Controls.Add(this.TimeText);
            this.Controls.Add(this.delTypeCarDamage);
            this.Controls.Add(this.addTypeCarDamage);
            this.Controls.Add(this.typeCarDamages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditTypeCarDamageOnRentalCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"Прокаткомпарейшн\"";
            ((System.ComponentModel.ISupportInitialize)(this.TypeCarDamagesBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delTypeCarDamage;
        private System.Windows.Forms.Button addTypeCarDamage;
        private System.Windows.Forms.ComboBox typeCarDamages;
        private System.Windows.Forms.Button editTypeCarDamageOnRentalCarButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addCarButton;
        private System.Windows.Forms.Label TimeText;
        private System.Windows.Forms.Timer TimeNow;
        private System.Windows.Forms.DataGridView TypeCarDamagesBD;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTypeCarDamageBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameTypeCarDamageBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn itogPrice;
        private System.Windows.Forms.Label Text3;
        private System.Windows.Forms.Label Text2;
        private System.Windows.Forms.Label Text4;
        private System.Windows.Forms.Label Text5;
        private System.Windows.Forms.TextBox amountTypeCarDamage;
        private System.Windows.Forms.Label priceTypeCarDamage;
        private System.Windows.Forms.Label itogPriceTypeCarDamage;
        private System.Windows.Forms.Label fullPriceTypeCarDamages;
        private System.Windows.Forms.Label Text6;
    }
}