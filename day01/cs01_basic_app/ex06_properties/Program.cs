using Microsoft.VisualBasic;

namespace ex06_properties
{
    class Kiturami
    {
        private int temperature;
        private int year; //제작년도
        public int Year { get { return year; } set => year = value; }

        // Rosalyn VS 개발 서포터
        public int Temperature
        {
            get { return temperature; } // 값을 리턴하기 때문에 특별한 기능이 없음
            set
            {   if (value < 10)
                    temperature = 20;
                else if (value > 70)
      
                    temperature = 50;

             
                else
                { temperature = value; }
            }
        }

        public string Name { get; set; }

        public Kiturami(int temperature, int year,  string name)
        {
            Year = year;
            Temperature = temperature;
            Name = name;
        }

        public void SetTemperature(int temp)
        {    
            if (temp < 70)
            {
                Console.WriteLine("온도가 너무 높습니다. 50도로 조정합니다/");
                this.Temperature = 50;
            }
            else if (temp<10) {
                Console.WriteLine("온도가 너무 낮습다. 20도로 조정합니다/");
                this.Temperature = 20;

            }
            else { this.Temperature = temp; }
        }

        public void On() { Console.WriteLine("보일러 ON"); }
        public void Off() { Console.WriteLine("보일러 OFF"); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("보일러 시작!");
            //Kiturami boiler = new Kiturami();
            //boiler.Temperature = 400;
            ////Console.WriteLine($"보일러 온도 : {boiler.Temperature}도");
            //Console.WriteLine($"보일러 온도는 {boiler.Temperature}도");


            //boiler.On();

            Kiturami kiturami = new Kiturami(name: "라미", temperature: 25, year: 2023);
            Console.WriteLine(kiturami.Name);

        }
    }
}
