using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<Models.User>();

            users.Add(new Models.User { Name = "Dave", Password = "hello" });
            users.Add(new Models.User { Name = "Steve", Password = "steve" });
            users.Add(new Models.User { Name = "Lisa", Password = "hello" });

            // 1. Display to the console, the names of the users where the password is "hello"
            var names = from user in users
                        where user.Password.Equals("hello")
                        select user.Name;
            Console.WriteLine("Users with password \"hello\":");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            // 2.Delete any passwords that are the lower-cased version of their Name. 
            users.RemoveAll(user => user.Password.Equals(user.Name.ToLower()));

            // 3. Delete the first User that has the password "hello".
            var userWithHello = from user in users
                                where user.Password.Equals("hello")
                                select user;
            if (userWithHello.Any())
            {
                users.Remove(userWithHello.First());
            }

            // 4. Display to the console the remaining users with their Name and Password.
            Console.WriteLine("Remaining users:");
            foreach (var user in users)
            {
                Console.WriteLine("Name: {0}, Password: {1}", user.Name, user.Password);
            }
        }
    }
}
