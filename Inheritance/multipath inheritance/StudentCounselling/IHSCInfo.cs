using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentCounselling
{
    public interface IHSCInfo:IPersonalInfo
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
        int HSCMarksheetNumber{get;set;}
        int Physics{get;set;}
        int Chemistry{get;set;}
        int Maths{get;set;}
        int Total{get;set;}
        int Percentage{get;set;}
        string ShowHSCMarksheet();
        void CalculateHSC();
    }
}