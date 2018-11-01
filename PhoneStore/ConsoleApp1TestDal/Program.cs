using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace ConsoleApp1TestDal
{
    class Program
    {
        static void Main(string[] args)
        {
            DALUser user = new DALUser() { Name = "Petro", Adress = "Petro@ukr.net" };
            Repository<DALUser> repository = new Repository<DALUser>(new Context());
            List<DALUser> users = new List<DALUser>();
            repository.Delete(user);
            users = repository.GetAll().ToList();

            foreach(var a in users)
            {
                Console.WriteLine(a.Name);
            }
        }
    }
}
