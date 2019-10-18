using System;
namespace machine_lab1
{
    public class IncorrectArgumentException : ArgumentException
    {
        public IncorrectArgumentException(string message, string parametr) : base(message, parametr)
        {

        }
    }
}
