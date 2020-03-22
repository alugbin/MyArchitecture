using Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess.EFCore
{
    public class BusinessDbContext : DbContext
    {
        public BusinessDbContext(DbContextOptions<BusinessDbContext> options) : base(options)
        {

        }
        public DbSet<Todo> Todos { get; set; }
    }
}
