using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    internal class ClassRoom
    {
        public string ClassName { get; set; }
        public List<Student> students { get; set; }
        public DateTime SemesterStart { get; set; }

        public ClassRoom()
        {

        }
    }
}
