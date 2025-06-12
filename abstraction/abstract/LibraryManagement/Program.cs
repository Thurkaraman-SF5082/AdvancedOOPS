using System;
namespace LibraryManagement;

class Program
{
    public static void Main()
    {
        /*Create an application for library management application
        Abstract class Library

        Field : serial number -LIB1000

        Property : SerialNumber

        Abstract properties:, AuthorName, BookName, PublisherName, Year

        Abstract methods: SetBookInfo, DisplayInfo
        Class EEEdepartment  inherit Library

        Overridden methods set bookinfo, display info
        Class CSEDepartment inherit Library

        Overridden methods set bookinfo, displayinfo
        Create objects for EEE, CSE departments using set book info set values to properties the serial number is auto 
        incremented property. If any book set serial number might be auto incremented. Using display info display the book info..*/
        Library library=new EEEDepartment();
        library.SetBookInfo("ram","rings of fire","publish",2025);
        System.Console.WriteLine(library.DisplayInfo());

        library=new CSEDepartment();
        library.SetBookInfo("sam","pacific rim","holly",2020);
        System.Console.WriteLine(library.DisplayInfo());

        
    }
}