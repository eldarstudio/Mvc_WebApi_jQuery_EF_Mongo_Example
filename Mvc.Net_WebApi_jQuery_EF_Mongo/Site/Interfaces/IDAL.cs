using Site.Models;
using System;
using System.Collections.Generic;

namespace Site.Interfaces
{
    public interface IDAL
    {
      void AddUser(User user);
      List<User> GetUsers();
    }
}
