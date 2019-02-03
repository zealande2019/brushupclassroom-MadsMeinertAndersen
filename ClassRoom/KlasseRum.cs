using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class KlasseRum
    {
        public string ClassName { get; set; }
        public List<Studerende> StudentList { get; set; }

        public DateTime SemesterStart { get; set; }

        public KlasseRum()
        {
            
        }

        public void BirthDaySeason(List<Studerende> list)
        {
            int vinter = 0;
            int forår = 0;
            int sommer = 0;
            int efterår = 0;
            foreach (var student in list)
            {


                if (student.BirthMonth == 1 || student.BirthMonth == 2 || student.BirthMonth == 12)
                {
                    vinter = vinter + 1;
                }
                else if (student.BirthMonth == 3 || student.BirthMonth == 4 || student.BirthMonth == 5)
                {
                    forår = forår + 1;
                }
                else if (student.BirthMonth == 6 || student.BirthMonth == 7 || student.BirthMonth == 8)
                {
                    sommer = sommer + 1;
                }
                else if (student.BirthMonth == 9 || student.BirthMonth == 10 || student.BirthMonth == 11)
                {
                    efterår = efterår + 1;
                }
            }

            Console.WriteLine($"Vinter: {vinter}\nForår: {forår}\nSommer: {sommer}\nEfterår: {efterår}");
        }
    }
}
