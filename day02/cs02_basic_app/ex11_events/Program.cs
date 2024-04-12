namespace ex11_events
{
        delegate int Calculate(int a, int b);
        delegate void EventHandler(string message); // EventHander 대리자
        class CustomNotifier // 미리 만들어져 있음.
        {
            // 이벤트 등록, event라는 키워드를 쓰면 기본적으로 EventHandler 이름을 일반적으로 사용
            public event EventHandler SomethingHappened;

            public void DoSomething(int num)
            {
                int temp = num % 10;
                if (temp !=0 && temp %3 == 0)
                {
                    SomethingHappened($"{num} : 짝"); // 이벤트 핸들러 발생, 자신의 메서드가 아닌 외부에서 만들어진 메서드를 대신 실행
                }
            }
        }// 우리가 구현하는게 아니라, 원래부터 만들어져 잇는것
    internal class Program
    {

        // 모든 메서드는 이름이 존재
        public static void MyHandler(string message)
        {
            //Console.WriteLine($"[{DateTime.Now.ToShortTimeString()}] : {message}");
           // Console.WriteLine($" {message}");
           Console.ReadLine();
        }
        static void Main(string[] args)
        {
            CustomNotifier notifier = new CustomNotifier();
            notifier.SomethingHappened += new EventHandler(MyHandler);

            for (int i = 0; i < 30; i++)
            {
                notifier.DoSomething(i); // 내장된 클래스의 어떠한 매서드 호출
            }



            #region "익명 메서드"
            Calculate callback; // 대리자
            // 메서드 이름이 존재X
            // 익명 메서드. 한번 사용이후 다시 호출할 필요가 없을 때 사용.

            callback = delegate (int a, int b)
            {
                return a + b;
            };
            var result = callback(10, 4);
            #endregion
        }
    }
}
