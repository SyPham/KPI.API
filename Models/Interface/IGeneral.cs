using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interface
{
     interface IGeneral
    {
        int Id { get; set; }
        int UserID { get; set; }
        int CategoryID { get; set; }
        int KPILevelID { get; set; }
        string KPILevelCode { get; set; }
        string CategoryCode { get; set; }
        DateTime CreatedTime { get; set; }
    }
}
