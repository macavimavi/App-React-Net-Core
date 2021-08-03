using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Challenge.Clear.Core.Application.Exeception
{
    public class MovieException : Exception
    {
        public MovieException() : base() { }

        public MovieException(string message) : base(message) { }

        public MovieException(string message, params object[] args)
            : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {
        }
    }
}
