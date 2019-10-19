using System;
namespace machine_lab1
{
    public class FactoryCar : IAbstractFactory
    {
        public FactoryCar()
        {
        }

        public AbstractMachine createMachine(EnumTransport transport)
        {
            AbstractMachine machine = null;
            switch (transport)
            {
                case EnumTransport.Car:
                    machine = new Car(0,120,120000);
                    break;
                case EnumTransport.Helicopter:
                    machine = new Helicopter(0, 290, 12000000);
                    break;
                case EnumTransport.Hybrid:
                    machine = new HybridCar(0, 110, 90000);
                    break;
            }

            return machine;
        }

        public AbstractMachine createMachine(EnumTransport transport, double age, double speed, double initialPrice)
        {
            AbstractMachine machine = null;

            switch (transport)
            {
                case EnumTransport.Car:
                    machine = new Car(age, speed, initialPrice);
                    break;
                case EnumTransport.Helicopter:
                    machine = new Helicopter(age, speed, initialPrice);
                    break;
                case EnumTransport.Hybrid:
                    machine = new HybridCar(age, speed, initialPrice);
                    break;
            }

            return machine;
        }
    }
}
