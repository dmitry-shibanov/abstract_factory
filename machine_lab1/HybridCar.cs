using System;
namespace machine_lab1
{
    public class HybridCar : AbstractMachine
    {
        public HybridCar(double age, double speed, double initialPrice) : base(age, speed, initialPrice)
        {
        }

        public override double Price
        {
            get
            {
                double currentPrice = InitialPrice;
                if (Age > 9)
                {
                    currentPrice = currentPrice * 0.3;
                }
                else
                {
                    currentPrice = currentPrice * (16.0 - Age > 6 ? Age : 6) / 10;
                }
                return currentPrice;
            }
        }

        public override DateTime drive(double way)
        {
            double time = way / (Speed * 0.8);
            return new DateTime((long)(time * 60 * 60 * 1000));
        }
    }
}
