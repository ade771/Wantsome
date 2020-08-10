using System;
using System.Collections.Generic;

namespace Tema7si8

//    1. Model a simple Hotel app.

{
    class Program
    {
        static List<Hotel> hotels = new List<Hotel>();
        static Hotel hotel;

        static void Main(string[] args)
        {
            hotels = new List<Hotel>();
            AddHotel();

            int myAmount = 1006;

            FindRoom(myAmount);
            DeleteHotel();
        }

        public static void AddHotel()
        {
            var rate1 = new Rate(1028,"lei");
            var room1 = new Room("1", rate1, 2, 3);

            var rate2 = new Rate(1000, "lei");
            var room2 = new Room("2", rate2, 2, 1);

            hotel = new Hotel("International", "Iasi");
            hotel._rooms.Add(room1);
            hotel._rooms.Add(room2);

            hotels.Add(hotel);
        }

        public static void DeleteHotel()
        {
            Console.WriteLine("Enter index of hotel you want to delete: ");
            int index = int.Parse(Console.ReadLine());

            hotels.RemoveAt(index);
        }
        public static void FindRoom(int amount)
        {
            for (int i = 0; i < hotel._rooms.Count; i++)
            {
                if (hotel._rooms[i]._rate._amount < amount)
                {
                    Console.WriteLine("Room :" + hotel._rooms[i]._name);
                }
            }
        }
    }
}
