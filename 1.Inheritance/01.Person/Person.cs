using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _01.Person
{
    public class Person
    {
        //private int _age;
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;

        }

        //public int Age
        //{

        //    get { return this._age; }
        //    set
        //    {
        //        if (value < 0)
        //            throw new ArgumentException("Age must be positive!");

        //        this._age = value;
        //    }
        //}

        public override string ToString()
        {
            return $"{this.GetType().Name} -> Name: {this.Name}, Age: {this.Age}";
        }

    }
}
