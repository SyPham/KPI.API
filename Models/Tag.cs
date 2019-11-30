using Models.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models
{
  public class Tag 
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int CommentID { get; set; }
        public int ActionPlanID { get; set; }
        public int NotificationID { get; set; }
        public bool IsUpload { get; set; }
    }
}
