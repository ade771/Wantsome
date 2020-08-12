using System.Collections.Generic;

namespace Tema7si8

//    1. Model a simple Hotel app.

{
    public class Hotel
    {
        public string Name { get; set; }
        public string City { get; set; }
        public List<Room>rooms;

        public Hotel(string name, string city)
        {
            this.Name = name;
            this.City = city;
            this.rooms = new List<Room>();
        }

        public int GetPriceForNumberOfRooms(int numberOfRooms) 
        {
            int price = 0;
            for (int i = 0; i < numberOfRooms; i++)
            {
                price += (int)rooms[i].Rate.amount;
            }

            return price;
        }
        public void Print()
        {
            System.Console.WriteLine($" Hotel name : {this.Name}, city : {this.City}");
        }
    }
}
