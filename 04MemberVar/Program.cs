using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// RPG에서 플레이어가 가지는 것
// 골드
// 경험치
// 공격력
// 방어력 .....

class Player
{
    // 개념 : 플레이어는 골드를 가진다.
    // 맴버변수의 선언은 
    // int(자료형) 이름(식별자)
    // 초기값을 넣어줄수 있다.
    // 리터럴값이라고 한다.
    // 선언을 함과 동시에 값을 넣어주는것을 리터럴 초기화라고 한다.
    bool IsFight; // 싸울수있냐 없냐
    int Gold = 10;
    int Exp = 1000;
    int Atk = 300;
    int Def= 400;
}