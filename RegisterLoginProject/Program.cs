using System;

namespace RegisterLoginProject
{
    class MainClass
    {
        static string username;
        static string password;

        public static void Register()
        {
            Console.WriteLine("Welcome, please register a user account. ");
            Console.Write("Enter a username: ");
            username = Console.ReadLine();
            Console.Write("Enter a password: ");
            password = Console.ReadLine();
            Console.WriteLine("Thank you, you are now registered!");
            Console.WriteLine("-----------------------------------------------");
        }

        public static void Login()
        {
            Console.Write("To login, please enter a valid username: ");
			//string userLogin = Console.ReadLine();
			//if(userLogin.Equals(username))
			if (username == Console.ReadLine())
            {
                Console.Write("Please enter your password: ");
				//string userPass = Console.ReadLine();
				//if(userPass.Equals(password))
				if (password == Console.ReadLine())
                {
                    Console.WriteLine("You are now logged in!");
                } else
                {
                    Console.WriteLine("That is not a valid password. Please restart the app and try again.");
                }
            } else
            {
                Console.WriteLine("That is not a valid username. Please restart the app and try again.");
            }
        }

        public static void Main(string[] args)
        {
            Register();
            Login();
            //Console.Read();
        }
    }
}
