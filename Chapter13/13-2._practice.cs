// using System;

// namespace Ex13_2
// {
//     delegate void MyDelegate(int a);

//     class Market
//     {
//         public event MyDelegate CustomerEvent;

//         public void BuySomething(int CustomerNo)
//         {
//             if(CustomerNo == 30)
//                 CustomerEvent(CustomerNo);
//         }
//     }

//     class MainApp
//     {
//         static void WinEvent(int time)
//         {
//             Console.WriteLine(string.Format("축하합니다! {0}번째 고객 이벤트에 당첨되셨습니다.", time));
//         }

//         static void Main()
//         {
//             Market market = new Market();
//             market.CustomerEvent += new MyDelegate(WinEvent);

//             for (int customerNo = 0; customerNo < 100; customerNo+=10)
//                 market.BuySomething(customerNo);
//         }
//     }
// }