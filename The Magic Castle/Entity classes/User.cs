﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Magic_Castle.Entity_classes
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string DateOfBirth { get; set; }
        public string BloodGroup { get; set; }
    }
}
