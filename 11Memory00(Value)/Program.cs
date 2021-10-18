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
        _Dmg = 1000;
    }
}
namespace _11Memory00_Value_
{
    class Program
    {
        static void Main(string[] args)
        {
            // 함수의 인자값
            int Value = 0;

            Player Newplayer = new Player();
            Newplayer.Test(Value);
            Console.WriteLine(Value);
        }
    }
}
