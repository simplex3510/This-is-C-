// 1. 다음 코드의 출력 결과값은 얼마인가?

/*
using System;

namespace Ex14_1
{
    class MainApp
    {
        static void Main()
        {
            Func<int> func_1 = () => 10;
            Func<int, int> func_2 = (a) => a*2;

            Console.WriteLine(func_1() + func_2(30));
        }
    }
}
*/

// func_1에서 10, func_2에서 60이 int형으로 반환되므로, 70의 결과값이 출력된다. 