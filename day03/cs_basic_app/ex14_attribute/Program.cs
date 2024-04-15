using System.Reflection;

namespace ex14_attribute
{
    class MyClass
    {
        [Obsolete("이 메서드는 다음 버전에서 폐기 됩니다. NewMethod를 사용하세요.",false)] //true, 아예 사용불가, false 사용가능 그러나 경고
        public void OldMethod() // 최초 제작
        {
            Console.WriteLine("Old Method");
        }
        public void NewMethod() { Console.WriteLine("New Method!"); } // 개선
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region "리플렉션"
            Console.WriteLine("리플렉션!");

            int a = int.MaxValue;
            Type type = a.GetType();
            Console.WriteLine(type.FullName);   // system.int32

            float f = float.MaxValue;
            Console.WriteLine(f.GetType());     // system.single

            double d = double.MaxValue; 
            Console.WriteLine(d.GetType());     // system.double

            FieldInfo[] fields = type.GetFields(); // 타입 객체에서 어떤 필드가 있는지 모두 확인
            foreach (var item in fields)
            {
                Console.WriteLine($"Type : {item.FieldType}, Name : {item.Name}");
            }

            MethodInfo[] methods = type.GetMethods();
            foreach (var item in methods)
            {
                Console.WriteLine($"Type : {item.DeclaringType}, Name : {item.Name}"); 
            }
            #endregion

            // 애트리뷰트
            Console.WriteLine("애트리뷰트!");

            MyClass myClass = new MyClass();    
            myClass.OldMethod();
        }
    }
}
