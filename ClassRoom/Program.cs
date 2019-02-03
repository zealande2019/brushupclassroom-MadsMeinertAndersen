using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {

            KlasseRum klasse3B = new KlasseRum();

            klasse3B.ClassName = "3B";
            klasse3B.SemesterStart = new DateTime(2018,9,4);

            klasse3B.StudentList = new List<Studerende>(){new Studerende("Henrik", 6, 25), new Studerende("Simon", 12, 24), new Studerende("Mads", 1, 1)};

            Console.WriteLine($"Klasse navn: {klasse3B.ClassName}\n\nSemesterStart: {klasse3B.SemesterStart}\n\nStuderende:");

            foreach (var h in klasse3B.StudentList)
            {
                Console.WriteLine($"Navn: {h.Name}   Fødselsdato: {h.Birthday}/{h.BirthMonth}");
            }

            Console.WriteLine();
            Console.WriteLine("Fødselsdage pr. årstid:");
            klasse3B.BirthDaySeason(klasse3B.StudentList);

            Console.ReadLine();
        }
    }
}
