using System;
using System.Linq;

namespace _01.DefiningSomeClasses
{
    public enum BatteryType
    {
        LiPoly, LiIon, NiCd, NiMH
    }

    class Battery
    {
        private string model;
        private float idleTime;
        private float talkingTime;
        private BatteryType type;

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The model can not be empty!");
                }
                this.model = value;
            }
        }
        public float IdleTime
        {
            get
            {
                return this.idleTime;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The idle time can not be less than zero!");
                }
                this.idleTime = value;
            }
        }
        public float TalkingTime 
        { 
            get 
            { 
                return this.talkingTime; 
            } 
            set 
            {
                if (value < 0 || value > this.IdleTime)
                {
                    throw new ArgumentOutOfRangeException("The idle time can not be less than zero or greater than idle time!");
                }
                this.talkingTime = value; 
            } 
        }
		public BatteryType Type 
        { 
            get 
            { 
                return this.type; 
            } 
            set 
            {
                this.type = value; 
            } 
        }

        public Battery() { }

        public Battery(string model, float idle, float talking, BatteryType type)
        {
            this.Model = model;
            this.IdleTime = idle;
            this.TalkingTime = talking;
            this.Type = type;
        }

        public override string ToString()
        {
            return "Battery info" +
                "\nmodel: " + this.Model +
                "\nidle time: " + this.IdleTime +
                "\ntalking time: " + this.TalkingTime +
                "\nbattery type: " + this.Type;
        }
    }
}
