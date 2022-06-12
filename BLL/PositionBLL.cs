using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.ADO;
using DAL.DTO;

namespace BLL
{
    public class PositionBLL
    {
        public static void AddPosition(PositionTBL positionTBL)
        {
            PositionDAO.AddPosition(positionTBL);
        }

        public static List<PositionDTO> GetPosition()
        {
            return PositionDAO.GetPositions();
        }
    }
}
