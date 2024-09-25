using System.Globalization;

namespace SportsOrderApp.Core
{
    public class JSException : Exception
    {
        public JSException() : base() { }
        public JSException(string message) : base(message) { }
        public JSException(string message, params object[] args) : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {
        }
    }
}
