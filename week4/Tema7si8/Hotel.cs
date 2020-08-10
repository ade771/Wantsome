using System.Collections.Generic;

namespace Tema7si8

//    1. Model a simple Hotel app.

{
    public class Hotel
    {
        private string _name;
        private string _city;
        public List<Room> _rooms;

        public Hotel(string name, string city)
        {
            this._name = name;
            this._city = city;
            this._rooms = new List<Room>();
        }

        public int GetPriceForNumberOfRooms(int numberOfRooms)
        {
            int price = 0;
            for (int i = 0; i < numberOfRooms; i++)
            {
                price += _rooms[i]._rate._amount;
            }

            return price;
        }
        public void Print()
        {
            System.Console.WriteLine($" Hotel name : {this._name}, city : {this._city}");
        }
    }
}
