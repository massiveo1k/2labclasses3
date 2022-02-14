using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2labclasses3
{

    internal class User
    {
        private string login;
        private string name;
        private string surname;
        private int age;

        public readonly DateTime date;
        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
            }


        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }


        }

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }


        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }


        }

        public User()
        {
            date = DateTime.Now;
        }
    }
}


