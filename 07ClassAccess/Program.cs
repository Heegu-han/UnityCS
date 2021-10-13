using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{// 클래스의 내부 시작


    // 객체지향의 캡슐화 은닉화를 대표하는 문법
    // 접근제한 지정자입니다.
    public int Atk; // 외부에도 공개
    protected int Hp; // 자식에게만 공개
    private int Def; // 내부에만 공개

    void Fight()
    {
        Console.WriteLine("싸운다.");
    }
} // -> 클래스의 끝
// 클래스의 외부
namespace _07ClassAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();

            // 만들어진 객체의 내용을 사용하기 위해서는
            // 객체의 이름. 을 사용한다.
            NewPlayer1.Atk = 1000;
            NewPlayer2.Atk = 500;
        }
    }
}
