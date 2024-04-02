using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSpace
{
    internal class Student :User
    {
        public int Grade { get; set; }

        public void Run()
        {
            string[] user = { "Nicat", "Pasha", "Ali", "Vuqar" };

            string[] pass = { "123", "456", "987" };

            Console.WriteLine("Zehmet olmasa istifadeci adinizi daxil edin...");
            string username = Console.ReadLine();
            Console.WriteLine("Zehmet olmasa parol daxil edin...");
            string password = Console.ReadLine();
            bool check = false;

            for (int i = 0; i < user.Length; i++)
            {
                for (int j = 0; j < pass.Length; j++)
                {
                    if (username == user[i])
                    {
                        check = true;

                    }
                    else if (pass[j] == password)
                    {
                        check = true;
                    }
                    else
                    {
                        check = false;
                    }

                }
                if (check==true)
                {
                    Console.WriteLine(check);
                    Console.WriteLine("Grade");
                }
                else
                {
                    Console.WriteLine("Bele bir istifadeci tapilmadi");
                }
               
                break;
            }
        }
    }
}
