using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Models.Interface
{
    public class Link : ILink
    {
       public int Id { get; set; }
       public string CodeTableA { get; set; }
       public string CodeTableB { get; set; }
    }
}
