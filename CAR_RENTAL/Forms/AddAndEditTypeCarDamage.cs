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
    public partial class AddAndEditTypeCarDamage : Form
    {
        int idTypeCarDamage = 0;
        CarRentalSalonEntities db = new CarRentalSalonEntities();
        public AddAndEditTypeCarDamage( int idTypeCarDamage)
        {
            InitializeComponent();
            this.idTypeCarDamage = idTypeCarDamage;
            LoadTypeCarDamage();
            editTypeCarDamageButton.Visible = true;
            addTypeCarDamageButton.Visible = false;
            Text1.Text = "Изменение типа повреждения";
        }
        public AddAndEditTypeCarDamage()
        {
            InitializeComponent();
            editTypeCarDamageButton.Visible = false;
            addTypeCarDamageButton.Visible = true;
            Text1.Text = "Добавление типа повреждения";
        }
        public void LoadTypeCarDamage()
        {
            try
            {
                var TypeCarDamageInfo = db.fc_OutputOneTypeCarDamage(idTypeCarDamage).FirstOrDefault();
                nameTypeCarDamage.Text = TypeCarDamageInfo.TypeCarDamageName;
                priceTypeCarDamage.Text = TypeCarDamageInfo.TypeCarDamagePrice.ToString();
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            TypeCarDamage typeCarDamage = new TypeCarDamage();
            typeCarDamage.Show();
            this.Close();
        }

        private void editTypeCarDamageButton_Click(object sender, EventArgs e)
        {
            editTypeCarDamage();
        }

        void editTypeCarDamage()
        {
            try
            {
                int count = db.pc_UpdateTypeCarDamage(idTypeCarDamage, nameTypeCarDamage.Text, Convert.ToInt32(priceTypeCarDamage.Text));
                if (count >= 1) 
                { 
                    MessageBox.Show("Изменение прошло успешно!"); 
                    TypeCarDamage typeCarDamage = new TypeCarDamage();
                    typeCarDamage.Show();
                    this.Close();
                }
                else { MessageBox.Show("Изменение прошло безуспешно!"); }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }

        private void addTypeCarDamageButton_Click(object sender, EventArgs e)
        {
            addTypeCarDamage();
        }
        
        void addTypeCarDamage()
        {
            try
            {
                int count = db.pc_AddTypeCarDamage(nameTypeCarDamage.Text, Convert.ToInt32(priceTypeCarDamage.Text));
                if (count >= 1) 
                { 
                    MessageBox.Show("Добавление прошло успешно!"); 
                    TypeCarDamage typeCarDamage = new TypeCarDamage();
                    typeCarDamage.Show();
                    this.Close();
                }
                else { MessageBox.Show("Добавление прошло безуспешно!"); }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }

        private void nameTypeCarDamage_TextChanged(object sender, EventArgs e)
        {
            if (nameTypeCarDamage.TextLength > 30) { MessageBox.Show("Длина названия услуги не может быть больше 30 символов"); nameTypeCarDamage.Text = nameTypeCarDamage.Text.Substring(0, 30); }
        }

        private void priceTypeCarDamage_KeyPress(object sender, KeyPressEventArgs e)
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
