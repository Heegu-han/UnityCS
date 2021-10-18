using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// static

class Player
{
    // 일반적인 맴버변수아 다른점
    // static을 붙이게 되면
    // 이런 경우 정적 맴버변수라고 한다.
    // 정적 맴버변수는 일반적인 맴버변수와 다르게
    // 객체화를 사용하지않고 사용할수 있다.
    // 클래스명으로만으로 사용가능하다.
    public static int PlayerCount = 0;


    public int AT=10;
    public int HP=100;
    // 클래스 내부 안에서는 사용가능하다.
    public void Setting(int _AT, int _HP)
    {

        AT = _AT;
        HP = _HP;
    }
}
namespace _13StaticVar
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer1 = new Player();
            Player.PlayerCount = 1;
            Player NewPlayer2 = new Player();
            Player.PlayerCount = 2;
            Player NewPlayer3 = new Player();
            Player.PlayerCount = 3;

            // 이런식으로 객체화를 전혀 하지 않고 사용할수가 있고
            // 정적 맴버변수라고 부르고
            // 이런 정적 맴버변수는 데이터 영역에 들어가게 된다.


            // 이 맴버변수라고 하는 녀석은 각각 존재한다.
            NewPlayer1.Setting(10, 100);
            NewPlayer2.Setting(20, 50);
            NewPlayer3.Setting(100, 500);

            // 모든 객체가 값을 공유할 필요가 있는 데이터를
            // 정의하고데 사용한다.
        }
    }
}
