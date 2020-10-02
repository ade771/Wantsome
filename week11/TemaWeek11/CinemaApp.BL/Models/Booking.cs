using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaApp.BL.Models
{
    public class Booking
    {
        public string FilmName { get; set; }
        public string UserName { get; set; }
        public Booking(string filmName,string userName)
        {
            this.FilmName = filmName;
            this.UserName = userName;
        }
    }
}
