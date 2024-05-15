using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TESTS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;
            Console.Write("Enter your name:");
            User.Name = Console.ReadLine();
            Console.WriteLine("Enter your LastName:");
            User.LastName = Console.ReadLine();
            Console.WriteLine("Enter your login:");
            User.Login = Console.ReadLine();
            Console.WriteLine();
            User.LoginLength =  User.Login.Length;
            Console.WriteLine("You have pet?Yes or No:");
            var result = Console.ReadLine();
            if (result == "Yes")
            {
                User.HasPet = true;
            }
            else
            {
                User.HasPet = false;
            }
            User.favcolors = new string[3];
            Console.WriteLine("Enter three colors user:");
            for (int i = 0; i < User.favcolors.Length; i++)
            {
                User.favcolors[i] = Console.ReadLine();
            }
            Console.WriteLine("Enter your age:");
            User.Age = double.Parse(Console.ReadLine());
            Console.ReadKey();







        }
    }
}
