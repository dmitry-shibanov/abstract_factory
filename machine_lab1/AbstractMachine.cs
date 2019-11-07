using System;
namespace machine_lab1
{
    public abstract class AbstractMachine
    {
        private double _age;
        private double _speed;
        private double _price;
        private double _initialPrice;

        public AbstractMachine(double age, double speed, double initialPrice)
        {
            this.Age = age;
            this.Speed = speed;
            this.InitialPrice = initialPrice;
        }

        public abstract double Price
        {
            get;
        }

        public double InitialPrice
        {
            private set
            {
                if (value < 0)
                {
                    throw new IncorrectArgumentException("Начальная цена машины не может быть отрицательной", "ошибка в поле initialPrice");
                }

                _initialPrice = value;
            }
            get
            {
                return _initialPrice;
            }
        }

        public double Age
        {
            private set
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

        public double Speed
        {
            private set
            {
                if (value < 0)
                {
                    throw new IncorrectArgumentException("Скорость машины не может быть отрицательной", "ошибка в поле age");
                }

                _speed = value;
            }
            get
            {
                return _speed;
            }
        }


        public abstract DateTime drive(double way);
    }
}
