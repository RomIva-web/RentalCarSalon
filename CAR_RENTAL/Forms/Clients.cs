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
    public partial class Clients : Form
    {
        CarRentalSalonEntities db = new CarRentalSalonEntities();
        public Clients()
        {
            InitializeComponent();
        }

        private void TimeNow_Tick(object sender, EventArgs e)
        {
            TimeNow.Interval = 1000;
            TimeText.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            if (UserAuthorization.Role == 1) { ClientBD.Visible = false; searchPassport.Visible = false; searchFullNameClient.Visible = false; }
            if (UserAuthorization.Role == 2) { addClientButton.Visible = true; editClientButton.Visible = true; }
            if (UserAuthorization.Role == 3) { addClientButton.Visible = true; editClientButton.Visible = true; delClientButton.Visible = true; }
            if (UserAuthorization.Role == 4) { addClientButton.Visible = true; editClientButton.Visible = true; delClientButton.Visible = true; }
            LoadClient();
        }
        void LoadClient()
        {
            try
            {
                var ClientInfo = db.fc_OutputClient(searchFullNameClient.Text, searchPassport.Text);
                if(ClientInfo != null)
                {
                    foreach(var client in ClientInfo)
                    {
                        ClientBD.Rows.Add(client.ClientId,client.ClientFullName,client.ClientBirthday.ToShortDateString(), client.ClientPassportNumber,client.ClientHaveDriverLicense,client.ClientDriverLicenseNumber);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
        private void backMenuButton_Click(object sender, EventArgs e)
        {
            MenuForEmployee menuForEmployee = new MenuForEmployee();
            menuForEmployee.Show();
            this.Close();
        }

        private void searchFullNameClient_TextChanged(object sender, EventArgs e)
        {
            ClientBD.Rows.Clear();
            LoadClient();
        }

        private void searchPassport_TextChanged(object sender, EventArgs e)
        {
            ClientBD.Rows.Clear();
            LoadClient();
        }

        private void editClientButton_Click(object sender, EventArgs e)
        {
            RegistrationAndEditClient registrationAndEditClient = new RegistrationAndEditClient( (int)ClientBD.Rows[ClientBD.CurrentRow.Index].Cells[0].Value);
            registrationAndEditClient.Show();
            this.Close();
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            RegistrationAndEditClient registrationAndEditClient = new RegistrationAndEditClient();
            registrationAndEditClient.Show();
            this.Close();
        }

        private void delClientButton_Click(object sender, EventArgs e)
        {
            if (ClientBD.CurrentRow.Index >= 0)
            {
                DialogResult dialogResult = MessageBox.Show($"Вы уверены, что хотите удалить {ClientBD.Rows[ClientBD.CurrentRow.Index].Cells[1].Value}", "Предупреждение!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        int count = db.pc_DeleteClient(Convert.ToInt32(ClientBD.Rows[ClientBD.CurrentRow.Index].Cells[0].Value));
                        if (count >= 1) { MessageBox.Show("Удаление прошло успешно!"); ClientBD.Rows.Clear(); LoadClient(); }
                        else { MessageBox.Show("Удаление прошло безуспешно!"); }
                    }
                    catch (Exception ex) { MessageBox.Show($"{ex}"); }
                }
            }
            else MessageBox.Show("Чтобы удалить клиента, нужно выделить нужную вам строку и затем нажать на эту же кнопку");
        }

        private void searchPassport_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void searchFullNameClient_Leave(object sender, EventArgs e)
        {
            if(searchFullNameClient.Text == "") infoSearch1.Visible = true;
        }

        private void searchPassport_Leave(object sender, EventArgs e)
        {
            if(searchPassport.Text == "") infoSearch2.Visible = true;
        }

        private void infoSearch1_Click(object sender, EventArgs e)
        {
            infoSearch1.Visible = false;
            searchFullNameClient.Focus();
        }

        private void infoSearch2_Click(object sender, EventArgs e)
        {
            infoSearch2.Visible = false;
            searchPassport.Focus();
        }

        private void searchFullNameClient_Enter(object sender, EventArgs e)
        {
            infoSearch1.Visible = false;
        }

        private void searchPassport_Enter(object sender, EventArgs e)
        {
            infoSearch2.Visible = false;
        }
    }
}
