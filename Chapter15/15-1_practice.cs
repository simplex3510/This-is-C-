// // 1. 다음과 같은 배열이 있다고 할 때, Cost는 50 이상, MaxSpeed는 150 이상인 레코드만 조회하는 LINQ를 작성하라.

// using System;
// using System.Linq;

// namespace Ex15_1
// {
//     class Car
//     {
//         public int Cost { get; set; }
//         public int MaxSpeed { get; set; }
//     }

//     class MainApp
//     {
//         static void Main()
//         {
//             Car[] arrCars =
//             {
//                 new Car(){Cost = 56, MaxSpeed=120},
//                 new Car(){Cost = 70, MaxSpeed=150},
//                 new Car(){Cost = 45, MaxSpeed=180},
//                 new Car(){Cost = 32, MaxSpeed=200},
//                 new Car(){Cost = 82, MaxSpeed=280}
//             };

//             var selected = from car in arrCars
//                            where 50 <= car.Cost && 150 <= car.MaxSpeed
//                            select car;

//             foreach (var car in selected)
//                 Console.WriteLine("Cost: {0}, MaxSpeed: {1}", car.Cost, car.MaxSpeed);

//         }
//     }
// }