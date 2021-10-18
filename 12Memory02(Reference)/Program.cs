using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    public int AT = 10;
    public int HP = 100;
    public void ATT(Monster _Monster)
    {
        _Monster.HP -= AT;
    }
}
class Monster
{
    public int AT = 10;
    public int HP = 100;
    public void ATT(Player _Player)
    {
        _Player.HP -= AT;
    }
}
namespace _12Memory02_Reference_
{
    class Program
    {
        static void Main(string[] args)
        {
            // 값형과 레퍼런스 형을 구분할줄 알아야한다.
            // 기본자료형을 선언만 하면 그녀석들은 값형이다.
            
            // 자기가 만든 클래스를 new 클래스명();
            // 해서 만든것을 그 클래스명에 받으면
            // 이런 녀석을 레퍼런스형이라고 한다.


            // HP 100 / AT 10
            // 이 래퍼런스라고 하는 녀석은
            // 힙에 생성된 어떠한 메모리의 위치를 가르킴
            Monster NewMonster = new Monster();
            Player NewPlayer = new Player(); // 힙 영역에 생성됨


            // 우리가 전에 배웠던대로라면
            // 플레이어가 자신의 공격력으로 때렸지만
            // 적용이 될리가 없다.
            NewPlayer.ATT(NewMonster);
            NewPlayer.ATT(NewMonster);
            NewPlayer.ATT(NewMonster);
            NewMonster.ATT(NewPlayer);
            // 플레이어의 hp가 깍인것이 보인다.
        }
    }
}
