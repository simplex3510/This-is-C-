// 2. 다음과 같은 결과를 출력하는 프로그램을 for문을 이용하여 작성하라.

using System;

namespace practice
{
    class MainApp
    {
        static void Main(string[] args)
        {
            for (int i = 5; 0 < i; i--) {
                for (int j = 0; j < i; j++) {
                    Console.Write($"*");
                }
                Console.WriteLine();
            }
        }
    }
}