using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncHospital
{
    public class Operation
    {
        List<DoctorDetails> doctors = new List<DoctorDetails>();
        List<AvailableSlotDetails> availableSlots = new List<AvailableSlotDetails>();
        List<PatientDetails> patients = new List<PatientDetails>();
        List<AppoinmentDetails> appoinments = new List<AppoinmentDetails>();
        PatientDetails currentPatient;

        public void DefaultData()
        {
            DoctorDetails doctor1 = new DoctorDetails("John", "Joe", "Male", "89877", 33, "O+ve", 20, "General", 200);
            DoctorDetails doctor2 = new DoctorDetails("Saravanan", "Mani", "Male", "98776", 39, "A1+ve", 30, "Heart", 500);
            DoctorDetails doctor3 = new DoctorDetails("Kavi", "Karthi", "Male", "77886", 34, "B+ve", 40, "Ortho", 100);

            doctors.AddRange(new List<DoctorDetails>() { doctor1, doctor2, doctor3 });

            AvailableSlotDetails available1 = new AvailableSlotDetails("DID301", "SL101", "6.00-6.30");
            AvailableSlotDetails available2 = new AvailableSlotDetails("DID301", "SL102", "6.30-7.00");
            AvailableSlotDetails available3 = new AvailableSlotDetails("DID301", "SL103", "7.00-7.30");
            AvailableSlotDetails available4 = new AvailableSlotDetails("DID301", "SL104", "7.30-8.00");
            AvailableSlotDetails available5 = new AvailableSlotDetails("DID301", "SL105", "8.00-8.30");
            AvailableSlotDetails available6 = new AvailableSlotDetails("DID301", "SL106", "8.30-9.00");
            AvailableSlotDetails available7 = new AvailableSlotDetails("DID302", "SL101", "6.00-6.30");
            AvailableSlotDetails available8 = new AvailableSlotDetails("DID302", "SL102", "6.30-7.00");
            AvailableSlotDetails available9 = new AvailableSlotDetails("DID302", "SL103", "7.00-7.30");
            AvailableSlotDetails available10 = new AvailableSlotDetails("DID302", "SL104", "7.30-8.00");
            AvailableSlotDetails available11 = new AvailableSlotDetails("DID303", "SL104", "7.30-8.00");
            AvailableSlotDetails available12 = new AvailableSlotDetails("DID303", "SL105", "8.00-8.30");
            AvailableSlotDetails available13 = new AvailableSlotDetails("DID303", "SL106", "8.30-9.00");

            availableSlots.AddRange(new List<AvailableSlotDetails>() { available1, available2, available3, available4, available5, available6, available7, available8, available9, available10, available11, available12, available13 });

            PatientDetails patient1 = new PatientDetails("Arun", "Mani", "Male", "75757", 45, "O+ve", 1000);
            PatientDetails patient2 = new PatientDetails("Kumar", "Suresh", "Male", "57755", 50, "A+ve", 500);
            PatientDetails patient3 = new PatientDetails("Malar", "Ganesh", "Female", "58855", 30, "B-ve", 100);
            PatientDetails patient4 = new PatientDetails("Selvi", "Pandi", "Female", "58858", 20, "O+ve", 50);

            patients.AddRange(new List<PatientDetails>() { patient1, patient2, patient3, patient4 });

            AppoinmentDetails appoinment1 = new AppoinmentDetails("PID1001", "DID301", new DateTime(2022, 04, 27), "SL101", AppoinmentStatus.Booked, 200);
            AppoinmentDetails appoinment2 = new AppoinmentDetails("PID1002", "DID302", new DateTime(2022, 04, 27), "SL102", AppoinmentStatus.Booked, 500);
            AppoinmentDetails appoinment3 = new AppoinmentDetails("PID1003", "DID303", new DateTime(2022, 04, 27), "SL104", AppoinmentStatus.Booked, 100);
            AppoinmentDetails appoinment4 = new AppoinmentDetails("PID1001", "DID303", new DateTime(2022, 04, 27), "SL106", AppoinmentStatus.Cancelled, 100);

            appoinments.AddRange(new List<AppoinmentDetails>(){appoinment1,appoinment2,appoinment3,appoinment4});

        }
    }
}