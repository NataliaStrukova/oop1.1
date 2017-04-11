using System;
using System.Text;

namespace ListLib
{
    public class ListException: Exception
    {
        public ListException(string message) : base(message) { }        
    }
}
