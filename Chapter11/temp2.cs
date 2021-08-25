// using System;
// using System.Collections;
// using System.Collections.Generic;

// namespace temp
// {
//     class MyList<T> : IEnumerable<T>, IEnumerator<T>
//     {
//         private T[] array;
//         int position = -1;

//         public MyList()
//         {
//             array = new T[3];
//         }

//         public T this[int index]
//         {
//             get { return array[index]; }
//             set
//             {
//                 if (index >= array.Length)
//                 {
//                     Array.Resize<T>(ref array, index + 1);
//                     Console.WriteLine($"Array Resized: {array.Length}");
//                 }

//                 array[index] = value;
//             }
//         }

//         public int Length
//         {
//             get { return array.Length; }
//         }

//         public T Current
//         {
//             get
//             {
//                 return array[position];
//             }
//         }

//         // IEnumerator 멤버
//         object IEnumerator.Current
//         {
//             get
//             {
//                 return array[position];
//             }
//         }

//         // IEnumerator 멤버
//         public bool MoveNext()
//         {
//             if (position == array.Length - 1)
//             {
//                 Reset();
//                 return false;
//             }

//             position++;
//             return (position < array.Length);
//         }

//         // IEnumerator 멤버
//         public void Reset()
//         {
//             position = -1;
//         }

//         // IEnumerable 멤버
//         public IEnumerator<T> GetEnumerator()
//         {
//             return this;
//         }

//         IEnumerator IEnumerable.GetEnumerator()
//         {
//             return this;
//         }

//         public void Dispose()
//         {
            
//         }
//     }

//     class MainApp
//     {
//         static void Main()
//         {
//             MyList<int> list = new MyList<int>();
//             for (int i = 0; i < 5; i++)
//                 list[i] = i;

//             foreach (int e in list)
//                 Console.WriteLine(e);
//         }
//     }
// }