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
    public partial class RegistrationAndEditClient : Form
    {
        int idClient;
        DateTime dateBirtday;
        CarRentalSalonEntities db = new CarRentalSalonEntities();
        public RegistrationAndEditClient()
        {
            InitializeComponent();
            addClientButton.Visible = true;
            editClientButton.Visible = false;
            Text1.Text = "Регистрация клиента";
        }
        public RegistrationAndEditClient( int id)
        {
            InitializeComponent();
            idClient = id;
            addClientButton.Visible = false;
            editClientButton.Visible = true;
            loadClient();
            Text1.Text = "Изменение данных клиента";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            clients.Show();
            this.Close();
        }

        private void editClientButton_Click(object sender, EventArgs e)
        {
            if ((extendsDriverLicense.Checked && numDriverLicense.Text != "") || (!extendsDriverLicense.Checked && numDriverLicense.Text == ""))
            {
                if (fullNameClient.Text != "" && numPassport.Text != "")
                {
                    editClient();
                }
                else MessageBox.Show("Заполните ФИО клиента и номер паспорта!");
            }
            else MessageBox.Show("Предупреждение!\nУбедитесь, что у клиента\n1)Клиент имеет водительское удостоверение и заполнено поле номера\n2)Клиент не имеет водительского удостоверения и не заполнено поле номера и если нужно убрать номер, нажмите кнопку Очистка номера, так же можно удалить вручную");
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            if ((extendsDriverLicense.Checked && numDriverLicense.Text != "") || (!extendsDriverLicense.Checked && numDriverLicense.Text == ""))
            {
                if (fullNameClient.Text != "" && numPassport.Text != "") {
                    addClient();
                }
                else MessageBox.Show("Заполните ФИО клиента и номер паспорта!");
            }
            else MessageBox.Show("Предупреждение!\nУбедитесь, что у клиента\n1)Клиент имеет водительское удостоверение и заполнено поле номера\n2)Клиент не имеет водительского удостоверения и не заполнено поле номера и если нужно убрать номер, нажмите кнопку Очистка номера, так же можно удалить вручную");
        }
        void editClient()
        {
            try
            {
                int count;
                if (numDriverLicense.Text == "") count = db.pc_UpdateClient(idClient, fullNameClient.Text, birthday.Value, Convert.ToDecimal(numPassport.Text), false, null);
                else count = db.pc_UpdateClient(idClient, fullNameClient.Text, birthday.Value, Convert.ToDecimal(numPassport.Text), true, Convert.ToDecimal(numDriverLicense.Text));
                
                if (count >= 1) 
                { 
                    MessageBox.Show("Изменение прошло успешно!"); 
                    Clients clients = new Clients();
                    clients.Show();
                    this.Close();
                }
                else { MessageBox.Show("Изменения прошло безуспешно!"); }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
        void addClient()
        {
            try
            {
                int count;
                if (numDriverLicense.Text == "") count = db.pc_RegistrationClient(fullNameClient.Text, birthday.Value, Convert.ToDecimal(numPassport.Text), false, null);
                else count = db.pc_RegistrationClient(fullNameClient.Text, birthday.Value, Convert.ToDecimal(numPassport.Text), true,Convert.ToDecimal(numDriverLicense.Text));
                if (count >= 1) 
                { 
                    MessageBox.Show("Регистрация прошло успешно!"); 
                    Clients clients = new Clients();
                    clients.Show();
                    this.Close();
                }
                else { MessageBox.Show("Регистрация прошло безуспешно!"); }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
        void loadClient()
        {
            try
            {
                var ClientInfo = db.fc_OutputOneClient(idClient).ToList().FirstOrDefault();
                if(ClientInfo != null)
                {
                    fullNameClient.Text = ClientInfo.ClientFullName;
                    birthday.Value = ClientInfo.ClientBirthday;
                    dateBirtday = ClientInfo.ClientBirthday;
                    numPassport.Text = ClientInfo.ClientPassportNumber.ToString();
                    extendsDriverLicense.Checked = ClientInfo.ClientHaveDriverLicense.Value;
                    numDriverLicense.Text = ClientInfo.ClientDriverLicenseNumber.ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }

        private void extendsDriverLicense_CheckedChanged(object sender, EventArgs e)
        {
            DateTime dateNow = DateTime.Today;
            TimeSpan subDate = dateNow - dateBirtday ;
            if (subDate.TotalDays >= 6570 && extendsDriverLicense.Checked == true)
            {
                if (extendsDriverLicense.Checked) numDriverLicense.Enabled = true;
                else numDriverLicense.Enabled = false;
            }
            if (subDate.TotalDays < 6570 && extendsDriverLicense.Checked == true) 
            { 
                MessageBox.Show("Клиенту меньше 18 лет, он не может иметь водительское удостоверение!"); 
                extendsDriverLicense.Checked = false;
                numDriverLicense.Enabled = false;
            }
            if (extendsDriverLicense.Checked) numDriverLicense.Enabled = true;
            else numDriverLicense.Enabled = false;
        }

        private void birthday_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateNow = DateTime.Today;
            TimeSpan subDate = dateNow - birthday.Value;
            if (subDate.TotalMilliseconds >= 0) 
            {
                if (subDate.TotalDays >= 5840) dateBirtday = birthday.Value;
                else { MessageBox.Show("Клиент должно быть не меньше 16 лет!"); birthday.Value = dateBirtday; }
            }
            if (subDate.TotalMilliseconds < 0) { MessageBox.Show("Клиент не может родиться позже сегодняшней даты!"); birthday.Value = dateBirtday; }
        }

        private void RegistrationAndEditClient_Load(object sender, EventArgs e)
        {
            dateBirtday = birthday.Value;
        }

        private void numPassport_TextChanged(object sender, EventArgs e)
        {
            if (numPassport.TextLength > 10) { MessageBox.Show("Длина номера паспорта не может быть больше 10 символов"); numPassport.Text = numPassport.Text.Substring(0, 10); }
        }

        private void numDriverLicense_TextChanged(object sender, EventArgs e)
        {
            if(numDriverLicense.TextLength > 10) { MessageBox.Show("Длина номера водительского удостоверения не может быть больше 10 символов"); numDriverLicense.Text = numDriverLicense.Text.Substring(0, 10); }
        }

        private void clearDriverLicenseButton_Click(object sender, EventArgs e)
        {
            numDriverLicense.Text = "";
        }

        private void fullNameClient_TextChanged(object sender, EventArgs e)
        {
            if (fullNameClient.TextLength > 50) { MessageBox.Show("Длина ФИО клиента не может быть больше 50 символов"); fullNameClient.Text = fullNameClient.Text.Substring(0, 50); }
        }

        private void numPassport_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void numDriverLicense_KeyPress(object sender, KeyPressEventArgs e)
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
