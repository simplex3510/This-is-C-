// // 2. Mean() 메소드를 실행한 후의 mean은 얼마의 값을 가지게 되고, 그 원인은 무엇이며, 어떤 부분을 수정해야 하는가?

// using System;

// namespace Ex6_2
// {
//     class MainApp
//     {
//         public static void Main()
//         {
//             double mean = 0;
            
//             // call by value 방식의 메소드이므로 Main 메소드의 mean의 값에는 영향을 주지 않는다.
//             // mean의 값을 변경하려 시도하는 메소드 호출이므로, mean을 출력 전용 매개변수로 선언 및 호출 해준다.
//             Mean(1, 2, 3, 4, 5, out mean);
            

//             Console.WriteLine("평균: {0}", mean);
//         }

//         public static void Mean( double a, double b, double c,
//                                  double d, double e, out double mean)
//         {
//             mean = (a + b + c + d + e) / 5;
//         }
//     }
// }