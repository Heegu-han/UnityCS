using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17while
{
    class Program
    {
        static void Main(string[] args)
        {
            // 어떤 함수내에서 bool 값이 들어가면 된다.
            // while (참/거짓)
            bool Check = true;
            
            while (Check)
            {
                Console.WriteLine("무한 출력");
                Check = false;
                // 조건문(true) -> 실행코드 -> //조건문 (false) -> 종료
                
            }
            // 실행코드 -> 조건문
            // while문은 쓸때
            // 빠져나올수 있는 조건을 넣어놓고 실행해줘야 한다.
            int Count = 0;
            //check = false;
            //do
            //{
            //    count = count + 1;
            //    console.writeline(count);
            //} while (count < 100);
            // 100까지 나옴
            while (Count<100)
            {
                Console.WriteLine(Count);
                Count = Count + 1;
            }
            // 99까지 나옴
    
        }
    }
}
