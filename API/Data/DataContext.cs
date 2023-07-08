using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            //extend fosse
            //informa
        }
        //dotnet ef migrations add InitialCreate --context DataContext
        //dotnet ef migrations add InitialCreate -o Data/Migrations
        public DbSet<AppUser> Users { get; set; }
        public DbSet<AppMovie> Movies { get; set; }
    }
}