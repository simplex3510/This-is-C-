// 1. 다음 코드 중에서 올바르게 동작하지 않는 것을 고르시오.

/*
① Type t = myObject.getType();
② Type t = typeof("int");
③ Type t = Type.GetType(int);
④ Type t = Type.GetType("System.Int32");
*/

/*
① myObject.getType()은 myObject 형식의 Type 객체를 반환함.
② typeof()의 매개변수는 식별자 자체를 받는다. 따라서 동작하지 않음.
③ ④번 풀이에 의거 동작하지 않음.
④ Type.GetType()의 매개변수는 형식의 전체 이름(네임스페이스를 포함한 형식이름)을 매개변수로 받음.
*/