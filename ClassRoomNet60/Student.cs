using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Student
    {
        public string name { get; set; }
        public int month { get; set; }
        public int birthday { get; set; }

        public Student(string Name, int Month, int Birthday)
        {
            this.name = Name;
            this.month = Month;
            this.birthday = Birthday;
        }

    }

}
