using System;
namespace machine_lab1
{
    public class Helicopter : AbstractMachine
    {
        public Helicopter(double age, double speed, double initialPrice) : base(age, speed, initialPrice)
        {
        }

        public override double Price
        {
            get
            {
                double currentPrice = InitialPrice;
                if (Age > 11)
                {
                    currentPrice = currentPrice * 0.3;
                }
                else
                {
                    currentPrice = currentPrice * 0.7;
                }
                return currentPrice;
            }
        }

        public override DateTime drive(double way)
        {
            double time = way / Speed / 2;
            return new DateTime((long)(time * 60 * 60 * 1000));
        }
    }
}
