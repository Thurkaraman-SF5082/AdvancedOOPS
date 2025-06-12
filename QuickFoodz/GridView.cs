using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;

namespace QuickFoodz
{
    public class GridView<Type>
    {
        public void DisplayDetails(CustomList<Type> list)
        {
            PropertyInfo[] properties=typeof(Type).GetProperties();

            System.Console.WriteLine(new string('-',properties.Length*25));
            foreach(PropertyInfo property in properties)
            {
                System.Console.Write($"|{property.Name,-24}");
            }
            System.Console.WriteLine($"|\n{new string('-',properties.Length*25)}");

            foreach(Type data in list)
            {
                foreach(PropertyInfo property in properties)
                {
                    if(property.CanRead)
                    {
                        if(property.PropertyType==typeof(DateTime))
                        {
                            System.Console.Write($"|{((DateTime)property.GetValue(data)).ToString("dd/MM/yyyy"),-24}");
                        }
                        else
                        {
                            System.Console.Write($"|{property.GetValue(data),-24}");
                        }
                    }
                }
                System.Console.WriteLine("|");
            }
            System.Console.WriteLine(new string('-',properties.Length*25));
        }
    }
}