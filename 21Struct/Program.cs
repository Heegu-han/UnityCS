﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
struct StructData
{
    // 클래스와 비슷한데 안되는 것이 있따.
    // 리터럴 초기화가 안된다.
    // = 0 안된다.
    // = 0 이 기본이기 때문에
    public int a;
    public int b;

    public void Func()
    {
        a = 100;
        b = 100;
    }
}
namespace _21Struct
{
    class Program
    {
        static void Test(StructData _Data)
        {
            _Data.a = 1000;
        }
        static void Main(string[] args)
        {
            // int Number = 100;
            StructData NewData = new StructData();

            NewData.a = 10;
            NewData.b = 10;

            // 참조형과 값형이 있다.
            // 클래스를 객체화하면 그건 참조형 
            // 구조체는 값형
            Test(NewData);
            
            // 들어갔다 나와도 안변함
        }
    }
}
