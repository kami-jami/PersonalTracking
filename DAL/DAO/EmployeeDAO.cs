using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class EmployeeDAO : EmployeeContext
    {
        public static void AddEmployee(EmployeeTBL employee)
        {
            try
            {
                db.EmployeeTBLs.InsertOnSubmit(employee);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<EmployeeTBL> GetUsers(int v)
        {
            return db.EmployeeTBLs.Where(x => x.UserNo == v).ToList();
        }
    }
}
