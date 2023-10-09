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
    public partial class AddAndEditAdditionalService : Form
    {
        int idAdditionalService;
        CarRentalSalonEntities db = new CarRentalSalonEntities();
        public AddAndEditAdditionalService()
        {
            InitializeComponent();
            addAdditionalServiceButton.Visible = true;
            editAdditionalServiceButton.Visible = false;
            Text1.Text = "Добавление услуги";
        }
        public AddAndEditAdditionalService( int id )
        {
            InitializeComponent();
            idAdditionalService = id;
            addAdditionalServiceButton.Visible = false;
            editAdditionalServiceButton.Visible = true;
            LoadAdditionalService();
            Text1.Text = "Изменение услуги";
        }
        public void LoadAdditionalService()
        {
            try
            {
                var AdditionalInfo = db.fc_OutputOneAdditionalService(idAdditionalService).FirstOrDefault();
                nameAdditionalService.Text = AdditionalInfo.AdditionalServiceName;
                priceAdditionalService.Text = AdditionalInfo.AdditionalServicePrice.ToString();
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
                AdditionalServices additionalServices = new AdditionalServices();
                additionalServices.Show();
                this.Close();
        }

        private void addAdditionalServiceButton_Click(object sender, EventArgs e)
        {
            if (nameAdditionalService.Text != "" && priceAdditionalService.Text != "")
            {
                addAdditionService();
            }
            else MessageBox.Show("Заполните все поля!");
        }

        private void editAdditionalServiceButton_Click(object sender, EventArgs e)
        {
            editAdditionService();
        }
        public void editAdditionService()
        {
            try
            {
                int count = db.pc_UpdateAdditionalService(idAdditionalService, nameAdditionalService.Text, Convert.ToInt32(priceAdditionalService.Text));
                if (count >= 1) 
                { 
                    MessageBox.Show("Изменение прошло успешно!"); 
                    AdditionalServices additionalServices = new AdditionalServices();
                    additionalServices.Show();
                    this.Close();
                }
                else { MessageBox.Show("Изменение прошло безуспешно!"); }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
        public void addAdditionService()
        {
            try
            {
                int count = db.pc_InsertAdditionalService(nameAdditionalService.Text,Convert.ToInt32(priceAdditionalService.Text));
                if (count >= 1) 
                { 
                    MessageBox.Show("Добавление прошло успешно!"); 
                    AdditionalServices additionalServices = new AdditionalServices();
                    additionalServices.Show();
                    this.Close();
                }
                else { MessageBox.Show("Добавление прошло безуспешно!"); }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }

        private void nameAdditionalService_TextChanged(object sender, EventArgs e)
        {
            if (nameAdditionalService.TextLength > 30) { MessageBox.Show("Длина названия услуги не может быть больше 30 символов"); nameAdditionalService.Text = nameAdditionalService.Text.Substring(0, 30); }
        }

        private void priceAdditionalService_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void TimeNow_Tick(object sender, EventArgs e)
        {
            TimeNow.Interval = 1000;
            TimeText.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }
    }
}
