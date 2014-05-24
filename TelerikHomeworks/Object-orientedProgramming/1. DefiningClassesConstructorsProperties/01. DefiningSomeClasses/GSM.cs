using System;
using System.Collections.Generic;

namespace _01.DefiningSomeClasses
{
    class GSM
    {
        public static readonly GSM IPhone4S = new GSM("iPhone 4S", "Apple", 299M, "Pesho",
            new Battery("4S Model", 200, 8, BatteryType.LiIon), new Display(640, 960, 16000000));

        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory;

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
                    throw new ArgumentNullException("Model can not be empty!");
                }
                this.model = value; 
            } 
        }
        public string Manufacturer 
        { 
            get 
            { 
                return this.manufacturer; 
            } 
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Model can not be empty!");
                }
                this.manufacturer = value; 
            } 
        }
        public decimal Price 
        { 
            get 
            { 
                return this.price; 
            } 
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The price can not be less then zero!");
                }
                this.price = value; 
            } 
        }
        public string Owner 
        { 
            get 
            { 
                return this.owner; 
            } 
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Owner can not be empty!");
                }
                this.owner = value; 
            } 
        }
        public Battery Battery 
        { 
            get 
            { 
                return this.battery; 
            } 
            set 
            {
                if (value == null)
                {
                    throw new NullReferenceException("There is no reference for battery!");
                }
                this.battery = value; 
            } 
        }
        public Display Display 
        { 
            get 
            { 
                return this.display; 
            } 
            set 
            {
                if (value == null)
                {
                    throw new NullReferenceException("There is no reference for display!");
                }
                this.display = value; 
            } 
        }
        public List<Call> CallHistory 
        { 
            get 
            { 
                return this.callHistory; 
            } 
        }

        public GSM(string model, string manufact)
        {
            this.Model = model;
            this.Manufacturer = manufact;
            this.Battery = new Battery();
            this.Display = new Display();
            this.callHistory = new List<Call>();
        }

        public GSM(string model, string manufact, decimal price)
            : this(model, manufact)
        {
            this.Price = price;
        }

        public GSM(string model, string manufact, decimal price, string owner)
            : this(model, manufact, price)
        {
            this.Owner = owner;
        }

        public GSM(string model, string manufact, decimal price, string owner, Battery bat, Display display)
            : this(model, manufact, price, owner)
        {
            this.Battery = bat;
            this.Display = display;
        }

        public GSM(string model, string manufact, decimal price, string owner, Battery bat, Display display, List<Call> log)
            : this(model, manufact, price, owner, bat, display)
        {
            this.callHistory = log;
        }

        public void AddCall(string number, int duration)
        {
            this.callHistory.Add(new Call(number, duration));
        }

        public void DeleteCall(int index)
        {
            this.callHistory.RemoveAt(index);
        }

        public void ClearCalls()
        {
            this.callHistory.Clear();
        }

        public decimal CalculateCalls()
        {
            int allCallsDuration = 0;
            foreach (var call in callHistory)
            {
                allCallsDuration += call.Duration;
            }

            if (allCallsDuration % 60 != 0)
            {
                allCallsDuration += 60;
            }

            return (allCallsDuration / 60) * 0.37M;
        }

        public override string ToString()
        {
            return "Model: " + this.Model +
                "\nManufacturer: " + this.Manufacturer +
                "\nPrice: " + this.Price +
                "\nOwner: " + this.Owner +
                "\n" + this.Battery.ToString() +
                "\n" + this.Display.ToString();
        }
    }
}