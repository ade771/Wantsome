using CinemaApp.BusinessLogic.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaApp.BusinessLogic.Infrastructure
{
    public interface IAuthRepository
    {
        bool IsUserInDataBase(string userName, string password);
        List<UserActionType> GetActionsForRole(Role role);
    }
}
