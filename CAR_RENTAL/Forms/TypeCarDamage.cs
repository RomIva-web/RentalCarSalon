using CAR_RENTAL.Classes;
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
    public partial class TypeCarDamage : Form
    {
        int sort = 1;
        CarRentalSalonEntities db = new CarRentalSalonEntities();
        public TypeCarDamage()
        {
            InitializeComponent();
        }

        private void TimeNow_Tick(object sender, EventArgs e)
        {
            TimeNow.Interval = 1000;
            TimeText.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }

        public void LoadTypeCarDamage()
        {
            try
            {
                var AdditionalInfo = db.pc_OutputTypeCarDamage(typeCarDamageName.Text, sort);
                if (AdditionalInfo != null)
                {
                    foreach (var additional in AdditionalInfo)
                    {
                        TypeCarDamageBD.Rows.Add(additional.TypeCarDamageId, additional.TypeCarDamageName, additional.TypeCarDamagePrice);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }

        private void backMenuButton_Click(object sender, EventArgs e)
        {
            MenuForEmployee menuForSotrydnik = new MenuForEmployee();
            menuForSotrydnik.Show();
            this.Close();
        }

        private void typeCarDamageName_TextChanged(object sender, EventArgs e)
        {
            TypeCarDamageBD.Rows.Clear();
            LoadTypeCarDamage();
        }

        private void editTypeCarDamageButton_Click(object sender, EventArgs e)
        {
            if (TypeCarDamageBD.CurrentRow.Index != -1)
            {
                AddAndEditTypeCarDamage andEditTypeCarDamage = new AddAndEditTypeCarDamage(Convert.ToInt32(TypeCarDamageBD.Rows[TypeCarDamageBD.CurrentRow.Index].Cells[0].Value));
                andEditTypeCarDamage.Show();
                this.Close();
            }
            else MessageBox.Show("Выберите тип повреждения, который вы хотите изменить!");
        }

        private void addTypeCarDamageButton_Click(object sender, EventArgs e)
        {
            AddAndEditTypeCarDamage andEditTypeCarDamage = new AddAndEditTypeCarDamage();
            andEditTypeCarDamage.Show();
            this.Close();
        }

        private void delTypeCarDamageButton_Click(object sender, EventArgs e)
        {
            if (TypeCarDamageBD.CurrentRow.Index >= 0)
            {
                DialogResult dialogResult = MessageBox.Show($"Вы уверены, что хотите удалить {TypeCarDamageBD.Rows[TypeCarDamageBD.CurrentRow.Index].Cells[1].Value}", "Предупреждение!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        int count = db.pc_DeleteTypeCarDamage(Convert.ToInt32(TypeCarDamageBD.Rows[TypeCarDamageBD.CurrentRow.Index].Cells[0].Value));
                        if (count >= 1) { MessageBox.Show("Удаление прошло успешно!"); TypeCarDamageBD.Rows.Clear(); LoadTypeCarDamage(); }
                        else { MessageBox.Show("Удаление прошло безуспешно!"); }
                    }
                    catch (Exception ex) { MessageBox.Show($"{ex}"); }
                }
            }
            else MessageBox.Show("Чтобы удалить услугу, нужно выделить нужную вам строку и затем нажать на эту же кнопку");
        }

        private void TypeCarDamage_Load(object sender, EventArgs e)
        {
            LoadTypeCarDamage();
            if (UserAuthorization.Role == 1) { TypeCarDamageBD.Visible = false; typeCarDamageName.Visible = false; sortType.Visible = false; }
            if (UserAuthorization.Role == 2) { }
            if (UserAuthorization.Role == 3) { addTypeCarDamageButton.Visible = true; editTypeCarDamageButton.Visible = true; delTypeCarDamageButton.Visible = true; }
            if (UserAuthorization.Role == 4) { addTypeCarDamageButton.Visible = true; editTypeCarDamageButton.Visible = true; delTypeCarDamageButton.Visible = true; }
            sortType.Items.Add("Без сортировки цены");
            sortType.Items.Add("По убыванию цены");
            sortType.Items.Add("По возрастанию цены");
            sortType.SelectedIndex = 0;
        }

        private void sortType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sortType.SelectedItem.ToString() == "Без сортировки цены") { sort = 1; }
            if (sortType.SelectedItem.ToString() == "По убыванию цены") { sort = 2; }
            if (sortType.SelectedItem.ToString() == "По возрастанию цены") { sort = 3; }
            TypeCarDamageBD.Rows.Clear();
            LoadTypeCarDamage();
        }

        private void typeCarDamageName_Enter(object sender, EventArgs e)
        {
            infoSearch1.Visible = false;
        }

        private void typeCarDamageName_Leave(object sender, EventArgs e)
        {
            if (typeCarDamageName.Text == "") infoSearch1.Visible = true;
        }

        private void infoSearch1_Click(object sender, EventArgs e)
        {
            infoSearch1.Visible = false;
            typeCarDamageName.Focus();
        }
    }
}
