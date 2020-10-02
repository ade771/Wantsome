using CinemaApp.BL;
using CinemaApp.BL.Models;
using CinemaApp.BL.Utilities;
using CinemaApp.BusinessLogic;
using CinemaApp.BusinessLogic.Infrastructure;
using CinemaApp.BusinessLogic.Utilities;
using CinemaApp.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CinemaAppTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void User_With_Correct_Email_And_Pass_Should_Login_Successfully()
        {
            // Arrange
            string email = "adelina@wantsome.ro";
            string password = "secretpass123";
            var accountService = new AuthRepository();
            // Act
            bool result = accountService.IsUserInDataBase(email, password);
            // Assert
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void VerifyAuthorisedAction()
        {
            var repo = new AuthRepository();
            var auth = new AuthHandler(repo);
            var role = Role.Admin;
            var action = UserActionType.BuyATicket;
            // Arrange
            try
            {   // Act
                auth.VerifyAuthorisedAction(role, action);
                // Assert
            }
            catch (UnauthorizedAccessException ex)
            {
                Assert.AreEqual("Unauthorised access", ex.Message);
            }
        }


        [TestMethod]
        public void If_User_Have_Enought_Money_Transaction_Should_Be_Succesful()
        {
            //Arrange

            var user = new User(3000);
            var amount = 35;
    
            var payment = new PaymentSystem();

            //Act
            bool result = payment.DoPayment(amount,user);
            //Assert
            Assert.IsTrue(result);



        }
        [TestMethod]
        public void CancelAReservation()
        {
            //Arrange
            Film film = new Film("Lord Of the rings");
            var booking = new Booking(film.Name, "Adelina");
            film.BookingsForFilms.Add(booking);
            var cancelBooking = new BookingRepository();
            //Act
            cancelBooking.CancelBooking(booking, film);
            //Assert


        }
    }
}

