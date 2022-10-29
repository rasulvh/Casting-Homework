using Casting.Models;
using Service.Helpers.Extensions;
using Service.Services;
using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework
            //Login();

            //int num = 4;
            //if (CheckNum(num))
            //{
            //    Console.WriteLine(num.CalculateFactorial()); 
            //}
            //else
            //{
            //    Console.WriteLine("Duzgun eded daxil edin");
            //}
            #endregion

            //Eagle eagle1 = new Eagle();

            //Animal animal = eagle1;

            //Animal animal2 = new Eagle();

            //animal2.Eat();

            //int num1 = 15;
            //byte num2 = (byte)num1;

            //byte num3 = 5;
            //int num4 = num3;

            //int a = 10;
            //object b = a;

            //int c = (int)b;

            //Console.WriteLine(b);

            //Eagle eagle1 = new Eagle();
            //Animal eagle2 = new Eagle();

            //Shark shark1 = new Shark();
            //Animal shark2 = new Shark();

            //Shark shark3 = (Shark)shark2;

            //Animal[] animals = { eagle1, eagle2, shark1, shark2 };

            //foreach (var item in animals)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //Animal shark1 = new Shark();
            //Animal shark2 = new Shark();

            //object[] objects = { 1, 2, "P414", shark1, shark2 };

            //foreach (var item in objects)
            //{
            //Animal animal = item as Animal;

            //string result = animal == null ? "Can't cast" : "Successfull";

            //bool isCast = animal == null ? true : false;

            //if (!isCast)
            //{
            //    string result = animal.Name ?? "random";
            //    Console.WriteLine(result);
            //}

            //if (animal == null)
            //{
            //    Console.WriteLine("Can't cast");
            //}
            //else
            //{
            //    animal.Name = "test";
            //    Console.WriteLine(animal.Name);

            //    Console.WriteLine("Successfull");
            //}




            //if (item is Animal t)
            //{
            //    t.Name = "Akula";
            //    Console.WriteLine(t.Name);
            //}
            //else
            //{
            //    //Console.WriteLine("Can't cast");
            //    //Console.WriteLine(item);
            //}
            //}

        }

        #region Homework
        public static void Login()
        {
            Console.WriteLine("Email daxil edin:");
            string email = Console.ReadLine();
            Console.WriteLine("Password daxil edin:");
            string password = Console.ReadLine();
            int role = 1;

            AccountService account = new AccountService();
            Console.WriteLine(account.Login(email, password, role));
        }

        public static bool CheckNum(int num)
        {
            if (num < 0)
            {
                return false;
            }
            return true;
        }
        #endregion
    }
}