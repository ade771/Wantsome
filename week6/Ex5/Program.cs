using System;
using System.Collections.Generic;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 5. ICloneable for Hotel (Hotel should have a list of Rooms)


            Hotel hotel1 = new Hotel("International", new List<Room>() {new Room("Room1",1),
                                                                        new Room("Room2",2),
                                                                        new Room("Room3",3)


            });

            Hotel hotel2 = new Hotel("Bavara", new List<Room>() {new Room("Room3",3),
                                                                new Room("Room4",4),
                                                                new Room("Room5",5)


            });


            Hotel hotel3 = hotel2.Clone() as Hotel;

            Console.WriteLine( $"Hotel1: {hotel1.Name}, has : {hotel1.RoomsList[0].Name}, {hotel1.RoomsList[1].Name}, {hotel1.RoomsList[2].Name}");
            Console.WriteLine($"Hotel2: {hotel2.Name}, has : {hotel2.RoomsList[0].Name}, {hotel2.RoomsList[1].Name}, {hotel2.RoomsList[2].Name}");
            Console.WriteLine($"Hotel3: {hotel3.Name}, has : {hotel3.RoomsList[0].Name}, {hotel3.RoomsList[1].Name}, {hotel3.RoomsList[2].Name}");
        }
    }
 }

