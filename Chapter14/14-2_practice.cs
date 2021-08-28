// // 2. 다음 코드에서 익명 메소드를 람다식으로 수정하라.

// using System;

// namespace Ex14_2
// {
//     class MainApp
//     {
//         static void Main()
//         {
//             int[] arr = {11, 22, 33, 44, 55};

//             foreach (int a in arr)
//             {
//                 Action action = () => Console.WriteLine(a*a);
//                 action.Invoke();
//             }
//         }
//     }
// }
