using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.ADO;

namespace BLL
{
    public class DepartmentBLL
    {
        public static void AddDepartment(DepartmentTBL departmentTBL)
        {
            DepartmentDAO.AddDepartment(departmentTBL);
        }

        public static List<DepartmentTBL> GetDapartments()
        {
            return DepartmentDAO.GetDepartments();
        }
    }
}
