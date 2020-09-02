using System;
using System.Collections.Generic;
using System.Text;

namespace Ex5
{
    class Hotel : ICloneable

    {
        public string Name { get; set; }
        public List<Room> RoomsList { get; set; }
        public Hotel(string name, List<Room> rooms)
        {
            this.Name = name;
            this.RoomsList = rooms;
        }
       

        public object Clone()
        {
            return new Hotel(this.Name, this.RoomsList);
        }

        public override string ToString()
        {
            return string.Format("Hotel: {0} has : {1}", this.Name, this.RoomsList);
        }
    }
}
