﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models
{
   public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string FontAwesome { get; set; }
        public string BackgroudColor { get; set; }
        public int Permission { get; set; }
        public int ParentID { get; set; }
        public int Position { get; set; }

    }
}
