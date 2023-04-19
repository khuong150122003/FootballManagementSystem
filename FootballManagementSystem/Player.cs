using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagementSystem
{
    
        class Player : IPlayer
        {
            string name;
            public string Name { get { return name; } set { name = value; } }
            int age;
            public int Age { get { return age; } set { age = value; } }
            int attack;
            public int Attack { get { return attack; } set { attack = value; } }
            int defense;
            public int Defense { get { return defense; } set { defense = value; } }
            int stamina;
            public int Stamina { get { return stamina; } set { stamina = value; } }
            int speed;
            public int Speed { get { return speed; } set { speed = value; } }
            int power;
            public int Power { get { return power; } set { power = value; } }

            public void GetInfo()
            {
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Age: " + Age);
                Console.WriteLine("Average point: " + (Attack + Defense + Stamina + Speed + Power) / 5.0f);
            }
        }
    }

