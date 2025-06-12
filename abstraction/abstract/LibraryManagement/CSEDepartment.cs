using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class CSEDepartment:Library
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