using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncHospital
{
    public class AvailableSlotDetails
    {
//         •	DoctorID
// •	SlotID
// •	SlotTime
        public string DoctorID{get;set;}
        public string SlotID{get;set;}
        public string SlotTime{get;set;}
        public AvailableSlotDetails(){}
        public AvailableSlotDetails(string doctorID,string slotID,string slotTime)
        {
            DoctorID=doctorID;
            SlotID=slotID;
            SlotTime=slotTime;
        }

    }
}