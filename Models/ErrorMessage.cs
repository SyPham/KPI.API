using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models
{
   public class ErrorMessage
    {
        public ErrorMessage()
        {

            this.CreateTime = DateTime.Now;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateTime { get; set; }
        public string Function { get; set; }
    }
}
