using System;
namespace SalesWebMvc.Services.Exception
{
    public class IntegretyException : ApplicationException
    {
        public IntegretyException(string message) : base(message)
        {

        }
    }
}
