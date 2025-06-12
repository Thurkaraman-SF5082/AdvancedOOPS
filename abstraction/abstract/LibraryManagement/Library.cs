using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public abstract class Library
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
        private int s_serialNumber=1000;
        public string SerialNumber{get;set;}
        public abstract string AuthorName{get;set;}
        public abstract string BookName{get;set;}
        public abstract string PublisherName{get;set;}
        public abstract int Year{get;set;}

        public Library()
        {
            SerialNumber=$"LIB{++s_serialNumber}";
        }
        public abstract void SetBookInfo(string authorName,string bookName,string publisherName,int year);
        public abstract string DisplayInfo();
    }
}