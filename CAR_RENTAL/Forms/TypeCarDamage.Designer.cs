
namespace CAR_RENTAL.Forms
{
    partial class TypeCarDamage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypeCarDamage));
            this.editTypeCarDamageButton = new System.Windows.Forms.Button();
            this.backMenuButton = new System.Windows.Forms.Button();
            this.typeCarDamageName = new System.Windows.Forms.TextBox();
            this.sortType = new System.Windows.Forms.ComboBox();
            this.delTypeCarDamageButton = new System.Windows.Forms.Button();
            this.addTypeCarDamageButton = new System.Windows.Forms.Button();
            this.TypeCarDamageBD = new System.Windows.Forms.DataGridView();
            this.idTypeCarDamageBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTypeCarDamageBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeText = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Text1 = new System.Windows.Forms.Label();
            this.TimeNow = new System.Windows.Forms.Timer(this.components);
            this.infoSearch1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TypeCarDamageBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // editTypeCarDamageButton
            // 
            this.editTypeCarDamageButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.editTypeCarDamageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editTypeCarDamageButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTypeCarDamageButton.Location = new System.Drawing.Point(115, 156);
            this.editTypeCarDamageButton.Name = "editTypeCarDamageButton";
            this.editTypeCarDamageButton.Size = new System.Drawing.Size(334, 100);
            this.editTypeCarDamageButton.TabIndex = 78;
            this.editTypeCarDamageButton.Text = "Изменение типа повреждения";
            this.editTypeCarDamageButton.UseVisualStyleBackColor = true;
            this.editTypeCarDamageButton.Visible = false;
            this.editTypeCarDamageButton.Click += new System.EventHandler(this.editTypeCarDamageButton_Click);
            // 
            // backMenuButton
            // 
            this.backMenuButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.backMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backMenuButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backMenuButton.Location = new System.Drawing.Point(1155, 708);
            this.backMenuButton.Name = "backMenuButton";
            this.backMenuButton.Size = new System.Drawing.Size(222, 59);
            this.backMenuButton.TabIndex = 77;
            this.backMenuButton.Text = "В меню";
            this.backMenuButton.UseVisualStyleBackColor = true;
            this.backMenuButton.Click += new System.EventHandler(this.backMenuButton_Click);
            // 
            // typeCarDamageName
            // 
            this.typeCarDamageName.BackColor = System.Drawing.Color.Beige;
            this.typeCarDamageName.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeCarDamageName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.typeCarDamageName.Location = new System.Drawing.Point(114, 519);
            this.typeCarDamageName.MaxLength = 40;
            this.typeCarDamageName.Name = "typeCarDamageName";
            this.typeCarDamageName.Size = new System.Drawing.Size(334, 43);
            this.typeCarDamageName.TabIndex = 74;
            this.typeCarDamageName.TextChanged += new System.EventHandler(this.typeCarDamageName_TextChanged);
            this.typeCarDamageName.Enter += new System.EventHandler(this.typeCarDamageName_Enter);
            this.typeCarDamageName.Leave += new System.EventHandler(this.typeCarDamageName_Leave);
            // 
            // sortType
            // 
            this.sortType.BackColor = System.Drawing.Color.Beige;
            this.sortType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortType.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortType.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.sortType.FormattingEnabled = true;
            this.sortType.Location = new System.Drawing.Point(114, 579);
            this.sortType.Name = "sortType";
            this.sortType.Size = new System.Drawing.Size(334, 47);
            this.sortType.TabIndex = 73;
            this.sortType.SelectedIndexChanged += new System.EventHandler(this.sortType_SelectedIndexChanged);
            // 
            // delTypeCarDamageButton
            // 
            this.delTypeCarDamageButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.delTypeCarDamageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delTypeCarDamageButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delTypeCarDamageButton.Location = new System.Drawing.Point(115, 397);
            this.delTypeCarDamageButton.Name = "delTypeCarDamageButton";
            this.delTypeCarDamageButton.Size = new System.Drawing.Size(334, 100);
            this.delTypeCarDamageButton.TabIndex = 72;
            this.delTypeCarDamageButton.Text = "Удаление типа повреждения";
            this.delTypeCarDamageButton.UseVisualStyleBackColor = true;
            this.delTypeCarDamageButton.Visible = false;
            this.delTypeCarDamageButton.Click += new System.EventHandler(this.delTypeCarDamageButton_Click);
            // 
            // addTypeCarDamageButton
            // 
            this.addTypeCarDamageButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.addTypeCarDamageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addTypeCarDamageButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTypeCarDamageButton.Location = new System.Drawing.Point(115, 276);
            this.addTypeCarDamageButton.Name = "addTypeCarDamageButton";
            this.addTypeCarDamageButton.Size = new System.Drawing.Size(334, 100);
            this.addTypeCarDamageButton.TabIndex = 71;
            this.addTypeCarDamageButton.Text = "Добавление типа повреждения";
            this.addTypeCarDamageButton.UseVisualStyleBackColor = true;
            this.addTypeCarDamageButton.Visible = false;
            this.addTypeCarDamageButton.Click += new System.EventHandler(this.addTypeCarDamageButton_Click);
            // 
            // TypeCarDamageBD
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.TypeCarDamageBD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TypeCarDamageBD.BackgroundColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TypeCarDamageBD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TypeCarDamageBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TypeCarDamageBD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTypeCarDamageBD,
            this.nameTypeCarDamageBD,
            this.priceBD});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TypeCarDamageBD.DefaultCellStyle = dataGridViewCellStyle3;
            this.TypeCarDamageBD.GridColor = System.Drawing.Color.Gray;
            this.TypeCarDamageBD.Location = new System.Drawing.Point(528, 145);
            this.TypeCarDamageBD.Name = "TypeCarDamageBD";
            this.TypeCarDamageBD.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TypeCarDamageBD.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.TypeCarDamageBD.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.TypeCarDamageBD.Size = new System.Drawing.Size(598, 516);
            this.TypeCarDamageBD.TabIndex = 70;
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
            this.nameTypeCarDamageBD.Width = 350;
            // 
            // priceBD
            // 
            this.priceBD.HeaderText = "Цена";
            this.priceBD.Name = "priceBD";
            this.priceBD.ReadOnly = true;
            this.priceBD.Width = 200;
            // 
            // TimeText
            // 
            this.TimeText.AutoSize = true;
            this.TimeText.BackColor = System.Drawing.Color.Transparent;
            this.TimeText.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeText.Location = new System.Drawing.Point(651, 722);
            this.TimeText.Name = "TimeText";
            this.TimeText.Size = new System.Drawing.Size(37, 45);
            this.TimeText.TabIndex = 69;
            this.TimeText.Text = "1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::CAR_RENTAL.Properties.Resources.Logotip;
            this.pictureBox2.Location = new System.Drawing.Point(5, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 115);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 68;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CAR_RENTAL.Properties.Resources.Logotip;
            this.pictureBox1.Location = new System.Drawing.Point(1246, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // Text1
            // 
            this.Text1.AutoSize = true;
            this.Text1.BackColor = System.Drawing.Color.Transparent;
            this.Text1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text1.Location = new System.Drawing.Point(497, 38);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(314, 45);
            this.Text1.TabIndex = 66;
            this.Text1.Text = "Типы повреждений";
            // 
            // TimeNow
            // 
            this.TimeNow.Enabled = true;
            this.TimeNow.Tick += new System.EventHandler(this.TimeNow_Tick);
            // 
            // infoSearch1
            // 
            this.infoSearch1.AutoSize = true;
            this.infoSearch1.BackColor = System.Drawing.Color.Beige;
            this.infoSearch1.Font = new System.Drawing.Font("Monotype Corsiva", 23.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoSearch1.Location = new System.Drawing.Point(118, 523);
            this.infoSearch1.Name = "infoSearch1";
            this.infoSearch1.Size = new System.Drawing.Size(229, 38);
            this.infoSearch1.TabIndex = 79;
            this.infoSearch1.Text = "Тип повреждения";
            this.infoSearch1.Click += new System.EventHandler(this.infoSearch1_Click);
            // 
            // TypeCarDamage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1384, 780);
            this.ControlBox = false;
            this.Controls.Add(this.infoSearch1);
            this.Controls.Add(this.editTypeCarDamageButton);
            this.Controls.Add(this.backMenuButton);
            this.Controls.Add(this.typeCarDamageName);
            this.Controls.Add(this.sortType);
            this.Controls.Add(this.delTypeCarDamageButton);
            this.Controls.Add(this.addTypeCarDamageButton);
            this.Controls.Add(this.TypeCarDamageBD);
            this.Controls.Add(this.TimeText);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Text1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TypeCarDamage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"Прокаткомпарейшн\"";
            this.Load += new System.EventHandler(this.TypeCarDamage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TypeCarDamageBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editTypeCarDamageButton;
        private System.Windows.Forms.Button backMenuButton;
        private System.Windows.Forms.TextBox typeCarDamageName;
        private System.Windows.Forms.ComboBox sortType;
        private System.Windows.Forms.Button delTypeCarDamageButton;
        private System.Windows.Forms.Button addTypeCarDamageButton;
        private System.Windows.Forms.DataGridView TypeCarDamageBD;
        private System.Windows.Forms.Label TimeText;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.Timer TimeNow;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTypeCarDamageBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameTypeCarDamageBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceBD;
        private System.Windows.Forms.Label infoSearch1;
    }
}