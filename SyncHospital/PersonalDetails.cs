using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncHospital
{
    public class PersonalDetails
    {
        //•	Name
// •	FatherName
// •	Gender
// •	Phone
// •	Age
// •	BloodGroup
        public string Name{get;set;}
        public string FatherName{get;set;}
        public string Gender{get;set;}
        public string Phone{get;set;}
        public int Age{get;set;}
        public string BloodGroup{get;set;}
        public PersonalDetails(){}
        public PersonalDetails(string name,string fatherName,string gender,string phone,int age,string bloodGroup)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Phone=phone;
            Age=age;
            BloodGroup=bloodGroup;
        }

    }
}