namespace ex06_properties
{
    class Kiturami
    {
        private int temperature;

        // Rosalyn VS 개발 서포터
        public int Temperature
        {
            get { return temperature; }
            set
            {   if (value < 10)
                {
                    temperature = 20;
                }
                else if (value > 70)
                {
                    temperature = 50;

                }
                else
                { temperature = value; }
            }
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
            Kiturami boiler = new Kiturami();
            boiler.Temperature = 400;
            //Console.WriteLine($"보일러 온도 : {boiler.Temperature}도");
            Console.WriteLine($"보일러 온도는 {boiler.Temperature}도");
            
            
            boiler.On();
        }
    }
}
