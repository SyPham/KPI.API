using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interface
{
   interface IInheritance
    {
        int Id { get; set; }
        string Name { get; set; }
        string Code { get; set; }
        DateTime CreateTime { get; set; }
        string ParentID { get; set; }
    }
}
