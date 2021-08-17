// 3. 다음 코드의 출력 결과는 무엇인가?

/*
Queue que = new Queue();
que.Enqueue(1);
que.Enqueue(2);
que.Enqueue(3);
que.Enqueue(4);
que.Enqueue(5);

while (que.Count > 0)
    Console.WriteLine(Stack.Dequeue());
*/

/*
정답: 1, 2, 3, 4, 5
풀이: que은 FIFO 구조의 자료구조이다. 따라서 Enqueue()를 시행하면 가장 먼저 입력된 값이 출력된다.
*/