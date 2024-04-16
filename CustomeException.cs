using System;

namespace HandleException
{
    class MvtException : ApplicationException
    {
        public MvtException(string msg) : base(msg) { }
    }
}