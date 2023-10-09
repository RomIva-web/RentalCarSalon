
namespace CAR_RENTAL.Forms
{
    partial class AddAndEditTypeCarDamage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAndEditTypeCarDamage));
            this.editTypeCarDamageButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addTypeCarDamageButton = new System.Windows.Forms.Button();
            this.priceTypeCarDamage = new System.Windows.Forms.TextBox();
            this.nameTypeCarDamage = new System.Windows.Forms.TextBox();
            this.Text4 = new System.Windows.Forms.Label();
            this.Text3 = new System.Windows.Forms.Label();
            this.TimeText = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Text1 = new System.Windows.Forms.Label();
            this.TimeNow = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // editTypeCarDamageButton
            // 
            this.editTypeCarDamageButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.editTypeCarDamageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editTypeCarDamageButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTypeCarDamageButton.Location = new System.Drawing.Point(288, 714);
            this.editTypeCarDamageButton.Name = "editTypeCarDamageButton";
            this.editTypeCarDamageButton.Size = new System.Drawing.Size(300, 50);
            this.editTypeCarDamageButton.TabIndex = 68;
            this.editTypeCarDamageButton.Text = "Изменить";
            this.editTypeCarDamageButton.UseVisualStyleBackColor = true;
            this.editTypeCarDamageButton.Click += new System.EventHandler(this.editTypeCarDamageButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(809, 714);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(300, 50);
            this.cancelButton.TabIndex = 67;
            this.cancelButton.Text = "Назад";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addTypeCarDamageButton
            // 
            this.addTypeCarDamageButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.addTypeCarDamageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addTypeCarDamageButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTypeCarDamageButton.Location = new System.Drawing.Point(288, 714);
            this.addTypeCarDamageButton.Name = "addTypeCarDamageButton";
            this.addTypeCarDamageButton.Size = new System.Drawing.Size(300, 50);
            this.addTypeCarDamageButton.TabIndex = 66;
            this.addTypeCarDamageButton.Text = "Добавить";
            this.addTypeCarDamageButton.UseVisualStyleBackColor = true;
            this.addTypeCarDamageButton.Click += new System.EventHandler(this.addTypeCarDamageButton_Click);
            // 
            // priceTypeCarDamage
            // 
            this.priceTypeCarDamage.BackColor = System.Drawing.Color.Beige;
            this.priceTypeCarDamage.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTypeCarDamage.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.priceTypeCarDamage.Location = new System.Drawing.Point(513, 439);
            this.priceTypeCarDamage.Name = "priceTypeCarDamage";
            this.priceTypeCarDamage.Size = new System.Drawing.Size(335, 34);
            this.priceTypeCarDamage.TabIndex = 65;
            this.priceTypeCarDamage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTypeCarDamage_KeyPress);
            // 
            // nameTypeCarDamage
            // 
            this.nameTypeCarDamage.BackColor = System.Drawing.Color.Beige;
            this.nameTypeCarDamage.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTypeCarDamage.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.nameTypeCarDamage.Location = new System.Drawing.Point(513, 331);
            this.nameTypeCarDamage.MaxLength = 40;
            this.nameTypeCarDamage.Name = "nameTypeCarDamage";
            this.nameTypeCarDamage.Size = new System.Drawing.Size(335, 34);
            this.nameTypeCarDamage.TabIndex = 64;
            this.nameTypeCarDamage.TextChanged += new System.EventHandler(this.nameTypeCarDamage_TextChanged);
            // 
            // Text4
            // 
            this.Text4.AutoSize = true;
            this.Text4.BackColor = System.Drawing.Color.Transparent;
            this.Text4.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Text4.Location = new System.Drawing.Point(527, 391);
            this.Text4.Name = "Text4";
            this.Text4.Size = new System.Drawing.Size(321, 45);
            this.Text4.TabIndex = 63;
            this.Text4.Text = "Цена за повреждение:";
            // 
            // Text3
            // 
            this.Text3.AutoSize = true;
            this.Text3.BackColor = System.Drawing.Color.Transparent;
            this.Text3.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Text3.Location = new System.Drawing.Point(472, 283);
            this.Text3.Name = "Text3";
            this.Text3.Size = new System.Drawing.Size(429, 45);
            this.Text3.TabIndex = 62;
            this.Text3.Text = "Название типа повреждения:";
            // 
            // TimeText
            // 
            this.TimeText.AutoSize = true;
            this.TimeText.BackColor = System.Drawing.Color.Transparent;
            this.TimeText.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeText.Location = new System.Drawing.Point(653, 725);
            this.TimeText.Name = "TimeText";
            this.TimeText.Size = new System.Drawing.Size(37, 45);
            this.TimeText.TabIndex = 61;
            this.TimeText.Text = "1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::CAR_RENTAL.Properties.Resources.Logotip;
            this.pictureBox2.Location = new System.Drawing.Point(7, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 115);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 60;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CAR_RENTAL.Properties.Resources.Logotip;
            this.pictureBox1.Location = new System.Drawing.Point(1248, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // Text1
            // 
            this.Text1.AutoSize = true;
            this.Text1.BackColor = System.Drawing.Color.Transparent;
            this.Text1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text1.Location = new System.Drawing.Point(449, 55);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(476, 45);
            this.Text1.TabIndex = 58;
            this.Text1.Text = "Добавление типа повреждения";
            // 
            // TimeNow
            // 
            this.TimeNow.Enabled = true;
            this.TimeNow.Tick += new System.EventHandler(this.TimeNow_Tick);
            // 
            // AddAndEditTypeCarDamage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1384, 780);
            this.ControlBox = false;
            this.Controls.Add(this.editTypeCarDamageButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addTypeCarDamageButton);
            this.Controls.Add(this.priceTypeCarDamage);
            this.Controls.Add(this.nameTypeCarDamage);
            this.Controls.Add(this.Text4);
            this.Controls.Add(this.Text3);
            this.Controls.Add(this.TimeText);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Text1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddAndEditTypeCarDamage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"Прокаткомпарейшн\"";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editTypeCarDamageButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addTypeCarDamageButton;
        private System.Windows.Forms.TextBox priceTypeCarDamage;
        private System.Windows.Forms.TextBox nameTypeCarDamage;
        private System.Windows.Forms.Label Text4;
        private System.Windows.Forms.Label Text3;
        private System.Windows.Forms.Label TimeText;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.Timer TimeNow;
    }
}