using System;

namespace _02.Humans
{
    class Worker : Human
    {
        private decimal weekSalary;
        private byte workHoursPerDay;

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                this.weekSalary = value;
            }
        }
        public byte WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value > 24)
                {
                    throw new ArgumentOutOfRangeException("Hours can not be over 24.");
                }
                this.workHoursPerDay = value;
            }
        }

        public Worker(string first, string last, decimal salary, byte workHoursPerDay)
        {
            this.FirstName = first;
            this.LastName = last;
            this.WeekSalary = salary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal MoneyPerHour()
        {
            return (decimal)(this.WeekSalary / (this.workHoursPerDay * 5));
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2:F2} {3} {4:F2}", this.FirstName, this.LastName, this.WeekSalary, this.WorkHoursPerDay, this.MoneyPerHour());
        }
    }
}
