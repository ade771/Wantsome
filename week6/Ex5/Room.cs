using System;
using System.Collections.Generic;
using System.Text;

namespace Ex5
{
    class Room
    {
        public string Name { get; set; }
        public int IdRoom { get; set; }
        public Room(string name, int idRoom)
        {
            this.Name = name;
            this.IdRoom = idRoom;
        }
    }
}
