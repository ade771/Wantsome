using CinemaApp.BL.Infrastructure;
using CinemaApp.BL.Models;
using CinemaApp.BusinessLogic;
using CinemaApp.BusinessLogic.Infrastructure;
using CinemaApp.BusinessLogic.Utilities;

namespace CinemaApp.BL
{
    public class CinemaManager
    {
        private readonly IAuthRepository authRepository;
        private readonly IBookingsRepository bookingRepository;
        private readonly IFilmsManager filmsManager;
        private readonly IPaymentSystem payment;

        public CinemaManager(IAuthRepository authRepository,
            IBookingsRepository bookingRepository,
            IFilmsManager filmsManager,
            IPaymentSystem payment)
        {
            this.authRepository = authRepository;
            this.bookingRepository = bookingRepository;
            this.filmsManager = filmsManager;
            this.payment = payment;
        }



        public string BookASeat(Film film, User user)
        {
            var authHandler = new AuthHandler(authRepository);
            authHandler.VerifyAuthorisedAction(user.Role, UserActionType.BookASeat);

            int seats = filmsManager.GetNumberOfSeatsForFilm(film.Name);
            int existingBookings = bookingRepository.GetBookingsForFilm(film.Name);

            if (existingBookings >= seats)
                return "No bookings available";
            else
            {
                var paymentSuccessful = payment.DoPayment(film.PricePerTicket, user);
                if (!paymentSuccessful)
                {
                    return "Payment failed! Please try again later.";
                }
                else
                {
                    bookingRepository.RegisterBooking(film, user);
                    return "Booking confirmed";
                }
            }
        }

      



    }
}
