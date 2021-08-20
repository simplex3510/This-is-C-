// 1. 다음 코드에서 문제를 찾고, 그 원인을 설명하시오.

/*
Queue queue = new Queue();
queue.Enqueue(10);
queue.Enqueue("한글");
queue.Enqueue(3.14);

Queue<int> queue = new Queue<int>();
queue.Enqueue(10);
queue.Enqueue("한글");
queue.Enqueue(3.14);
*/

/*
int형 Queue에 문자열형과 int형 외의 값들을 저장하려 함
*/