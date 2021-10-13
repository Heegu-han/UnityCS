using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    
    int Atk;
    int HP;
    
    void Fight()
    {
        int Damage = 0;
        Console.WriteLine("플레이어가 싸운다");
    }
}
namespace _06LocalVar
{
    // c#은 고지식한 객체지향 언어.
    // 프로그램의 시작조차도 클래스 안에 묶어놔야한다. 
    class Program
    {
        // 시작용 함수
        static void Main(string[] args)
        {
            // 클래스 안에있는 얘들을 맴버변수
            // 함수안에 있는 얘들을 지역변수라고 한다.
            int Atk = 0;
            Atk = 50;

            // 클래스는 설계도
            // Player의 설계대로 플레이어를 만드는데
            // 그 이름을 NewPlayer라고 해서 만든다.

            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();
            
            // Console.WriteLine("지역변수를 배우기");
        }
    }
}
