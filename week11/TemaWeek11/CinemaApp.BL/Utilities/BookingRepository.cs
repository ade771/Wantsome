using CinemaApp.BL.Infrastructure;
using CinemaApp.BL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaApp.BL.Utilities
{
    public class BookingRepository : IBookingsRepository
    {
        public int GetBookingsForFilm(string film)
        {
            return 0;
        }

        public void RegisterBooking(Film f, User c)
        {
            var booking = new Booking(f.Name, c.Name);
            f.BookingsForFilms.Add(booking);

        }
        public void CancelBooking(Booking booking, Film f)
        {
            if (f.BookingsForFilms.Contains(booking))
            {
                f.BookingsForFilms.Remove(booking);
            }
        }
    }
}
