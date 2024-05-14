using System;

namespace Codecool.WasteRecycling
{
    // Inherits from the base Exception class
    public class DustbinContentException : Exception
    {
        public DustbinContentException()
        {
        }
        
        public DustbinContentException(string message)
            : base(message)
        {
        }
        
        public DustbinContentException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
