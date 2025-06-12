using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace HotelManagement
{
    public class FileManager<T>
    {
        string _folder;
        // method to create folder
        public void CreateFolder()
        {
            _folder = typeof(T).Namespace;
            if(!Directory.Exists(_folder))
            {
                Directory.CreateDirectory(_folder);
            }
        }
        string _file;
        public void CreateFile()
        {
            _file = $"{_folder}/{typeof(T).Name}.csv";
            if(!File.Exists(_file))
            {
                File.Create(_file).Close();
            }
        }

        // method to write in csv
        public void WriteToCsv(CustomList<T> list)
        {
            CreateFolder();
            CreateFile();
            PropertyInfo[] properties = typeof(T).GetProperties();
            CustomList<string> content = new CustomList<string>();
            foreach(T data in list)
            {
                string[] column = new string[properties.Length];
                for(int i=0;i<properties.Length;i++)
                {
                    if(properties[i].CanRead)
                    {
                        if(properties[i].PropertyType==typeof(DateTime))
                        {
                            column[i] = ((DateTime)properties[i].GetValue(data)).ToString("dd/MM/yyyy",null);
                        }
                        else
                        {
                            column[i] = properties[i].GetValue(data).ToString() ?? "";
                        }
                    }
                }
                content.Add(string.Join(',',column));
            }
            File.WriteAllLines(_file,content.ToArray());
        }

        // method to readFrom csv
        public CustomList<T> ReadFromCsv()
        {
            CreateFolder();
            CreateFile();
            CustomList<T> contentList = new CustomList<T>();
            PropertyInfo[] properties = typeof(T).GetProperties();
            string[] values = File.ReadAllLines(_file);
            foreach(string value in values)
            {
                string[] data = value.Split(",");
                T newObject = Activator.CreateInstance<T>();
                for(int i=0;i<properties.Length;i++)
                {
                    if(properties[i].CanWrite)
                    {
                        if(properties[i].PropertyType==typeof(DateTime))
                        {
                            properties[i].SetValue(newObject,DateTime.ParseExact(data[i],"dd/MM/yyyy",null));
                        }
                        else if(properties[i].PropertyType.IsEnum)
                        {
                            properties[i].SetValue(newObject,Enum.Parse(properties[i].PropertyType,data[i]));
                        }
                        else
                        {
                            object val = Convert.ChangeType(data[i],properties[i].PropertyType);
                            properties[i].SetValue(newObject,val);
                        }
                    }
                }
                contentList.Add(newObject);
            }
            return contentList;
        }

    }
}