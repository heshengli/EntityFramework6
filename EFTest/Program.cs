using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            TDbContext _TDbContext = new TDbContext();
            var users = _TDbContext.Set<T_User>();
            foreach (var item in users)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }
    }
}
