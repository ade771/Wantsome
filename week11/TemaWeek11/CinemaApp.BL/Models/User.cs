using CinemaApp.BusinessLogic.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaApp.BL.Models
{
    public class User
    {
        public string Name { get; set; }
        public Role Role { get; set; }
        public double Sold { get; set; }


        public User(double sold)
        {
            this.Sold = sold;
        }
    }
}
