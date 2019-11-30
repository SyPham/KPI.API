using Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models
{
    public class KPI : Inheritance
    {
        public KPI() { }

        public KPI(int id, string name, string code, int levelID,
            string parentID, int unit, int categoryID, string categoryCode)
        {
            Id = id;
            Name = name;
            Code = code;
            LevelID = levelID;
            ParentID = parentID;
          
            Unit = unit;
            CategoryID = categoryID;
            CategoryCode = categoryCode;
        }
        public string CategoryCode { get; set; }
        public int CategoryID { get; set; }
        public int Unit { get; set; }
  
    }
}
