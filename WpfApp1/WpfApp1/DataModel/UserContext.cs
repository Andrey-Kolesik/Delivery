namespace WpfApp1
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;
    using System.Windows.Controls;

    public class UserContext : DbContext
    {
        public UserContext()
            : base("UserContext")
        {
        }

        public virtual DbSet<Restaurants> restaurants { get; set; }
        public virtual DbSet<User> user { get; set; }
    }

    public class User
    {
        public int UserID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
    }

    public class Restaurants
    {
        [Key]
        public int RestId { get; set; }

        public string RestName { get; set; }

        public string RestSourse { get; set; }

         
    }




}