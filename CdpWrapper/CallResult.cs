namespace CdpWrapper
{
    public class CallResult<T> : CallResult
    {
        /// <summary>
        /// The data returned by the call
        /// </summary>
        public T Data { get; set; }
        /// <summary>
        /// Raw data
        /// </summary>
        public string RawData { get; set; }
    }

    public class CallResult
    {
        /// <summary>
        /// An error if the call didn't succeed
        /// </summary>
        public Error Error { get; set; }

        /// <summary>
        /// Whether the call was successful
        /// </summary>
        public bool Success => Error == null;

        /// <summary>
        /// Success message.
        /// </summary>
        public string SuccessMessage { get; set; }

        /// <summary>
        /// Success message.
        /// </summary>
        public string Message => Error == null ? SuccessMessage : Error.Message;
    }
}
