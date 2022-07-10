using BLL;
using DAL;
using DAL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalTracking
{
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        EmployeeDTO dto = new EmployeeDTO();

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            dto = EmployeeBLL.GetAll();
            cmbDepartment.DataSource = dto.departments;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "ID";
            cmbPosition.DataSource = dto.positions;
            cmbPosition.DisplayMember = "PositionName";
            cmbPosition.ValueMember = "ID";
            cmbDepartment.SelectedIndex = -1;
            cmbPosition.SelectedIndex = -1;
            comboFull = true;
        }

        bool comboFull;

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFull)
            {
                int departmentId = Convert.ToInt32(cmbDepartment.SelectedValue);
                cmbPosition.DataSource = dto.positions.Where(x => x.DepartmentID == departmentId).ToList();
            }
        }

        string fileName = "";

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                txtImagePath.Text = openFileDialog1.FileName;
                string Unique = Guid.NewGuid().ToString();
                fileName += Unique + openFileDialog1.SafeFileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUserNo.Text.Trim() == "")
                MessageBox.Show("نام کاربری را وارد کنید.");
            else if (!EmployeeBLL.isUnique(Convert.ToInt32(txtUserNo.Text)))
                MessageBox.Show("نام کاربری موجو است لطفا نام کاربری دیگری استفاده کنید.");
            else if (txtPassword.Text.Trim() == "")
                MessageBox.Show("کلمه عبور را وارد کنید.");
            else if (txtName.Text.Trim() == "")
                MessageBox.Show("نام را وارد کنید.");
            else if (txtSurname.Text.Trim() == "")
                MessageBox.Show("نام مستعار را وارد کنید.");
            else if (txtSalary.Text.Trim() == "")
                MessageBox.Show("حقوق را وارد کنید.");
            else if (cmbDepartment.SelectedIndex == -1)
                MessageBox.Show("بخش را وارد کنید.");
            else if (cmbPosition.SelectedIndex == -1)
                MessageBox.Show("سمت را وارد کنید.");
            else
            {
                EmployeeTBL employee = new EmployeeTBL();
                employee.UserNo = Convert.ToInt32(txtUserNo.Text);
                employee.Password = txtPassword.Text;
                employee.isAdmin = chAdmin.Checked;
                employee.Name = txtName.Text;
                employee.Surname = txtSurname.Text;
                employee.Salary = Convert.ToInt32(txtSalary.Text);
                employee.DepartmentID = Convert.ToInt32(cmbDepartment.SelectedValue);
                employee.PositionID = Convert.ToInt32(cmbPosition.SelectedValue);
                employee.Address = txtAddress.Text;
                employee.BirthDay = dateTimePicker1.Value;
                employee.ImagePath = fileName;
                EmployeeBLL.AddEmployee(employee);
                File.Copy(txtImagePath.Text, @"images\\"+fileName);
                MessageBox.Show("کاربر با موفقیت ایجاد شد");

                txtUserNo.Clear();
                txtPassword.Clear();
                chAdmin.Checked = false;
                txtName.Clear();
                txtSurname.Clear();
                txtSalary.Clear();
                comboFull = false;
                cmbDepartment.SelectedIndex = -1;
                cmbPosition.DataSource = dto.positions;
                cmbPosition.SelectedIndex = -1;
                comboFull = true;
                txtAddress.Clear();
                dateTimePicker1.Value = DateTime.Now;
                txtImagePath.Clear();
                pictureBox1.Image = null;
                
            }
        }
        bool isUnique = false;
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtUserNo.Text == "")
                MessageBox.Show("نام کاربری را وارد کنید.");
            else
            {
                isUnique = EmployeeBLL.isUnique(Convert.ToInt32(txtUserNo.Text));
                if (!isUnique)
                    MessageBox.Show("نام کاربری موجو است لطفا نام کاربری دیگری استفاده کنید.");
                else
                    MessageBox.Show("نام کاربری هنوز ثبت نشده است.");
            }

        }
    }
}
