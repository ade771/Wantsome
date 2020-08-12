namespace Tema7si8

//    1. Model a simple Hotel app.

{
    public class Room
    {
        public string Name { get; set; }
        public Rate Rate { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }

        public Room(string name, Rate rate, int adults, int children)
        {
            this.Name = name;
            this.Rate = rate;
            this.Adults = adults;
            this.Children = children;
        }

        public int GetPriceForDays(int numberOfDays)
        {
            return (int)(Rate.amount * numberOfDays);
        }
        public void PrintRoom()
        {
            System.Console.WriteLine($" Name : {this.Name}, rate : {this.Rate}, adults : {this.Adults}, children : {this.Children}");
        }

    }
}
