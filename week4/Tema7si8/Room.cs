namespace Tema7si8

//    1. Model a simple Hotel app.

{
    public class Room
    {
        public string _name;
        public Rate _rate;
        private int _adults;
        private int _children;

        public Room(string name, Rate rate, int adults, int children)
        {
            this._name = name;
            this._rate = rate;
            this._adults = adults;
            this._children = children;
        }

        public int GetPriceForDays(int numberOfDays)
        {
            return _rate._amount * numberOfDays;
        }
        public void PrintRoom()
        {
            System.Console.WriteLine($" Name : {this._name}, rate : {this._rate}, adults : {this._adults}, children : {this._children}");
        }

    }
}
