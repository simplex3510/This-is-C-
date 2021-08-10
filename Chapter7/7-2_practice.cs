// // 2. 다음 코드에서 오류를 찾고, 오류의 원인을 설명하라.

// /*
// class A { }
// class B { }
// class C
// {
//     public static void Main()
//     {
//         A a = new A();
//         B b = new B();
//         A c = new B();
//         B d = new D();
//     }
// }
// */


// namespace Ex7_2
// {
//     class A { }
//     class B : A { }
//     class C
//     {
//         public static void Main()
//         {
//             A a = new A();
//             B b = new B();
//             A c = new B();  // B가 A를 상속하여 다형성으로 인해 문장이 성립한다.
//             B d = new A();  // 파생 클래스 B의 객체에 기반 클래스인 A의 인스턴스로 초기화할 수 없다.
//             /* 파생 클래스인 B의 필드나 메소드가 초기화되지 않는 문제가 발생한다. */
//         }
//     }
