using System;
using System.Collections.Generic;
using API.Models;

namespace API.Dtos
{
    public class UserForDetailedDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}