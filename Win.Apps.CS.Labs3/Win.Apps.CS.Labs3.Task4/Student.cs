using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win.Apps.CS.Labs3.Task4
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PersonNumber { get; set; }

        public override string ToString()
        {
            return LastName + " " + FirstName + "\nТабельный №: " + PersonNumber + "\n";
        }
    }
}
