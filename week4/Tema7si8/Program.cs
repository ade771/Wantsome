using System;
using System.Collections.Generic;

namespace Tema7si8

//    1. Model a simple Hotel app.

{
    class Program
    {
        static List<Hotel> hotels = new List<Hotel>();

        static void Main(string[] args)
        {
            hotels = new List<Hotel>();
            AddHotel();

            Console.WriteLine("Enter your amount:");
            int myAmount = int.Parse(Console.ReadLine());

            FindRoom(myAmount);
            DeleteHotel();
        }

        public static void AddHotel()
        {
            var rate1 = new Rate(1028,"lei");
            var room1 = new Room("room1", rate1, 2, 3);

            var rate2 = new Rate(1000, "lei");
            var room2 = new Room("room2", rate2, 2, 1);

            var rate3 = new Rate(900, "lei");
            var room3 = new Room("room3", rate3, 2, 1);

            var rate4 = new Rate(3000, "lei");
            var room4 = new Room("room4", rate4, 2, 1);

            var hotel1 = new Hotel("International", "Iasi");
            var hotel2 = new Hotel("Ansablu", "Iasi");

            hotel1.rooms.Add(room1);
            hotel1.rooms.Add(room2);

            hotel2.rooms.Add(room3);
            hotel2.rooms.Add(room4);

            hotels.Add(hotel1);
            hotels.Add(hotel2);

        }

        public static void DeleteHotel()
        {
            Console.WriteLine("Enter the name of hotel you want to delete ");
           string nameOfhotel = Console.ReadLine();
            for (int i = 0; i < hotels.Count; i++)
            {

                if (nameOfhotel == hotels[i].name)
                {
                    hotels.RemoveAt(i);
                    
                }

            }

            
        }
        public static void FindRoom(int amount)
        {
            for (int i = 0; i < hotels.Count; i++)
            {
                for (int j = 0; j < hotels[i].rooms.Count; j++)
                {
                    if (hotels[i].rooms[j].rate.amount < amount)
                    {
                        Console.WriteLine("Hotel: " + hotels[i].name + ", room: "  + hotels[i].rooms[j].name + " " + hotels[i].rooms[j].rate.amount);
                    }
                }
            }

        }
    }
}
