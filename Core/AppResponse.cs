namespace SportsOrderApp.Core
{
    public class AppResponse
    {
        public object Data { get; set; }
        public string Message { get; set; }
        public bool IsSuccessful { get; set; }
    }

    public class AppResponse<T>
    {
        public T Data { get; set; }
        public string Message { get; set; }
    }
}
