using Service__and_İnterface.Service.İnterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service__and_İnterface.Service
{
    internal class AccountService : IAccountService
    {
        public void Account(string username, string password)
        {
            if (username == "cavid123" && password == "Cavid1993")
            {
                Console.WriteLine("giris ugurludur");
            }
            else
            {
                Console.WriteLine("sehvdir");
            }
        }
    }
}
