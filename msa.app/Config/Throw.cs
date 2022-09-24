namespace msa.App.Config
{
    public class Throw
    {
        public int StatusCode { get; set; }
        public object Object { get; set; }

        public Throw()
        {

        }

        public Throw(int statusCode, object obJect)
        {
            StatusCode = statusCode;
            Object = obJect;
        }
    }
}
