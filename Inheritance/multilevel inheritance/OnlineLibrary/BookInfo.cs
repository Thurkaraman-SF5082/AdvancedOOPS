using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary
{
    public class BookInfo:RackInfo
    {
        /*Online Library Create and store 3 bookInfo details.

        Class DepartmentDetails:

        Properties: DepartmentName, Degree

        Class RackInfo: DepartmentDetails

        Properties: RackNumber, ColumnNumber

        Class BookInfo: Inherit RackInfo

        Properties: BookID, BookName, AuthorName, Price

        Method: Display info*/
        private int s_bookID=0;
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public double Price { get; set; }

        public BookInfo(){}
        public BookInfo(string departmentName,string degree,int rackNumber,int columnNumber,string bookName,string authorName,double price):base(departmentName,degree,rackNumber,columnNumber)
        {
            s_bookID++;
            BookID=s_bookID;
            BookName=bookName;
            AuthorName=authorName;
            Price=price;
        }
        public string DisplayDetails()
        {
            return $"DepartmentName:{DepartmentName}, Degree:{Degree}, RackNumber:{RackNumber}, ColumnNumber:{ColumnNumber}, BookID:{BookID}, BookName:{BookName}, AuthorName:{AuthorName}, Price:{Price}";
        }
    }
}