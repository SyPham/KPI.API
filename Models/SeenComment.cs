using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models
{
   public class SeenComment
    {
        public int Id { get; set; }
        public int CommentID { get; set; }
        public int UserID { get; set; }
        public bool Status { get; set; }
    }
}
