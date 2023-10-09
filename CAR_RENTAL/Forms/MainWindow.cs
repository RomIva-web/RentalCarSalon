using CAR_RENTAL.Classes;
using CAR_RENTAL.Forms;
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

namespace CAR_RENTAL
{
    public partial class MainWindow : Form
    {
        int PasswordTry = 0;
        CarRentalSalonEntities db = new CarRentalSalonEntities();
        public MainWindow()
        {
            InitializeComponent();
            UserAuthorization.UserExit();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TimeNow_Tick(object sender, EventArgs e)
        {
            TimeNow.Interval = 1000;
            TimeText.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }

        private void BanPassword_Tick(object sender, EventArgs e)
        {
            BanPassword.Enabled = false;
            MessageBox.Show("Теперь вы можете снова авторизироваться!");
            logInButton.Enabled = true;
        }

        void CheckTry() 
        {
            if (PasswordTry >= 5)
            {
                logInButton.Enabled = false;
                MessageBox.Show("Превышено число попыток авторизации! Подождите 40 секунд!");
                BanPassword.Interval = 10000;
                BanPassword.Enabled = true;
                PasswordTry = 0;
            }
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (login.Text == "" && password.Text == "")
                {
                    MessageBox.Show("Введите данные"); return;
                }
                if (login.Text != "")
                {
                    if (password.Text != "")
                    {
                        var UserInfo = db.fc_OutputLoginPassword(login.Text).ToList().FirstOrDefault();
                        if (UserInfo != null)
                        {
                            if (Verification.VerifySHA512Hash(password.Text, UserInfo.UserPassword))
                            {
                                if (UserInfo.RoleId > 1 && UserInfo.RoleId <= 4)
                                {
                                    UserAuthorization.Role = UserInfo.RoleId;
                                    UserAuthorization.Name = UserInfo.UserFullName;
                                    UserAuthorization.Id = UserInfo.UserId;
                                    MenuForEmployee menuForSotrydnik = new MenuForEmployee();
                                    menuForSotrydnik.Show();
                                    this.Hide();
                                }
                                else MessageBox.Show("Ошибка роли");
                            }
                            else
                            {
                                MessageBox.Show("Неверный пароль");
                                password.Text = "";
                                PasswordTry++;
                                CheckTry();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Нет такого пользователя");
                            this.login.Text = "";
                            password.Text = "";
                        }
                    }
                    else MessageBox.Show("Введите пароль!");
                }
                else MessageBox.Show("Введите логин!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return; }
        }

        private void HidePassword_Click(object sender, EventArgs e)
        {
            if (password.PasswordChar == '\0') password.PasswordChar = '*';
            else password.PasswordChar = '\0';
        }

        private void CatalogCarButton_Click(object sender, EventArgs e)
        {
            Catalog catalog = new Catalog();
            catalog.Show();
            this.Hide();
        }

        private void FashionButton_Click(object sender, EventArgs e)
        {
            Fashion fashoin = new Fashion();
            fashoin.Show();
            this.Hide();
        }

        private void login_TextChanged(object sender, EventArgs e)
        {
            if (login.TextLength > 50) { MessageBox.Show("Длина логина не может быть больше 50 символов"); login.Text = login.Text.Substring(0, 50); }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            if (password.TextLength > 256) { MessageBox.Show("Длина пароля не может быть больше 256 символов"); password.Text = password.Text.Substring(0, 256); }
        }
    }
}
