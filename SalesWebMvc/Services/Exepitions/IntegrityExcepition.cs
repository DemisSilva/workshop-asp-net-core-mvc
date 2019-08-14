using System;

namespace SalesWebMvc.Services.Exepitions
{
    public class IntegrityExcepition : ApplicationException
    {
        public IntegrityExcepition(string message) : base(message)
        {

        }
    }
}
