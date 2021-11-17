using Delegates.Classes;
using System;
using System.Collections.Generic;

namespace Delegates
{
    class Program
    {         
        static void Main(string[] args)
        {
            string s = "0123456789123456     ";
            MethodsForString.StringDelegate stringDelegate;
            stringDelegate = MethodsForString.CutString;
            stringDelegate(s);
            Console.WriteLine(s);

            // List<User>
            List<User> userList = new List<User>();
            userList.Add(new User("Sam", "M", 19));
            userList.Add(new User("Jane", "F", 27));
            userList.Add(new User("Jack", "M", 31));

            FileringMethods.FilterDelegate filterDelegate;
            filterDelegate = FileringMethods.AgeFilter;
            var filterList = FileringMethods.Filter(filterDelegate, userList);
            
            foreach (var user in filterList)
            {
                Console.WriteLine(user);
            }

        }
    }
}

