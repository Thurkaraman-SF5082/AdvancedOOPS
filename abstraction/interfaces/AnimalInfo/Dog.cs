using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalInfo
{
    public class Dog:IAnimal
    {
        /*Create an application that logs various animal info

        Interface : IAnimal

        Property: Name, Habitat, Eating Habit

        Method: DisplayName

        Class Dog interface IAnimal

        Method: Display info

        Class Duck interface IAnimal

        Method: Display info

        Create two dog objects and duck objects and display object info of four.*/
        public string Name{get;set;}
        public string Habitat{get;set;}
        public string EatingHabit{get;set;}
        public Dog(){}
        public Dog(string name,string habitat,string eatingHabit)
        {
            Name=name;
            Habitat=habitat;
            EatingHabit=eatingHabit;
        }
        public string DisplayName()
        {
            return $"Name:{Name}, Habitat:{Habitat}, Eating Habit:{EatingHabit}";
        }
    }
}