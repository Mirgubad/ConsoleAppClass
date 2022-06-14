using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Delegates
{
    class Employee  :Human
    {
        public string  Position { get; set; }


        public Employee()
        {
          
            

        }
        public Employee(string name ,string surname,int age,string position):base(name,surname,age)
        {

            Name = name;
            SurName = surname;
            Age = age;
            Position = position;
        }
    }
}
