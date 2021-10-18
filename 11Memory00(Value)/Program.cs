using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    int AT;
    int HP;

    public void Test(int _Dmg)
    {
        // 이 안에 지역변수에서 벌어지는 일은
        // 이 안에서만 일어남
        _Dmg = 1002342;
    }
}
namespace _11Memory00_Value_
{
    class Program
    {
        static void Main(string[] args)
        {
            // 함수의 인자값
            int Value = 10;

            Player Newplayer = new Player();
            Newplayer.Test(Value);
            Console.WriteLine(Value);
        }
    }
}
