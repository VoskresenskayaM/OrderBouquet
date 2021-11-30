﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderBouquet.Models
{
    public class Role : BaseEntity
    {
       
        public string Name { get; set; }
        public virtual List<User> Users { get; set; }
        public Role()
        {
            Users = new List<User>();
        }
    }
}