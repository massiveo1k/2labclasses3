using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2labclasses3
{
    internal class Program
    {
        public class User
        {
            public string someString = "Dodge1";
            public string someString2 = "Mark";
            public string someString3 = "Smith";
            public int someInt = 20;
            public DateTime someDateTime = DateTime.Now;    
        }
        static void Main(string[] args)
        {
            User someUser = new User();
            Console.WriteLine($"Login: { someUser.someString}; Name: {someUser.someString2}; Surname: {someUser.someString3}; Age: {someUser.someInt}; date of filling in the questionnaire: {someUser.someDateTime};");
            Console.ReadLine();
        }
    }
}

