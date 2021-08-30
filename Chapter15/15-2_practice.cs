// // 2. 다음 코드에서 cars.Where( c => c.Cost < 60).OrderBy(c => c.Cost)와 동일한 결과를 반환하는 LINQ를 작성하라.

// using System;
// using System.Linq;

// namespace Ex15_2
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
//                            where car.Cost < 60
//                            orderby car.Cost ascending
//                            select car;

//             foreach (var car in selected)
//                 Console.WriteLine("Cost: {0}, MaxSpeed: {1}", car.Cost, car.MaxSpeed);

//         }
//     }
// }