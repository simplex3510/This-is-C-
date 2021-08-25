// // 1. 다음 코드를 컴파일 하면 실행결과처럼 예외를 표시하고 비정상 종료 한다.
// // try ~ catch 문을 이용하여 예외를 안전하게 처리하도록 코드를 수정하라.

// using System;

// namespace Ex12_1
// {
//     class MainApp
//     {
//         static void Main()
//         {
//             int[] arr = new int[10];

//             for (int i = 0; i < 10; i++)
//                 arr[i] = i;

//             try
//             {
//                 for (int i = 0; i < 11; i++)
//                     Console.WriteLine(arr[i]);
//             }
//             catch (IndexOutOfRangeException e)
//             {
//                 Console.WriteLine(e.Message);
//             }
//         }
//     }
// }