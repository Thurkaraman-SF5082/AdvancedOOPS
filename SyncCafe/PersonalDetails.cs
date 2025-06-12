using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncCafe
{
    public class PersonalDetails
    {
        /*Properties: 
        a.	CustomerName 
        b.	FatherName
        c.	Gender {Enum – Male, Female, Others}
        d.	MobileNumber 
        e.	DateOfBirth
        f.	MailID 
        */

        public string CustomerName{get;set;}
        public string FatherName{get;set;}
        public GenderDetails Gender{get;set;}
        public string MobileNumber{get;set;}
        public DateTime DOB{get;set;}
        public string MailID{get;set;}
        public PersonalDetails(string customerName,string fatherName,GenderDetails gender,string mobileNumber,DateTime dob,string mailID)
        {
            CustomerName=customerName;
            FatherName=fatherName;
            Gender=gender;
            MobileNumber=mobileNumber;
            DOB=dob;
            MailID=mailID;
        }
    }
}