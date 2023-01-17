namespace CdpWrapper
{
    public class CDPResponse
    {
        public bool Success => ErrorMessage == null;

        public string ErrorMessage { get; set; }

        public object Response { get; set; }
    }
}
