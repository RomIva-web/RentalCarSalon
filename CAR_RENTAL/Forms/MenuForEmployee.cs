using CAR_RENTAL.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAR_RENTAL.Forms
{
    public partial class MenuForEmployee : Form
    {
        public MenuForEmployee()
        {
            InitializeComponent();
        }

        private void TimeNow_Tick(object sender, EventArgs e)
        {
            TimeNow.Interval = 1000;
            TimeText.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void backMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();

        }

        private void rentalCarsButton_Click(object sender, EventArgs e)
        {
            RentalCars rentalCars = new RentalCars();
            rentalCars.Show();
            this.Close();
        }

        private void additionalServicesButton_Click(object sender, EventArgs e)
        {
            AdditionalServices additionalServices = new AdditionalServices();
            additionalServices.Show();
            this.Close();
        }

        private void carsButton_Click(object sender, EventArgs e)
        {
            Cars cars = new Cars();
            cars.Show();
            this.Close();
        }

        private void finesButton_Click(object sender, EventArgs e)
        {
            Fines fines = new Fines();
            fines.Show();
            this.Close();
        }

        private void clientsButton_Click(object sender, EventArgs e)
        {
                Clients clients = new Clients();
                clients.Show();
                this.Close();
        }

        private void employeesButton_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            employees.Show();
            this.Close();
        }

        private void MenuForEmployee_Load(object sender, EventArgs e)
        {
            if (UserAuthorization.Role == 2) { rentalCarsButton.Visible = true; additionalServicesButton.Visible = true; carsButton.Visible = true; finesButton.Visible = true; clientsButton.Visible = true; driversButton.Visible = true; typeCarDamageButton.Visible = true; }
            if (UserAuthorization.Role == 3) { rentalCarsButton.Visible = true; additionalServicesButton.Visible = true; carsButton.Visible = true; finesButton.Visible = true; clientsButton.Visible = true; driversButton.Visible = true; typeCarDamageButton.Visible = true; }
            if (UserAuthorization.Role == 4) { rentalCarsButton.Visible = true; additionalServicesButton.Visible = true; carsButton.Visible = true; finesButton.Visible = true; employeesButton.Visible = true; clientsButton.Visible = true; driversButton.Visible = true; typeCarDamageButton.Visible = true; }
        }

        private void driversButton_Click(object sender, EventArgs e)
        {
            Drivers drivers = new Drivers();
            drivers.Show();
            this.Close();
        }

        private void typeCarDamageButton_Click(object sender, EventArgs e)
        {
            TypeCarDamage typeCarDamage = new TypeCarDamage();
            typeCarDamage.Show();
            this.Close();
        }
    }
}
