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
    public partial class Employees : Form
    {
        CarRentalSalonEntities db = new CarRentalSalonEntities();
        public Employees()
        {
            InitializeComponent();
        }

        private void TimeNow_Tick(object sender, EventArgs e)
        {
            TimeNow.Interval = 1000;
            TimeText.Text = string.Format($"{DateTime.Now.ToLocalTime().ToShortTimeString()}");
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            if (UserAuthorization.Role == 1) { EmployeeBD.Visible = false; employeeFullName.Visible = false; }
            if (UserAuthorization.Role == 2) { }
            if (UserAuthorization.Role == 3) { }
            if (UserAuthorization.Role == 4) { addEmployeeButton.Visible = true; editEmployeeButton.Visible = true; delEmployeeButton.Visible = true; }
            LoadEmployee();
        }
        public void LoadEmployee()
        {
            try
            {
                var EmployeeInfo = db.fc_OutputEmployees(employeeFullName.Text).ToList();
                if(EmployeeInfo != null)
                {
                    foreach(var employee in EmployeeInfo)
                    {
                        EmployeeBD.Rows.Add(employee.UserId,employee.UserFullName,employee.UserBirthday.ToShortDateString(), employee.UserPhone,employee.RoleName);
                    }
                }    
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }

        private void editEmployeeButton_Click(object sender, EventArgs e)
        {
            RegistrationAndEditEmployee registrationAndEditEmployee = new RegistrationAndEditEmployee( Convert.ToInt32(EmployeeBD.Rows[EmployeeBD.CurrentRow.Index].Cells[0].Value));
            registrationAndEditEmployee.Show();
            this.Close();
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            RegistrationAndEditEmployee registrationAndEditEmployee = new RegistrationAndEditEmployee();
            registrationAndEditEmployee.Show();
            this.Close();
        }

        private void delEmployeeButton_Click(object sender, EventArgs e)
        {
            
            if (EmployeeBD.CurrentRow.Index >= 0)
            {
                if (EmployeeBD.Rows[EmployeeBD.CurrentRow.Index].Cells[4].Value.ToString() != "Администратор" && UserAuthorization.Role == 4)
                {
                    DialogResult dialogResult = MessageBox.Show($"Вы уверены, что хотите уволить {EmployeeBD.Rows[EmployeeBD.CurrentRow.Index].Cells[1].Value}", "Предупреждение!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            int count = db.pc_DeleteEmployee(Convert.ToInt32(EmployeeBD.Rows[EmployeeBD.CurrentRow.Index].Cells[0].Value));
                            if (count >= 1) { MessageBox.Show("Увольнение прошло успешно!"); }
                            else { MessageBox.Show("Увольнение прошло безуспешно!"); }
                            EmployeeBD.Rows.Clear();
                            LoadEmployee();
                        }
                        catch (Exception ex) { MessageBox.Show($"{ex}"); }
                    }
                }
                else MessageBox.Show("Нельзя уволить сотрудника выше вашей должности или сотрудников с вашей же должностью!");
            }
            else MessageBox.Show("Чтобы уволить сотрудника, нужно выделить нужную вам строку и затем нажать на эту же кнопку");
        }

        private void employeeFullName_TextChanged(object sender, EventArgs e)
        {
            EmployeeBD.Rows.Clear();
            LoadEmployee();
        }

        private void backMenuButton_Click(object sender, EventArgs e)
        {
            MenuForEmployee menuForSotrydnik = new MenuForEmployee();
            menuForSotrydnik.Show();
            this.Close();
        }

        private void employeeFullName_Leave(object sender, EventArgs e)
        {
            if(employeeFullName.Text == "") infoSearch1.Visible = true;
        }

        private void employeeFullName_Enter(object sender, EventArgs e)
        {
            infoSearch1.Visible = false;
        }

        private void infoSearch1_Click(object sender, EventArgs e)
        {
            infoSearch1.Visible = false;
            employeeFullName.Focus();
        }
    }
}
