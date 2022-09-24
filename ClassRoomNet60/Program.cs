// See https://aka.ms/new-console-template for more information
using ClassRoomNet60;
using System.ComponentModel;

Console.WriteLine("Hello, World!");
ClassRoom classRoom = new ClassRoom();
classRoom.ClassName = "3Q";
classRoom.SemesterStart = new DateTime(2019,08,26);

classRoom.students.Add(new Student("Sami", 01, 01));
classRoom.students.Add(new Student("Sami2", 01, 01));
classRoom.students.Add(new Student("Sam", 01, 08));
classRoom.students.Add(new Student("Sam3", 01, 05));
classRoom.students.Add(new Student("Sa", 05, 01));
classRoom.students.Add(new Student("Sai", 01, 01));
classRoom.students.Add(new Student("Ami", 04, 01));

