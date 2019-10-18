using System;
namespace machine_lab1
{
    public abstract class AbstractMachine
    {
        private double _age;
        private double _speed;
        private double _price;
        private double _initialPrice;

        public abstract double price
        {
            get;
        }

        public double initialPrice
        {
            get
            {
                return _initialPrice;
            }
        }

        public double age
        {
            set
            {
                if (value < 0)
                {
                    throw new IncorrectArgumentException("Возраст машины не может быть отрицательным", "ошибка в поле age");
                }
                _age = value;
            }
            get
            {
                return _age;
            }
        }

        public double speed
        {
            set
            {
                if (value < 0)
                {
                    throw new IncorrectArgumentException("Возраст машины не может быть отрицательным", "ошибка в поле age");
                }
            }
            get
            {
                return _speed;
            }
        }


        public abstract DateTime drive(double way);
    }
}
