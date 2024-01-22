using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    internal class Human
    {
        static Human()
        {
            TotalCount = 0;
        }

        public Human()
        {
            TotalCount++;
            No = TotalCount;
        }
        public string Fullname;
        public static int TotalCount;
        public int No;
    }
}
