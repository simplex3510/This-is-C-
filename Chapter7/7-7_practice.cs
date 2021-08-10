// 7. 다음 코드에서 switch 식을 제거하고 switch 문으로 동일한 기능을 작성하라.

using System;

namespace Ex7_7
{
    class MainApp
    {
        private static double GetDiscountRate(object client)
        {
            switch (client)
            {
                case ("학생", int n) when n < 18:
                    return 0.2;
                case ("학생", _):
                    return 0.1;
                case ("일반", int n) when n < 18:
                    return 0.1;
                case ("일반", _):
                    return 0.05;
                default:
                    return 0;
            }
        }
    }
}

/* when 키워드에 대한 이해가 부족했다. 튜플을 연산하기 위해 새로운 변수 n을 선언하고 이것을 활용하는 것이 포인트였다.  */