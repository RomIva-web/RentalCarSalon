
namespace CAR_RENTAL.Forms
{
    partial class Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            this.TimeNow = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Text1 = new System.Windows.Forms.Label();
            this.TimeText = new System.Windows.Forms.Label();
            this.employeeFullName = new System.Windows.Forms.TextBox();
            this.delEmployeeButton = new System.Windows.Forms.Button();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.editEmployeeButton = new System.Windows.Forms.Button();
            this.backMenuButton = new System.Windows.Forms.Button();
            this.EmployeeBD = new System.Windows.Forms.DataGridView();
            this.idUserBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIOUserBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayUserBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneUserBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleUserBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoSearch1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBD)).BeginInit();
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
            this.pictureBox2.Location = new System.Drawing.Point(5, 0);
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
            this.pictureBox1.Location = new System.Drawing.Point(1246, 0);
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
            this.Text1.Location = new System.Drawing.Point(615, 42);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(200, 45);
            this.Text1.TabIndex = 5;
            this.Text1.Text = "Сотрудники";
            // 
            // TimeText
            // 
            this.TimeText.AutoSize = true;
            this.TimeText.BackColor = System.Drawing.Color.Transparent;
            this.TimeText.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeText.Location = new System.Drawing.Point(697, 726);
            this.TimeText.Name = "TimeText";
            this.TimeText.Size = new System.Drawing.Size(37, 45);
            this.TimeText.TabIndex = 16;
            this.TimeText.Text = "1";
            // 
            // employeeFullName
            // 
            this.employeeFullName.BackColor = System.Drawing.Color.Beige;
            this.employeeFullName.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeFullName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.employeeFullName.Location = new System.Drawing.Point(12, 395);
            this.employeeFullName.MaxLength = 50;
            this.employeeFullName.Name = "employeeFullName";
            this.employeeFullName.Size = new System.Drawing.Size(362, 43);
            this.employeeFullName.TabIndex = 51;
            this.employeeFullName.TextChanged += new System.EventHandler(this.employeeFullName_TextChanged);
            this.employeeFullName.Enter += new System.EventHandler(this.employeeFullName_Enter);
            this.employeeFullName.Leave += new System.EventHandler(this.employeeFullName_Leave);
            // 
            // delEmployeeButton
            // 
            this.delEmployeeButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.delEmployeeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delEmployeeButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delEmployeeButton.Location = new System.Drawing.Point(12, 297);
            this.delEmployeeButton.Name = "delEmployeeButton";
            this.delEmployeeButton.Size = new System.Drawing.Size(362, 59);
            this.delEmployeeButton.TabIndex = 47;
            this.delEmployeeButton.Text = "Увольнение сотрудника";
            this.delEmployeeButton.UseVisualStyleBackColor = true;
            this.delEmployeeButton.Visible = false;
            this.delEmployeeButton.Click += new System.EventHandler(this.delEmployeeButton_Click);
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.addEmployeeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addEmployeeButton.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addEmployeeButton.Location = new System.Drawing.Point(12, 220);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(362, 59);
            this.addEmployeeButton.TabIndex = 46;
            this.addEmployeeButton.Text = "Регистрация сотрудника";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Visible = false;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // editEmployeeButton
            // 
            this.editEmployeeButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.editEmployeeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editEmployeeButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editEmployeeButton.Location = new System.Drawing.Point(12, 142);
            this.editEmployeeButton.Name = "editEmployeeButton";
            this.editEmployeeButton.Size = new System.Drawing.Size(362, 59);
            this.editEmployeeButton.TabIndex = 45;
            this.editEmployeeButton.Text = "Изменение сотрудника";
            this.editEmployeeButton.UseVisualStyleBackColor = true;
            this.editEmployeeButton.Visible = false;
            this.editEmployeeButton.Click += new System.EventHandler(this.editEmployeeButton_Click);
            // 
            // backMenuButton
            // 
            this.backMenuButton.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms;
            this.backMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backMenuButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backMenuButton.Location = new System.Drawing.Point(1143, 704);
            this.backMenuButton.Name = "backMenuButton";
            this.backMenuButton.Size = new System.Drawing.Size(222, 59);
            this.backMenuButton.TabIndex = 44;
            this.backMenuButton.Text = "В меню";
            this.backMenuButton.UseVisualStyleBackColor = true;
            this.backMenuButton.Click += new System.EventHandler(this.backMenuButton_Click);
            // 
            // EmployeeBD
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.EmployeeBD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EmployeeBD.BackgroundColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeBD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeeBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeBD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUserBD,
            this.FIOUserBD,
            this.birthdayUserBD,
            this.phoneUserBD,
            this.roleUserBD});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeBD.DefaultCellStyle = dataGridViewCellStyle3;
            this.EmployeeBD.GridColor = System.Drawing.Color.Gray;
            this.EmployeeBD.Location = new System.Drawing.Point(403, 142);
            this.EmployeeBD.Name = "EmployeeBD";
            this.EmployeeBD.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeBD.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.EmployeeBD.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.EmployeeBD.Size = new System.Drawing.Size(918, 516);
            this.EmployeeBD.TabIndex = 43;
            // 
            // idUserBD
            // 
            this.idUserBD.HeaderText = "Номер сотрудника";
            this.idUserBD.Name = "idUserBD";
            this.idUserBD.ReadOnly = true;
            this.idUserBD.Visible = false;
            // 
            // FIOUserBD
            // 
            this.FIOUserBD.HeaderText = "ФИО Сотрудника";
            this.FIOUserBD.Name = "FIOUserBD";
            this.FIOUserBD.ReadOnly = true;
            this.FIOUserBD.Width = 300;
            // 
            // birthdayUserBD
            // 
            this.birthdayUserBD.HeaderText = "Дата рождения";
            this.birthdayUserBD.Name = "birthdayUserBD";
            this.birthdayUserBD.ReadOnly = true;
            this.birthdayUserBD.Width = 175;
            // 
            // phoneUserBD
            // 
            this.phoneUserBD.HeaderText = "Телефон";
            this.phoneUserBD.Name = "phoneUserBD";
            this.phoneUserBD.ReadOnly = true;
            this.phoneUserBD.Width = 200;
            // 
            // roleUserBD
            // 
            this.roleUserBD.HeaderText = "Должность";
            this.roleUserBD.Name = "roleUserBD";
            this.roleUserBD.ReadOnly = true;
            this.roleUserBD.Width = 200;
            // 
            // infoSearch1
            // 
            this.infoSearch1.AutoSize = true;
            this.infoSearch1.BackColor = System.Drawing.Color.Beige;
            this.infoSearch1.Font = new System.Drawing.Font("Monotype Corsiva", 23.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoSearch1.Location = new System.Drawing.Point(16, 399);
            this.infoSearch1.Name = "infoSearch1";
            this.infoSearch1.Size = new System.Drawing.Size(228, 38);
            this.infoSearch1.TabIndex = 68;
            this.infoSearch1.Text = "ФИО Сотрудника";
            this.infoSearch1.Click += new System.EventHandler(this.infoSearch1_Click);
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CAR_RENTAL.Properties.Resources.FonForms5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1384, 780);
            this.ControlBox = false;
            this.Controls.Add(this.infoSearch1);
            this.Controls.Add(this.employeeFullName);
            this.Controls.Add(this.delEmployeeButton);
            this.Controls.Add(this.addEmployeeButton);
            this.Controls.Add(this.editEmployeeButton);
            this.Controls.Add(this.backMenuButton);
            this.Controls.Add(this.EmployeeBD);
            this.Controls.Add(this.TimeText);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Text1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"Прокаткомпарейшн\"";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TimeNow;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.Label TimeText;
        private System.Windows.Forms.TextBox employeeFullName;
        private System.Windows.Forms.Button delEmployeeButton;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Button editEmployeeButton;
        private System.Windows.Forms.Button backMenuButton;
        private System.Windows.Forms.DataGridView EmployeeBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUserBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIOUserBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayUserBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneUserBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleUserBD;
        private System.Windows.Forms.Label infoSearch1;
    }
}