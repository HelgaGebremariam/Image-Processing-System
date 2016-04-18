using IPS.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPS.BLL.Account
{
    public static class Registration
    {
        public static bool RegisterUser(string userName, string password)
        {
            if (Accounts.IsUserExist(userName))
                return false;
            using (var context = new ImageDataEntities())
            {
                User userEntity = new User()
                {
                    Name = userName,
                    Password = password,
                    Role = 2

                };
                context.Users.Add(userEntity);
                context.SaveChanges();
            }
            return true;
        }     
    }
}
