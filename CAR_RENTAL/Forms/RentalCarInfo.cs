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
    public partial class RentalCarInfo : Form
    {
        int idRentalCar;
        CarRentalSalonEntities db = new CarRentalSalonEntities();
        public RentalCarInfo(int id)
        {
            InitializeComponent();
            idRentalCar = id;
            LoadAdditionalService();
            LoadDriver();
        }
        public void LoadDriver()
        {
            try
            {
                var DriverInfo = db.fc_OutputDriverOneRentalCar(idRentalCar).ToList().FirstOrDefault();
                if(DriverInfo != null)
                {
                    DriverBD.Rows.Add(DriverInfo.DriverFullName,DriverInfo.DriverPricePerDay);
                    itogSumma.Text = DriverInfo.AdditionalServicesOnOrderFullPriceOnOrder.ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
        public void LoadAdditionalService()
        {
            try
            {
                var AdditionalInfo = db.fc_OutputAdditionalServicesOneRentalCar(idRentalCar).ToList();
                if(AdditionalInfo != null)
                {
                    foreach(var additional in AdditionalInfo)
                    {
                        AdditionalServiceBD.Rows.Add(additional.AdditionalServiceName,additional.AdditionalServicePrice);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
        private void TimeNow_Tick(object sender, EventArgs e)
        {
            TimeNow.Interval = 1000;
            TimeText.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }

        private void BackMenu_Click(object sender, EventArgs e)
        {
            RentalCars rentalCars = new RentalCars();
            rentalCars.Show();
            this.Close();
        }
    }
}
