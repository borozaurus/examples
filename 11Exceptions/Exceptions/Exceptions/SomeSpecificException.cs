﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class SomeSpecificException : Exception
    {
        public SomeSpecificException(string message) : base(message)
        {
        }
    }
}
