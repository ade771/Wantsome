using System.Collections.Generic;

namespace Tema7si8

//    1. Model a simple Hotel app.

{
    public class Hotel
    {
        public string name;
        public string city;
        public List<Room>rooms;

        public Hotel(string name, string city)
        {
            this.name = name;
            this.city = city;
            this.rooms = new List<Room>();
        }

        public int GetPriceForNumberOfRooms(int numberOfRooms)
        {
            int price = 0;
            for (int i = 0; i < numberOfRooms; i++)
            {
                price += (int)rooms[i].rate.amount;
            }

            return price;
        }
        public void Print()
        {
            System.Console.WriteLine($" Hotel name : {this.name}, city : {this.city}");
        }
    }
}
