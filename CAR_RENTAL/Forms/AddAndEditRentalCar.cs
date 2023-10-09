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
    public partial class AddAndEditRentalCar : Form
    {
        int idRentalCar = 0, idCar = 0;
        string carName, clientName;
        string[] carInfoTurn;
        DateTime dateStart = DateTime.Now.Date, dateEnd = DateTime.Now.Date;
        CarRentalSalonEntities db = new CarRentalSalonEntities();
        bool statusPay = false;
        public AddAndEditRentalCar()
        {
            InitializeComponent();
            LoadCar();
            LoadStatusAdditionalPayment();
            LoadStatusPayment();
            LoadStatusRentalCar();
            LoadClient();
            addRentalCarButton.Visible = true;
            editRentalCarButton.Visible = false;
            Text1.Text = "Добавление заказа проката";
            rentalCarTake.Enabled = false;
            statusAdditionalPayment.Enabled = false;
            statusPayment.Enabled = false;
            statusRentalCar.Enabled = false;
            statusAdditionalPayment.Enabled = false;
            statusAdditionalPayment.SelectedIndex = 0;
            statusPayment.Enabled = false;
            statusPayment.SelectedIndex = 0;
            statusRentalCar.Enabled = false;
            statusRentalCar.SelectedIndex = 0;
        }
        public AddAndEditRentalCar(int id)
        {
            InitializeComponent();
            idRentalCar = id;
            LoadStatusAdditionalPayment();
            LoadStatusPayment();
            LoadStatusRentalCar();
            LoadOneClient();
            LoadCar();
            rentalCarTake.Value = dateStart;
            rentalCarReturn.Value = dateEnd;
            LoadClient();
            LoadDriver();
            LoadAdditionalService();
            addRentalCarButton.Visible = false;
            editRentalCarButton.Visible = true;
            client.Enabled = false;
            rentalCarTake.Enabled = false;
            Text1.Text = "Изменение заказа проката";
            carInfoTurn = car.SelectedItem.ToString().Split('|');
            statusRentalCar.Enabled = false;
            if (statusPayment.Text == "Оплата принята")
            {
                statusPay = true;
                addAdditionalService.Enabled = false;
                delAdditionalService.Enabled = false;
                addDriver.Enabled = false;
                delDriver.Enabled = false;
                car.Enabled = false;
                statusPayment.Enabled = false;
                if (statusAdditionalPayment.Text == "Дополнительная оплата принята") statusAdditionalPayment.Enabled = false;
            }
            else
            {
                statusPayment.Enabled = true;
                statusPay = false;
                statusAdditionalPayment.Enabled = false;
                statusRentalCar.Enabled = false;
            }
            if (statusRentalCar.SelectedItem.ToString() == "Возвращена") { statusAdditionalPayment.Enabled = true; rentalCarReturn.Enabled = false; }
        }

        private void TimeNow_Tick(object sender, EventArgs e)
        {
            TimeNow.Interval = 1000;
            TimeText.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }

        private void addRentalCarButton_Click(object sender, EventArgs e)
        {
            if (car.SelectedIndex != -1 && client.SelectedIndex != -1 && AdditionalServiceBD.Rows.Count - 1 != 0 && DriverBD.Rows.Count - 1 != 0)
            {
                TimeSpan timeSpan = rentalCarReturn.Value.Date - rentalCarTake.Value.Date;
                if (timeSpan.Days >= 0)
                {
                    string driverS = DriverBD.Rows[0].Cells[0].Value.ToString();
                    string[] split = client.SelectedItem.ToString().Split('|');
                    if ((driverS == "Без водителя" && split[3] == "+") || (driverS != "Без водителя"))
                    {
                        if (statusPayment.Text == "Оплата принята")
                        {
                            DialogResult dialogResult = MessageBox.Show($"Вы уверены, что хотите подтвердить оплату заказа?\nУбедитесь, что все услуги, водитель и машина выбраны правильно!\nДанное действие необратимо и вы не сможете больше изменять эти данные в заказе!", "Предупреждение!", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                AddRentalCar();
                            }
                        }
                        else AddRentalCar();

                    }
                    else MessageBox.Show("У клиента нет водительского удостоверения, он обязан взять водителя!");
                }
                else MessageBox.Show("Дата возврата не может быть раньше, чем дата взятия в прокат");
            }
            else MessageBox.Show("Заполните все поля, а так же добавьте в заказ услуги и водителя");
        }

        private void editRentalCarButton_Click(object sender, EventArgs e)
        {
            TimeSpan timeSpan = rentalCarReturn.Value.Date - rentalCarTake.Value.Date;
            if (timeSpan.Days >= 0)
            {
                timeSpan = DateTime.Now.Date - rentalCarReturn.Value.Date;
                if (timeSpan.Days <= 0)
                {
                    string[] splitCar = car.SelectedItem.ToString().Split('|');
                    if (splitCar[0] == carInfoTurn[0] || (splitCar[0] != carInfoTurn[0] && status.Text != "-"))
                    {
                        if (statusPayment.Text == "Оплата принята" && !statusPay)
                        {
                            DialogResult dialogResult = MessageBox.Show($"Вы уверены, что хотите подтвердить оплату заказа?\nУбедитесь, что все услуги, водитель и машина выбраны правильно!\nДанное действие необратимо и вы не сможете больше изменять эти данные в заказе!", "Предупреждение!", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                if (statusPay) EditRentalCarWithPay();
                                else EditRentalCarWithoutPay();
                            }
                        }
                        else
                        {

                            if (statusPayment.Text == "Отмена оплаты")
                            {
                                DialogResult dialogResult = MessageBox.Show($"Вы уверены, что хотите отменить оплату заказа?\nДанное действие необратимо и вы не сможете больше работать с этим заказом!", "Предупреждение!", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    EditPaymentCancel();
                                }
                            }
                            else
                            {
                                if (statusAdditionalPayment.Enabled) { EditStatusAdditionalPayment(); }
                                else
                                {
                                    if (statusPay) EditRentalCarWithPay();
                                    else EditRentalCarWithoutPay();
                                }
                            }
                        }

                    }
                    else MessageBox.Show("Машина на данный момент заказа!");
                }
                else MessageBox.Show("Дата возврата не может быть раньше, чем сегодняшняя дата!");
            }
            else MessageBox.Show("Дата возврата не может быть раньше, чем дата взятия в прокат");
        }

        void EditPaymentCancel()
        {
            try
            {
                int count = db.pc_UpdateRentalCarPaymentCancel(idRentalCar);
                if (count >= 1)
                {
                    MessageBox.Show("Изменение прошло успешно!");
                    RentalCars rentalCars = new RentalCars();
                    rentalCars.Show();
                    this.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }

        void EditStatusAdditionalPayment()
        {
            try
            {
                int count = db.pc_UpdateRentalCarStatusAdditionalPayment(idRentalCar, db.StatusAdditionalPaymentRentalCars.Where(s => s.StatusAdditionalPaymentRentalCarName == statusAdditionalPayment.SelectedItem.ToString()).FirstOrDefault().StatusAdditionalPaymentRentalCarId);
                if (count >= 1)
                {
                    MessageBox.Show("Изменение прошло успешно!");
                    RentalCars rentalCars = new RentalCars();
                    rentalCars.Show();
                    this.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }

        void LoadStatusPayment()
        {
            var StatusPaymentInfo = db.StatusPaymentRentalCars.ToList();
            if (StatusPaymentInfo != null)
            {
                foreach (var status in StatusPaymentInfo)
                {
                    statusPayment.Items.Add(status.StatusPaymentRentalCarName);
                }
            }
        }

        void LoadStatusAdditionalPayment()
        {
            var StatusAdditionalPaymentInfo = db.StatusAdditionalPaymentRentalCars.ToList();
            if (StatusAdditionalPaymentInfo != null)
            {
                foreach (var status in StatusAdditionalPaymentInfo)
                {
                    statusAdditionalPayment.Items.Add(status.StatusAdditionalPaymentRentalCarName);
                }
            }
        }

        void LoadStatusRentalCar()
        {
            var StatusRentalCarInfo = db.StatusRentalCars.ToList();
            if (StatusRentalCarInfo != null)
            {
                foreach (var status in StatusRentalCarInfo)
                {
                    statusRentalCar.Items.Add(status.StatusRentalCarName);
                }
            }
        }

        void AddRentalCar()
        {
            var transaction = db.Database.BeginTransaction();
            try
            {

                string[] splitCar = car.SelectedItem.ToString().Split('|');
                string[] splitClient = client.SelectedItem.ToString().Split('|');
                int countAdditionalService = 0, countRentalCar = db.pc_AddRentalCar(Convert.ToInt32(splitCar[0]), Convert.ToInt32(splitClient[0]), rentalCarTake.Value, rentalCarReturn.Value, Convert.ToInt32(itogSumma.Text), Convert.ToInt32(itogSummaAS.Text), Convert.ToDecimal(DriverBD.Rows[0].Cells[1].Value.ToString()));
                for (int i = 0; i < AdditionalServiceBD.Rows.Count - 1; i++)
                {
                    countAdditionalService += db.pc_AddAdditionalServicesOnOrder(AdditionalServiceBD.Rows[i].Cells[0].Value.ToString());
                }
                if (countRentalCar >= 1 && countAdditionalService >= 1)
                {
                    transaction.Commit();
                    MessageBox.Show("Добавление прошло успешно!");
                    RentalCars rentalCars = new RentalCars();
                    rentalCars.Show();
                    this.Close();
                }
                else { transaction.Rollback(); MessageBox.Show("Добавление прошло безуспешно!"); }

            }
            catch (Exception ex) { transaction.Rollback(); MessageBox.Show($"{ex}"); }
        }
        void EditRentalCarWithPay()
        {
            try
            {
                int count = db.pc_UpdateRentalCarWithPay(idRentalCar, rentalCarReturn.Value, Convert.ToInt32(itogSumma.Text), Convert.ToInt32(itogSummaAS.Text), db.StatusAdditionalPaymentRentalCars.Where(s => s.StatusAdditionalPaymentRentalCarName == statusAdditionalPayment.Text).FirstOrDefault().StatusAdditionalPaymentRentalCarId);
                if (count >= 2)
                {
                    MessageBox.Show("Изменение прошло успешно!");
                    RentalCars rentalCars = new RentalCars();
                    rentalCars.Show();
                    this.Close();
                }
                else { MessageBox.Show("Изменение прошло безуспешно!"); }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
        void EditRentalCarWithoutPay()
        {
            var transaction = db.Database.BeginTransaction();
            try
            {
                int count3 = 0;
                string[] splitCar = car.SelectedItem.ToString().Split('|');
                int count1 = db.pc_UpdateRentalCarWithoutPay(idRentalCar, Convert.ToInt32(splitCar[0]), db.StatusPaymentRentalCars.Where(s => s.StatusPaymentRentalCarName == statusPayment.Text).FirstOrDefault().StatusPaymentRentalCarId, rentalCarReturn.Value, Convert.ToDecimal(DriverBD.Rows[0].Cells[1].Value.ToString()), Convert.ToInt32(itogSumma.Text), Convert.ToInt32(itogSummaAS.Text));
                if (count1 >= 2)
                {
                    int count2 = db.pc_DeleteAdditionalServicesHasOrderForUpdateRentalCar(idRentalCar);
                    if (count2 >= 1)
                    {
                        for (int i = 0; i < AdditionalServiceBD.Rows.Count - 1; i++)
                        {
                            count3 += db.pc_AddAdditionalServicesOnOrder(AdditionalServiceBD.Rows[i].Cells[0].Value.ToString());
                        }
                        if (count3 >= 1)
                        {
                            transaction.Commit();
                            MessageBox.Show("Изменение прошло успешно!");
                            RentalCars rentalCars = new RentalCars();
                            rentalCars.Show();
                            this.Close();
                        }
                        else transaction.Rollback();
                    }
                    else transaction.Rollback();
                }
                else { transaction.Rollback(); MessageBox.Show("Изменение прошло безуспешно!"); }
            }
            catch (Exception ex) { transaction.Rollback(); MessageBox.Show($"{ex}"); }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            RentalCars rentalCars = new RentalCars();
            rentalCars.Show();
            this.Close();
        }
        private void infoClientButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Если клиента нет в данном списке,\n то нужно вернуться в меню,\n далее в раздел клиентов и добавить его,\n а затем вернуться сюда и продолжить добавление заказа!");
        }
        public void LoadDriver()
        {
            try
            {
                var DriverInfo = db.fc_OutputDriverOneRentalCar(idRentalCar).ToList();
                if (DriverInfo != null)
                {
                    foreach (var driver in DriverInfo)
                    {
                        DriverBD.Rows.Add(driver.DriverFullName, driver.DriverDriverLicenseNumber, driver.DriverPricePerDay);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }

        private void addAdditionalService_Click(object sender, EventArgs e)
        {
            if (additionalServices.SelectedIndex != -1)
            {
                if (AdditionalServiceBD.Rows.Count - 1 == 0) { string[] split = additionalServices.SelectedItem.ToString().Split('|'); AdditionalServiceBD.Rows.Add(split[0], split[1]); CalculateSumDP(); CalculateSumMain(); }
                else
                {
                    int checkWithoutAdditionalService = 0;
                    if (additionalServices.SelectedItem.ToString() == $"Без услуг|0") { checkWithoutAdditionalService++; }
                    if (checkWithoutAdditionalService == 0)
                    {
                        int checkDuplicate = 0;
                        for (int i = 0; i < AdditionalServiceBD.Rows.Count - 1; i++)
                        {
                            if (additionalServices.SelectedItem.ToString() == $"{AdditionalServiceBD.Rows[i].Cells[0].Value.ToString()}|{AdditionalServiceBD.Rows[i].Cells[1].Value.ToString()}") { checkDuplicate++; }
                        }
                        if (checkDuplicate == 0)
                        {
                            if (AdditionalServiceBD.Rows[0].Cells[0].Value.ToString() != "Без услуг") { string[] split = additionalServices.SelectedItem.ToString().Split('|'); AdditionalServiceBD.Rows.Add(split[0], split[1]); CalculateSumDP(); CalculateSumMain(); }
                            else { MessageBox.Show("Выбран пункт Без услуг, если вы хотите добавить услугу, удалите пункт Без услуг"); }
                        }
                        else { MessageBox.Show("Услугу можно взять всего лишь один раз на прокат!"); }
                    }
                    else MessageBox.Show("Пункт Без услуг нельзя добавить, если уже выбраны услуги!");
                }
            }
            else { MessageBox.Show("Выберите услугу!"); }
        }

        private void delAdditionalService_Click(object sender, EventArgs e)
        {
            if (AdditionalServiceBD.Rows.Count - 1 != AdditionalServiceBD.CurrentRow.Index)
            {
                AdditionalServiceBD.Rows.RemoveAt(AdditionalServiceBD.CurrentRow.Index);
                CalculateSumDP();
                CalculateSumMain();

            }
            else { MessageBox.Show("Выберите услугу для удаления"); }
        }

        private void addDriver_Click(object sender, EventArgs e)
        {
            if (drivers.SelectedIndex != -1)
            {
                if (DriverBD.Rows.Count - 1 == 0)
                {
                    string[] split = drivers.SelectedItem.ToString().Split('|'); DriverBD.Rows.Add(split[0], split[1], split[2]); CalculateSumDP();
                    CalculateSumMain();
                }
                else
                {
                    MessageBox.Show("В прокат можно только взять одного водителя или выбрать без водителя");
                }
            }
            else { MessageBox.Show("Выберите водителя!"); }
        }

        private void delDriver_Click(object sender, EventArgs e)
        {
            if (DriverBD.Rows.Count - 1 != DriverBD.CurrentRow.Index)
            {
                DriverBD.Rows.RemoveAt(DriverBD.CurrentRow.Index);
                CalculateSumDP();
                CalculateSumMain();

            }
            else { MessageBox.Show("Выберите водителя для удаления"); }
        }
        void LoadListDriver()
        {
            try
            {
                var DriverInfo = db.fc_OutputDriver();
                if (DriverInfo != null)
                {
                    foreach (var driver in DriverInfo)
                    {
                        drivers.Items.Add(driver.Drivers);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
        void LoadListAdditionalService()
        {
            try
            {
                var AdditionalInfo = db.fc_OutputAdditionalServices().ToList();
                if (AdditionalInfo != null)
                {
                    foreach (var additional in AdditionalInfo)
                    {
                        additionalServices.Items.Add(additional.AdditionalServices);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }

        private void AddAndEditRentalCar_Load(object sender, EventArgs e)
        {
            LoadListDriver();
            LoadListAdditionalService();
        }

        public void LoadAdditionalService()
        {
            try
            {
                var AdditionalInfo = db.fc_OutputAdditionalServicesOneRentalCar(idRentalCar).ToList();
                if (AdditionalInfo != null)
                {
                    foreach (var additional in AdditionalInfo)
                    {
                        AdditionalServiceBD.Rows.Add(additional.AdditionalServiceName, additional.AdditionalServicePrice);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
        void LoadClient()
        {
            try
            {
                var ClientInfo = db.fc_OutputClientAndPassportNumberAndDriverLicense().ToList();
                if (ClientInfo != null)
                {
                    foreach (var clients in ClientInfo)
                    {
                        client.Items.Add(clients.ClientFullNameAndPassportNumberAndHaveDriverLicense);
                        if (idRentalCar != 0) { if (clients.ClientFullNameAndPassportNumberAndHaveDriverLicense == clientName) { client.SelectedIndex = client.Items.Count - 1; } }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }

        private void rentalCarTake_ValueChanged(object sender, EventArgs e)
        {
            if (car.SelectedIndex != -1)
            {
                CheckBusyCar();
                dateStart = rentalCarTake.Value;
                CalculateSumDP();
                CalculateSumMain();
            }
            else { MessageBox.Show("Выберите машину"); rentalCarTake.Value = dateStart; }
        }
        private void rentalCarReturn_ValueChanged(object sender, EventArgs e)
        {
            if (car.SelectedIndex != -1)
            {
                CheckBusyCar();
                dateEnd = rentalCarReturn.Value;
                CalculateSumDP();
                CalculateSumMain();

            }
            else { MessageBox.Show("Выберите машину"); rentalCarReturn.Value = dateEnd; }
        }

        private void AdditionalServiceBD_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalculateSumDP();
            CalculateSumMain();
        }

        private void AdditionalServiceBD_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalculateSumDP();
            CalculateSumMain();
        }

        private void DriverBD_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalculateSumDP();
            CalculateSumMain();
        }

        private void DriverBD_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalculateSumDP();
            CalculateSumMain();
        }

        void CalculateSumDP()
        {
            itogSummaAS.Text = "0";
            if (AdditionalServiceBD.Rows.Count - 1 != 0) { for (int i = 0; i < AdditionalServiceBD.Rows.Count - 1; i++) { int yclygaPrice = Convert.ToInt32(AdditionalServiceBD.Rows[i].Cells[1].Value); itogSummaAS.Text = (Convert.ToInt32(itogSummaAS.Text) + yclygaPrice).ToString(); } }
            if (DriverBD.Rows.Count - 1 != 0) { TimeSpan timeSpan = dateEnd - dateStart; int voditelPrice = Convert.ToInt32(DriverBD.Rows[0].Cells[2].Value); itogSummaAS.Text = (Convert.ToInt32(itogSummaAS.Text) + voditelPrice * (timeSpan.Days + 1)).ToString(); }
        }
        void CalculateSumMain()
        {
            itogSumma.Text = "0";
            if (car.SelectedIndex != -1) { TimeSpan timeSpan = dateEnd - dateStart; string[] split = car.SelectedItem.ToString().Split('|'); itogSumma.Text = (Convert.ToInt32(itogSumma.Text) + Convert.ToInt32(split[3]) * (timeSpan.Days + 1)).ToString(); }
            itogSumma.Text = (Convert.ToInt32(itogSumma.Text) + Convert.ToInt32(itogSummaAS.Text)).ToString();
        }
        private void status_Click(object sender, EventArgs e)
        {
            if (status.Text == "-") { MessageBox.Show("Машина заказана в каком-то дне из этого промежутка!"); }
            if (status.Text == "+") { MessageBox.Show("Машина свободна!"); }
        }
        private void car_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] split = car.SelectedItem.ToString().Split('|');
            idCar = Convert.ToInt32(split[0]);
            CheckBusyCar();
            CalculateSumDP();
            CalculateSumMain();
        }

        private void statusAdditionalPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statusAdditionalPayment.SelectedItem.ToString() == "Отсутствует дополнительная оплата" && statusAdditionalPayment.Enabled == true) { MessageBox.Show("Самому нельзя выбирать данный пункт, это выбирается автоматически программой,\nкогда у клиента при возврате сумма оплаты отличается с уже оплаченной"); statusAdditionalPayment.SelectedIndex = 1; }
        }

        void LoadCar()
        {
            try
            {
                var CarInfo = db.fc_OutputCatalogCarIdAndBrandAndModelAndPricePerDay().ToList();
                if (CarInfo != null)
                {
                    foreach (var cars in CarInfo)
                    {
                        car.Items.Add(cars.CatalogCarIdAndBrandAndModelAndPricePerDay);
                        if (idRentalCar != 0) { if (cars.CatalogCarIdAndBrandAndModelAndPricePerDay == carName) { car.SelectedIndex = car.Items.Count - 1; } }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }

        void LoadOneClient()
        {
            try
            {
                var ClientInfo = db.fc_OutputOneClientForRentalCar(idRentalCar).ToList().FirstOrDefault();
                if (ClientInfo != null)
                {
                    carName = ClientInfo.CatalogCarIdAndBrandAndModelAndPricePerDay;
                    clientName = ClientInfo.ClientFullNameAndPassportNumberAndHaveDriverLicense;
                    itogSumma.Text = ClientInfo.RentalCarFullPriceNow.ToString();
                    dateStart = ClientInfo.RentalCarRentalDateCar;
                    dateEnd = ClientInfo.RentalCarReturnDate;
                    itogSummaAS.Text = ClientInfo.AdditionalServicesOnOrderFullPriceOnOrder.ToString();
                    statusAdditionalPayment.SelectedIndex = statusAdditionalPayment.Items.IndexOf(db.StatusAdditionalPaymentRentalCars.Where(s => s.StatusAdditionalPaymentRentalCarId == ClientInfo.StatusAdditionalPaymentRentalCarId).FirstOrDefault().StatusAdditionalPaymentRentalCarName);
                    statusPayment.SelectedIndex = statusPayment.Items.IndexOf(db.StatusPaymentRentalCars.Where(s => s.StatusPaymentRentalCarId == ClientInfo.StatusPaymentRentalCarId).FirstOrDefault().StatusPaymentRentalCarName);
                    statusRentalCar.SelectedIndex = statusRentalCar.Items.IndexOf(db.StatusRentalCars.Where(s => s.StatusRentalCarId == ClientInfo.StatusRentalCarId).FirstOrDefault().StatusRentalCarName);
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }

        void CheckBusyCar()
        {
            try
            {
                var CarBusyInfo = db.fc_OutputBusyCarStatus(idCar).ToList().FirstOrDefault();
                if (CarBusyInfo != null)
                {
                    if (CarBusyInfo.Status == 0) { status.ForeColor = Color.Red; status.Text = "-"; addRentalCarButton.Enabled = false; }
                    else { status.ForeColor = Color.Green; status.Text = "+"; addRentalCarButton.Enabled = true; }
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
    }
}
