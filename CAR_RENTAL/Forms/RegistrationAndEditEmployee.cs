using CAR_RENTAL.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAR_RENTAL.Forms
{
    public partial class RegistrationAndEditEmployee : Form
    {
        int idEmployee;
        string passwordLast;
        CarRentalSalonEntities db = new CarRentalSalonEntities();
        public RegistrationAndEditEmployee()
        {
            InitializeComponent();
            editEmployeeButton.Visible = false;
            addEmployeeButton.Visible = true;
            Text11.Visible = false;
            Text10.Visible = true;
            Text7.Visible = true;
            Text12.Visible = false;
            infoPasswordButton.Visible = false;
            LoadRoles();
            Text1.Text = "Регистрация сотрудника";
        }
        public RegistrationAndEditEmployee(int id)
        {
            InitializeComponent();
            idEmployee = id;
            editEmployeeButton.Visible = true;
            addEmployeeButton.Visible = false;
            Text11.Visible = true;
            Text10.Visible = false;
            Text12.Visible = true;
            Text7.Visible = false;
            infoPasswordButton.Visible = true;
            LoadRoles();
            LoadEmployee();
            Text1.Text = "Изменение данных сотрудника";
        }

        private void TimeNow_Tick(object sender, EventArgs e)
        {
            TimeNow.Interval = 1000;
            TimeText.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }

        private void hideConfirmPasswordButton_Click(object sender, EventArgs e)
        {
            if (confirmPassword.PasswordChar == '\0') confirmPassword.PasswordChar = '*';
            else confirmPassword.PasswordChar = '\0';
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            if (fullNameEmployee.Text != "" && login.Text != "" && password.Text != "" && confirmPassword.Text != "" && numberPhone.Text != "" && role.SelectedIndex != -1)
            {
                addEmployee();
                Employees sotrydnik = new Employees();
                sotrydnik.Show();
                this.Close();
            }
            else MessageBox.Show("Заполните все поля!");
        }

        private void editEmployeeButton_Click(object sender, EventArgs e)
        {
            if (fullNameEmployee.Text != "" && login.Text != "" && numberPhone.Text != "" && role.SelectedIndex != -1)
            {
                editEmployee();
            Employees sotrydnik = new Employees();
            sotrydnik.Show();
            this.Close();
        }
            else MessageBox.Show("Заполните все поля!");
        }

        private void HidePassword_Click(object sender, EventArgs e)
        {
            if (password.PasswordChar == '\0') password.PasswordChar = '*';
            else password.PasswordChar = '\0';
        }
        public void editEmployee()
        {
            if (password.Text != "" && confirmPassword.Text != "")
            {
                if (passwordLast == Verification.GetSHA512Hash(confirmPassword.Text))
                {
                    try
                    {
                        int count = db.pc_UpdateEmployeeWithPassword(idEmployee,fullNameEmployee.Text,birthday.Value,login.Text,Verification.GetSHA512Hash(password.Text),numberPhone.Text,role.SelectedIndex+2);
                        if (count >= 1) { MessageBox.Show("Изменение прошло успешно!"); }
                        else { MessageBox.Show("Изменение прошло безуспешно!"); }
                    }
                    catch (Exception ex) { MessageBox.Show($"{ex}"); }
                }
                else { MessageBox.Show("Подтверждение старого пароля не совпадает, попробуйте ещё раз"); }
            }
            else
            {
                try
                {
                    int count = db.pc_UpdateEmployeeWithoutPassword(idEmployee, fullNameEmployee.Text, birthday.Value, login.Text, numberPhone.Text, db.Roles.Where(r => r.RoleName == role.Text).FirstOrDefault().RoleId);
                    if (count >= 1) { MessageBox.Show("Изменение прошло успешно!"); }
                    else { MessageBox.Show("Изменение прошло безуспешно!"); }
                }
                catch (Exception ex) { MessageBox.Show($"{ex}"); }
            }
        }
        public void addEmployee()
        {
            try
            {
                int count = db.pc_RegistrationEmployee(fullNameEmployee.Text,birthday.Value,login.Text,Verification.GetSHA512Hash(password.Text),numberPhone.Text, db.Roles.Where(r => r.RoleName == role.Text).FirstOrDefault().RoleId);
                if (count >= 1) { MessageBox.Show("Регистрация прошла успешно!"); }
                else { MessageBox.Show("Регистрация прошла безуспешно!"); }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
        void LoadRoles()
        {
            if (UserAuthorization.Role == 1) { }
            if (UserAuthorization.Role == 2) { }
            if (UserAuthorization.Role == 3) { }
            if (UserAuthorization.Role == 4) 
            {
                role.Items.Add("Менеджер");
                role.Items.Add("Старший менеджер");
            }
        }

        private void infoPasswordButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Если вы хотите изменить пароль, то введите Пароль и Подтверждение старого пароля.\n" +
                "Если вы не хотите менять пароль, то оставьте оба поля пустыми");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Employees sotrydnik = new Employees();
            sotrydnik.Show();
            this.Close();
        }

        private void fullNameEmployee_TextChanged(object sender, EventArgs e)
        {
            if (fullNameEmployee.TextLength > 50) { MessageBox.Show("Длина ФИО сотрудника не может быть больше 50 символов"); fullNameEmployee.Text = fullNameEmployee.Text.Substring(0, 50); }
        }

        private void login_TextChanged(object sender, EventArgs e)
        {
            if (login.TextLength > 50) { MessageBox.Show("Длина логина не может быть больше 50 символов"); login.Text = login.Text.Substring(0, 50); }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            if (password.TextLength > 256) { MessageBox.Show("Длина пароля не может быть больше 256 символов"); password.Text = password.Text.Substring(0, 256); }
        }

        private void confirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (confirmPassword.TextLength > 256) { MessageBox.Show("Длина подтверждения пароля не может быть больше 256 символов"); confirmPassword.Text = confirmPassword.Text.Substring(0, 256); }
        }

        private void numberPhone_TextChanged(object sender, EventArgs e)
        {
            if (numberPhone.TextLength > 12) { MessageBox.Show("Длина номера телефона не может быть больше 12 символов"); numberPhone.Text = numberPhone.Text.Substring(0, 12); }
        }

        private void numberPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        public void LoadEmployee()
        {
            try
            {
                var EmployeeInfo = db.fc_OutputOneEmployee(idEmployee).ToList().FirstOrDefault();
                if(EmployeeInfo != null)
                {
                    fullNameEmployee.Text = EmployeeInfo.UserFullName;
                    birthday.Value = EmployeeInfo.UserBirthday;
                    login.Text = EmployeeInfo.UserLogin;
                    numberPhone.Text = EmployeeInfo.UserPhone;
                    role.SelectedIndex = EmployeeInfo.RoleId - 2;
                    passwordLast = EmployeeInfo.UserPassword;
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
    }
}
