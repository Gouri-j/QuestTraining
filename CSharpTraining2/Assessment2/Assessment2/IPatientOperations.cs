using Assessment2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    internal interface IPatientOperations
    {
        void Add(Patient patient);
        List<Patient> ListAll();
        void Update(Patient patient);
        void Delete(int id);

    }
}
