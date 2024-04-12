namespace ex10_delegators
{
    delegate int MyDelegate(int a, int b); // 대리자
    delegate int Compare(int a, int b); // 두 값을 비교하는 대리자
    // 어떠한 일이 발생하는지 시스템이 알려주는 것 - 이벤트
    delegate void Notify(string message); // Notify 대리자 선언

    class Notifier
    {
        public Notify EventOccured; // 이벤트 발생
    }

    class EventListener// 이벤트가 발생하는지 듣고있는 객체
    {
        public string name;
        public EventListener(string name) { this.name = name; }
        public void somethingHappend(string message) { Console.WriteLine($"{name}.일이 발생하였다: {message}"); }
    }

    class Calculator
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }

        public int Minus(int a, int b)
        {
            return a - b;
        }
    }

    class Sorting
    {
        public int AscendCompare(int a, int b) {// 오름차순 비교
            if (a> b)
            {
                return 1;
            }
            else if (a ==  b) { return 0; }
            else { return -1; }
        }
        public int DescendCompare(int a, int b) // 내림차순 비교
        {
            if (a > b)
            {
                return -1;
            }
            else if (a == b)
            {
                return 0;
            }
            else { return 1; }
        }

        public void BubbleSort(int[] Dataset, Compare comparer)
        {
            int i = 0, j = 0, temp = 0;
            for ( i = 0; i < Dataset.Length-1; i++)
            {
                for(j=0; j< Dataset.Length - (i + 1); j++)
                {
                    if (comparer(Dataset[j], Dataset[j+1])> 0)
                    {
                        temp = Dataset[j+1];
                        Dataset[j+1] = Dataset[j];
                        Dataset[j] = temp;
                    }
                }
            }
        }

    }




    internal class Program
    {
        static void Main(string[] args)
        {
            Notifier notifier = new Notifier();
            EventListener listener1 = new EventListener("리스너1");
            EventListener listener2 = new EventListener("리스너2");
            EventListener listener3 = new EventListener("리스너3");
            // 대리자 체인 notifier의 eventoccured라는 대리자에 리스너 3개에 일어날 수 있는 메서드를 연결
            // 일반적인 함수 호출에서 한번에 여러개의 함수 실행이 가능하냐? 불가능!!
            notifier.EventOccured += listener1.somethingHappend;
            notifier.EventOccured += listener2.somethingHappend;
            notifier.EventOccured += listener3.somethingHappend;
            notifier.EventOccured("메일을 받았어요!");
            Console.WriteLine();

            notifier.EventOccured -= listener2.somethingHappend;
            notifier.EventOccured("파일 다운로드 완료!");
            Console.WriteLine();

            notifier.EventOccured = new Notify(listener2.somethingHappend)+ new Notify(listener3.somethingHappend);
            notifier.EventOccured("미사일 발사!");
            Console.WriteLine(); // 윈폼(PyQt 등) 이벤트도 이와 유사한 형태로 동작


            #region "버블 소트 비교 대리자 사용코드 영역"
            int[] array = { 2, 3, 5, 1, 4 };
            Sorting sorting = new Sorting();

            Console.WriteLine("오름차순 정렬");
            sorting.BubbleSort(array, new Compare(sorting.AscendCompare));

            for (int i = 0;i < array.Length;i++)
            {
                Console.Write($"{array[i]}");
            }
            Console.WriteLine();

            Console.WriteLine("내림차순 정렬");
            sorting.BubbleSort(array, new Compare(sorting.DescendCompare));

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}");
            }
            Console.WriteLine();
            #endregion

            #region "계산기 대리자 코드 영역"

            Calculator calc = new Calculator(); // 객체 생성
            MyDelegate CallBack;

            CallBack = new MyDelegate(calc.Plus); // int a, int b가 아닌 Calculator객체의 Plus() 메서드를 전달
            var result = CallBack(10, 4);   // CallBack은 calc.Plus를 실행

            Console.WriteLine(result);

            CallBack = new MyDelegate(calc.Minus);
            result = CallBack(10, 4);
            Console.WriteLine(result);
            #endregion
        }
    }
}
