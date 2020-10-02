using CinemaApp.BL.Models;

namespace CinemaApp.BL.Infrastructure
{
    public interface IBookingsRepository
    {
        int GetBookingsForFilm(string film);
        void RegisterBooking(Film f, User c);
    }
}
