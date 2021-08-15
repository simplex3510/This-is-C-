// // 1. 다음 코드에서 접근자 메소드들을 프로퍼티로 변경하여 작성하라.

// using System;

// namespace Ex9_1
// {
//     class NameCard
//     {
//         public int Age { get; set; }
//         public string Name { get; set; }
//     }

//     class MainApp
//     {
//         static void Main()
//         {
//             NameCard MyCard = new NameCard
//             {
//                 Age = 24,
//                 Name = "박상현"
//             };

//             Console.WriteLine("나이: {0}", MyCard.Age);
//             Console.WriteLine("이름: {0}", MyCard.Name);
//         }
//     }
// }