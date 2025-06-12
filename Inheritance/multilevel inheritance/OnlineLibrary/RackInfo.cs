using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary
{
    public class RackInfo:DepartmentDetails
    {
        /*Online Library Create and store 3 bookInfo details.

        Class DepartmentDetails:

        Properties: DepartmentName, Degree

        Class RackInfo: DepartmentDetails

        Properties: RackNumber, ColumnNumber

        Class BookInfo: Inherit RackInfo

        Properties: BookID, BookName, AuthorName, Price

        Method: Display info*/
        public int RackNumber { get; set; }
        public int ColumnNumber { get; set; }
        public RackInfo(){}
        public RackInfo(string departmentName,string degree,int rackNumber,int columnNumber):base(departmentName,degree)
        {
            RackNumber=rackNumber;
            ColumnNumber=columnNumber;
        }
    }
}