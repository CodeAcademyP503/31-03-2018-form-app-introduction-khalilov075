using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormCRUD
{
    
    class User
    {
        public static List<User> List = new List<User>();
        public int Id;
        public string Name;
        public string Surname;
        public int Age;
        public User(string _name,string _surname,int _age)
        {
            this.Name = _name;
            this.Surname = _surname;
            this.Age = _age;
            List.Add(this);
        }


    }
}
