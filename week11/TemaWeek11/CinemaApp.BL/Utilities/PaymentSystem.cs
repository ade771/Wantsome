using CinemaApp.BL.Infrastructure;
using CinemaApp.BL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaApp.BL.Utilities
{
    public class PaymentSystem : IPaymentSystem
    {
        public bool DoPayment(double amount, User user)
        {
            if (amount < user.Sold)
            {
                user.Sold = user.Sold - amount;
                return true;
            }
            return false;
        }
    }
}
