﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_TestTask_SoftService.Models
{
    public class CarDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        
    }
}
