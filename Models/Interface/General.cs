using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interface
{
    public class General : IGeneral
    {
        public General()
        {
            this.CreatedTime = DateTime.Now;
        }
        public int Id { get; set; }
        public int CategoryID { get; set; }
        public int KPILevelID { get; set; }
        public string KPILevelCode { get; set; }
        public string CategoryCode { get; set; }
        public DateTime CreatedTime { get; set; }
        public int UserID { get ; set; }
    }
}
