using System;

namespace oop_6115261019_w02
{
    class Program
    {
        static void Main(string[] args)
        {
            Room r433= new Room("433", "432", 2, 2, "Art");
            Console.WriteLine(r433);
            Building b3 = new Building("3 ", " Art ", " 7.233 ", " 422.322 ");
            Console.WriteLine(b3);
            Subject at = new Subject("001 " , " Art " , " 2 " ,  " 4 ", " 2 ");
            Console.WriteLine(at);
            Lecturer tr = new Lecturer("Tawisa ", " Heem ", " Teacher ");
            Console.WriteLine(tr);
            Section as = new Section("432 ", " 01 ", " Art ", " T.Asba ", " 2 may ", " 08.30 ", " 12.00 ");
            Console.WriteLine(as);
            Programm pr = new Programm("Art ", " Bachelor degree ");
            Console.WriteLine(pr);
        }

    }
}
