using System;
using System.Collections.Generic;
using System.Text;

namespace Students_and_workers
{
    class Worker : Human
    {
        private double WeekSalary;
        public double WorkHoursPerDay { get; set; }
        public double WorkHoursPerWeek { get; set; }

        public Worker(string firstName, string lastName, double weekSalary, double workHoursperDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursperDay;
        }

        public double MoneyPerHour()
       {

            this.WorkHoursPerWeek = 7 * this.WorkHoursPerDay;
            double moneyPerhour = this.WeekSalary / WorkHoursPerWeek;

            return moneyPerhour;
        }
    }
}
