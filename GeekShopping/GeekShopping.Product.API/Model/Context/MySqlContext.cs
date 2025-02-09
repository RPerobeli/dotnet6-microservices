﻿using Microsoft.EntityFrameworkCore;

namespace GeekShopping.Product.API.Model.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(){}

        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) {}
        public DbSet<Product> Products { get; set;}
    }
}
