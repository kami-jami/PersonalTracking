using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class EmployeeDTO
    {
        public List<DepartmentTBL> departments { get; set; }
        public List<PositionDTO> positions { get; set; }
    }
}
