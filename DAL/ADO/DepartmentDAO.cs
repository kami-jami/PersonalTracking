using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ADO
{
    public class DepartmentDAO : EmployeeContext
    {
        public static void AddDepartment(DepartmentTBL departmentTBL)
        {
            try
            {
                db.DepartmentTBLs.InsertOnSubmit(departmentTBL);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public static List<DepartmentTBL> GetDepartments()
        {
            return db.DepartmentTBLs.ToList();
        }
    }
}
