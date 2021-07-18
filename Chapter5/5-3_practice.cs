// 3. 1번과 2번을 for문 대신 while 문과 do while문으로 바꿔서 각각 작성하라.

using System;

namespace practice
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // 1번 - while 문
            int i = 0, j = 0;

            while (i < 5) {
                j = 0;
                while (j <= i) {
                    Console.Write($"*");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
            Console.WriteLine();

            // 2번 - do-while문
            i = 5; j = i;

            do {
                j = 0;
                do {
                    Console.Write($"*");
                    j++;
                }while(j < i);
                Console.WriteLine();
                i--;
            } while (0 < i);
        }
    }
}