using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace HotelManagement
{
    public class Gridview<Type>
    {
        public void DisplayDetails(CustomList<Type> list)
        {
            PropertyInfo[] properties=typeof(Type).GetProperties();
            System.Console.WriteLine(new string('-',properties.Length*18));

            foreach(PropertyInfo property in properties)
            {
                System.Console.Write($"|{property.Name,-15}");
            }

            System.Console.WriteLine($"|\n{new string('-',properties.Length*18)}");

            foreach(Type data in list)
            {
                foreach(PropertyInfo property in properties)
                {
                    if(property.CanRead)
                    {
                        if(property.PropertyType==typeof(DateTime))
                        {
                            System.Console.Write($"|{((DateTime)property.GetValue(data)).ToString("dd/MM/yyyy"),-15}");
                        }
                        else
                        {
                            System.Console.Write($"|{property.GetValue(data),-15}");
                        }
                    }
                }
                System.Console.WriteLine("|");
            }
            System.Console.WriteLine(new string('-',properties.Length*18));
        }
    }
}