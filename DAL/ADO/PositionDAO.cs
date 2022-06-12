using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DTO;

namespace DAL.ADO
{
    public class PositionDAO : EmployeeContext
    {
        public static void AddPosition(PositionTBL positionTBL)
        {
            try
            {
                db.PositionTBLs.InsertOnSubmit(positionTBL);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<PositionDTO> GetPositions()
        {
            try
            {
                var list = (from p in db.PositionTBLs
                            join d in db.DepartmentTBLs on p.DepartmentID equals d.ID
                            select new
                            {
                                positionID = p.ID,
                                positionName = p.PositionName,
                                departmentID = p.DepartmentID,
                                departmentName = d.DepartmentName
                            }).OrderBy(x => x.positionID).ToList();
                List<PositionDTO> positionlist = new List<PositionDTO>();
                foreach (var item in list)
                {
                    PositionDTO dto = new PositionDTO();
                    dto.ID = item.positionID;
                    dto.PositionName = item.positionName;
                    dto.DepartmentID = item.departmentID;
                    dto.DepartmentName = item.departmentName;

                    positionlist.Add(dto);
                }
                return positionlist;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
