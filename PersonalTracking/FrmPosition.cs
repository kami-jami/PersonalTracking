using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalTracking
{
    public partial class FrmPosition : Form
    {
        public FrmPosition()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPosition.Text.Trim() == "")
                MessageBox.Show("لطفا نام را پر کنید.");
            else if(cmbDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("لطفا یک بخش را انتخاب کنید.");
            }
            else
            {
                PositionTBL positionTBL = new PositionTBL();
                positionTBL.PositionName = txtPosition.Text;
                positionTBL.DepartmentID = Convert.ToInt32(cmbDepartment.SelectedValue);
                PositionBLL.AddPosition(positionTBL);
                MessageBox.Show("سمت با موفقیت افزوده شد.");
                txtPosition.Clear();
                cmbDepartment.SelectedIndex = -1;
            }
        }

        List<DepartmentTBL> departmentlist = new List<DepartmentTBL>();
        private void FrmPosition_Load(object sender, EventArgs e)
        {
            departmentlist = DepartmentBLL.GetDapartments();
            cmbDepartment.DataSource = departmentlist;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "ID";
            cmbDepartment.SelectedIndex = -1;
        }
    }
}
