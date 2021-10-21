using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    private int HP = 100;

    public void Heal(int _Heal)
    {
        HP += _Heal;
    }
    public void Damage(int _Dmg)
    {
        //HP -= _Dmg;

        this.HP -= _Dmg;
    }
    // 맴버함수에서 맴버 변수를 쓴다면
    // 앞에 보이지 않는 this.이 생략된 것이다.
    private static int StTest = 100;

    public static void PVP(Player _Left, Player _Right)
    {
        StTest = 50;
        
        // 객체에 영향을 받지 않는것이
        // 정적 맴버함수 정적 맴버변수
        // HP = 1000;
    }
}
namespace _16This
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();
            Player NewPlayer3 = new Player();

            NewPlayer2.Damage(10);
            NewPlayer2.Heal(1000);

            Player.PVP(NewPlayer1, NewPlayer2);
        }
    }
}