using System;

namespace CdpWrapper
{
    public class Error
    {
        /// <summary>
        /// The error code
        /// </summary>
        public int? Code { get; set; }

        /// <summary>
        /// The message for the error that occured
        /// </summary>
        public string Message { get; set; }

        public Exception Exception { get; set; }

        public Error() { }

        public Error(string message)
        {
            Message = message;
        }

        public Error(int code)
        {
            Code = code;
        }

        public Error(Exception ex)
        {
            Message = $"{ex.Message}\n{ex.StackTrace}";
            Exception = ex;
        }

        public Error(int code, string message)
        {
            Code = code;
            Message = message;
        }

        public Error(string message, Exception ex)
        {
            Message = message;
            Message += "\n" + ex.StackTrace;
            Exception = ex;
        }

        public override string ToString()
        {
            return Code == null ? Message : $"{Code}: {Message}";
        }
    }
}
