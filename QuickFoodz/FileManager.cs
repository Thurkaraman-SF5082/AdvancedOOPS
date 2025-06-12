using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace QuickFoodz
{
    public class FileManager<Type>
    {
        string folderName;
        string fileName;
        public void CreateFolder()
        {
            folderName = new Program().GetType().Namespace;

            if (!Directory.Exists(folderName))
            {
                System.Console.WriteLine("Folder created");
                Directory.CreateDirectory(folderName);
            }
            else
            {
                System.Console.WriteLine("Folder already exist");
            }
        }
        public void CreateFile()
        {
            fileName = $"{folderName}/{typeof(Type).Name}.csv";

            if (!File.Exists(fileName))
            {
                System.Console.WriteLine("File created");
                File.Create(fileName).Close();
            }
            else
            {
                System.Console.WriteLine("File already exist");
            }
        }
        public void WriteToCSV(CustomList<Type> list)
        {
            CreateFolder();
            CreateFile();

            CustomList<string> row = new CustomList<string>();

            PropertyInfo[] properties = typeof(Type).GetProperties();

            foreach (Type data in list)
            {
                string[] column = new string[properties.Length];
                for (int i = 0; i < properties.Length; i++)
                {
                    PropertyInfo property = properties[i];
                    if (property.CanRead)
                    {
                        if (property.PropertyType == typeof(DateTime))
                        {
                            column[i] = ((DateTime)property.GetValue(data)).ToString("dd/MM/yyyy");
                        }
                        else
                        {
                            column[i] = property.GetValue(data).ToString() ?? "";
                        }
                    }
                }
                row.Add(string.Join(",", column));
            }
            File.WriteAllLines(fileName, row.ToArray());
        }
        public CustomList<Type> ReadFromCSV()
        {
            CreateFolder();
            CreateFile();

            CustomList<Type> list = new CustomList<Type>();

            PropertyInfo[] properties = typeof(Type).GetProperties();

            string[] contents = File.ReadAllLines(fileName);
            foreach (string content in contents)
            {
                string[] values = content.Split(",");
                Type newObject = Activator.CreateInstance<Type>();

                for (int i = 0; i < properties.Length; i++)
                {
                    PropertyInfo property = properties[i];
                    if (property.CanWrite)
                    {
                        if (property.PropertyType == typeof(DateTime))
                        {
                            property.SetValue(newObject,DateTime.ParseExact(values[i],"dd/MM/yyyy",null));
                        }
                        else if(property.PropertyType.IsEnum)
                        {
                            Enum.TryParse(property.PropertyType,values[i],true,out object data);
                            property.SetValue(newObject,data);
                        }
                        else
                        {
                            var value=Convert.ChangeType(values[i],property.PropertyType);
                            property.SetValue(newObject,value);
                        }
                    }
                }
                list.Add(newObject);
            }
            return list;
        }
    }
}