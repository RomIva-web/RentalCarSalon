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
    public partial class Fines : Form
    {
        int sort = 1;
        CarRentalSalonEntities db = new CarRentalSalonEntities();
        public Fines()
        {
            InitializeComponent();
        }

        private void TimeNow_Tick(object sender, EventArgs e)
        {
            TimeNow.Interval = 1000;
            TimeText.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }

        private void editFineButton_Click(object sender, EventArgs e)
        {
            AddAndEditFine addAndEditFine = new AddAndEditFine( (int)FineBD.Rows[FineBD.CurrentRow.Index].Cells[0].Value);
            addAndEditFine.Show();
            this.Close();
        }

        private void addFineButton_Click(object sender, EventArgs e)
        {
            AddAndEditFine addAndEditFine = new AddAndEditFine();
            addAndEditFine.Show();
            this.Close();
        }

        private void delFineButton_Click(object sender, EventArgs e)
        {
            if (FineBD.CurrentRow.Index >= 0)
            {
                DialogResult dialogResult = MessageBox.Show($"Вы уверены, что хотите удалить штраф у {FineBD.Rows[FineBD.CurrentRow.Index].Cells[2].Value}", "Предупреждение!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        int count = db.pc_DeleteFine(Convert.ToInt32(FineBD.Rows[FineBD.CurrentRow.Index].Cells[0].Value));
                        if (count >= 1) { MessageBox.Show("Удаление прошло успешно!"); FineBD.Rows.Clear(); if (Text2.ForeColor == Color.Red) LoadShtrafWithoutTime(); if (Text2.ForeColor == Color.Green) LoadShtrafWithTime();}
                        else { MessageBox.Show("Удаление прошло безуспешно!"); }

                    }
                    catch (Exception ex) { MessageBox.Show($"{ex}"); }
                }
            }
            else MessageBox.Show("Чтобы удалить штраф, нужно выделить нужную вам строку и затем нажать на эту же кнопку");
        }

        private void filtrDateButton_Click(object sender, EventArgs e)
        {
            FineBD.Rows.Clear();
            if (Text2.ForeColor == Color.Red) { Text2.ForeColor = Color.Green; Text2.Text = "Активен"; LoadShtrafWithTime(); return; }
            if (Text2.ForeColor == Color.Green) { Text2.ForeColor = Color.Red;Text2.Text = "Не активен"; LoadShtrafWithoutTime(); return; }
        }

        private void backMenuButton_Click(object sender, EventArgs e)
        {
            MenuForEmployee menuForSotrydnik = new MenuForEmployee();
            menuForSotrydnik.Show();
            this.Close();
        }
        void LoadShtrafWithoutTime() 
        {
            try
            {
                var FineInfo = db.pc_OutputFines(intruderName.Text, sort).ToList();
                if(FineInfo != null)
                {
                    foreach(var fine in FineInfo)
                    {
                        FineBD.Rows.Add(fine.FineId,fine.RentalCarId,fine.IntruderFullName,fine.Intruder,fine.NameFineName,fine.FineReceiptDate.ToShortDateString(),fine.FinePrice);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
        void LoadShtrafWithTime()
        {
            try
            {
                var FineInfo = db.pc_OutputFinesWithDate(intruderName.Text,sort, fineStart.Value, fineEnd.Value).ToList();
                if(FineInfo != null)
                {
                    foreach(var fine in FineInfo)
                    {
                        FineBD.Rows.Add(fine.FineId, fine.RentalCarId, fine.IntruderFullName, fine.Intruder, fine.NameFineName, fine.FineReceiptDate.ToShortDateString(), fine.FinePrice);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
        private void Strafs_Load(object sender, EventArgs e)
        {
            LoadShtrafWithoutTime();
            if (UserAuthorization.Role == 1) { FineBD.Visible = false; fineEnd.Visible = false; fineStart.Visible = false; sortType.Visible = false; }
            if (UserAuthorization.Role == 2) { }
            if (UserAuthorization.Role == 3) { addFineButton.Visible = true; editFineButton.Visible = true; delFineButton.Visible = true; }
            if (UserAuthorization.Role == 4) { addFineButton.Visible = true; editFineButton.Visible = true; delFineButton.Visible = true; }
            sortType.Items.Add("Без сортировки цены");
            sortType.Items.Add("По убыванию цены");
            sortType.Items.Add("По возрастанию цены");
            sortType.SelectedIndex = 0;
        }

        private void clientName_TextChanged(object sender, EventArgs e)
        { 
            FineBD.Rows.Clear();
            if (Text2.ForeColor == Color.Red) LoadShtrafWithoutTime();
            if (Text2.ForeColor == Color.Green) LoadShtrafWithTime();
        }

        private void Text2_TextChanged(object sender, EventArgs e)
        {
            FineBD.Rows.Clear();
            if (Text2.ForeColor == Color.Red) LoadShtrafWithoutTime();
            if (Text2.ForeColor == Color.Green) LoadShtrafWithTime();
        }

        private void shtrafStart_ValueChanged(object sender, EventArgs e)
        {
            if (Text2.ForeColor == Color.Green)
            {
                FineBD.Rows.Clear();
                LoadShtrafWithTime();
            }
        }

        private void shtrafEnd_ValueChanged(object sender, EventArgs e)
        {
            if (Text2.ForeColor == Color.Green) 
            {
                FineBD.Rows.Clear();
                LoadShtrafWithTime();
            }
        }

        private void sortType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sortType.SelectedItem.ToString() == "Без сортировки цены") { sort = 1; }
            if (sortType.SelectedItem.ToString() == "По убыванию цены") { sort = 2; }
            if (sortType.SelectedItem.ToString() == "По возрастанию цены") { sort = 3; }
            FineBD.Rows.Clear();
            if (Text2.ForeColor == Color.Red) LoadShtrafWithoutTime();
            if (Text2.ForeColor == Color.Green) LoadShtrafWithTime();
        }

        private void intruderName_Enter(object sender, EventArgs e)
        {
            infoSearch1.Visible = false;
        }

        private void intruderName_Leave(object sender, EventArgs e)
        {
            if (intruderName.Text == "") infoSearch1.Visible = true;
        }

        private void infoSearch1_Click(object sender, EventArgs e)
        {
            infoSearch1.Visible = false;
            intruderName.Focus();
        }
    }
}
