using CinemaApp.BusinessLogic.Infrastructure;
using CinemaApp.BusinessLogic.Utilities;
using System;

namespace CinemaApp.BusinessLogic
{
    public class AuthHandler
    {
        private readonly IAuthRepository authRepository;

        public AuthHandler(IAuthRepository authRepository)
        {
            this.authRepository = authRepository;
        }

        public bool Login()
        {
            Console.WriteLine("Please insert your email:");
            var email = Console.ReadLine();
            Console.WriteLine("Please insert your password:");
            var pass = Console.ReadLine();
            if (!IsAuthenticated(email, pass))
            {
                Console.WriteLine("Unknown identity.");
                return false;
            }
            return true;
        } 

        public void VerifyAuthorisedAction(Role role, UserActionType userAction)
        {
            var actionsForCurrentRole = authRepository.GetActionsForRole(role);
            if (actionsForCurrentRole.Contains(userAction))
                return;
            throw new UnauthorizedAccessException("Unauthorised access");
        }

        private bool IsAuthenticated(string username, string password)
        {
            if (authRepository.IsUserInDataBase(username, password))
                return true;
            return false;
        }
    }
}
