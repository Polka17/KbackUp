﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyKitchen.Data
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }

        public  Role Role{ get; set; }

        public ICollection<Order> Order { get; set; }
    }
}
