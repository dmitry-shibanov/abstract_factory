using System;
namespace machine_lab1
{
    public class Car : AbstractMachine
    {
        public Car(double age, double speed, double initialPrice) : base(age,speed,initialPrice)
        {
        }

        public override double price
        {
            get
            {
                double currentPrice = initialPrice;
                if (age > 7)
                {
                    currentPrice = currentPrice * 0.3;
                }
                else
                {
                    currentPrice = currentPrice * (10.0 - age) / 10;
                }
                return currentPrice;
            }
        }

        public override DateTime drive(double way)
        {
            double time = way / speed;
            return new DateTime((long)(time * 60 * 60 * 1000));
        }
    }
}
