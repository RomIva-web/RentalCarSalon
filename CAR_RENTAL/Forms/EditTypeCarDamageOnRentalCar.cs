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
    public partial class EditTypeCarDamageOnRentalCar : Form
    {
        int idRentalCar = 0;
        CarRentalSalonEntities db = new CarRentalSalonEntities();
        public EditTypeCarDamageOnRentalCar(int id)
        {
            InitializeComponent();
            idRentalCar = id;
            editTypeCarDamageOnRentalCarButton.Visible = true;
            Text1.Text = "Изменение повреждений на прокат";
            LoadTypeCarDamage();
            LoadTypeCarDamageOnRentalCar();
        }

        private void TimeNow_Tick(object sender, EventArgs e)
        {
            TimeNow.Interval = 1000;
            TimeText.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }

        private void LoadTypeCarDamageOnRentalCar()
        {
            try
            {
                var InfoTypeCarDamageOnRentalCar = db.fc_OutputTypeCarDamageOnRentalCar(idRentalCar).ToList();
                if(InfoTypeCarDamageOnRentalCar != null)
                {
                    foreach(var type in InfoTypeCarDamageOnRentalCar)
                    {
                        TypeCarDamagesBD.Rows.Add(type.TypeCarDamageId,type.TypeCarDamageName,type.ReturnCarHaveDamageAmount,type.TypeCarDamagePrice,type.TypeCarDamagePrice * type.ReturnCarHaveDamageAmount);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void AddTypeCarDamageInBD()
        {
            if (TypeCarDamagesBD.Rows.Count <= 1) TypeCarDamagesBD.Rows.Add(db.TypeCarDamages.Where(t => t.TypeCarDamageName == typeCarDamages.Text).FirstOrDefault().TypeCarDamageId, typeCarDamages.Text, amountTypeCarDamage.Text, priceTypeCarDamage.Text, itogPriceTypeCarDamage.Text);
            else
            {
                if (TypeCarDamagesBD.Rows[0].Cells[1].Value.ToString() != "Без повреждений")
                {
                    if (typeCarDamages.Text == "Без повреждений" && TypeCarDamagesBD.Rows.Count == 1) TypeCarDamagesBD.Rows.Add(db.TypeCarDamages.Where(t => t.TypeCarDamageName == typeCarDamages.Text).FirstOrDefault().TypeCarDamageId, typeCarDamages.Text, 0, priceTypeCarDamage.Text, itogPriceTypeCarDamage.Text);
                    else
                    {
                        if (typeCarDamages.Text == "Без повреждений" && TypeCarDamagesBD.Rows.Count != 1) MessageBox.Show("Чтобы добавить без повреждений, нужно удалить все другие повреждения!");
                        else
                        {
                            bool duplicate = false;
                            for (int i = 0; i < TypeCarDamagesBD.Rows.Count - 1; i++)
                            {
                                if (TypeCarDamagesBD.Rows[i].Cells[1].Value.ToString() == typeCarDamages.Text) duplicate = true;
                            }
                            if (!duplicate) TypeCarDamagesBD.Rows.Add(db.TypeCarDamages.Where(t => t.TypeCarDamageName == typeCarDamages.Text).FirstOrDefault().TypeCarDamageId, typeCarDamages.Text, amountTypeCarDamage.Text, priceTypeCarDamage.Text, itogPriceTypeCarDamage.Text);
                            else MessageBox.Show("Данное повреждение уже есть. Если нужно добавить ещё, то удалите и добавьте, но выбрав большее количество.");
                        }
                    }
                }
                else MessageBox.Show("Выбран пункт без повреждений, больше нельзя добавить повреждения.\nЕсли вам нужно добавить повреждения, удалите данную строку и добавите повреждение.");
            }
        }

        private void DelTypeCarDamageInBD()
        {
            if (TypeCarDamagesBD.Rows.Count >= 2 && TypeCarDamagesBD.CurrentRow.Index != TypeCarDamagesBD.Rows.Count-1)
            {
                TypeCarDamagesBD.Rows.RemoveAt(TypeCarDamagesBD.CurrentRow.Index);
            }
        }

        private void editTypeCarDamageOnRentalCarButton_Click(object sender, EventArgs e)
        {
            if (TypeCarDamagesBD.Rows.Count >= 2)
            {
                editTypeCarDamageOnRentalCar();
            }
            else MessageBox.Show("Выберите повреждения, чтобы добавить!");
        }

        private void editTypeCarDamageOnRentalCar()
        {
            var transaction = db.Database.BeginTransaction();
            try
            {
                int count1 = db.pc_DeleteTypeCarDamageOnRentalCar(idRentalCar);
                if (count1 >= 1)
                {
                    int count2 = 0;
                    for (int i = 0; i < TypeCarDamagesBD.Rows.Count - 1; i++)
                    {
                        count2 += db.pc_AddTypeCarDamageOnRentalCar(idRentalCar, Convert.ToInt32(TypeCarDamagesBD.Rows[i].Cells[0].Value),Convert.ToInt32(TypeCarDamagesBD.Rows[i].Cells[2].Value));
                    }
                    if (count2 >= 1)
                        {
                            transaction.Commit();
                            MessageBox.Show("Успешно изменено");
                            RentalCars rentalCar = new RentalCars();
                            rentalCar.Show();
                            this.Close();
                        }
                        else { transaction.Rollback(); MessageBox.Show("Безуспешно изменено"); }
                }
                else { transaction.Rollback(); MessageBox.Show("Безуспешно изменено"); }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); transaction.Rollback(); }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            RentalCars rentalCar = new RentalCars();
            rentalCar.Show();
            this.Close();
        }

        private void addTypeCarDamage_Click(object sender, EventArgs e)
        {
            if (typeCarDamages.SelectedIndex != -1 && amountTypeCarDamage.Text != "")
            {
                AddTypeCarDamageInBD();
            }
            else MessageBox.Show("Заполните все поля!");
        }

        private void delTypeCarDamage_Click(object sender, EventArgs e)
        {
            if(TypeCarDamagesBD.CurrentRow.Index != -1)
            {
                DelTypeCarDamageInBD();
            }
        }

        private void LoadTypeCarDamage()
        {
            try
            {
                var InfoTypeCarDamages = db.TypeCarDamages.ToList();
                if(InfoTypeCarDamages != null)
                {
                    foreach(var type in InfoTypeCarDamages)
                    {
                        typeCarDamages.Items.Add(type.TypeCarDamageName);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void typeCarDamages_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (typeCarDamages.Text == "Без повреждений") { amountTypeCarDamage.Text = "0"; amountTypeCarDamage.Enabled = false; }
                else { amountTypeCarDamage.Enabled = true; amountTypeCarDamage.Text = "1";  }
                var InfoTypeCarDamage = db.TypeCarDamages.Where(t => t.TypeCarDamageName == typeCarDamages.Text).FirstOrDefault();
                priceTypeCarDamage.Text = InfoTypeCarDamage.TypeCarDamagePrice.ToString();
                itogPriceTypeCarDamage.Text = Convert.ToString(Convert.ToInt32(priceTypeCarDamage.Text) * Convert.ToInt32(amountTypeCarDamage.Text));
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void amountTypeCarDamage_TextChanged(object sender, EventArgs e)
        {
            if (amountTypeCarDamage.Text != "")
            {
                if( typeCarDamages.Text != "Без повреждений" && Convert.ToInt32(amountTypeCarDamage.Text) == 0) { amountTypeCarDamage.Text = "1"; }
                itogPriceTypeCarDamage.Text = Convert.ToString(Convert.ToInt32(priceTypeCarDamage.Text) * Convert.ToInt32(amountTypeCarDamage.Text));
            }
        }

        private void amountTypeCarDamage_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void TypeCarDamagesBD_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalculateFullPrice();
        }

        private void TypeCarDamagesBD_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalculateFullPrice();
        }

        private void CalculateFullPrice()
        {
            if (TypeCarDamagesBD.Rows.Count >= 2)
            {
                int fullPrice = 0;
                for(int i = 0; i< TypeCarDamagesBD.Rows.Count -1; i++)
                {
                    fullPrice += Convert.ToInt32(TypeCarDamagesBD.Rows[i].Cells[4].Value);
                }
                fullPriceTypeCarDamages.Text = fullPrice.ToString();
            }
            else fullPriceTypeCarDamages.Text = "0";
        }
    }
}
