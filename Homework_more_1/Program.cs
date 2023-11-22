using System.Xml.Linq;

namespace HW_1
{
    class Car
    {
        private string name;
        private int speed;

        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetSpeed(int speed)
        {
            this.speed = speed < 0 ? speed * (-1) : speed;
        }
        public string GetName()
        {
            return name;
        }
        public int GetSpeed()
        {
            return speed;
        }

        class program
        {
            static void Main(string[] args)
            {
                Car car = new Car();
                Console.WriteLine("Input name of first car and its speed");
                car.SetName(Console.ReadLine());
                car.SetSpeed(int.Parse(Console.ReadLine()));
                Car car2 = new Car();
                Console.WriteLine("Input name of second car and its speed");
                car2.SetName(Console.ReadLine());
                car2.SetSpeed(int.Parse(Console.ReadLine()));
                string result = car.GetSpeed() > car2.GetSpeed() ? $"{car.GetName()} is faster" : car.GetSpeed() < car2.GetSpeed() ? $"{car2.GetName()} is faster" : "Both cars have the same speed";
                Console.WriteLine(result);
            }
        }
    }
}