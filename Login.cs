using System;
using System.Collections.Generic;
using System.Linq;

namespace morningcsharp
{
    class Login
    {
      Dictionary<string, string> users = new Dictionary<string, string>();
        public Login()
        {
          users.Add("Tim", "cheese");
          users.Add("Xallan", "rogue");
        }

        public void Run()
        {
          bool running = true;
          while(running)
          {
            Console.WriteLine("Welcome to the site! Please login with your username and then password, or enter Q to exit.");
            Console.WriteLine("Username:");
            string unInput = Console.ReadLine();
            if (users.ContainsKey(unInput))
            {
              Console.WriteLine("Password:");
              string pwInput = Console.ReadLine();
              if (users[unInput] == pwInput)
              {
                Console.WriteLine("Successfully logged in!");
                running = false;
              }
              else if (pwInput.ToUpper() == "Q")
              {
                running = false;
              }
              else
              {
                Console.WriteLine("Password does not match.");
              }
            }
            else if (unInput.ToUpper() == "Q")
            {
              running = false;
            }
            else
            {
              Console.WriteLine("Username not found.");
            }
          }
        }
    }
}
