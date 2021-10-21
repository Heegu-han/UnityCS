using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19if
{
    class Program
    {
        static void Main(string[] args)
        {
            int Test = 100;

            if (Test != 100)
            {
                Console.WriteLine("Test는 100 아닙니다");
            }
            else if (Test == 100)
            {
                Console.WriteLine("Test는 100입니다");
            }
            int ElseTest = 5;

            if (ElseTest == 10)
            {
                Console.WriteLine("ElseTest는 10입니다.");
            }
            else if (ElseTest == 100)
            {
                Console.WriteLine("ElseTest는 100입니다.");
            }
            else if (ElseTest == 1000)
            {
                Console.WriteLine("ElseTest는 1000입니다.");
            }
            else
            {
                Console.WriteLine("모든 조건이 거짓이였습니다.");
            }
        }
    }
}
