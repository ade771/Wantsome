namespace Tema7si8

//    1. Model a simple Hotel app.

{
    public class Room
    {
        public string name;
        public Rate rate;
        public int adults;
        public int children;

        public Room(string name, Rate rate, int adults, int children)
        {
            this.name = name;
            this.rate = rate;
            this.adults = adults;
            this.children = children;
        }

        public int GetPriceForDays(int numberOfDays)
        {
            return (int)(rate.amount * numberOfDays);
        }
        public void PrintRoom()
        {
            System.Console.WriteLine($" Name : {this.name}, rate : {this.rate}, adults : {this.adults}, children : {this.children}");
        }

    }
}
