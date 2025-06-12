using System;
namespace LibraryManagement;

class Program
{
    public static void Main()
    {
        /*Create an application for library management application for method overriding
        Abstract class Library
        Field : serial number -LIB1000
        Property : serial number
        Abstract properties:, author name, book name, publisher name, year
        Abstract methods: set book info, display info

        Class EEEDepartment  inherit Library
        Overridden methods set bookinfo, display info

        Class CSEDepartment inherit Library
        Overridden methods set bookinfo, displayinfo
        Create objects for eee, cse and call the overridden method setbookinfo to provide values to 
        properties and displayinfo to display property data.*/
        Library library=new EEEDepartment();
        library.SetBookInfo("ram","rings of fire","publish",2025);
        System.Console.WriteLine(library.DisplayInfo());

        library=new CSEDepartment();
        library.SetBookInfo("sam","pacific rim","holly",2020);
        System.Console.WriteLine(library.DisplayInfo());

        
    }
}