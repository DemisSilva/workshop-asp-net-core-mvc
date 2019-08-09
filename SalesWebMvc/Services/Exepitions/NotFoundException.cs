using System;

namespace SalesWebMvc.Services.Exepitions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message): base(message)
        {
            
        }
    }
}
