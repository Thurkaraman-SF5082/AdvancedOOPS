using System;
namespace OnlineLibrary;

class Program
{
    public static void Main()
    {
        /*Online Library Create and store 3 bookInfo details.

        Class DepartmentDetails:

        Properties: DepartmentName, Degree

        Class RackInfo: DepartmentDetails

        Properties: RackNumber, ColumnNumber

        Class BookInfo: Inherit RackInfo

        Properties: BookID, BookName, AuthorName, Price

        Method: Display info*/
        BookInfo book=new BookInfo("IT","B.Tech",2,4,"DSA","Paul",244.55);

        System.Console.WriteLine(book.DisplayDetails());
    }
}