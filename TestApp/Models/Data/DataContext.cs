using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestApp.Models;
using MySql.Data.MySqlClient;
using TestApp.Models;

namespace TestApp.Models.Data
{
    public class DataContext : DbContext
    {
        public DbSet<TestApp.Models.Asset> Assets { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<TestApp.Models.AddAssetDto> AddAssetDto { get; set; }
    }
}
