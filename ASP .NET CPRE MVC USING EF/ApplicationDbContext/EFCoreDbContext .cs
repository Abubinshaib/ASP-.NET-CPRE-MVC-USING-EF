﻿using ASP_.NET_CPRE_MVC_USING_EF.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_.NET_CPRE_MVC_USING_EF.ApplicationDbContext
{
    public class EFCoreDbContext : DbContext
    {
        //Constructor calling the Base DbContext Class Constructor
        public EFCoreDbContext(DbContextOptions<EFCoreDbContext> options) : base(options)
        {
        }
        //OnConfiguring() method is used to select and configure the data source
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        //Adding Domain Classes as DbSet Properties
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}

