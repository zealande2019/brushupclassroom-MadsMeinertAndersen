using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Studerende
    {
        public string Name { get; private set; }
        public int BirthMonth { get; private set; }

        public int Birthday { get; private set; }

        public Studerende(string name, int brithMonth, int brithday)
        {
            Name = name;
            BirthMonth = brithMonth;
            Birthday = brithday;
        }

        public string Årstid()
        {

            if (BirthMonth > 12 || BirthMonth <= 0)
            {
                throw new ArgumentException();
                
            }
            
            
                if (BirthMonth == 12 || BirthMonth == 1 || BirthMonth == 2)
                {
                    return "Vinter";
                }
                else if (BirthMonth == 3 || BirthMonth == 4 || BirthMonth == 5)
                {
                    return "Forår";
                }
                else if (BirthMonth == 6 || BirthMonth == 7 || BirthMonth == 8)
                {
                    return "Sommer";
                }
                else if (BirthMonth == 9 || BirthMonth == 10 || BirthMonth == 11)
                {
                    return "Efterår";
                }
                else
                {
                return "Invalid";
            }

        }
    }
}
