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
    public partial class Fashion : Form
    {
        int idCar, idDriver;
        CarRentalSalonEntities db = new CarRentalSalonEntities();
        public Fashion()
        {
            InitializeComponent();
        }

        private void TimeNow_Tick(object sender, EventArgs e)
        {
            TimeNow.Interval = 1000;
            TimeText.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }

        private void Fashion_Load(object sender, EventArgs e)
        {
            LoadCar();
            LoadFine();
            LoadDriver();
            LoadAdditionalService();
        }
        public void LoadCar()
        {
            try
            {
                var CarInfo = db.fc_FashionCar().ToList().FirstOrDefault();
                if(CarInfo != null)
                {
                    idCar = CarInfo.CatalogCarId;
                    brandCar.Text = CarInfo.CatalogCarBrand;
                    modelCar.Text = CarInfo.CatalogCarModel;
                    countryCar.Text = CarInfo.CountryCarName;
                    mileageCar.Text = CarInfo.CatalogCarMileage.ToString();
                    classCar.Text = CarInfo.ClassCarName;
                    pricePerDayCar.Text = CarInfo.CatalogCarPricePerDay.ToString();
                    amountCar.Text = CarInfo.Amount.ToString();
                    CheckBusyCar();
                    try
                    {
                        pictureCar.Image = Image.FromFile($"../../Images/ImageCar/{brandCar.Text} {modelCar.Text} {idCar.ToString()}.png");
                    }
                    catch { pictureCar.Image = Image.FromFile($"../../Images/ImageCar/.png"); }
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
        public void CheckBusyCar()
        {
            try
            {
                var StatusInfo = db.fc_CheckBusyCar(DateTime.Today.Date, idCar).ToList().FirstOrDefault();
                if (StatusInfo != null)
                {
                    statusCar.Text = StatusInfo.Status;
                }
                else statusCar.Text = "Свободна";
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
        public void LoadFine()
        {
            try
            {
                var FineInfo = db.fc_FashionFine().ToList().FirstOrDefault();
                if(FineInfo != null)
                {
                    fineName.Text = FineInfo.NameFineName;
                    amountFine.Text = FineInfo.Amount.ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
        public void LoadAdditionalService()
        {
            try
            {
                var AdditionalInfo = db.fc_FashionAdditionalService().ToList().FirstOrDefault();
                if(AdditionalInfo != null)
                {
                    nameAdditionalService.Text = AdditionalInfo.AdditionalServiceName;
                    priceAdditionalService.Text = AdditionalInfo.AdditionalServicePrice.ToString();
                    amountAdditionalService.Text = AdditionalInfo.Amount.ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
        public void LoadDriver()
        {
            try
            {
                var DriverInfo = db.fc_FashionDriver().ToList().FirstOrDefault();
                if(DriverInfo != null)
                {
                    idDriver = DriverInfo.DriverId;
                    fullNameDriver.Text = DriverInfo.DriverFullName;
                    pricePerDayDriver.Text = DriverInfo.DriverPricePerDay.ToString();
                    amountDriver.Text = DriverInfo.Amount.ToString();
                    CheckBusyDriver();
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
        public void CheckBusyDriver()
        {
            try
            {
                var StatusInfo = db.fc_CheckBusyDriver(DateTime.Today.Date, idDriver).ToList().FirstOrDefault();
                if(StatusInfo != null)
                {
                    statusDriver.Text = StatusInfo.Status;
                }
                else statusDriver.Text = "Свободен";
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }

        private void backMenuButton_Click(object sender, EventArgs e)
        {
            MainWindow mainMenu = new MainWindow();
            mainMenu.Show();
            this.Close();
        }
    }
}
