using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Player
{
    // 객체화를 하지 않아도 플레이어의 내부는 내부이므로
    // 접근제한 지정자의 영향을 받지 않는다.
    static public void PVP(Player _Left, Player _Right)
    {
        _Left.HP -= _Right.AT;
        _Right.HP -= -_Left.AT;

    }
    private int AT = 100;
    private int HP = 100;
    public void Damage(Player _Other)
    {
        HP -= _Other.AT;
    }
}
namespace _14StaticFunc
{
    class Program
    {
        // 이녀석도 클래스에 속한 정적 함수
        static void Main(string[] args)
        {
            Console.WriteLine("static 함수 배우는중");
            //Player NewPlayer1 = new Player();
            //Player NewPlayer2 = new Player();
            
            // 마찬가지로 그 클래스에 속하지만
            // 객체를 굳이 만들지 않고도 사용할수 있는
            // 함수를 정적맴버함수라고 한다.
            //Player.PVP(NewPlayer1, NewPlayer2);
            //NewPlayer1.Damage(100);
        }
    }
}
public class Monster
{
    // private int AT = 100;
}
