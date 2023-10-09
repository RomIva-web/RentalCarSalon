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
    public partial class AddAndEditFine : Form
    {
        int idFine = 0;
        DateTime dateStart, dateEnd, dateNow;
        CarRentalSalonEntities db = new CarRentalSalonEntities();
        public AddAndEditFine()
        {
            InitializeComponent();
            LoadFineName();
            OutputFIOIntruder();
            addFineButton.Visible = true;
            editFineButton.Visible = false;
            Text1.Text = "Добавление штрафа";
        }
        public AddAndEditFine(int idFine)
        {
            InitializeComponent();
            LoadFineName();
            this.idFine = idFine;
            addFineButton.Visible = false;
            editFineButton.Visible = true;
            Text3.Visible = false;
            Text4.Visible = false;
            Text5.Visible = false;
            FIOIntruder.Visible = false;
            brand.Visible = false;
            model.Visible = false;
            infoButton.Visible = true;
            LoadFine();
            Text1.Text = "Изменение штрафа";
        }
        private void TimeNow_Tick(object sender, EventArgs e)
        {
            TimeNow.Interval = 1000;
            TimeText.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }

        private void editFineButton_Click(object sender, EventArgs e)
        {
            if (fineName.SelectedIndex != -1 && price.Text != "")
            {
                editFine();
            }
            else MessageBox.Show("Заполните все поля!");
        }

        private void addFineButton_Click(object sender, EventArgs e)
        {
            if (fineName.SelectedIndex != -1 && price.Text != "" && FIOIntruder.SelectedIndex != -1 && brand.SelectedIndex != -1 && model.SelectedIndex != -1)
            {
                addFine();
            }
            else MessageBox.Show("Заполните все поля!");
        }
        void LoadFine()
        {
            try
            {
                var FineInfo = db.fc_OutputOneFine(idFine).ToList().FirstOrDefault();
                if(FineInfo != null)
                {
                    fineName.SelectedIndex = GetComboBoxIndexItem(fineName,db.NameFines.Where(f => f.NameFineId == FineInfo.NameFineId).FirstOrDefault().NameFineName);
                    dateStart = FineInfo.RentalCarRentalDateCar;
                    dateEnd = FineInfo.RentalCarReturnDate;
                    dateNow = FineInfo.FineReceiptDate;
                    fineReceipt.Value = FineInfo.FineReceiptDate;
                    price.Text = FineInfo.FinePrice.ToString();

                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }

        private int GetComboBoxIndexItem(ComboBox comboBox, string item)
        {
            for (int i = 0; i < comboBox.Items.Count; i++)
            {
                if (comboBox.Items[i].ToString() == item) { return i; }
            }
            return 0;
        }

        void addFine()
        {
            try
            {
                int count = db.pc_AddFine(fineReceipt.Value,db.NameFines.Where(f => f.NameFineName == fineName.Text).FirstOrDefault().NameFineId,Convert.ToInt32(price.Text), FIOIntruder.Text, brand.Text,model.Text);
                if (count >= 1) 
                { 
                    MessageBox.Show("Добавление прошло успешно!"); 
                    Fines fines = new Fines();
                    fines.Show();
                    this.Close();
                }
                else { MessageBox.Show("Добавление прошло безуспешно!"); }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
        void editFine()
        {
            try
            {
                int count = db.pc_UpdateFine(idFine, fineReceipt.Value, db.NameFines.Where(f => f.NameFineName == fineName.Text).FirstOrDefault().NameFineId,Convert.ToInt32(price.Text));
                if (count >= 1) 
                { 
                    MessageBox.Show("Изменение прошло успешно!"); 
                    Fines fines = new Fines();
                    fines.Show();
                    this.Close();
                }
                else { MessageBox.Show("Изменение прошло безуспешно!"); }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Fines fines = new Fines();
            fines.Show();
            this.Close();
        }

        private void fineReceipt_ValueChanged(object sender, EventArgs e)
        {
            if (idFine != 0) 
            {
                if (dateStart <= fineReceipt.Value && fineReceipt.Value <= dateEnd) { dateNow = fineReceipt.Value; }
                else { fineReceipt.Value = dateNow; MessageBox.Show($"Штраф должен быть в течение проката у данного нарушителя\n От {dateStart.ToLongDateString()} до {dateEnd.ToLongDateString()}"); }
            }
            else OutputFIOIntruder();
        }
        void OutputFIOIntruder()
        {
            FIOIntruder.Items.Clear();
            brand.Items.Clear();
            model.Items.Clear();
            try
            {
                var IntruderInfo = db.fc_OutputIntruderFullNameForInsertFine(fineReceipt.Value).ToList();
                if(IntruderInfo != null)
                {
                    foreach(var intruder in IntruderInfo)
                    {
                        FIOIntruder.Items.Add(intruder.FIOIntruder);
                    }
                    FIOIntruder.SelectedIndex = -1;
                    brand.SelectedIndex = -1;
                    model.SelectedIndex = -1;
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }

        private void FIOIntruder_SelectedIndexChanged(object sender, EventArgs e)
        {
            brand.Items.Clear();
            model.Items.Clear();
            try
            {
                var BrandInfo = db.fc_OutputBrandForInsertFine(fineReceipt.Value,FIOIntruder.Text).ToList();
                if(BrandInfo != null)
                {
                    foreach (var brand in BrandInfo)
                    {
                        this.brand.Items.Add(brand.CatalogCarBrand);
                    }
                    brand.SelectedIndex = -1;
                    model.SelectedIndex = -1;
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }

        private void addNewFineName_Click(object sender, EventArgs e)
        {
            try
            {
                int count = db.pc_AddNewFineName(newFineName.Text);
                if (count >= 1) { MessageBox.Show("Добавление прошло успешно!"); fineName.Items.Clear(); LoadFineName(); }
                else { MessageBox.Show("Добавление прошло безуспешно!"); }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }

        private void newFineName_TextChanged(object sender, EventArgs e)
        {
            if (newFineName.TextLength > 255) { MessageBox.Show("Длина нового вида штрафа не может быть больше 255 символов"); newFineName.Text = newFineName.Text.Substring(0, 255); }
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            model.Items.Clear();
            try
            {
                var ModelInfo = db.fc_OutputModelForInsertFine(fineReceipt.Value,FIOIntruder.Text,brand.Text).ToList();
                if(ModelInfo != null)
                {
                    foreach(var models in ModelInfo)
                    {
                        model.Items.Add(models.CatalogCarModel);
                    }
                    model.SelectedIndex = -1;
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Чтобы изменить нарушителя с машиной, нужно удалить этот штраф.\n Затем создать штраф уже с нужными данными нарушителя!");
        }

        void LoadFineName()
        {
            try
            {
                var FineInfo = db.fc_OutputFineName().ToList();
                if(FineInfo != null)
                {
                    foreach(var fine in FineInfo)
                    {
                        fineName.Items.Add(fine.NameFineName);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
    }
}
