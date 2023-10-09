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
    public partial class AddAndEditCar : Form
    {
        int idCar, newImage = 0;
        string brandNow, modelNow;
        CarRentalSalonEntities db = new CarRentalSalonEntities();
        public AddAndEditCar()
        {
            InitializeComponent();
            addCarButton.Visible = true;
            editCarButton.Visible = false;
            LoadCountry();
            LoadStatusCatalogCar();
            Text1.Text = "Добавление машины";
        }
        public AddAndEditCar(int id)
        {
            InitializeComponent();
            idCar = id;
            addCarButton.Visible = false;
            editCarButton.Visible = true;
            LoadCountry();
            LoadStatusCatalogCar();
            LoadOneCar();
            Text1.Text = "Изменение машины";
        }

        private void editCarButton_Click(object sender, EventArgs e)
        {
            if (brand.Text != "" && model.Text != "" && countryName.SelectedIndex != -1 && mileage.Text != "" && pricePerDay.Text != "" && statusCatalogCar.SelectedIndex != -1)
            {
                editCar();
            }
            else MessageBox.Show("Заполните все поля!");
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            if (brand.Text != "" && model.Text != "" && countryName.SelectedIndex != -1 && mileage.Text != "" && pricePerDay.Text != "" && statusCatalogCar.SelectedIndex != -1)
            {
                addCar();
            }
            else MessageBox.Show("Заполните все поля!");
        }

        private void LoadStatusCatalogCar()
        {
            var StatusCatalogCarInfo = db.StatusCatalogCars.ToList();
            if(StatusCatalogCarInfo != null)
            {
                foreach(var status in StatusCatalogCarInfo)
                {
                    statusCatalogCar.Items.Add(status.StatusCatalogCarName);
                }
            }
        }

        void addCar()
        {
            try
            {
                int count = db.pc_AddCar(brand.Text,model.Text, db.CountryCars.Where(c => c.CountryCarName == countryName.Text).FirstOrDefault().CountryCarId, Convert.ToInt32(mileage.Text),Convert.ToInt32(pricePerDay.Text), db.StatusCatalogCars.Where(s => s.StatusCatalogCarName == statusCatalogCar.Text).FirstOrDefault().StatusCatalogCarId, $"{brand.Text} {model.Text} {GetMaxId() + 1}");
                if (count >= 1)
                {
                    MessageBox.Show("Добавление прошло успешно!");
                    if (carImage.Image != null)
                    {
                        try
                        {
                            Image image = carImage.Image;
                            carImage.Image = null;
                            image.Save($@"..\..\Images\ImageCar\{brand.Text} {model.Text} {GetMaxId().ToString()}.png");
                        }
                        catch
                        {
                            MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    Cars cars = new Cars();
                    cars.Show();
                    this.Close();
                }
                else { MessageBox.Show("Добавление прошло безуспешно!"); }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
        int GetMaxId()
        {
            try
            {
                return Convert.ToInt32(db.fc_GetMaxId().FirstOrDefault().MaxNumber);
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); return 0; }
        }
        void editCar()
        {
            try
            {
                int count = db.pc_UpdateCar(idCar, brand.Text, model.Text, db.CountryCars.Where(c => c.CountryCarName == countryName.Text).FirstOrDefault().CountryCarId, Convert.ToInt32(mileage.Text), Convert.ToInt32(pricePerDay.Text),db.StatusCatalogCars.Where(s => s.StatusCatalogCarName == statusCatalogCar.Text).FirstOrDefault().StatusCatalogCarId, $"{brand.Text} {model.Text} {idCar}");
                if (count >= 1)
                {
                    MessageBox.Show("Изменение прошло успешно!");
                    Image imageCar = carImage.Image;
                    carImage.Image = null;
                    Image imageVoid = new Bitmap($"../../Images/ImageCar/.png");
                    if (newImage > 0 || brandNow != brand.Text || modelNow != model.Text)
                    {
                        imageCar.Save($@"..\..\Images\ImageCar\{brand.Text} {model.Text} {idCar.ToString()}.png");
                    }
                    Cars cars = new Cars();
                    cars.Show();
                    this.Close();
                }
                else { MessageBox.Show("Изменение прошло безуспешно!"); }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
        private void addNewCountryButton_Click(object sender, EventArgs e)
        {
            try
            {
                int count = db.pc_AddNewCountry(newCountryName.Text);
                if (count >= 1) { MessageBox.Show("Добавление прошло успешно!"); countryName.Items.Clear(); LoadCountry(); }
                else  MessageBox.Show("Добавление прошло безуспешно!"); 
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
        void LoadCountry()
        {
            try
            {
                var CountryInfo = db.fc_OutputCountry().ToList();
                if (CountryInfo != null)
                {
                    foreach (var country in CountryInfo)
                    {
                        countryName.Items.Add(country.CountryCarName);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }

        }
        void LoadOneCar()
        {
            try
            {
                var CarInfo = db.fc_OutputOneCar(idCar).ToList().FirstOrDefault();
                if (CarInfo != null)
                {
                    brand.Text = CarInfo.CatalogCarBrand;
                    brandNow = CarInfo.CatalogCarBrand;
                    model.Text = CarInfo.CatalogCarModel;
                    modelNow = CarInfo.CatalogCarModel;
                    countryName.SelectedIndex = GetComboBoxIndexItem(countryName, db.CountryCars.Where(c => c.CountryCarId == CarInfo.CountryCarId).FirstOrDefault().CountryCarName);
                    statusCatalogCar.SelectedIndex = GetComboBoxIndexItem(statusCatalogCar, db.StatusCatalogCars.Where(s => s.StatusCatalogCarId == CarInfo.StatusCatalogCarId).FirstOrDefault().StatusCatalogCarName);
                    mileage.Text = CarInfo.CatalogCarMileage.ToString();
                    pricePerDay.Text = CarInfo.CatalogCarPricePerDay.ToString();
                    try
                    {
                        carImage.Image = null;
                        carImage.Image = new Bitmap($"../../Images/ImageCar/{brand.Text} {model.Text} {idCar}.png");

                    }
                    catch
                    {
                        carImage.Image = null;
                        carImage.Image = new Bitmap($"../../Images/ImageCar/.png");
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }

        private int GetComboBoxIndexItem(ComboBox comboBox ,string item)
        {
            for(int i = 0; i < comboBox.Items.Count; i++)
            {
                if(comboBox.Items[i].ToString() == item) { return i; }
            }
            return 0;
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Если на данный момент у вас нет фотографии автомобиля,\nто вы можете оставить фотографию пустой и добавить потом!");
        }

        private void takeWayPictureButton_Click(object sender, EventArgs e)
        {
            newImage++;
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image image = new Bitmap(open_dialog.FileName);
                    carImage.Image = null;
                    carImage.Image = image;
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void brand_TextChanged(object sender, EventArgs e)
        {
            if (brand.TextLength > 30) { MessageBox.Show("Длина марки не может быть больше 30 символов"); brand.Text = brand.Text.Substring(0, 30); }
        }

        private void model_TextChanged(object sender, EventArgs e)
        {
            if (model.TextLength > 30) { MessageBox.Show("Длина модели не может быть больше 30 символов"); model.Text = model.Text.Substring(0, 30); }
        }

        private void pricePerDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void newCountryName_TextChanged(object sender, EventArgs e)
        {
            if (newCountryName.TextLength > 50) { MessageBox.Show("Длина новой страны не может быть больше 50 символов"); newCountryName.Text = newCountryName.Text.Substring(0, 50); }
        }

        private void mileage_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Cars cars = new Cars();
            cars.Show();
            this.Close();
        }

        private void TimeNow_Tick(object sender, EventArgs e)
        {
            TimeNow.Interval = 1000;
            TimeText.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }
    }
}
