﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models
{
   public class StateSendMail
    {
        public StateSendMail()
        {
            ToDay = DateTime.Today;
            Status = true;
            Description = "IsSended";
        }

        public int Id { get; set; }
        public DateTime ToDay { get; set; }
        public bool Status { get; set; }
        public string Description { get; set; }
    }
}
