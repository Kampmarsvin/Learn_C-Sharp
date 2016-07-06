using System;

namespace _09_Portfolio
{
    internal class SavingsAccount : Asset
    {
       

        public SavingsAccount(string v1, int v2, double v3)
        {
            Name = v1;
            Value = v2;
            InterestRate = v3;
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
    }
}