// 4. 다음과 같이 사용자로부터 입력받은 횟수만큼 별을 반복 출력하는 프로그램을 작성하시오.

using System;

namespace practice
{
    class MainApp
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write($"반복 횟수를 입력하세요 : ");
                string input = Console.ReadLine();
                int time = Convert.ToInt32(input);

                if (time <= 0) {
                    Console.WriteLine($"0보다 작거나 같은 수는 입력할 수 없습니다.");
                    Console.WriteLine();
                    continue;
                }

                Console.WriteLine();
                for (int i = 0; i < time; i++) {
                    for (int j = 0; j <= i; j++) {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                break;
            }
        }
    }
}