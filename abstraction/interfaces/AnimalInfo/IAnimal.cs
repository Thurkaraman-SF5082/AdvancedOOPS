using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalInfo
{
    public interface IAnimal
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
        string Name{get;set;}
        string Habitat{get;set;}
        string EatingHabit{get;set;}
        string DisplayName();
    }
}