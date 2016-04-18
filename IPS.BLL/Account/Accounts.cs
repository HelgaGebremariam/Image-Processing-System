using IPS.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPS.BLL.Account
{
    public static class Accounts
    {
        public static bool IsUserExist(string userName)
        {
            using (var context = new ImageDataEntities())
            {
                if (context.Users.Where(u => u.Name == userName).Count() > 0)
                    return true;
            }
            return false;
        }

        public static bool IsUserExist(int userID)
        {
            using (var context = new ImageDataEntities())
            {
                if (context.Users.Where(u => u.Id == userID).Count() > 0)
                    return true;
            }
            return false;
        }

        public static bool IsLoginDataValid(string userName, string passwordHash)
        {
            using (var context = new ImageDataEntities())
            {
                if (context.Users.Where(u => u.Password == passwordHash && u.Name == userName).Count() > 0)
                    return true;
            }
            return false;
        }
    }
}
