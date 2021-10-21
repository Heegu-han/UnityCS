using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int SwitchTest = 100;
            // switch는 = 연산밖에 못함.
            // case Test1: 이런식으로 변수는 안됨
            // 오로지 상수와만 비교가능
            switch (SwitchTest)
            {
                case 0:
                    Console.WriteLine("SwitchTest 는 0 입니다.");
                    break;
                case 1:
                    Console.WriteLine("SwitchTest 는 1 입니다.");
                    break;
                case 100:
                    Console.WriteLine("SwitchTest 는 100 입니다.");
                    break;
                default: // else의 역할
                    Console.WriteLine("모든 조건이 맞지 않습니다.");
                    break;
            }
        }
    }
}
