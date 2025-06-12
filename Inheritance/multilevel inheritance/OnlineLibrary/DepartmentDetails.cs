using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary
{
    public class DepartmentDetails
    {
        /*Online Library Create and store 3 bookInfo details.

        Class DepartmentDetails:

        Properties: DepartmentName, Degree

        Class RackInfo: DepartmentDetails

        Properties: RackNumber, ColumnNumber

        Class BookInfo: Inherit RackInfo

        Properties: BookID, BookName, AuthorName, Price

        Method: Display info*/
        public string DepartmentName { get; set; }
        public string Degree { get; set; }
        public DepartmentDetails(){}
        public DepartmentDetails(string departmentName,string degree)
        {
            DepartmentName=departmentName;
            Degree=degree;
        }
    }
}