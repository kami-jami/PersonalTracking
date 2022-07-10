using DAL;
using DAL.DAO;
using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EmployeeBLL
    {
        public static EmployeeDTO GetAll()
        {
            EmployeeDTO dto =  new EmployeeDTO();
            dto.departments = DepartmentDAO.GetDepartments();
            dto.positions = PositionDAO.GetPositions();
            return  dto;
        }

        public static void AddEmployee(EmployeeTBL employee)
        {
            EmployeeDAO.AddEmployee(employee);
        }

        public static bool isUnique(int v)
        {
            List<EmployeeTBL> employees = EmployeeDAO.GetUsers(v);
            if (employees.Count > 0)
                return false;
            else
                return true;
        }
    }
}
