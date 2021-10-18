using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Player
{
    private int HP = 10;
    private int Atk = 100;
    private int LV = 10;
    public int GetLv()
    {
        //LV = 10000;
        return LV;
        LV = 10000;
    }
    public void LVUP()
    {
        HP = 1000;
        Atk = 1000;
    }
    public void SetHP(int _HP)
    {
        HP = _HP;
    }
    public void Damage(int _Dmg, int _SubDmg)
    {
        HP = HP - _Dmg;
        HP = HP - _SubDmg;
    }

}
namespace _08FuncEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            // NewPlayer.Hp = 0;
            NewPlayer.SetHP(100);
            NewPlayer.LVUP();

            Console.WriteLine(NewPlayer.GetLv());
        }
    }
}
