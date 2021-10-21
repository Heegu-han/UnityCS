using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18for
{
    class Program
    {
        // while문과 for문은 함수 안에서만 언제든지 사용할 수 있다.
        // 함수 밖에서는 사용할 수 없다.
        static void Main(string[] args)
        {
            // for ( 초기화문; 조건문; 증감문)
            // {
            //   실행 코드
            // }
            // for문의 장점은 접근성
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            for (;  true;)
            {
                Console.WriteLine(100);
            }
        }
    }
}
