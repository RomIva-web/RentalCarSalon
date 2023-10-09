using CAR_RENTAL.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace CAR_RENTAL.Forms
{
    public partial class RentalCars : Form
    {
        CarRentalSalonEntities db = new CarRentalSalonEntities();
        public RentalCars()
        {
            InitializeComponent();
        }

        private void TimeNow_Tick(object sender, EventArgs e)
        {
            TimeNow.Interval = 1000;
            TimeText.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }

        private void BackMenu_Click(object sender, EventArgs e)
        {
            MenuForEmployee menuForEmployee = new MenuForEmployee();
            menuForEmployee.Show();
            this.Close();
        }

        private void RentalCars_Load(object sender, EventArgs e)
        {
            if (UserAuthorization.Role == 1) { RentalCarBD.Visible = false; checkRentalCarButton.Visible = false; addRentalCarButton.Visible = false; delRentalCarButton.Visible = false; editRentalCarButton.Visible = false; brandSearch.Visible = false; modelSearch.Visible = false; fullNameSearch.Visible = false; sortType.Visible = false; rentalCarTake.Visible = false; rentalCarReturn.Visible = false; Text2.Visible = false; filtrDateButton.Visible = false; }
            if (UserAuthorization.Role == 2) { checkRentalCarButton.Visible = true; addRentalCarButton.Visible = true; }
            if (UserAuthorization.Role == 3) { checkRentalCarButton.Visible = true; addRentalCarButton.Visible = true; delRentalCarButton.Visible = true; editRentalCarButton.Visible = true; }
            if (UserAuthorization.Role == 4) { checkRentalCarButton.Visible = true; addRentalCarButton.Visible = true; delRentalCarButton.Visible = true; editRentalCarButton.Visible = true; }
            sortType.Items.Add("Без сортировки цены");
            sortType.Items.Add("По убыванию цены");
            sortType.Items.Add("По возрастанию цены");
            sortType.SelectedIndex = 0;
        }

        private void brandSearch_TextChanged(object sender, EventArgs e)
        {
            RentalCarBD.Rows.Clear();
            if (Text2.ForeColor == Color.Red) LoadRentalCarWithoutTime();
            if (Text2.ForeColor == Color.Green) LoadRentalCarWithTime();
        }

        private void modelSearch_TextChanged(object sender, EventArgs e)
        {
            RentalCarBD.Rows.Clear();
            if (Text2.ForeColor == Color.Red) LoadRentalCarWithoutTime();
            if (Text2.ForeColor == Color.Green) LoadRentalCarWithTime();
        }

        private void fullNameSearch_TextChanged(object sender, EventArgs e)
        {
            RentalCarBD.Rows.Clear();
            if (Text2.ForeColor == Color.Red) LoadRentalCarWithoutTime();
            if (Text2.ForeColor == Color.Green) LoadRentalCarWithTime();
        }

        private void sortType_SelectedIndexChanged(object sender, EventArgs e)
        {
            RentalCarBD.Rows.Clear();
            if (Text2.ForeColor == Color.Red) LoadRentalCarWithoutTime();
            if (Text2.ForeColor == Color.Green) LoadRentalCarWithTime();
        }

        private void rentalCarTake_ValueChanged(object sender, EventArgs e)
        {
            if (Text2.ForeColor == Color.Green)
            {
                RentalCarBD.Rows.Clear();
                LoadRentalCarWithTime();
            }
        }

        private void rentalCarReturn_ValueChanged(object sender, EventArgs e)
        {
            if (Text2.ForeColor == Color.Green)
            {
                RentalCarBD.Rows.Clear();
                LoadRentalCarWithTime();
            }
        }

        private void checkRentalCarButton_Click(object sender, EventArgs e)
        {
            if (RentalCarBD.CurrentRow.Index != RentalCarBD.Rows.Count - 1)
            {
                RentalCarInfo prokatInfo = new RentalCarInfo((int)RentalCarBD.Rows[RentalCarBD.CurrentRow.Index].Cells[0].Value);
                prokatInfo.Show();
                this.Close();
            }
            else MessageBox.Show("Выберите заказ!");
        }

        private void addRentalCarButton_Click(object sender, EventArgs e)
        {
            AddAndEditRentalCar addAndEditProkat = new AddAndEditRentalCar();
            addAndEditProkat.Show();
            this.Close();
        }

        private void delRentalCarButton_Click(object sender, EventArgs e)
        {
            if (RentalCarBD.CurrentRow.Index >= 0)
            {
                DialogResult dialogResult = MessageBox.Show($"Вы уверены, что хотите удалить прокат у {RentalCarBD.Rows[RentalCarBD.CurrentRow.Index].Cells[2].Value}", "Предупреждение!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        int count = db.pc_DeleteRentalCar(Convert.ToInt32(RentalCarBD.Rows[RentalCarBD.CurrentRow.Index].Cells[0].Value));
                        if (count >= 1) { MessageBox.Show("Удаление прошло успешно!"); }
                        else { MessageBox.Show("Удаление прошло безуспешно!"); }
                        RentalCarBD.Rows.Clear();
                        if (Text2.ForeColor == Color.Red) LoadRentalCarWithoutTime();
                        if (Text2.ForeColor == Color.Green) LoadRentalCarWithTime();
                    }
                    catch (Exception ex) { MessageBox.Show($"{ex}"); }
                }
            }
            else MessageBox.Show("Чтобы удалить прокат, нужно выделить нужную вам строку и затем нажать на эту же кнопку");
        }

        private void editRentalCarButton_Click(object sender, EventArgs e)
        {
            string str = RentalCarBD.Rows[RentalCarBD.CurrentRow.Index].Cells[4].Value.ToString();
            TimeSpan timeSpan = DateTime.Now.Date - Convert.ToDateTime(str);
            if (RentalCarBD.Rows[RentalCarBD.CurrentRow.Index].Cells[5].Value.ToString() != "Отмена оплаты")
            {
                if (!((RentalCarBD.Rows[RentalCarBD.CurrentRow.Index].Cells[6].Value.ToString() == "Отсутствует дополнительная оплата" || RentalCarBD.Rows[RentalCarBD.CurrentRow.Index].Cells[6].Value.ToString() == "Дополнительная оплата принята") && RentalCarBD.Rows[RentalCarBD.CurrentRow.Index].Cells[7].Value.ToString() == "Возвращена" && RentalCarBD.Rows[RentalCarBD.CurrentRow.Index].Cells[5].Value.ToString() == "Оплата принята"))
                {
                        AddAndEditRentalCar addAndEditProkat = new AddAndEditRentalCar((int)RentalCarBD.Rows[RentalCarBD.CurrentRow.Index].Cells[0].Value);
                        addAndEditProkat.Show();
                        this.Close(); 
                }
                else MessageBox.Show("У данного проката отсутствует дополнительная оплата или дополнительная оплата принята и возвращена машина!");
            }
            else MessageBox.Show("Данный прокат был отменён!");
        }
        private void filtrDateButton_Click(object sender, EventArgs e)
        {
            RentalCarBD.Rows.Clear();
            if (Text2.ForeColor == Color.Red) { Text2.ForeColor = Color.Green; Text2.Text = "Активен"; LoadRentalCarWithTime(); return; }
            if (Text2.ForeColor == Color.Green) { Text2.ForeColor = Color.Red; Text2.Text = "Не активен"; LoadRentalCarWithoutTime(); return; }
        }

        private void Text2_TextChanged(object sender, EventArgs e)
        {
            RentalCarBD.Rows.Clear();
            if (Text2.ForeColor == Color.Red) LoadRentalCarWithoutTime();
            if (Text2.ForeColor == Color.Green) LoadRentalCarWithTime();
        }
        void LoadRentalCarWithoutTime()
        {
            RentalCarBD.Rows.Clear();
            try
            {
                var RentalInfo = db.pc_OutputRentalCarWithoutDate(brandSearch.Text, modelSearch.Text, fullNameSearch.Text, sortType.SelectedIndex + 1).ToList();
                if (RentalInfo != null)
                {
                    foreach (var rental in RentalInfo)
                    {
                        RentalCarBD.Rows.Add(rental.RentalCarId, rental.CatalogCarBrandAndModel, rental.ClientFullName, rental.RentalCarRentalDateCar.ToShortDateString(), rental.RentalCarReturnDate.ToShortDateString(), rental.StatusPaymentRentalCarName, rental.StatusAdditionalPaymentRentalCarName, rental.StatusRentalCarName, rental.RentalCarFullPriceNow, rental.RentalCarFullPricePay);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
        void LoadRentalCarWithTime()
        {
            RentalCarBD.Rows.Clear();
            try
            {
                var RentalInfo = db.pc_OutputRentalCarWithDate(brandSearch.Text, modelSearch.Text, fullNameSearch.Text, sortType.SelectedIndex + 1, rentalCarTake.Value, rentalCarReturn.Value).ToList();
                if (RentalInfo != null)
                {
                    foreach (var rental in RentalInfo)
                    {
                        RentalCarBD.Rows.Add(rental.RentalCarId, rental.CatalogCarBrandAndModel, rental.ClientFullName, rental.RentalCarRentalDateCar.ToShortDateString(), rental.RentalCarReturnDate.ToShortDateString(), rental.StatusPaymentRentalCarName, rental.StatusAdditionalPaymentRentalCarName, rental.StatusRentalCarName, rental.RentalCarFullPriceNow, rental.RentalCarFullPricePay);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }

        private void addAndEditTypeCarDamageOnRentalCarButton_Click(object sender, EventArgs e)
        {
            if (RentalCarBD.CurrentRow.Index != -1)
            {
                if (RentalCarBD.CurrentRow.Index != RentalCarBD.Rows.Count - 1)
                {
                    if (RentalCarBD.Rows[RentalCarBD.CurrentRow.Index].Cells[7].Value.ToString() == "Выдана")
                    {
                        if (RentalCarBD.Rows[RentalCarBD.CurrentRow.Index].Cells[6].Value.ToString() != "Дополнительная оплата принята")
                        {
                            EditTypeCarDamageOnRentalCar editTypeCarDamageOnRentalCar = new EditTypeCarDamageOnRentalCar(Convert.ToInt32(RentalCarBD.Rows[RentalCarBD.CurrentRow.Index].Cells[0].Value));
                            editTypeCarDamageOnRentalCar.Show();
                            this.Close();
                        }
                        else MessageBox.Show("У заказа оплачена дополнительная оплата!");
                    }
                    else MessageBox.Show("Машина возвращена или ожидает выдачи, повреждения нельзя изменять!");
                }
                else MessageBox.Show("Выберите заказ!");
            }
            else MessageBox.Show("Выберите заказ!");
        }

        private void printContractReturnCarButton_Click(object sender, EventArgs e)
        {
            if (RentalCarBD.CurrentRow.Index != -1)
            {
                if (RentalCarBD.Rows[RentalCarBD.CurrentRow.Index].Cells[7].Value.ToString() == "Выдана")
                {
                    if (RentalCarBD.Rows[RentalCarBD.CurrentRow.Index].Cells[6].Value.ToString() == "Дополнительная оплата принята" || RentalCarBD.Rows[RentalCarBD.CurrentRow.Index].Cells[6].Value.ToString() == "Отсутствует дополнительная оплата")
                    {
                        DialogResult dialogResult = MessageBox.Show($"Вы уверены, что хотите распечатать договор?\nУбедитесь, что все повреждения и штрафы проверены и добавлены на заказ!\nДанное действие необратимо и вы не сможете больше изменять эти данные в заказе!", "Предупреждение!", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            string[] idAdditionalServices, nameAddionalServices, priceAdditionalServices, idFines, nameFines, dateReceiptFines, priceFines,idDamages,nameDamages,amountDamages,priceDamages ;
                            int fullPriceFine = 0, fullPricePaymentNow = 0, fullPriceAdditionalServicesOnOrderNow = 0;
                            var DataRentalCar = db.fc_GetDataRentalCarForPrint(Convert.ToInt32(RentalCarBD.Rows[RentalCarBD.CurrentRow.Index].Cells[0].Value)).FirstOrDefault();
                            var DataRentalCarAdditionalService = db.fc_GetDataRentalCarAdditionalServicesForPrint(Convert.ToInt32(RentalCarBD.Rows[RentalCarBD.CurrentRow.Index].Cells[0].Value)).ToArray();
                            if (DataRentalCarAdditionalService != null)
                            {
                                int count = DataRentalCarAdditionalService.Count(), check = 0;
                                idAdditionalServices = new string[count];
                                nameAddionalServices = new string[count];
                                priceAdditionalServices = new string[count];
                                foreach (var data in DataRentalCarAdditionalService)
                                {
                                    idAdditionalServices[check] = data.AdditionalServiceId.ToString();
                                    nameAddionalServices[check] = data.AdditionalServiceName;
                                    priceAdditionalServices[check] = data.AdditionalServicePrice.ToString();
                                    check++;
                                }
                            }
                            else
                            {
                                idAdditionalServices = new string[1];
                                nameAddionalServices = new string[1];
                                priceAdditionalServices = new string[1];
                            }
                            var DataRentalCarDamage = db.fc_OutputTypeCarDamageOnRentalCar(Convert.ToInt32(RentalCarBD.Rows[RentalCarBD.CurrentRow.Index].Cells[0].Value));
                            if (DataRentalCarDamage != null)
                            {
                                int count = DataRentalCarDamage.Count(), check = 0;
                                idDamages = new string[count];
                                nameDamages = new string[count];
                                amountDamages = new string[count];
                                priceDamages = new string[count];
                                foreach (var data in DataRentalCarDamage)
                                {
                                    idDamages[check] = data.TypeCarDamageId.ToString();
                                    nameDamages[check] = data.TypeCarDamageName;
                                    amountDamages[check] = data.ReturnCarHaveDamageAmount.ToString();
                                    priceDamages[check] = data.TypeCarDamagePrice.ToString();
                                    check++;
                                }
                            }
                            else
                            {
                                idDamages = new string[1]; 
                                nameDamages = new string[1];  
                                amountDamages = new string[1]; 
                                priceDamages = new string[1];
                            }
                            var DataRentalCarFine = db.fc_OutputFineOnRentalCarForPrint(Convert.ToInt32(RentalCarBD.Rows[RentalCarBD.CurrentRow.Index].Cells[0].Value));
                            if(DataRentalCarFine.Count() >= 1)
                            {
                                int count = DataRentalCarFine.Count(), check = 0;
                                idFines = new string[count];
                                nameFines = new string[count];
                                dateReceiptFines = new string[count];
                                priceFines = new string[count];
                                foreach (var data in DataRentalCarFine)
                                {
                                    idFines[check] = data.FineId.ToString();
                                    nameFines[check] = data.NameFineName;
                                    dateReceiptFines[check] = data.FineReceiptDate.ToShortDateString();
                                    priceFines[check] = data.FinePrice.ToString();
                                    check++;
                                }
                            }
                            else
                            {
                                idFines = new string[1];
                                idFines[0] = "0";
                                nameFines = new string[1];
                                nameFines[0] = "Без штрафов";
                                dateReceiptFines = new string[1];
                                dateReceiptFines[0] = DateTime.Now.ToShortDateString();
                                priceFines = new string[1];
                                priceFines[0] = "0";
                            }
                            var DataRentalCarItogSumAdditionalService = db.fc_GetDataRentalCarItogSumAdditionalServicesForPrint(Convert.ToInt32(RentalCarBD.Rows[RentalCarBD.CurrentRow.Index].Cells[0].Value)).FirstOrDefault();
                            var DataFullPriceFineOnRentalCar = db.fc_GetFullPriceFineOnRentalCar(Convert.ToInt32(RentalCarBD.Rows[RentalCarBD.CurrentRow.Index].Cells[0].Value)).FirstOrDefault();
                            if (DataFullPriceFineOnRentalCar != null)
                            {
                                fullPriceFine = Convert.ToInt32(DataFullPriceFineOnRentalCar.FullPriceFineOnRentalCar);
                            }
                            else fullPriceFine = 0;
                            var DataFullPriceDamageOnRentalCardb = db.fc_GetFullPriceDamageOnRentalCar(Convert.ToInt32(RentalCarBD.Rows[RentalCarBD.CurrentRow.Index].Cells[0].Value)).FirstOrDefault();
                            int daysRental = (DateTime.Now - DataRentalCar.RentalCarRentalDateCar).Days + 1;
                            if (DataRentalCar.DriverId != 1)
                            {
                                fullPricePaymentNow = Convert.ToInt32(daysRental * DataRentalCar.DriverPricePerDay + daysRental * DataRentalCar.CatalogCarPricePerDay + DataRentalCarItogSumAdditionalService.ItogSumAdditionalServices);
                                fullPriceAdditionalServicesOnOrderNow = Convert.ToInt32(daysRental * DataRentalCar.DriverPricePerDay + DataRentalCarItogSumAdditionalService.ItogSumAdditionalServices);
                                var helper = new WordsHelper("../../Contracts/ReturnWithDriver/TemplateActContactReturnCarWithDriver.doc");
                                var items = new Dictionary<string, string>
                                {
                                    { "<IDRENTALCAR>", DataRentalCar.RentalCarId.ToString()},
                                    { "<DATERENTALCAR>", DataRentalCar.RentalCarRentalDateCar.ToShortDateString()},
                                    { "<DATERETURNCAR>", DateTime.Now.ToShortDateString()},
                                    { "<IDCAR>", DataRentalCar.CatalogCarId.ToString()},
                                    { "<NAMECAR>",DataRentalCar.CarName},
                                    { "<PRICEPERDAYCAR>", DataRentalCar.CatalogCarPricePerDay.ToString()},
                                    { "<ITOGPRICEPERDAYCAR>", (daysRental * DataRentalCar.CatalogCarPricePerDay).ToString()},
                                    { "<IDDRIVERT>", DataRentalCar.DriverId.ToString()},
                                    { "<FULLNAMEDRIVER>", DataRentalCar.DriverFullName},
                                    { "<CLIENTFULLNAME>" , DataRentalCar.ClientFullName},
                                    { "<DRIVERLICENSE>", DataRentalCar.DriverDriverLicenseNumber.ToString()},
                                    { "<PRICEPERDAYDRIVERT>", DataRentalCar.DriverPricePerDay.ToString()},
                                    { "<ITOGPRICEPERDAYDRIVERT>", (daysRental * DataRentalCar.DriverPricePerDay).ToString()},
                                    { "<ITOGPRICEADDITIONALPRICE>",DataRentalCarItogSumAdditionalService.ItogSumAdditionalServices.ToString()},
                                    { "<ITOGPRICERENTALCAR>",DataRentalCar.RentalCarFullPriceNow.ToString()},
                                    { "<ITOGPRICERENTALCARPAY>", DataRentalCar.RentalCarFullPricePay.ToString()},
                                    { "<ITOGPRICERENTALCARNOW>", fullPricePaymentNow.ToString()},
                                    { "<ITOGPRICE>", (fullPricePaymentNow - DataRentalCar.RentalCarFullPricePay).ToString()}
                                };
                                helper.ProcessReturnCarWithDamage(items, DataRentalCar.RentalCarId, DataRentalCar.CarName, idAdditionalServices, nameAddionalServices, priceAdditionalServices);
                                db.pc_UpdateRentalCarStatusRentalCar(DataRentalCar.RentalCarId, 3);
                                if (fullPricePaymentNow - DataRentalCar.RentalCarFullPricePay == 0)  db.pc_UpdateRentalCarWithAdditionalPayment(DataRentalCar.RentalCarId, DateTime.Now, fullPricePaymentNow, fullPriceAdditionalServicesOnOrderNow, 1); 
                                else db.pc_UpdateRentalCarWithAdditionalPayment(DataRentalCar.RentalCarId, DateTime.Now, fullPricePaymentNow, fullPriceAdditionalServicesOnOrderNow, 2);
                                RentalCarBD.Rows.Clear();
                                if (Text2.ForeColor == Color.Red) LoadRentalCarWithoutTime();
                                if (Text2.ForeColor == Color.Green) LoadRentalCarWithTime();
                                MessageBox.Show("Готово");
                            }
                            else
                            {
                                fullPricePaymentNow = Convert.ToInt32(daysRental * DataRentalCar.DriverPricePerDay + daysRental * DataRentalCar.CatalogCarPricePerDay + DataRentalCarItogSumAdditionalService.ItogSumAdditionalServices);
                                var helper = new WordsHelper("../../Contracts/ReturnWithoutDriver/TemplateActContactReturnCarWithoutDriver.doc");
                                var items = new Dictionary<string, string>
                                {
                                    { "<IDRENTALCAR>", DataRentalCar.RentalCarId.ToString()},
                                    { "<DATERENTALCAR>", DataRentalCar.RentalCarRentalDateCar.ToShortDateString()},
                                    { "<DATERETURNCAR>", DateTime.Now.ToShortDateString()},
                                    { "<IDCAR>", DataRentalCar.CatalogCarId.ToString()},
                                    { "<NAMECAR>",DataRentalCar.CarName},
                                    { "<PRICEPERDAYCAR>", DataRentalCar.CatalogCarPricePerDay.ToString()},
                                    { "<ITOGPRICEPERDAYCAR>", (daysRental * DataRentalCar.CatalogCarPricePerDay).ToString()},
                                    { "<ITOGPRICEADDITIONALPRICE>",DataRentalCarItogSumAdditionalService.ItogSumAdditionalServices.ToString()},
                                    { "<CLIENTFULLNAME>" , DataRentalCar.ClientFullName},
                                    { "<ITOGPRICERENTALCAR>",DataRentalCar.RentalCarFullPriceNow.ToString()},
                                    { "<ITOGPRICERENTALCARPAY>", DataRentalCar.RentalCarFullPricePay.ToString()},
                                    { "<ITOGPRICERENTALCARNOW>", (fullPricePaymentNow + DataFullPriceDamageOnRentalCardb.FullPriceDamageOnRentalCar + fullPriceFine).ToString()},
                                    { "<ITOGPRICE>", (fullPricePaymentNow - DataRentalCar.RentalCarFullPricePay + DataFullPriceDamageOnRentalCardb.FullPriceDamageOnRentalCar + fullPriceFine).ToString()},
                                    { "<ITOGPRICEFINEPRICE>", fullPriceFine.ToString()},
                                    { "<ITOGPRICEDAMAGEPRICE>",DataFullPriceDamageOnRentalCardb.FullPriceDamageOnRentalCar.ToString()}
                                };

                                helper.ProcessReturnCarWithoutDriver(items, DataRentalCar.RentalCarId, DataRentalCar.CarName, idAdditionalServices, nameAddionalServices, priceAdditionalServices, idFines, nameFines, dateReceiptFines, priceFines, idDamages, nameDamages, amountDamages, priceDamages);
                                db.pc_UpdateRentalCarStatusRentalCar(DataRentalCar.RentalCarId, 3);
                                if (fullPricePaymentNow - DataRentalCar.RentalCarFullPricePay + DataFullPriceDamageOnRentalCardb.FullPriceDamageOnRentalCar + fullPriceFine == 0) db.pc_UpdateRentalCarWithAdditionalPayment(DataRentalCar.RentalCarId, DateTime.Now, fullPricePaymentNow + DataFullPriceDamageOnRentalCardb.FullPriceDamageOnRentalCar + fullPriceFine, fullPriceAdditionalServicesOnOrderNow, 1);
                                else db.pc_UpdateRentalCarWithAdditionalPayment(DataRentalCar.RentalCarId, DateTime.Now, fullPricePaymentNow + DataFullPriceDamageOnRentalCardb.FullPriceDamageOnRentalCar + fullPriceFine, fullPriceAdditionalServicesOnOrderNow, 2);
                                RentalCarBD.Rows.Clear();
                                if (Text2.ForeColor == Color.Red) LoadRentalCarWithoutTime();
                                if (Text2.ForeColor == Color.Green) LoadRentalCarWithTime();
                                MessageBox.Show("Готово");
                            }
                        }
                    }
                    else MessageBox.Show("Дополнительная плата не оплачена!");
                }
                else MessageBox.Show("Машина уже возвращена или ожидает выдачи!");
            }
            else MessageBox.Show("Выберите заказ!");
        }

        private void checkContractReturnCarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (RentalCarBD.Rows[RentalCarBD.CurrentRow.Index].Cells[7].Value.ToString() == "Возвращена")
                {
                    var DataRentalCar = db.fc_GetDataRentalCarForPrint(Convert.ToInt32(RentalCarBD.Rows[RentalCarBD.CurrentRow.Index].Cells[0].Value)).FirstOrDefault();
                    string directory = "";
                    if (DataRentalCar.DriverId == 1) directory = "../../Contracts/ReturnWithoutDriver/";
                    else directory = "../../Contracts/ReturnWithDriver/";
                    if (File.Exists($"{directory}{DataRentalCar.CarName}_{DataRentalCar.RentalCarId}.doc"))
                    {
                        string fullPath = Path.GetFullPath($"{directory}{DataRentalCar.CarName}_{DataRentalCar.RentalCarId}.doc");
                        Process.Start(fullPath);
                    }
                    else MessageBox.Show("Договор не существует!");
                }
                else MessageBox.Show("Договор на данный заказ не распечатан, так как машина ещё выдана или ожидает выдачи!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void printContractIssuedCarButton_Click(object sender, EventArgs e)
        {
            if (RentalCarBD.CurrentRow.Index != -1)
            {
                if (RentalCarBD.Rows[RentalCarBD.CurrentRow.Index].Cells[7].Value.ToString() == "Ожидает выдачи")
                {
                    if (RentalCarBD.Rows[RentalCarBD.CurrentRow.Index].Cells[5].Value.ToString() == "Оплата принята")
                    {
                        DialogResult dialogResult = MessageBox.Show($"Вы уверены, что хотите распечатать договор?\nУбедитесь, что все услуги, водитель и машина выбраны правильно!\nДанное действие необратимо и вы не сможете больше изменять эти данные в заказе!", "Предупреждение!", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            string[] idAdditionalServices, nameAddionalServices, priceAdditionalServices;
                            var DataRentalCar = db.fc_GetDataRentalCarForPrint(Convert.ToInt32(RentalCarBD.Rows[RentalCarBD.CurrentRow.Index].Cells[0].Value)).FirstOrDefault();
                            var DataRentalCarAdditionalService = db.fc_GetDataRentalCarAdditionalServicesForPrint(Convert.ToInt32(RentalCarBD.Rows[RentalCarBD.CurrentRow.Index].Cells[0].Value)).ToArray();
                            if (DataRentalCarAdditionalService != null)
                            {
                                int count = DataRentalCarAdditionalService.Count(), check = 0;
                                idAdditionalServices = new string[count];
                                nameAddionalServices = new string[count];
                                priceAdditionalServices = new string[count];
                                foreach (var data in DataRentalCarAdditionalService)
                                {
                                    idAdditionalServices[check] = data.AdditionalServiceId.ToString();
                                    nameAddionalServices[check] = data.AdditionalServiceName;
                                    priceAdditionalServices[check] = data.AdditionalServicePrice.ToString();
                                    check++;
                                }
                            }
                            else
                            {
                                idAdditionalServices = new string[1];
                                nameAddionalServices = new string[1];
                                priceAdditionalServices = new string[1];
                            }
                            var DataRentalCarItogSumAdditionalService = db.fc_GetDataRentalCarItogSumAdditionalServicesForPrint(Convert.ToInt32(RentalCarBD.Rows[RentalCarBD.CurrentRow.Index].Cells[0].Value)).FirstOrDefault();
                            int daysRental = (DataRentalCar.RentalCarReturnDate - DataRentalCar.RentalCarRentalDateCar).Days + 1;
                            if (DataRentalCar.DriverId != 1)
                            {
                                var helper = new WordsHelper("../../Contracts/RentalWithDriver/TemplateActContactIssuedCarWithDriver.doc");
                                var items = new Dictionary<string, string>
                            {
                                { "<IDRENTALCAR>", DataRentalCar.RentalCarId.ToString()},
                                { "<DATERENTALCAR>", DataRentalCar.RentalCarRentalDateCar.ToShortDateString()},
                                { "<DATERETURNCAR>", DataRentalCar.RentalCarReturnDate.ToShortDateString()},
                                { "<IDCAR>", DataRentalCar.CatalogCarId.ToString()},
                                { "<NAMECAR>",DataRentalCar.CarName},
                                { "<PRICEPERDAYCAR>", DataRentalCar.CatalogCarPricePerDay.ToString()},
                                { "<ITOGPRICEPERDAYCAR>", (daysRental * DataRentalCar.CatalogCarPricePerDay).ToString()},
                                { "<IDDRIVERT>", DataRentalCar.DriverId.ToString()},
                                { "<FULLNAMEDRIVER>", DataRentalCar.DriverFullName},
                                { "<CLIENTFULLNAME>" , DataRentalCar.ClientFullName},
                                { "<DRIVERLICENSE>", DataRentalCar.DriverDriverLicenseNumber.ToString()},
                                { "<PRICEPERDAYDRIVERT>", DataRentalCar.DriverPricePerDay.ToString()},
                                { "<ITOGPRICEPERDAYDRIVERT>", (daysRental * DataRentalCar.DriverPricePerDay).ToString()},
                                { "<ITOGPRICEADDITIONALPRICE>",DataRentalCarItogSumAdditionalService.ItogSumAdditionalServices.ToString()},
                                { "<ITOGPRICERENTALCAR>",DataRentalCar.RentalCarFullPriceNow.ToString()}
                            };

                                helper.ProcessIssuedCar(items, DataRentalCar.RentalCarId, DataRentalCar.CarName, idAdditionalServices, nameAddionalServices, priceAdditionalServices);
                                db.pc_UpdateRentalCarStatusRentalCar(DataRentalCar.RentalCarId, 2);
                                RentalCarBD.Rows.Clear();
                                if (Text2.ForeColor == Color.Red) LoadRentalCarWithoutTime();
                                if (Text2.ForeColor == Color.Green) LoadRentalCarWithTime();
                                MessageBox.Show("Готово");
                            }
                            else
                            {
                                var helper = new WordsHelper("../../Contracts/RentalWithoutDriver/TemplateActContactIssuedCarWithoutDriver.doc");
                                var items = new Dictionary<string, string>
                            {
                                { "<IDRENTALCAR>", DataRentalCar.RentalCarId.ToString()},
                                { "<DATERENTALCAR>", DataRentalCar.RentalCarRentalDateCar.ToShortDateString()},
                                { "<DATERETURNCAR>", DataRentalCar.RentalCarReturnDate.ToShortDateString()},
                                { "<IDCAR>", DataRentalCar.CatalogCarId.ToString()},
                                { "<NAMECAR>",DataRentalCar.CarName},
                                { "<PRICEPERDAYCAR>", DataRentalCar.CatalogCarPricePerDay.ToString()},
                                { "<ITOGPRICEPERDAYCAR>", (daysRental * DataRentalCar.CatalogCarPricePerDay).ToString()},
                                { "<CLIENTFULLNAME>" , DataRentalCar.ClientFullName},
                                { "<ITOGPRICEADDITIONALPRICE>",DataRentalCarItogSumAdditionalService.ItogSumAdditionalServices.ToString()},
                                { "<ITOGPRICERENTALCAR>",DataRentalCar.RentalCarFullPriceNow.ToString()}
                            };

                                helper.ProcessIssuedCar(items, DataRentalCar.RentalCarId, DataRentalCar.CarName, idAdditionalServices, nameAddionalServices, priceAdditionalServices);
                                db.pc_UpdateRentalCarStatusRentalCar(DataRentalCar.RentalCarId, 2);
                                RentalCarBD.Rows.Clear();
                                if (Text2.ForeColor == Color.Red) LoadRentalCarWithoutTime();
                                if (Text2.ForeColor == Color.Green) LoadRentalCarWithTime();
                                MessageBox.Show("Готово");
                            }
                        }
                    }
                    else MessageBox.Show("Заказ не оплачен!");
                }
                else MessageBox.Show("Машина уже выдана!");
            }
            else MessageBox.Show("Выберите заказ!");
        }

        private void checkContractIssuedCarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (RentalCarBD.Rows[RentalCarBD.CurrentRow.Index].Cells[7].Value.ToString() != "Ожидает выдачи")
                {
                    var DataRentalCar = db.fc_GetDataRentalCarForPrint(Convert.ToInt32(RentalCarBD.Rows[RentalCarBD.CurrentRow.Index].Cells[0].Value)).FirstOrDefault();
                    string directory = "";
                    if (DataRentalCar.DriverId == 1) directory = "../../Contracts/RentalWithoutDriver/";
                    else directory = "../../Contracts/RentalWithDriver/";
                    if (File.Exists($"{directory}{DataRentalCar.CarName}_{DataRentalCar.RentalCarId}.doc"))
                    {
                        string fullPath = Path.GetFullPath($"{directory}{DataRentalCar.CarName}_{DataRentalCar.RentalCarId}.doc");
                        Process.Start(fullPath);
                    }
                    else MessageBox.Show("Договор не существует!");
                }
                else MessageBox.Show("Договор на данный заказ не распечатан, так как машина ещё ожидает выдачи!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void brandSearch_Enter(object sender, EventArgs e)
        {
            infoSearch1.Visible = false;
        }

        private void brandSearch_Leave(object sender, EventArgs e)
        {
            if (brandSearch.Text == "") infoSearch1.Visible = true;
        }

        private void infoSearch1_Click(object sender, EventArgs e)
        {
            infoSearch1.Visible = false;
            brandSearch.Focus();
        }

        private void modelSearch_Enter(object sender, EventArgs e)
        {
            infoSearch2.Visible = false;
        }

        private void modelSearch_Leave(object sender, EventArgs e)
        {
            if (modelSearch.Text == "") infoSearch2.Visible = true;
        }

        private void infoSearch2_Click(object sender, EventArgs e)
        {
            infoSearch2.Visible = false;
            modelSearch.Focus();
        }

        private void fullNameSearch_Enter(object sender, EventArgs e)
        {
            infoSearch3.Visible = false;
        }

        private void fullNameSearch_Leave(object sender, EventArgs e)
        {
            if (fullNameSearch.Text == "") infoSearch3.Visible = true;
        }

        private void infoSearch3_Click(object sender, EventArgs e)
        {
            infoSearch3.Visible = false;
            fullNameSearch.Focus();
        }
    }
}
