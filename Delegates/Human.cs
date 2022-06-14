using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Delegates
{
    class Human
    {
        public string Name { get; set; }
        public string  SurName { get; set; }
        public int Age { get; set; }
      
        public Human() 
        { 
        }
      
        public Human(string name,string surname,int age):this()
        {
            Name = name;
            SurName = surname;
            Age = age;
        }

    }

    
}
