using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    int HP = 100;
    void Damage(int _HP)
    {
        HP = HP - 10;
    }
    public int Plus(int _Left, int _Right)
    {
        int Result = _Left + _Right;

        return Result;
    }
}
namespace _09perator
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            int Result = 0;
            int Left = 7;
            int Right = 3;

            Result = NewPlayer.Plus(Left, Right);
            Result = Left + Right;
            Result = Left - Right;
            Result = Left * Right;
            Result = Left / Right;
            Result = Left % Right;


            Result = 0;
            Result += 10;
        }
    }
}
