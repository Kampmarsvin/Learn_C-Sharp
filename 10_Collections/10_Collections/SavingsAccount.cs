using System;

namespace _10_Collections
{
    internal class SavingsAccount : Asset
    {
       

        public SavingsAccount(string name, int value, double interestRate)
        {
            Name = name;
            Value = value;
            InterestRate = interestRate;
        }

        public string Name { get; set; }
        public double Value { get; set; }
        public double InterestRate { get; set; }

       
        internal void ApplyInterest()
        {
            Value = Value * (1 + (InterestRate/100));
        }

        public double GetValue()
        {
            return Value;
           
        }
        public override string ToString()
        {
            string result = string.Format("{0:0.0}", Value);
            var newValue = result.Replace(',', '.');
            var newInterestRate = InterestRate.ToString().Replace(',', '.');
            return "SavingsAccount[value=" + newValue + ",interestRate=" + newInterestRate + "]";
            
        }

        public string GetName()
        {
            return Name;
        }
    }
}