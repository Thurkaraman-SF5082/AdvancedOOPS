using System;
namespace AnimalInfo;

class Program
{
    public static void Main()
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

       IAnimal animal=new Dog("puppy","domestic","non-veg");
       System.Console.WriteLine(animal.DisplayName());

       animal=new Duck("buggy","domestic","veg");
       System.Console.WriteLine(animal.DisplayName()); 
        
    }
}