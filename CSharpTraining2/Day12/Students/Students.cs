using System.Collections.Generic;
using System.Security;

namespace Students
{
    class Students
    {
        public string Name;
        public string RegisterNumber;
        public int Class;

        public List<Mark> Marks;
        public override string ToString()
        {
            return $"Student: {Name}, Register num: {RegisterNumber}, class: {Class}";
        }
    }


    class Mark
    {
        public string Subject;
        public int MarkObtained;
        public int MaximumMark;
    }
}
