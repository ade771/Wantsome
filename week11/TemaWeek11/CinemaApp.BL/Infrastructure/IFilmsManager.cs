using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaApp.BL.Infrastructure
{
    public interface IFilmsManager
    {
        int GetNumberOfSeatsForFilm(string film);
    }
}
