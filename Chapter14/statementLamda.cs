// using System;

// namespace StatementLamda
// {
//     class MainApp
//     {
//         delegate string Concatenate(string[] args);
//         static void Main(string[] args)
//         {
//             Concatenate concat =
//                 (arr) =>
//                 {
//                     string result = "";

//                     foreach (string str in arr)
//                         result += str;

//                     return result;
//                 };

//             //string[] args = Console.ReadLine();
//             Console.WriteLine(concat(args));
//         }
//     }
// }