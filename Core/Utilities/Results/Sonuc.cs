namespace Core.Utilities.Results
{
    public class Sonuc<T> // T : object, bool, product , class olmayabilir
    {
        public string Message { get; }
        public T Data { get; }
        public bool Status { get; }

        public Sonuc(bool status, string message, T data)
        {
            Status = status;
            Message = message;
            Data = data;
        }

        public Sonuc(bool status, string message)
            : this(status, message, default(T))
        {
        }

        public Sonuc(bool status, T data)
            : this(status, string.Empty, data)
        {
        }

        public Sonuc(bool status)
            : this(status, string.Empty, default(T))
        {
        }
    }

}
