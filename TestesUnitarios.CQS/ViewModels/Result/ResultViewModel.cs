namespace TestesUnitarios.CQS.ViewModels.Result
{
    public class ResultViewModel<TResult>
    {
        public TResult Result { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }

        public ResultViewModel(TResult result = default)
        {
            Result = result;
            Success = result != null;
        }

        public ResultViewModel<TResult> AddMessage(string message)
        {
            Message = message;
            return this;
        }
    }
}