using System;
using System.Collections.Generic;
using System.Text;

namespace Service.ViewModel.KPI
{
    public class KPIViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int LevelID { get; set; }
        public DateTime CreateTime { get; set; }
        public string ParentID { get; set; }
        public string CategoryCode { get; set; }
        public int CategoryID { get; set; }
        public string Unit { get; set; }
    }
}
