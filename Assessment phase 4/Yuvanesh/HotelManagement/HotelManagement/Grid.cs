using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace HotelManagement
{
    public class Grid<T>
    {
        // method to display the grid
        public void Display(CustomList<T> lists)
        {
            PropertyInfo[] properties = typeof(T).GetProperties();
            // printing the header line
            System.Console.WriteLine(new string('-',properties.Length*18));
            // printing headers
            foreach(PropertyInfo property in properties)
            {
                System.Console.Write($"| {property.Name,-15}");
            }
            System.Console.WriteLine("|");
            System.Console.WriteLine(new string('-',properties.Length*18));
            // printing values
            foreach(T list in lists)
            {
                foreach(PropertyInfo property in properties)
                {
                    if(property.CanRead)
                    {
                        if(property.PropertyType==typeof(DateTime))
                        {
                            object date = ((DateTime)property.GetValue(list)).ToString("dd/MM/yyyy",null);
                            System.Console.Write($"| {date,-15}");
                        }
                        else
                        {
                            System.Console.Write($"| {property.GetValue(list),-15}");
                        }
                    }
                }
                System.Console.WriteLine("|");
            }
            System.Console.WriteLine(new string('-',properties.Length*18));
        }
    }
}