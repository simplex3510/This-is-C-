// // 5. 다음 코드를 컴파일 및 실행이 가능하도록 수정하라.

// using System;

// namespace Ex7_5
// {
//     struct ACSetting
//     {
//         public double currentInCelsius;
//         public double target;

//         public readonly double GetFahrenheit()
//         {
//             return (currentInCelsius * 1.8 + 32);
//         }
//     }

//     class MainApp
//     {
//         static void Main()
//         {
//             ACSetting acs;
//             acs.currentInCelsius = 25;
//             acs.target = 25;

//             Console.WriteLine($"{acs.GetFahrenheit()}");
//             Console.WriteLine($"{acs.target}");
//         }
//     }
// }

