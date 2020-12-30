﻿using Microsoft.EntityFrameworkCore;
using Store.web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.web.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set;}


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
