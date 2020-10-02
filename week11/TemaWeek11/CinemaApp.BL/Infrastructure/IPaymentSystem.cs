using CinemaApp.BL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaApp.BL.Infrastructure
{
    public interface IPaymentSystem
    {
        bool DoPayment(double amount, User user);
    }
}
