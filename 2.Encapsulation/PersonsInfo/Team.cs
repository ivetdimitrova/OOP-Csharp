﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public Team(string name)
        {
            this.Name = name;
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
        }

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public IReadOnlyCollection<Person> FirstTeam
        {
            get { return this.firstTeam.AsReadOnly(); }
        }

        public IReadOnlyCollection<Person> ReserveTeam
        {
            get { return this.reserveTeam.AsReadOnly(); }
        }


        public void AddPlayer(Person person)
        {
            if (person.Age < 40)
                this.firstTeam.Add(person);
            else
                this.reserveTeam.Add(person);
        }

        public override string ToString()
        {
            return $"First team has {firstTeam.Count} players.\nReserve team has {reserveTeam.Count} players.";
        }
    }
}
