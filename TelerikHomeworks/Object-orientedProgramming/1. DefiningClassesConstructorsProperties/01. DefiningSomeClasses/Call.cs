using System;
using System.Text.RegularExpressions;

namespace _01.DefiningSomeClasses
{
    class Call
    {
        private DateTime dateAndTime;
        private string dialedNumber;
        private int duration;

        public DateTime DateAndTime 
        {
            get 
            { 
                return this.dateAndTime; 
            } 
        }
        public string DialedNumber 
        { 
            get 
            { 
                return this.dialedNumber; 
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The dialed number can not be empty!");
                }
                this.dialedNumber = value;
            }
        }
        public int Duration 
        { 
            get 
            { 
                return this.duration; 
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The duration can not be less than zero!");
                }
                this.duration = value;
            }
        }

        public Call(string number, int duration)
        {
            this.dateAndTime = DateTime.Now;
            this.DialedNumber = number;
            this.Duration = duration;
        }

        public override string ToString()
        {
            return "date: " + this.dateAndTime.ToString() +
                "\nduration: " + new TimeSpan(0, this.duration / 60, this.duration % 60).ToString(@"mm\:ss") +
                "\ndialed number: " + this.dialedNumber;
        }
    }
}
