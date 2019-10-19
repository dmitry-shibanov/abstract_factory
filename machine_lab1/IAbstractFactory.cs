using System;
namespace machine_lab1
{
    public interface IAbstractFactory
    {
        AbstractMachine createMachine(EnumTransport transport);

        AbstractMachine createMachine(EnumTransport transport, double age, double speed, double initialPrice);
    }
}
