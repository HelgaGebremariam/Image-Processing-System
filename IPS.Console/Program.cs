using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPS.BLL.Account;

namespace IPS.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Accounts.IsUserExist("helga"))
                System.Console.WriteLine("yes");
            else
                System.Console.WriteLine("No");

            Registration.RegisterUser("helgafm@yandex.ru", "V|ru$9112");
            System.Console.ReadKey();
        }
    }
}
