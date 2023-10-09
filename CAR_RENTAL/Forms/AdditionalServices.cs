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
    public partial class AdditionalServices : Form
    {
        int sort = 1;
        CarRentalSalonEntities db = new CarRentalSalonEntities();
        public AdditionalServices()
        {
            InitializeComponent();
        }

        private void TimeNow_Tick(object sender, EventArgs e)
        {
            TimeNow.Interval = 1000;
            TimeText.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }

        private void AdditionalServices_Load(object sender, EventArgs e)
        {
            LoadAdditionalService();
            if (UserAuthorization.Role == 1) { AdditionalServiceBD.Visible = false; additionalServiceName.Visible = false; sortType.Visible = false; }
            if (UserAuthorization.Role == 2) { }
            if (UserAuthorization.Role == 3) { addAdditionalServiceButton.Visible = true; editAdditionalServiceButton.Visible = true; delAdditionalServiceButton.Visible = true; }
            if (UserAuthorization.Role == 4) { addAdditionalServiceButton.Visible = true; editAdditionalServiceButton.Visible = true; delAdditionalServiceButton.Visible = true; }
            sortType.Items.Add("Без сортировки цены");
            sortType.Items.Add("По убыванию цены");
            sortType.Items.Add("По возрастанию цены");
            sortType.SelectedIndex = 0;
        }
        public void LoadAdditionalService()
        {
            try
            {
                var AdditionalInfo = db.pc_OutputAdditionalServices(additionalServiceName.Text, sort);
                if(AdditionalInfo != null)
                {
                    foreach(var additional in AdditionalInfo)
                    {
                        AdditionalServiceBD.Rows.Add(additional.AdditionalServiceId,additional.AdditionalServiceName,additional.AdditionalServicePrice);
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

        private void AdditionalServiceName_TextChanged(object sender, EventArgs e)
        {
            AdditionalServiceBD.Rows.Clear();
            LoadAdditionalService();
        }

        private void editAdditionalServiceButton_Click(object sender, EventArgs e)
        {
            AddAndEditAdditionalService addAndEditDopAdditionalService = new AddAndEditAdditionalService(Convert.ToInt32(AdditionalServiceBD.Rows[AdditionalServiceBD.CurrentRow.Index].Cells[0].Value));
            addAndEditDopAdditionalService.Show();
            this.Close();
        }

        private void addAdditionalServiceButton_Click(object sender, EventArgs e)
        {
            AddAndEditAdditionalService addAndEditDopAdditionalService = new AddAndEditAdditionalService();
            addAndEditDopAdditionalService.Show();
            this.Close();
        }

        private void delAdditionalServiceButton_Click(object sender, EventArgs e)
        {
            if (AdditionalServiceBD.CurrentRow.Index >= 0)
            {
                DialogResult dialogResult = MessageBox.Show($"Вы уверены, что хотите удалить {AdditionalServiceBD.Rows[AdditionalServiceBD.CurrentRow.Index].Cells[1].Value}", "Предупреждение!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        int count = db.pc_DeleteAdditionalService(Convert.ToInt32(AdditionalServiceBD.Rows[AdditionalServiceBD.CurrentRow.Index].Cells[0].Value));
                        if (count >= 1) { MessageBox.Show("Удаление прошло успешно!"); AdditionalServiceBD.Rows.Clear(); LoadAdditionalService(); }
                        else { MessageBox.Show("Удаление прошло безуспешно!"); }
                    }
                    catch (Exception ex) { MessageBox.Show($"{ex}"); }
                }
            }
            else MessageBox.Show("Чтобы удалить услугу, нужно выделить нужную вам строку и затем нажать на эту же кнопку");
        }

        private void sortType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(sortType.SelectedItem.ToString() == "Без сортировки цены") { sort = 1; }
            if(sortType.SelectedItem.ToString() == "По убыванию цены") { sort = 2; }
            if (sortType.SelectedItem.ToString() == "По возрастанию цены") { sort = 3; }
            AdditionalServiceBD.Rows.Clear();
            LoadAdditionalService();
        }

        private void infoSearch1_Click(object sender, EventArgs e)
        {
            infoSearch1.Visible = false;
            additionalServiceName.Focus();
        }

        private void additionalServiceName_Leave(object sender, EventArgs e)
        {
            if (additionalServiceName.Text == "") infoSearch1.Visible = true;
        }

        private void additionalServiceName_Enter(object sender, EventArgs e)
        {
            infoSearch1.Visible = false;
        }
    }
}
