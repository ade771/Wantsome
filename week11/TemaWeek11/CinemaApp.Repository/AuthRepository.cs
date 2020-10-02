using CinemaApp.BusinessLogic.Infrastructure;
using CinemaApp.BusinessLogic.Utilities;
using System;
using System.Collections.Generic;

namespace CinemaApp.Repository
{
    public class AuthRepository : IAuthRepository
    {
        public List<UserActionType> GetActionsForRole(Role role)
        {
            //DB CALL
            var adminActions = new List<UserActionType> {
                UserActionType.AddFilm,
                UserActionType.RemoveFilm,
                UserActionType.CancelBooking
            };

            var clientActions = new List<UserActionType> {
                UserActionType.SeeFilmsList,
                UserActionType.BuyATicket,
                UserActionType.BookASeat,
                UserActionType.CancelBooking
            };

            if (role == Role.Admin)
                return adminActions;
            return clientActions;
        }

        public bool IsUserInDataBase(string userName, string password)
        {
            //DB CALL
            if (userName.Contains("@wantsome.ro") && password.Equals("secretpass123"))
                return true;
            return false;
        }
    }
}
