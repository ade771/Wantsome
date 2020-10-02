using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaApp.BL.Models
{
    public class Film
    {
        public string Name { get; set; }
        public int Rating { get; set; }
        public string Category { get; set; }
        public double PricePerTicket { get; set; }
        public List<Booking> BookingsForFilms{ get; set; }

        public Film(string name )
        {
            this.Name = name;
            this.BookingsForFilms = new List<Booking>();
        }
    }
}
