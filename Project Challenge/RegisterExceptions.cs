using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingPXL
{
    //Klasse voor exceptions
    //Author: Kenny Vanrusselt
    //Date: 25/04/2014 22:25
    class UserAlreadyExistsException : ApplicationException
    {
        public UserAlreadyExistsException(string message)
            : base(message)
        { }

    }
    class NoNetworkException : ApplicationException
    {
        public NoNetworkException(string message)
            : base(message)
        { }

    }

    class InvalidEmailException : ApplicationException
    {
        public InvalidEmailException(string message)
            : base(message)
        { }

    }
}
