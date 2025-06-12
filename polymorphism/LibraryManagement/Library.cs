using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public abstract class Library
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