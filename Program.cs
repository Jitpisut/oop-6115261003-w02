using System;

namespace oop_6115261003_w02
{
    class Program
    {
        static void Main(string[] args)
        {
            Room r433 = new Room();
            Room r434 = new Room("434", "434", 4, 4, "Computer");
            Console.WriteLine(r433);
            Console.WriteLine(r434);

            Building b4 = new Building("4", "Computer", "425", "213");
            Console.WriteLine(b4);

            Subject s9022081 = new Subject("9022081", "Programming", "3", "2", "5");
            Console.WriteLine(s9022081);

            Lecturer l001 = new Lecturer("001", "Jason", "A.", "professor");
            Console.WriteLine(l001);

            Studygroup sg001 = new Studygroup("001", "01", "Bachelor");
            Console.WriteLine(sg001);

            Section se01 = new Section("01", "r434", "b4", "s9022081", "l001", "Monday", "8.00AM", "12.00PM");
            Console.WriteLine(se01);
        }
    }
}
