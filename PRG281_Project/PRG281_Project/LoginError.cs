using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG281_Project
{
    class LoginError : Exception
    {
        public LoginError() { }
        public LoginError(string message) : base(message){}
        public LoginError(string message, Exception inner) : base(message, inner) { }
    }
}
