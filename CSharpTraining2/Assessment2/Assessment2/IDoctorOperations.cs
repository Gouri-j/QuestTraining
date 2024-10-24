using Assessment2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    internal interface IDoctorOperations
    {
        void Add(Doctor doctor);
        List<Doctor> ListAll();
        void Update(Doctor doctor);
        void Delete(int id);
    }
}
