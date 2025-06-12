using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class CSEDepartment:Library
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
        public override string AuthorName{get;set;}
        public override string BookName{get;set;}
        public override string PublisherName{get;set;}
        public override int Year{get;set;}

        public CSEDepartment()
        {
            
        }
        public override void SetBookInfo(string authorName,string bookName,string publisherName,int year)
        {
            AuthorName=authorName;
            BookName=bookName;
            PublisherName=publisherName;
            Year=year;
        }
        public override string DisplayInfo()
        {
            return $"SerialNumber:{SerialNumber}, AuthorName:{AuthorName}, BookName:{BookName}, PublisherName:{PublisherName}, Year:{Year}";
        }
    }
}