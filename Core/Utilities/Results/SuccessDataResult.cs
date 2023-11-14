namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, bool success) : base(data, true) { }

        public SuccessDataResult(T data, bool success, string message) : base(data, true, message) { }

        public SuccessDataResult(string message) : base(default, success: true, message) { }

        public SuccessDataResult() : base(default, success: true) { }
    }
}
