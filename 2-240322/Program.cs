using System;

namespace _2_240322
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ad Soyad: ");
            string FullName = Console.ReadLine();
            Console.Write("Email: ");
            string Email = Console.ReadLine();
            User user = new User(FullName, Email);
            Console.Write("Password: ");
            user.Password = Console.ReadLine();
            user.FullName = FullName;
            user.Email = Email;

            Console.WriteLine(user.ShowInfo());
        }
    }
}
