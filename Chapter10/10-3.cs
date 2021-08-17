// 3. 다음 코드의 출력 결과는 무엇인가?

/*
Stack stack = new stack();
stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Push(5);

while (stack.Count > 0)
    Console.WriteLine(Stack.Pop());
*/

/*
정답: 5, 4, 3, 2, 1
풀이: stack은 LIFO 구조의 자료구조이다. 따라서 Pop()을 시행하면 가장 최근의 요소(top)가 출력된다.
*/