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
    public partial class Catalog : Form
    {
        int fieldSort = 1,typeSort = 1,fieldSearch = -1;
        CarRentalSalonEntities db = new CarRentalSalonEntities();
        public Catalog()
        {
            InitializeComponent();
        }

        private void TimeNow_Tick(object sender, EventArgs e)
        {
            TimeNow.Interval = 1000;
            TimeText.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }

        private void CatalogCar_Load(object sender, EventArgs e)
        {
            sortType.Items.Add("Без сортировки");
            sortType.Items.Add("По убыванию");
            sortType.Items.Add("По возрастанию");
            sortField.Items.Add("Пробег");
            sortField.Items.Add("Цена в день");
            searchField.Items.Add("Марка");
            searchField.Items.Add("Модель");
            searchField.Items.Add("Страна");
            searchField.Items.Add("Класс");
            searchField.Items.Add("Статус");
            LoadCatalogWithSort();
            Brand1.Text = CatalogBD.Rows[0].Cells[1].Value.ToString();
            Brand2.Text = CatalogBD.Rows[1].Cells[1].Value.ToString();
            Brand3.Text = CatalogBD.Rows[2].Cells[1].Value.ToString();
            Model1.Text = CatalogBD.Rows[0].Cells[2].Value.ToString();
            Model2.Text = CatalogBD.Rows[1].Cells[2].Value.ToString();
            Model3.Text = CatalogBD.Rows[2].Cells[2].Value.ToString();
            Country1.Text = CatalogBD.Rows[0].Cells[3].Value.ToString();
            Country2.Text = CatalogBD.Rows[1].Cells[3].Value.ToString();
            Country3.Text = CatalogBD.Rows[2].Cells[3].Value.ToString();
            Mileage1.Text = CatalogBD.Rows[0].Cells[4].Value.ToString();
            Mileage2.Text = CatalogBD.Rows[1].Cells[4].Value.ToString();
            Mileage3.Text = CatalogBD.Rows[2].Cells[4].Value.ToString();
            Class1.Text = CatalogBD.Rows[0].Cells[5].Value.ToString();
            Class2.Text = CatalogBD.Rows[1].Cells[5].Value.ToString();
            Class3.Text = CatalogBD.Rows[2].Cells[5].Value.ToString();
            PricePerDay1.Text = CatalogBD.Rows[0].Cells[6].Value.ToString();
            PricePerDay2.Text = CatalogBD.Rows[1].Cells[6].Value.ToString();
            PricePerDay3.Text = CatalogBD.Rows[2].Cells[6].Value.ToString();
            try { PictureCar1.Image = null; PictureCar1.Image = new Bitmap($"../../Images/ImageCar/{CatalogBD.Rows[0].Cells[7].Value.ToString()}.png"); }
            catch { PictureCar1.Image = null; PictureCar1.Image = new Bitmap($"../../Images/ImageCar/.png"); }
            try { PictureCar2.Image = null; PictureCar2.Image = new Bitmap($"../../Images/ImageCar/{CatalogBD.Rows[1].Cells[7].Value.ToString()}.png"); }
            catch { PictureCar2.Image = null; PictureCar2.Image = new Bitmap($"../../Images/ImageCar/.png"); }
            try { PictureCar3.Image = null; PictureCar3.Image = new Bitmap($"../../Images/ImageCar/{CatalogBD.Rows[2].Cells[7].Value.ToString()}.png"); }
            catch { PictureCar3.Image = null; PictureCar3.Image = new Bitmap($"../../Images/ImageCar/.png"); }
            Status1.Text = CatalogBD.Rows[0].Cells[8].Value.ToString();
            Status2.Text = CatalogBD.Rows[1].Cells[8].Value.ToString();
            Status3.Text = CatalogBD.Rows[2].Cells[8].Value.ToString();
            endPage.Text = (CatalogBD.Rows.Count - 1).ToString();
        }
        private void BackMainMenu_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void searchField_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchType.SelectedIndex = -1;
            searchType.Items.Clear();
            if(searchField.SelectedIndex == 0) { LoadBrand(); }
            if (searchField.SelectedIndex == 1) { LoadModel(); }
            if (searchField.SelectedIndex == 2) { LoadCountry(); }
            if (searchField.SelectedIndex == 3) { LoadClass(); }
            if (searchField.SelectedIndex == 4) { LoadStatus(); }
        }
        void LoadBrand()
        {
            try
            {
                var BrandInfo = db.fc_OutputBrand().ToList();
                if(BrandInfo != null)
                {
                    foreach(var brand in BrandInfo)
                    {
                        searchType.Items.Add(brand.CatalogCarBrand);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
        void LoadModel()
        {
            try
            {
                var ModelInfo = db.fc_OutputModel().ToList();
                if (ModelInfo != null)
                {
                    foreach (var model in ModelInfo)
                    {
                        searchType.Items.Add(model.CatalogCarModel);
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
                        searchType.Items.Add(country.CountryCarName);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
        void LoadClass()
        {
            try
            {
                var ClassInfo = db.fc_OutputClass().ToList();
                if(ClassInfo != null)
                {
                    foreach(var classs in ClassInfo)
                    {
                        searchType.Items.Add(classs.ClassCarName);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
        void LoadStatus()
        {
            searchType.Items.Add("Заказана");
            searchType.Items.Add("Свободна");
        }
        void LoadCatalogWithSort()
        {
            try
            {
                var CarInfo = db.pc_OutputCatalogWithSort(fieldSort, typeSort);
                if (CarInfo != null)
                {
                    foreach (var car in CarInfo)
                    {
                        CatalogBD.Rows.Add(car.CatalogCarId, car.CatalogCarBrand, car.CatalogCarModel, car.CountryCarName, car.CatalogCarMileage, car.ClassCarName, car.CatalogCarPricePerDay, car.CatalogCarImageName, car.Status);
                    }
                }
                else
                {
                    Car1.Visible = false;
                    Car2.Visible = false;
                    Car3.Visible = false;
                    Text2.Visible = false;
                    startPage.Visible = false;
                    endPage.Visible = false;
                    noFoundCar.Visible = true;
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
        void LoadCatalogWithSortAndBrand()
        {
            try
            {
                var CarInfo = db.pc_OutputCatalogWithSortAndBrand(fieldSort, typeSort, searchType.Text).ToList();
                if(CarInfo != null)
                {
                    foreach(var car in CarInfo)
                    {
                        CatalogBD.Rows.Add(car.CatalogCarId, car.CatalogCarBrand, car.CatalogCarModel, car.CountryCarName, car.CatalogCarMileage, car.ClassCarName, car.CatalogCarPricePerDay, car.CatalogCarImageName, car.Status);
                    }
                }
                else
                {
                    Car1.Visible = false;
                    Car2.Visible = false;
                    Car3.Visible = false;
                    Text2.Visible = false;
                    startPage.Visible = false;
                    endPage.Visible = false;
                    noFoundCar.Visible = true;
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
        void LoadCatalogWithSortAndModel()
        {
            try
            {
                var CarInfo = db.pc_OutputCatalogWithSortAndModel(fieldSort, typeSort, searchType.Text).ToList();
                if (CarInfo != null)
                {
                    foreach (var car in CarInfo)
                    {
                        CatalogBD.Rows.Add(car.CatalogCarId, car.CatalogCarBrand, car.CatalogCarModel, car.CountryCarName, car.CatalogCarMileage, car.ClassCarName, car.CatalogCarPricePerDay, car.CatalogCarImageName, car.Status);
                    }
                }
                else
                {
                    Car1.Visible = false;
                    Car2.Visible = false;
                    Car3.Visible = false;
                    Text2.Visible = false;
                    startPage.Visible = false;
                    endPage.Visible = false;
                    noFoundCar.Visible = true;
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
        void LoadCatalogWithSortAndCountry()
        {
            try
            {
                var CarInfo = db.pc_OutputCatalogWithSortAndCountry(fieldSort, typeSort, searchType.Text).ToList();
                if (CarInfo != null)
                {
                    foreach (var car in CarInfo)
                    {
                        CatalogBD.Rows.Add(car.CatalogCarId, car.CatalogCarBrand, car.CatalogCarModel, car.CountryCarName, car.CatalogCarMileage, car.ClassCarName, car.CatalogCarPricePerDay, car.CatalogCarImageName, car.Status);
                    }
                }
                else
                {
                    Car1.Visible = false;
                    Car2.Visible = false;
                    Car3.Visible = false;
                    Text2.Visible = false;
                    startPage.Visible = false;
                    endPage.Visible = false;
                    noFoundCar.Visible = true;
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
        void LoadCatalogWithSortAndClass()
        {
            try
            {
                var CarInfo = db.pc_OutputCatalogWithSortAndClass(fieldSort, typeSort, searchType.Text).ToList();
                if (CarInfo != null)
                {
                    foreach (var car in CarInfo)
                    {
                        CatalogBD.Rows.Add(car.CatalogCarId, car.CatalogCarBrand, car.CatalogCarModel, car.CountryCarName, car.CatalogCarMileage, car.ClassCarName, car.CatalogCarPricePerDay, car.CatalogCarImageName, car.Status);
                    }
                }
                else
                {
                    Car1.Visible = false;
                    Car2.Visible = false;
                    Car3.Visible = false;
                    Text2.Visible = false;
                    startPage.Visible = false;
                    endPage.Visible = false;
                    noFoundCar.Visible = true;
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
        void LoadCatalogWithSortAndStatus()
        {
            try
            {
                var CarInfo = db.pc_OutputCatalogWithSortAndStatus(fieldSort, typeSort, searchType.SelectedIndex).ToList();
                if (CarInfo != null)
                {
                    foreach (var car in CarInfo)
                    {
                        CatalogBD.Rows.Add(car.CatalogCarId, car.CatalogCarBrand, car.CatalogCarModel, car.CountryCarName, car.CatalogCarMileage, car.ClassCarName, car.CatalogCarPricePerDay, car.CatalogCarImageName, car.Status);
                    }
                }
                else
                {
                    Car1.Visible = false;
                    Car2.Visible = false;
                    Car3.Visible = false;
                    Text2.Visible = false;
                    startPage.Visible = false;
                    endPage.Visible = false;
                    noFoundCar.Visible = true;
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
        private void LeftArrow_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(startPage.Text)>3)
            {
                noFoundCar.Visible = false;
                Car1.Visible = true;
                Car2.Visible = true;
                Car3.Visible = true;
                Text2.Visible = true;
                startPage.Visible = true;
                endPage.Visible = true;
                Brand1.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 4].Cells[1].Value.ToString();
                Brand2.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 3].Cells[1].Value.ToString();
                Brand3.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 2].Cells[1].Value.ToString();
                Model1.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 4].Cells[2].Value.ToString();
                Model2.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 3].Cells[2].Value.ToString();
                Model3.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 2].Cells[2].Value.ToString();
                Country1.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 4].Cells[3].Value.ToString();
                Country2.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 3].Cells[3].Value.ToString();
                Country3.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 2].Cells[3].Value.ToString();
                Mileage1.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 4].Cells[4].Value.ToString();
                Mileage2.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 3].Cells[4].Value.ToString();
                Mileage3.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 2].Cells[4].Value.ToString();
                Class1.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 4].Cells[5].Value.ToString();
                Class2.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 3].Cells[5].Value.ToString();
                Class3.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 2].Cells[5].Value.ToString();
                PricePerDay1.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 4].Cells[6].Value.ToString();
                PricePerDay2.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 3].Cells[6].Value.ToString();
                PricePerDay3.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 2].Cells[6].Value.ToString();
                Status1.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 4].Cells[8].Value.ToString();
                Status2.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 3].Cells[8].Value.ToString();
                Status3.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 2].Cells[8].Value.ToString();
                try { PictureCar1.Image = null; PictureCar1.Image = new Bitmap($"../../Images/ImageCar/{CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 4].Cells[7].Value.ToString()}.png"); }
                catch { PictureCar1.Image = null; PictureCar1.Image = new Bitmap($"../../Images/ImageCar/.png"); }
                try { PictureCar2.Image = null; PictureCar2.Image = new Bitmap($"../../Images/ImageCar/{CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 3].Cells[7].Value.ToString()}.png"); }
                catch { PictureCar2.Image = null; PictureCar2.Image = new Bitmap($"../../Images/ImageCar/.png"); }
                try { PictureCar3.Image = null; PictureCar3.Image = new Bitmap($"../../Images/ImageCar/{CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 2].Cells[7].Value.ToString()}.png"); }
                catch { PictureCar3.Image = null; PictureCar3.Image = new Bitmap($"../../Images/ImageCar/.png"); }
                startPage.Text = (Convert.ToInt32(startPage.Text) - 1).ToString();
            }
        }

        private void RightArrow_Click(object sender, EventArgs e)
        {
            if (startPage.Text != endPage.Text)
            {
                noFoundCar.Visible = false;
                Car1.Visible = true;
                Car2.Visible = true;
                Car3.Visible = true;
                Text2.Visible = true;
                startPage.Visible = true;
                endPage.Visible = true;
                Brand1.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 2].Cells[1].Value.ToString();
                Brand2.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 1].Cells[1].Value.ToString();
                Brand3.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text)].Cells[1].Value.ToString();
                Model1.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 2].Cells[2].Value.ToString();
                Model2.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 1].Cells[2].Value.ToString();
                Model3.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text)].Cells[2].Value.ToString();
                Country1.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 2].Cells[3].Value.ToString();
                Country2.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 1].Cells[3].Value.ToString();
                Country3.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text)].Cells[3].Value.ToString();
                Mileage1.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 2].Cells[4].Value.ToString();
                Mileage2.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 1].Cells[4].Value.ToString();
                Mileage3.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text)].Cells[4].Value.ToString();
                Class1.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 2].Cells[5].Value.ToString();
                Class2.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 1].Cells[5].Value.ToString();
                Class3.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text)].Cells[5].Value.ToString();
                PricePerDay1.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 2].Cells[6].Value.ToString();
                PricePerDay2.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 1].Cells[6].Value.ToString();
                PricePerDay3.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text)].Cells[6].Value.ToString();
                Status1.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 2].Cells[8].Value.ToString();
                Status2.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 1].Cells[8].Value.ToString();
                Status3.Text = CatalogBD.Rows[Convert.ToInt32(startPage.Text)].Cells[8].Value.ToString();
                try { PictureCar1.Image = null; PictureCar1.Image = new Bitmap($"../../Images/ImageCar/{CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 2].Cells[7].Value.ToString()}.png"); }
                catch { PictureCar1.Image = null; PictureCar1.Image = new Bitmap($"../../Images/ImageCar/.png"); }
                try { PictureCar2.Image = null; PictureCar2.Image = new Bitmap($"../../Images/ImageCar/{CatalogBD.Rows[Convert.ToInt32(startPage.Text) - 1].Cells[7].Value.ToString()}.png"); }
                catch { PictureCar2.Image = null; PictureCar2.Image = new Bitmap($"../../Images/ImageCar/.png"); }
                try { PictureCar3.Image = null; PictureCar3.Image = new Bitmap($"../../Images/ImageCar/{CatalogBD.Rows[Convert.ToInt32(startPage.Text)].Cells[7].Value.ToString()}.png"); }
                catch { PictureCar3.Image = null; PictureCar3.Image = new Bitmap($"../../Images/ImageCar/.png"); }
                startPage.Text = (Convert.ToInt32(startPage.Text) + 1).ToString();
            }   
        }

        private void sortType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CatalogBD.Rows.Clear();
            if (searchField.SelectedIndex != -1 && searchType.SelectedIndex != -1 && ((sortType.SelectedIndex == -1 && sortField.SelectedIndex != -1) || (sortType.SelectedIndex != -1 && sortField.SelectedIndex == -1) || (sortType.SelectedIndex == -1 && sortField.SelectedIndex == -1))) { fieldSort = 1; typeSort = 1; fieldSearch = searchField.SelectedIndex + 1; SelectLoad(); return; }
            if (sortField.SelectedIndex != -1 && sortType.SelectedIndex != -1 && ((searchType.SelectedIndex == -1 && searchField.SelectedIndex != -1) || (searchType.SelectedIndex != -1 && searchField.SelectedIndex == -1) || ((searchType.SelectedIndex == -1 && searchField.SelectedIndex == -1)))) { fieldSort = sortField.SelectedIndex + 1; typeSort = sortType.SelectedIndex + 1; LoadCatalogWithSort(); CheckCountAndLoadCar(); return; }
            if (searchField.SelectedIndex != -1 && searchType.SelectedIndex != -1 && sortType.SelectedIndex != -1 && sortField.SelectedIndex != -1) { fieldSort = sortField.SelectedIndex + 1; typeSort = sortType.SelectedIndex + 1; fieldSearch = searchField.SelectedIndex + 1; SelectLoad(); return; }
            fieldSort = 1; typeSort = 1; LoadCatalogWithSort(); CheckCountAndLoadCar(); return;
        }

        private void sortField_SelectedIndexChanged(object sender, EventArgs e)
        {
            CatalogBD.Rows.Clear();
            if (searchField.SelectedIndex != -1 && searchType.SelectedIndex != -1 && ((sortType.SelectedIndex == -1 && sortField.SelectedIndex != -1) || (sortType.SelectedIndex != -1 && sortField.SelectedIndex == -1) || (sortType.SelectedIndex == -1 && sortField.SelectedIndex == -1))) { fieldSort = 1; typeSort = 1; fieldSearch = searchField.SelectedIndex + 1; SelectLoad(); return; }
            if (sortField.SelectedIndex != -1 && sortType.SelectedIndex != -1 && ((searchType.SelectedIndex == -1 && searchField.SelectedIndex != -1) || (searchType.SelectedIndex != -1 && searchField.SelectedIndex == -1) || ((searchType.SelectedIndex == -1 && searchField.SelectedIndex == -1)))) { fieldSort = sortField.SelectedIndex + 1; typeSort = sortType.SelectedIndex + 1; LoadCatalogWithSort(); CheckCountAndLoadCar(); return; }
            if (searchField.SelectedIndex != -1 && searchType.SelectedIndex != -1 && sortType.SelectedIndex != -1 && sortField.SelectedIndex != -1) { fieldSort = sortField.SelectedIndex + 1; typeSort = sortType.SelectedIndex + 1; fieldSearch = searchField.SelectedIndex + 1; SelectLoad(); return; }
            fieldSort = 1; typeSort = 1; LoadCatalogWithSort(); CheckCountAndLoadCar(); return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{CatalogBD.Rows.Count - 1}");
        }

        private void searchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CatalogBD.Rows.Clear();
            if (searchField.SelectedIndex != -1 && searchType.SelectedIndex != -1 && ((sortType.SelectedIndex == -1 && sortField.SelectedIndex != -1) || (sortType.SelectedIndex != -1 && sortField.SelectedIndex == -1) || (sortType.SelectedIndex == -1 && sortField.SelectedIndex == -1))) { fieldSort = 1; typeSort = 1; fieldSearch = searchField.SelectedIndex + 1; SelectLoad(); return; }
            if (sortField.SelectedIndex != -1 && sortType.SelectedIndex != -1 && ((searchType.SelectedIndex == -1 && searchField.SelectedIndex != -1) || (searchType.SelectedIndex != -1 && searchField.SelectedIndex == -1) || ((searchType.SelectedIndex == -1 && searchField.SelectedIndex == -1)))) { fieldSort = sortField.SelectedIndex + 1; typeSort = sortType.SelectedIndex + 1; LoadCatalogWithSort(); CheckCountAndLoadCar(); return; }
            if (searchField.SelectedIndex != -1 && searchType.SelectedIndex != -1 && sortType.SelectedIndex != -1 && sortField.SelectedIndex != -1) { fieldSort = sortField.SelectedIndex + 1; typeSort = sortType.SelectedIndex + 1; fieldSearch = searchField.SelectedIndex + 1; SelectLoad(); return; }
            fieldSort = 1; typeSort = 1; LoadCatalogWithSort(); CheckCountAndLoadCar(); return;
        }
        void SelectLoad()
        {
            if(fieldSearch == 1) { LoadCatalogWithSortAndBrand(); }
            if (fieldSearch == 2) { LoadCatalogWithSortAndModel(); }
            if (fieldSearch == 3) { LoadCatalogWithSortAndCountry(); }
            if (fieldSearch == 4) { LoadCatalogWithSortAndClass(); }
            if (fieldSearch == 5) { LoadCatalogWithSortAndStatus(); }
            CheckCountAndLoadCar();
        }
        void CheckCountAndLoadCar()
        {
            if (CatalogBD.Rows.Count - 1 == 1) { LoadOneCar(); }
            if (CatalogBD.Rows.Count - 1 == 2) { LoadTwoCar(); }
            if (CatalogBD.Rows.Count - 1 == 3) { LoadThreeCar(); }
            if (CatalogBD.Rows.Count - 1 > 3) { LoadMoreThreeCar(); }
            if (CatalogBD.Rows.Count - 1 <= 0) { LoadZeroCar(); }
        }
        void LoadOneCar()
        {
            noFoundCar.Visible = false;
            Car1.Visible = true;
            Car2.Visible = false;
            Car3.Visible = false;
            Text2.Visible = true;
            startPage.Visible = true;
            endPage.Visible = true;
            Brand1.Text = CatalogBD.Rows[0].Cells[1].Value.ToString();
            Model1.Text = CatalogBD.Rows[0].Cells[2].Value.ToString();
            Country1.Text = CatalogBD.Rows[0].Cells[3].Value.ToString();
            Mileage1.Text = CatalogBD.Rows[0].Cells[4].Value.ToString();
            Class1.Text = CatalogBD.Rows[0].Cells[5].Value.ToString();
            PricePerDay1.Text = CatalogBD.Rows[0].Cells[6].Value.ToString();
            Status1.Text = CatalogBD.Rows[0].Cells[8].Value.ToString();
            try { PictureCar1.Image = null; PictureCar1.Image = new Bitmap($"../../Images/ImageCar/{CatalogBD.Rows[0].Cells[7].Value.ToString()}.png"); }
            catch { PictureCar1.Image = null; PictureCar1.Image = new Bitmap($"../../Images/ImageCar/.png"); }
            startPage.Text = "1";
            endPage.Text = "1";
        }
        void LoadTwoCar()
        {
            noFoundCar.Visible = false;
            Car1.Visible = true;
            Car2.Visible = true;
            Car3.Visible = false;
            Text2.Visible = true;
            startPage.Visible = true;
            endPage.Visible = true;
            Brand1.Text = CatalogBD.Rows[0].Cells[1].Value.ToString();
            Model1.Text = CatalogBD.Rows[0].Cells[2].Value.ToString();
            Country1.Text = CatalogBD.Rows[0].Cells[3].Value.ToString();
            Mileage1.Text = CatalogBD.Rows[0].Cells[4].Value.ToString();
            Class1.Text = CatalogBD.Rows[0].Cells[5].Value.ToString();
            PricePerDay1.Text = CatalogBD.Rows[0].Cells[6].Value.ToString();
            Status1.Text = CatalogBD.Rows[0].Cells[8].Value.ToString();
            try { PictureCar1.Image = null; PictureCar1.Image = new Bitmap($"../../Images/ImageCar/{CatalogBD.Rows[0].Cells[7].Value.ToString()}.png"); }
            catch { PictureCar1.Image = null; PictureCar1.Image = new Bitmap($"../../Images/ImageCar/.png"); }
            Brand2.Text = CatalogBD.Rows[1].Cells[1].Value.ToString();
            Model2.Text = CatalogBD.Rows[1].Cells[2].Value.ToString();
            Country2.Text = CatalogBD.Rows[1].Cells[3].Value.ToString();
            Mileage2.Text = CatalogBD.Rows[1].Cells[4].Value.ToString();
            Class2.Text = CatalogBD.Rows[1].Cells[5].Value.ToString();
            PricePerDay2.Text = CatalogBD.Rows[1].Cells[6].Value.ToString();
            Status2.Text = CatalogBD.Rows[1].Cells[8].Value.ToString();
            try { PictureCar2.Image = null; PictureCar2.Image = new Bitmap($"../../Images/ImageCar/{CatalogBD.Rows[1].Cells[7].Value.ToString()}.png"); }
            catch { PictureCar2.Image = null; PictureCar2.Image = new Bitmap($"../../Images/ImageCar/.png"); }
            startPage.Text = "2";
            endPage.Text = "2";
        }
        void LoadThreeCar()
        {
            noFoundCar.Visible = false;
            Car1.Visible = true;
            Car2.Visible = true;
            Car3.Visible = true;
            Text2.Visible = true;
            startPage.Visible = true;
            endPage.Visible = true;
            Brand1.Text = CatalogBD.Rows[0].Cells[1].Value.ToString();
            Model1.Text = CatalogBD.Rows[0].Cells[2].Value.ToString();
            Country1.Text = CatalogBD.Rows[0].Cells[3].Value.ToString();
            Mileage1.Text = CatalogBD.Rows[0].Cells[4].Value.ToString();
            Class1.Text = CatalogBD.Rows[0].Cells[5].Value.ToString();
            PricePerDay1.Text = CatalogBD.Rows[0].Cells[6].Value.ToString();
            Status1.Text = CatalogBD.Rows[0].Cells[8].Value.ToString();
            try { PictureCar1.Image = null; PictureCar1.Image = new Bitmap($"../../Images/ImageCar/{CatalogBD.Rows[0].Cells[7].Value.ToString()}.png"); }
            catch { PictureCar1.Image = null; PictureCar1.Image = new Bitmap($"../../Images/ImageCar/.png"); }
            Brand2.Text = CatalogBD.Rows[1].Cells[1].Value.ToString();
            Model2.Text = CatalogBD.Rows[1].Cells[2].Value.ToString();
            Country2.Text = CatalogBD.Rows[1].Cells[3].Value.ToString();
            Mileage2.Text = CatalogBD.Rows[1].Cells[4].Value.ToString();
            Class2.Text = CatalogBD.Rows[1].Cells[5].Value.ToString();
            PricePerDay2.Text = CatalogBD.Rows[1].Cells[6].Value.ToString();
            Status2.Text = CatalogBD.Rows[1].Cells[8].Value.ToString();
            try { PictureCar2.Image = null; PictureCar2.Image = new Bitmap($"../../Images/ImageCar/{CatalogBD.Rows[1].Cells[7].Value.ToString()}.png"); }
            catch { PictureCar2.Image = null; PictureCar2.Image = new Bitmap($"../../Images/ImageCar/.png"); }
            Brand3.Text = CatalogBD.Rows[2].Cells[1].Value.ToString();
            Model3.Text = CatalogBD.Rows[2].Cells[2].Value.ToString();
            Country3.Text = CatalogBD.Rows[2].Cells[3].Value.ToString();
            Mileage3.Text = CatalogBD.Rows[2].Cells[4].Value.ToString();
            Class3.Text = CatalogBD.Rows[2].Cells[5].Value.ToString();
            PricePerDay3.Text = CatalogBD.Rows[2].Cells[6].Value.ToString();
            Status3.Text = CatalogBD.Rows[2].Cells[8].Value.ToString();
            try { PictureCar3.Image = null; PictureCar3.Image = new Bitmap($"../../Images/ImageCar/{CatalogBD.Rows[2].Cells[7].Value.ToString()}.png"); }
            catch { PictureCar3.Image = null; PictureCar3.Image = new Bitmap($"../../Images/ImageCar/.png"); }
            startPage.Text = "3";
            endPage.Text = "3";
        }
        void LoadMoreThreeCar()
        {
            noFoundCar.Visible = false;
            Car1.Visible = true;
            Car2.Visible = true;
            Car3.Visible = true;
            Text2.Visible = true;
            startPage.Visible = true;
            endPage.Visible = true;
            Brand1.Text = CatalogBD.Rows[0].Cells[1].Value.ToString();
            Model1.Text = CatalogBD.Rows[0].Cells[2].Value.ToString();
            Country1.Text = CatalogBD.Rows[0].Cells[3].Value.ToString();
            Mileage1.Text = CatalogBD.Rows[0].Cells[4].Value.ToString();
            Class1.Text = CatalogBD.Rows[0].Cells[5].Value.ToString();
            PricePerDay1.Text = CatalogBD.Rows[0].Cells[6].Value.ToString();
            Status1.Text = CatalogBD.Rows[0].Cells[8].Value.ToString();
            try { PictureCar1.Image = null; PictureCar1.Image = new Bitmap($"../../Images/ImageCar/{CatalogBD.Rows[0].Cells[7].Value.ToString()}.png"); }
            catch { PictureCar1.Image = null; PictureCar1.Image = new Bitmap($"../../Images/ImageCar/.png"); }
            Brand2.Text = CatalogBD.Rows[1].Cells[1].Value.ToString();
            Model2.Text = CatalogBD.Rows[1].Cells[2].Value.ToString();
            Country2.Text = CatalogBD.Rows[1].Cells[3].Value.ToString();
            Mileage2.Text = CatalogBD.Rows[1].Cells[4].Value.ToString();
            Class2.Text = CatalogBD.Rows[1].Cells[5].Value.ToString();
            PricePerDay2.Text = CatalogBD.Rows[1].Cells[6].Value.ToString();
            Status2.Text = CatalogBD.Rows[1].Cells[8].Value.ToString();
            try { PictureCar2.Image = null; PictureCar2.Image = new Bitmap($"../../Images/ImageCar/{CatalogBD.Rows[1].Cells[7].Value.ToString()}.png"); }
            catch { PictureCar2.Image = null; PictureCar2.Image = new Bitmap($"../../Images/ImageCar/.png"); }
            Brand3.Text = CatalogBD.Rows[2].Cells[1].Value.ToString();
            Model3.Text = CatalogBD.Rows[2].Cells[2].Value.ToString();
            Country3.Text = CatalogBD.Rows[2].Cells[3].Value.ToString();
            Mileage3.Text = CatalogBD.Rows[2].Cells[4].Value.ToString();
            Class3.Text = CatalogBD.Rows[2].Cells[5].Value.ToString();
            PricePerDay3.Text = CatalogBD.Rows[2].Cells[6].Value.ToString();
            Status3.Text = CatalogBD.Rows[2].Cells[8].Value.ToString();
            try { PictureCar3.Image = null; PictureCar3.Image = new Bitmap($"../../Images/ImageCar/{CatalogBD.Rows[2].Cells[7].Value.ToString()}.png"); }
            catch { PictureCar3.Image = null; PictureCar3.Image = new Bitmap($"../../Images/ImageCar/.png"); }
            startPage.Text = "3";
            endPage.Text = (CatalogBD.Rows.Count - 1).ToString();
        }
        void LoadZeroCar()
        {
            noFoundCar.Visible = true;
            Car1.Visible = false;
            Car2.Visible = false;
            Car3.Visible = false;
            Text2.Visible = false;
            startPage.Visible = false;
            endPage.Visible = false;
            endPage.Text = "0";
            startPage.Text = "0";
        }

        private void clearSearch_Click(object sender, EventArgs e)
        {
            CatalogBD.Rows.Clear();
            sortField.SelectedIndex = -1;
            sortType.SelectedIndex = -1;
            searchField.SelectedIndex = -1;
            searchType.SelectedIndex = -1;
            fieldSearch = 1; typeSort = 1;
            LoadCatalogWithSort();
        }
    }
}
