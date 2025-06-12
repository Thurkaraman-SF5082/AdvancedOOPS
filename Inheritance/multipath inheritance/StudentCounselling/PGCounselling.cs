using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentCounselling
{
    public class PGCounselling:IHSCInfo,IUGInfo
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
        private int s_applicationID=0;
        public int ApplicationID{get;set;}
        public DateTime DateOfApplication{get;set;}
        public string FeeStatus{get;set;}
        public long AdharNumber{get;set;}
        public string Name{get;set;}
        public string FatherName{get;set;}
        public string Phone{get;set;}
        public DateTime DOB{get;set;}
        public string Gender{get;set;}
        public int HSCMarksheetNumber{get;set;}
        public int Physics{get;set;}
        public int Chemistry{get;set;}
        public int Maths{get;set;}
        public int Total{get;set;}
        public int Percentage{get;set;}
        public int UGMarksheetNumber{get;set;}
        public int Sem1{get;set;}
        public int Sem2{get;set;}
        public int Sem3{get;set;}
        public int Sem4{get;set;}
        public int Total1{get;set;}
        public int Percentage1{get;set;}
        public PGCounselling(DateTime dateOfApplication,string feeStatus,long adharNumber,string name,string fatherName,string phone,DateTime dob,string gender,int hscMarksheetNumber,int physics,int chemistry,int maths,int ugMarksheetNumber,int sem1,int sem2,int sem3,int sem4)
        {
            s_applicationID++;
            ApplicationID=s_applicationID;
            DateOfApplication=dateOfApplication;
            FeeStatus=feeStatus;
            AdharNumber=adharNumber;
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            DOB=dob;
            Gender=gender;
            HSCMarksheetNumber=hscMarksheetNumber;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
            UGMarksheetNumber=ugMarksheetNumber;
            Sem1=sem1;
            Sem2=sem2;
            Sem3=sem3;
            Sem4=sem4;
        }
        
        public string ShowHSCMarksheet()
        {
            CalculateHSC();
            return $"HSCMarksheetNumber:{HSCMarksheetNumber}, Physics:{Physics}, chemistry:{Chemistry}, maths:{Maths}, Total:{Total}, percentage:{Percentage}";
        }
        public void CalculateHSC()
        {
            Total=Physics+Chemistry+Maths;
            Percentage=Total/3;
        }
        public string ShowUGMarksheet()
        {
            CalculateUG();
            return $"UGMarksheetNumber:{UGMarksheetNumber}, Sem1:{Sem1}, Sem2:{Sem2}, Sem3:{Sem3}, Sem4:{Sem4} Total:{Total1}, Percentage:{Percentage1}";
        }
        public void CalculateUG()
        {
            Total1=Sem1+Sem2+Sem3+Sem4;
            Percentage1=Total/4;
        }
        //Method: UpdateInfo, ShowInfo, PayFees -> 500 Rs
        public void UpdateInfo(DateTime dateOfApplication,string feeStatus,long adharNumber,string name,string fatherName,string phone,DateTime dob,string gender,int hscMarksheetNumber,int physics,int chemistry,int maths,int ugMarksheetNumber,int sem1,int sem2,int sem3,int sem4)
        {
            DateOfApplication=dateOfApplication;
            FeeStatus=feeStatus;
            AdharNumber=adharNumber;
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            DOB=dob;
            Gender=gender;
            HSCMarksheetNumber=hscMarksheetNumber;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
            UGMarksheetNumber=ugMarksheetNumber;
            Sem1=sem1;
            Sem2=sem2;
            Sem3=sem3;
            Sem4=sem4;
        }
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

        public string ShowInfo()
        {
            CalculateHSC();
            CalculateUG();
            return $"ApplicationID:{ApplicationID}, DateOfApplication:{DateOfApplication}, FeeStatus:{FeeStatus}\nAdharNumber:{AdharNumber}, Name:{Name}, FatherName:{FatherName}, Phone:{Phone}, DOB:{DOB}, Gender:{Gender}\nHSCMarksheetNumber:{HSCMarksheetNumber}, Physics:{Physics}, chemistry:{Chemistry}, maths:{Maths}, Total:{Total}, percentage:{Percentage}\nUGMarksheetNumber:{UGMarksheetNumber}, Sem1:{Sem1}, Sem2:{Sem2}, Sem3:{Sem3}, Sem4:{Sem4} Total:{Total1}, Percentage:{Percentage1}";
        }
        public string PayFees()
        {
            if(FeeStatus!="PAID")
            {
                FeeStatus="PAID";
                return "Fees paid successfully";
            }
            else
            {
                return "Fees already paid";
            }
        }
    }
}