using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentCounselling
{
    public interface IPersonalInfo
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
        long AdharNumber{get;set;}
        string Name{get;set;}
        string FatherName{get;set;}
        string Phone{get;set;}
        DateTime DOB{get;set;}
        string Gender{get;set;}
    }
}