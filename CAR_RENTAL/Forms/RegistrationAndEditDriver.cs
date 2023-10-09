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
    public partial class RegistrationAndEditDriver : Form
    {
        int idDriver;
        CarRentalSalonEntities db = new CarRentalSalonEntities();
        public RegistrationAndEditDriver( int id)
        {
            InitializeComponent();
            idDriver = id;
            addDriverButton.Visible = false;
            editDriverButton.Visible = true;
            LoadDriver();
            Text1.Text = "Изменение данных водителя";
        }
        public RegistrationAndEditDriver()
        {
            InitializeComponent();
            addDriverButton.Visible = true;
            editDriverButton.Visible = false;
            Text1.Text = "Регистрация водителя";
        }

        private void TimeNow_Tick(object sender, EventArgs e)
        {
            TimeNow.Interval = 1000;
            TimeText.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }

        private void addDriverButton_Click(object sender, EventArgs e)
        {
            if (fullNameDriver.Text != "" && pricePerDay.Text != "")
            {
                if (workEnd.Value > workStart.Value)
                {
                    addDriver();
                    Drivers drivers = new Drivers();
                    drivers.Show();
                    this.Close();
                }
                else MessageBox.Show("Водитель не может работать больше 24 часов");
            }
            else MessageBox.Show("Заполните все поля!");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Drivers drivers = new Drivers();
            drivers.Show();
            this.Close();
        }

        private void editDriverButton_Click(object sender, EventArgs e)
        {
            if (fullNameDriver.Text != "" && pricePerDay.Text != "")
            {
                if (workEnd.Value > workStart.Value)
                {
                    editDriver();
                    Drivers drivers = new Drivers();
                    drivers.Show();
                    this.Close();
                }
                else MessageBox.Show("Водитель не может работать больше 24 часов");
            }
            else MessageBox.Show("Заполните все поля!");
        }
        public void LoadDriver()
        {
            try
            {
                var DriverInfo = db.fc_OutputOneDrivers(idDriver).ToList().FirstOrDefault();
                if (DriverInfo != null)
                {
                    fullNameDriver.Text = DriverInfo.DriverFullName;
                    driverLicense.Text = DriverInfo.DriverDriverLicenseNumber.ToString();
                    pricePerDay.Text = DriverInfo.DriverPricePerDay.ToString();
                    workStart.Value = workStart.Value.AddTicks(DriverInfo.DriverWorkBegin.Ticks);
                    workEnd.Value = workEnd.Value.AddTicks(DriverInfo.DriverWorkEnd.Ticks);
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
        public void editDriver()
        {
            try
            {
                int count = db.pc_UpdateDriver(fullNameDriver.Text, Convert.ToDecimal(driverLicense.Text), Convert.ToInt32(pricePerDay.Text), idDriver, workStart.Value.TimeOfDay, workEnd.Value.TimeOfDay);
                if (count >= 1) { MessageBox.Show("Изменение прошло успешно!"); }
                else { MessageBox.Show("Изменение прошло безуспешно!"); }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }

        private void fullNameDriver_TextChanged(object sender, EventArgs e)
        {
            if (fullNameDriver.TextLength > 50) { MessageBox.Show("Длина ФИО водителя не может быть больше 50 символов"); fullNameDriver.Text = fullNameDriver.Text.Substring(0, 50); }
        }

        private void driverLicense_TextChanged(object sender, EventArgs e)
        {
            if (driverLicense.TextLength > 10) { MessageBox.Show("Длина номера водительского удостоверения не может быть больше 10 символов"); driverLicense.Text = driverLicense.Text.Substring(0, 10); }
        }

        private void driverLicense_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void pricePerDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        public void addDriver()
        {
            try
            {
                int count = db.pc_RegistationDriver(fullNameDriver.Text, Convert.ToDecimal(driverLicense.Text), Convert.ToInt32(pricePerDay.Text), workStart.Value.TimeOfDay, workEnd.Value.TimeOfDay);
                if (count >= 1) { MessageBox.Show("Регистрация прошла успешно!"); }
                else { MessageBox.Show("Регистрация прошла безуспешно!"); }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
    }
}
