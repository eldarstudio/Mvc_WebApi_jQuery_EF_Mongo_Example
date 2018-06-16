using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using System.Linq;
using Site.Models;
using Site.Interfaces;

namespace Site.DB
{
    public class EFDB: IDAL
    {
        public class UsersDb : DbContext
        {

            public DbSet<User> Users { get; set; }
        }
        
        public UsersDb GetDB()
        {
            return new UsersDb();
        }

        public void AddUser(User user)
        {
            using (var db = GetDB())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        public List<User> GetUsers()
        {
            using (var db = GetDB())
            {
                return db.Users.ToList();
            }
        }
    }
}
