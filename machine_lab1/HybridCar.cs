using System;
namespace machine_lab1
{
    public class HybridCar : AbstractMachine
    {
        public HybridCar(double age, double speed, double initialPrice) : base(age, speed, initialPrice)
        {
        }

        public override double price
        {
            get
            {
                double currentPrice = initialPrice;
                if (age > 9)
                {
                    currentPrice = currentPrice * 0.3;
                }
                else
                {
                    currentPrice = currentPrice * (16.0 - age > 6 ? age : 6) / 10;
                }
                return currentPrice;
            }
        }

        public override DateTime drive(double way)
        {
            double time = way / (speed * 0.8);
            return new DateTime((long)(time * 60 * 60 * 1000));
        }
    }
}
