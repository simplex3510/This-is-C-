// using System;

// namespace ConstraintsOnTypeParameters
// {
//     class StructArray<T> where T : struct
//     {
//         public T[] Array { get; set; }
//         public StructArray(int size)
//         {
//             Array = new T[size];
//         }
//     }

//     class RefArray<T> where T : class
//     {
//         public T[] Array { get; set; }
//         public RefArray(int size)
//         {
//             Array = new T[size];
//         }
//     }

//     class Base { }
//     class Derived : Base { }
//     class BaseArray<U> where U : Base
//     {
//         public U[] Array { get; set; }
//         public BaseArray(int size)
//         {
//             Array = new U[size];
//         }

//         public void CopyArray<T>(T[] Source) where T : U
//         {
//             Source.CopyTo(Array, 0);
//         }
//     }

//     class MainApp
//     {
//         public static T CreateInstance<T>() where T : new()
//         {
//             return new T();
//         }

//         static void Main()
//         {
//             StructArray<int> a = new StructArray<int>(3);
//             a.Array[0] = 0;
//             a.Array[1] = 1;
//             a.Array[2] = 2;

//             // StructArray 클래스는 참조형식이므로 가능하다.
//             RefArray<StructArray<double>> b = new RefArray<StructArray<double>>(3);
//             // b 객체의 Array는 StructArray<double> 형이며, 각 요소가 인스턴스이므로 생성자로 초기화해야 한다.
//             b.Array[0] = new StructArray<double>(1);
//             b.Array[1] = new StructArray<double>(2);
//             b.Array[2] = new StructArray<double>(3);

//             BaseArray<Base> c = new BaseArray<Base>(3);
//             // 마찬가지로, c의 Array도 Base의 인스턴스이므로 생성자로 초기화해야 한다.
//             c.Array[0] = new Base();
//             c.Array[1] = new Derived();
//             c.Array[2] = CreateInstance<Base>();

//             BaseArray<Derived> d = new BaseArray<Derived>(3);
//             d.Array[0] = new Derived();     // Base 형식은 여기에 할당할 수 없다.
//             d.Array[1] = CreateInstance<Derived>();
//             d.Array[2] = CreateInstance<Derived>();

//             BaseArray<Derived> e = new BaseArray<Derived>(3);
//             e.CopyArray<Derived>(d.Array);
//         }
//     }
// }