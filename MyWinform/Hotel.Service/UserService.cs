using Hotel_Data.ProgramDbContext;
using Hotel_Domain.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Service
{
    public  class UserService : Generel
    {
       

        public static void AddUser(User user)
        {
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }

        public static User GetUser(int id)
        {
            return dbContext.Users.FirstOrDefault(x => x.Id == id);
        }

    }
}
