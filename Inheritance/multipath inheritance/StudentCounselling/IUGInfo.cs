using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentCounselling
{
    public interface IUGInfo:IPersonalInfo
    {
        /*Create an application to handle student Counselling information: create 2 objects for PGCouncelling class

        Interface IPersonalInfo:
        Properties: AdharNumber, Name, FatherName, Phone, DOB, Gender

        Interface IHSCInfo: Inherits IPersonalInfo
        Properties: HSCMarksheetNumber, Physics, chemistry, maths, Total, percentage Marks
        Methods: ShowHSCMarksheet, CalculateHSC -> Total, percentage. 

        Interface IUGInfo: Inhertis IPersonalInfo
        Properties: UGMarksheetNumber, Sem1, Sem2, Sem3, Sem4 Marks, Total and Percentage
        Methods: SHowUGMarkSHeet, CalculateUG -> Total, percentage.

        Class PGCouncelling inherits IHSCInfo, IUGInfo
        Properties: ApplicationID, DateOfApplication, FeeStatus.
        Method: UpdateInfo, ShowInfo, PayFees -> 500 Rs.*/
        int UGMarksheetNumber{get;set;}
        int Sem1{get;set;}
        int Sem2{get;set;}
        int Sem3{get;set;}
        int Sem4{get;set;}
        int Total1{get;set;}
        int Percentage1{get;set;}
        string ShowUGMarksheet();
        void CalculateUG();
    }
}