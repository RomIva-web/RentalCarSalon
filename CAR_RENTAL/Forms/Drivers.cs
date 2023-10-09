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
    public partial class Drivers : Form
    {
        int sort = 1;
        CarRentalSalonEntities db = new CarRentalSalonEntities();
        public Drivers()
        {
            InitializeComponent();
        }

        private void TimeNow_Tick(object sender, EventArgs e)
        {
            TimeNow.Interval = 1000;
            TimeText.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }

        private void sortType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sortType.SelectedItem.ToString() == "Без сортировки цены в день") { sort = 1; }
            if (sortType.SelectedItem.ToString() == "По убыванию цены в день") { sort = 2; }
            if (sortType.SelectedItem.ToString() == "По возрастанию цены в день") { sort = 3; }
            DriverBD.Rows.Clear();
            LoadDriver();
        }

        private void Drivers_Load(object sender, EventArgs e)
        {
            if (UserAuthorization.Role == 1) { DriverBD.Visible = false; driverFullName.Visible = false; sortType.Visible = false; }
            if (UserAuthorization.Role == 2) { }
            if (UserAuthorization.Role == 3) { addDriverButton.Visible = true; editDriverButton.Visible = true; delDriverButton.Visible = true; }
            if (UserAuthorization.Role == 4) { addDriverButton.Visible = true; editDriverButton.Visible = true; delDriverButton.Visible = true; }
            sortType.Items.Add("Без сортировки цены в день");
            sortType.Items.Add("По убыванию цены в день");
            sortType.Items.Add("По возрастанию цены в день");
            sortType.SelectedIndex = 0;

        }

        public void LoadDriver()
        {
            try
            {
                var DriverInfo = db.pc_OutputDrivers(driverFullName.Text, sort, DateTime.Today.Date).ToList();
                if(DriverInfo != null)
                {
                    foreach (var driver in DriverInfo)
                    {
                        string status;
                        if (driver.Status == null) status = "Свободен";
                        else status = driver.Status;
                        DriverBD.Rows.Add(driver.DriverId,driver.DriverFullName,driver.DriverDriverLicenseNumber,driver.DriverPricePerDay,driver.DriverWorkBegin,driver.DriverWorkEnd,status);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
        private void driverFullName_TextChanged(object sender, EventArgs e)
        {
            DriverBD.Rows.Clear();
            LoadDriver();
        }

        private void editDriverButton_Click(object sender, EventArgs e)
        {
            RegistrationAndEditDriver registrationAndEditVoditel = new RegistrationAndEditDriver( Convert.ToInt32(DriverBD.Rows[DriverBD.CurrentRow.Index].Cells[0].Value));
            registrationAndEditVoditel.Show();
            this.Close();
        }

        private void addDriverButton_Click(object sender, EventArgs e)
        {
            RegistrationAndEditDriver registrationAndEditVoditel = new RegistrationAndEditDriver();
            registrationAndEditVoditel.Show();
            this.Close();
        }

        private void delDriverButton_Click(object sender, EventArgs e)
        {
            if (DriverBD.CurrentRow.Index >= 0)
            {
                DialogResult dialogResult = MessageBox.Show($"Вы уверены, что хотите уволить {DriverBD.Rows[DriverBD.CurrentRow.Index].Cells[1].Value}", "Предупреждение!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        int count = db.pc_DeleteDrivers(Convert.ToInt32(DriverBD.Rows[DriverBD.CurrentRow.Index].Cells[0].Value));
                        if (count >= 1) { MessageBox.Show("Увольнение прошло успешно!"); DriverBD.Rows.Clear(); LoadDriver();}
                        else { MessageBox.Show("Увольнение прошло безуспешно!"); }
                    }
                    catch (Exception ex) { MessageBox.Show($"{ex}"); }
                }
            }
            else MessageBox.Show("Чтобы уволить водителя, нужно выделить нужную вам строку и затем нажать на эту же кнопку");
        }

        private void BackMenu_Click(object sender, EventArgs e)
        {
            MenuForEmployee menuForEmployee = new MenuForEmployee();
            menuForEmployee.Show();
            this.Close();
        }

        private void driverFullName_Leave(object sender, EventArgs e)
        {
            if(driverFullName.Text == "") infoSearch1.Visible = true;
        }

        private void infoSearch1_Click(object sender, EventArgs e)
        {
            infoSearch1.Visible = false;
            driverFullName.Focus();
        }

        private void driverFullName_Enter(object sender, EventArgs e)
        {
            infoSearch1.Visible = false;
        }

        private void reportStart_ValueChanged(object sender, EventArgs e)
        {
            int Days = (reportEnd.Value - reportStart.Value).Days;
            if (Days < 0) { reportEnd.Value = reportStart.Value; MessageBox.Show("Дата начала периода не должна быть позже конца периода.\nВремя скорректировано!"); }
        }

        private void reportEnd_ValueChanged(object sender, EventArgs e)
        {
            int Days = (reportEnd.Value - reportStart.Value).Days;
            if (Days < 0) { reportStart.Value = reportEnd.Value; MessageBox.Show("Дата конца периода не должна быть раньше начала периода.\nВремя скорректировано!"); }
        }

        private void printReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (DriverBD.CurrentRow.Index != -1)
                {
                    int fullPriceRentalCar = 0, fullPriceSalaryOfHours = 0, fullPriceSalary = 0 ;
                    string[] amountHoursAndMinute;
                    var DataDriverWorkOfPeriod = db.fc_OutputDriverWorkOfPeriodForPrint(Convert.ToInt32(DriverBD.Rows[DriverBD.CurrentRow.Index].Cells[0].Value), reportStart.Value, reportEnd.Value).ToList();
                    if (DataDriverWorkOfPeriod.Count >= 1)
                    {
                        amountHoursAndMinute = new string[DataDriverWorkOfPeriod.Count];
                        int count = 0;
                        foreach (var data in DataDriverWorkOfPeriod)
                        {
                            fullPriceRentalCar += Convert.ToInt32(data.FullPriceRentalCar);
                            fullPriceSalaryOfHours += GetSalaryOnHoursAndMinute(Convert.ToInt32(data.DaysWork), DriverBD.Rows[DriverBD.CurrentRow.Index].Cells[4].Value.ToString(), DriverBD.Rows[DriverBD.CurrentRow.Index].Cells[5].Value.ToString());
                            amountHoursAndMinute[count] = GetHoursAndMinute(Convert.ToInt32(data.DaysWork), DriverBD.Rows[DriverBD.CurrentRow.Index].Cells[4].Value.ToString(), DriverBD.Rows[DriverBD.CurrentRow.Index].Cells[5].Value.ToString());
                            count++;
                        }
                        fullPriceSalary = fullPriceRentalCar + fullPriceSalaryOfHours;
                        var helper = new WordsHelper("../../Reports/ReportDriverTemplate.doc");
                        var items = new Dictionary<string, string>
                                {
                                    { "<PERIODSTART>", reportStart.Value.ToShortDateString()},
                                    { "<PERIODEND>", reportEnd.Value.ToShortDateString()},
                                    { "<NUMDRIVER>", DriverBD.Rows[DriverBD.CurrentRow.Index].Cells[0].Value.ToString()},
                                    { "<FULLNAMEDRIVER>", DriverBD.Rows[DriverBD.CurrentRow.Index].Cells[1].Value.ToString()},
                                    { "<WORKSTART>", DriverBD.Rows[DriverBD.CurrentRow.Index].Cells[4].Value.ToString()},
                                    { "<WORKEND>", DriverBD.Rows[DriverBD.CurrentRow.Index].Cells[5].Value.ToString()},
                                    { "<ITOGRENTALCARS>", fullPriceRentalCar.ToString()},
                                    { "<ITOGSALARYOFHOURS>", fullPriceSalaryOfHours.ToString()},
                                    { "<ITOGSALARY>", fullPriceSalary.ToString()}
                                };
                        helper.ProcessReportDriverOfPeriod(items, DataDriverWorkOfPeriod, amountHoursAndMinute, DriverBD.Rows[DriverBD.CurrentRow.Index].Cells[3].Value.ToString(), DriverBD.Rows[DriverBD.CurrentRow.Index].Cells[0].Value.ToString(), DriverBD.Rows[DriverBD.CurrentRow.Index].Cells[1].Value.ToString(),reportStart.Value.ToShortDateString(), reportEnd.Value.ToShortDateString());
                        MessageBox.Show("Готово");
                    }
                    else MessageBox.Show("У данного водителя нет заказов в данный период!");
                }
                else MessageBox.Show("Выберите водителя!");
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        int GetSalaryOnHoursAndMinute(int days, string Start, string End)
        {
            string[] splitStart = Start.Split(':');
            string[] splitEnd = End.Split(':');
            int hour = Convert.ToInt32(splitEnd[0]) - Convert.ToInt32(splitStart[0]);
            int minute = Convert.ToInt32(splitEnd[1]) - Convert.ToInt32(splitStart[1]);
            if(minute < 0) { hour--;minute += 60; }
            hour = hour * days;
            minute = minute * days;
            hour = Convert.ToInt32(Math.Floor(Convert.ToDecimal(minute/60))) + hour;
            minute = minute - (Convert.ToInt32(Math.Floor(Convert.ToDecimal(minute / 60))) * 60);
            return ((hour * 60) + minute) * 6;
        }
        string GetHoursAndMinute(int days, string Start, string End)
        {
            string[] splitStart = Start.Split(':');
            string[] splitEnd = End.Split(':');
            int hour = Convert.ToInt32(splitEnd[0]) - Convert.ToInt32(splitStart[0]);
            int minute = Convert.ToInt32(splitEnd[1]) - Convert.ToInt32(splitStart[1]);
            if (minute < 0) { hour--; minute += 60; }
            hour = hour * days;
            minute = minute * days;
            hour = Convert.ToInt32(Math.Floor(Convert.ToDecimal(minute / 60))) + hour;
            minute = minute - (Convert.ToInt32(Math.Floor(Convert.ToDecimal(minute / 60))) * 60);
            if (hour == 0) return $"{minute} мин.";
            else return $"{hour} ч. {minute} мин.";
        }
    }
}
