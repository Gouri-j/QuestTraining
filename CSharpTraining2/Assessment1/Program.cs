using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    internal class Program
    {
        static List<Dictionary<string, string>> hospital = new List<Dictionary<string, string>>();
        static void AddDept()
        {
            var department = new Dictionary<string, string>();

            Console.WriteLine("Enter department name: ");
            department.Add("name", Console.ReadLine());

            Console.WriteLine("Enter the name of doctors assigned ");
            department.Add("doctors", Console.ReadLine());

            var id = Guid.NewGuid();
            department.Add("id", Guid.NewGuid().ToString());

            hospital.Add(department);

            Console.WriteLine("Department added successfully");
        }
        static void AddDoctor()
        {
            var doctor = new Dictionary<string, string>();

            Console.WriteLine("Enter doctor name:");
            doctor.Add("name", Console.ReadLine());

            var id = Guid.NewGuid();
            doctor.Add("id", Guid.NewGuid().ToString());

            Console.WriteLine("Enter department name: ");
            doctor.Add("departmentname", Console.ReadLine());

            Console.WriteLine("Doctor added successfully");

            hospital.Add(doctor);
        }
        static void AdmitPatient()
        {
            var patient = new Dictionary<string, string>();

            Console.WriteLine("Enter name of patient: ");
            patient.Add("name", Console.ReadLine());

            Console.WriteLine("Enter doctor name");
            patient.Add("drName", Console.ReadLine());

            Console.WriteLine("Enter doctor's id");
            patient.Add("dId",Console.ReadLine());

            Console.WriteLine("Enter department name");
            patient.Add("deptName", Console.ReadLine());

            var id = Guid.NewGuid();
            patient.Add("id", Guid.NewGuid().ToString());

            hospital.Add(patient);

            Console.WriteLine("Patient added successfully");
        }
        static void GetDoctorsByDepartment()
        {
            Console.WriteLine("Enter the department");
            string dept = Console.ReadLine();

            foreach(var department in hospital)
            {
                if (department["name"]  == dept)
                {
                    Console.WriteLine("Doctors: " + department["doctors"]);
                }
            }
        }
        static void GetPatientsByDoctor()
        {
            Console.WriteLine("Enter doctor's id: ");
            string doctId = Console.ReadLine();

            foreach (var patient in hospital)
            {
                if (patient["dId"] == doctId)
                {
                    Console.WriteLine("Patient names:" + patient["name"]);
                    Console.WriteLine("Department: " + patient["deptName"]);
                }
            }
        }
        static void Discharge()
        {
            Console.WriteLine("Enter patient's id");
            string patientId = Console.ReadLine();

            foreach( var patient in hospital)
            {
                if (patient["id"] == patientId)
                {
                    patient.Remove("id");
                    patient.Remove("name");
                    patient.Remove("drName");
                    patient.Remove("dId");
                    patient.Remove("deptName");
                }
               
            }
        }
        
        static void Main(string[] args)
        {
            var hospital = new List<Dictionary<string, string>>();
            while (true)
            {
                Console.WriteLine("1. Add department");
                Console.WriteLine("2. Add doctor");
                Console.WriteLine("3. Admit patient");
                Console.WriteLine("4. List doctors by department");
                Console.WriteLine("5. List patients by doctor");
                Console.WriteLine("6. To Discharge");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddDept();
                        break;
                    case "2":
                        AddDoctor();
                        break;
                    case "3":
                        AdmitPatient();
                        break;
                    case "4":
                        GetDoctorsByDepartment();
                        break;
                    case "5":
                        GetPatientsByDoctor();
                        break;
                    case "6":
                        Discharge();
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}
