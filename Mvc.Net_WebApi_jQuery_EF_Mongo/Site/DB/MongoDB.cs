using MongoDB.Driver;
using Site.Interfaces;
using Site.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Site.DB
{
    public class MongoDB : IDAL
    {
        private IMongoDatabase db { get; }

        public MongoDB()
        {
            try
            {//mongodb://username:password!@localhost
                MongoClientSettings settings = MongoClientSettings.FromUrl(new MongoUrl("mongodb://localhost"));
                //if (IsSSL)
                //{
                //    settings.SslSettings = new SslSettings { EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12 };
                //}
                var mongoClient = new MongoClient(settings);
                db = mongoClient.GetDatabase("UsersDb");
            }
            catch (Exception ex)
            {
                throw new Exception("Can not access to db server.", ex);
            }
        }

        public void AddUser(User user)
        {
            var users = db.GetCollection<User>("Users");
            users.InsertOne(user);
        }

        public List<User> GetUsers()
        {
            return db.GetCollection<User>("Users").AsQueryable<User>().ToList();
        }
    }
}
