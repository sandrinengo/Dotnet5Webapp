﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet5Webapp.Models
{
    public class Contact
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string NickName { get; set; }

        public string Place { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public bool isActive { get; set; }//test
    }
}
