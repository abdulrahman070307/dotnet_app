using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestApplication.Models;
using MySql.Data.MySqlClient;

namespace TestApp.Models.Data
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public List<User> GetUsers()
        {
            List<User> userList = new List<User>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Call GetAllUsers()";
            var val = cmd.ExecuteReader();
            //userList = val;
            return userList;
        }
    }
}
