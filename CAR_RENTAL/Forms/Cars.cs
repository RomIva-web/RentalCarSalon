using CAR_RENTAL.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAR_RENTAL.Forms
{
    public partial class Cars : Form
    {
        CarRentalSalonEntities db = new CarRentalSalonEntities();
        public Cars()
        {
            InitializeComponent();
        }
        private void TimeNow_Tick(object sender, EventArgs e)
        {
            TimeNow.Interval = 1000;
            TimeText.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }
        void LoadCarWithSort()
        {
            try
            {
                    var CarInfo = db.pc_OutputCarWithSort(brandSearch.Text,modelSearch.Text, sortType.SelectedIndex + 1, countrySearch.SelectedIndex + 1,  countrySearch.Text).ToList();
                    if (CarInfo != null)
                    {
                        foreach (var car in CarInfo)
                        {
                            CarBD.Rows.Add(car.CatalogCarId, car.CatalogCarBrand, car.CatalogCarModel, car.CountryCarName, car.ClassCarName, car.StatusCatalogCarName, car.CatalogCarMileage, car.CatalogCarPricePerDay);
                        }
                    }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }

        void LoadCountry()
        {
            try
            {
                var CountryInfo = db.fc_OutputCountry().ToList();
                if(CountryInfo != null)
                {
                    foreach(var country in CountryInfo)
                    {
                        countrySearch.Items.Add(country.CountryCarName);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
        private void Cars_Load(object sender, EventArgs e)
        {
            if (UserAuthorization.Role == 1) { CarBD.Visible = false; brandSearch.Visible = false; modelSearch.Visible = false; sortType.Visible = false; countrySearch.Visible = false; }
            if (UserAuthorization.Role == 2) { }
            if (UserAuthorization.Role == 3) { addCarButton.Visible = true; editCarButton.Visible = true; delCarButton.Visible = true; }
            if (UserAuthorization.Role == 4) { addCarButton.Visible = true; editCarButton.Visible = true; delCarButton.Visible = true; }
            sortType.Items.Add("Без сортировки");
            sortType.Items.Add("По убыванию пробега");
            sortType.Items.Add("По возрастанию пробега");
            sortType.Items.Add("По убыванию цены");
            sortType.Items.Add("По возрастанию цены");
            countrySearch.Items.Add("Без поиска");
            sortType.SelectedIndex = 0;
            countrySearch.SelectedIndex = 0;
        }

        private void editCarButton_Click(object sender, EventArgs e)
        {
            AddAndEditCar addAndEditCar = new AddAndEditCar((int)CarBD.Rows[CarBD.CurrentRow.Index].Cells[0].Value);
            addAndEditCar.Show();
            this.Close();
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            AddAndEditCar addAndEditCar = new AddAndEditCar();
            addAndEditCar.Show();
            this.Close();
        }

        private void delCarButton_Click(object sender, EventArgs e)
        {
            if (CarBD.CurrentRow.Index >= 0)
            {
                DialogResult dialogResult = MessageBox.Show($"Вы уверены, что хотите удалить {CarBD.Rows[CarBD.CurrentRow.Index].Cells[1].Value} {CarBD.Rows[CarBD.CurrentRow.Index].Cells[2].Value}", "Предупреждение!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        int count = db.pc_DeleteCar(Convert.ToInt32(CarBD.Rows[CarBD.CurrentRow.Index].Cells[0].Value));
                        if (count >= 1) { MessageBox.Show("Удаление прошло успешно!"); try { File.Delete($@"..\..\Images\ImageCar\{CarBD.Rows[CarBD.CurrentRow.Index].Cells[1].Value} {CarBD.Rows[CarBD.CurrentRow.Index].Cells[2].Value} {CarBD.Rows[CarBD.CurrentRow.Index].Cells[0].Value}.png"); CarBD.Rows.Clear(); LoadCarWithSort(); } catch { } }
                        else { MessageBox.Show("Удаление прошло безуспешно!"); }
                    }
                    catch (Exception ex) { MessageBox.Show($"{ex}"); }
                }
            }
            else MessageBox.Show("Чтобы удалить клиента, нужно выделить нужную вам строку и затем нажать на эту же кнопку");
        }

        private void sortType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (countrySearch.SelectedIndex == -1) { countrySearch.SelectedIndex = 0; LoadCountry(); }
            CarBD.Rows.Clear();
            LoadCarWithSort();
        }

        private void brandSearch_TextChanged(object sender, EventArgs e)
        {
            CarBD.Rows.Clear();
            LoadCarWithSort();
        }

        private void modelSearch_TextChanged(object sender, EventArgs e)
        {
            CarBD.Rows.Clear();
            LoadCarWithSort();
        }

        private void countrySearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarBD.Rows.Clear();
            LoadCarWithSort();
        }

        private void backMenuButton_Click(object sender, EventArgs e)
        {
            MenuForEmployee menuForEmployee = new MenuForEmployee();
            menuForEmployee.Show();
            this.Close();
        }

        private void brandSearch_Leave(object sender, EventArgs e)
        {
            if(brandSearch.Text == "") infoSearch1.Visible = true;  
        }

        private void infoSearch1_Click(object sender, EventArgs e)
        {
            infoSearch1.Visible = false;
            brandSearch.Focus();
        }

        private void infoSearch2_Click(object sender, EventArgs e)
        {
            infoSearch2.Visible = false;
            modelSearch.Focus();
        }

        private void modelSearch_Leave(object sender, EventArgs e)
        {
            if(modelSearch.Text == "") infoSearch2.Visible = true;
        }

        private void brandSearch_Enter(object sender, EventArgs e)
        {
            infoSearch1.Visible = false;
        }

        private void modelSearch_Enter(object sender, EventArgs e)
        {
            infoSearch2.Visible = false;
        }
    }
}
