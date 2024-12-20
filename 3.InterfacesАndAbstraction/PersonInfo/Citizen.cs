﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfo
{
    public class Citizen : IPerson , IIdentifiable,IBirthable
    {
        public Citizen(string name, int age, string id , string birthDate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthDate;
        }

        public string Name { get; }
        public int Age { get; }
        public string Id { get; }
        public string Birthdate { get; }
    }
}
