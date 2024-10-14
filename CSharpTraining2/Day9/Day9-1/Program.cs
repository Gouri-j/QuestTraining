using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_1
{
    internal class Program
    {
        static List<Dictionary<string, string>> patients = new List<Dictionary<string, string>>();
        static void AddPatient()
        {
            var patient = new Dictionary<string, string>();

            Console.WriteLine("Enter patient name: ");
            patient.Add("name", Console.ReadLine());

            Console.WriteLine("Enter the patient age: ");
            patient.Add("age",Console.ReadLine());

            Console.WriteLine("Enter the symptos as comma seperated values: ");
            patient.Add("symptoms",Console.ReadLine()) ;

            var id = Guid.NewGuid();
            patient.Add("id",Guid.NewGuid().ToString());
            patients.Add(patient);

            Console.WriteLine("Patient added successfully");
        }
        static void GetPatientById(string id)
        {
            Console.WriteLine("Enter patient id: ");
            var id = Console.ReadLine();
            foreach (var patient in patients)
            {
                if (patient["id"] == id)
                {
                    Console.WriteLine("Name: " + patient["name"]);
                    Console.WriteLine("Age: " + patient["age"]);
                    Console.WriteLine("Symptoms: " + patient["symptoms"]);
                    break;
                }
            } 
        }
        static void GetPatientBySymptom()
        {
            Console.Write("Enter the symptoms: ");
            string symptoms = Console.ReadLine();
            foreach (var patient in patients)
            {
                var details = patient.Value;
                if (details["Symptoms"].Contains(symptoms))
                {
                    Console.WriteLine("Name: " + patient["name"]);
                    Console.WriteLine("Age: " + patient["age"]);
                }
            }
        }
        static void Main(string[] args)
        {
            var patients = new List<Dictionary<string, string>>();
            while (true)
            {
                Console.WriteLine("1. Add Patient");
                Console.WriteLine("2. Search Patient by id");
                Console.WriteLine("3. Search Patient by symptom");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddPatient(patients);
                        break;
                    case "2":
                        GetPatientById();
                        break;
                    case "3":
                        GetPatientBySymptom();
                        break;
                }
                        
                
            }
        }
    }
}
