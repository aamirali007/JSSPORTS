using System.Net;

namespace SportsOrderApp.Core
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        //public async Task Invoke(HttpContext context)
        //{
        //    try
        //    {
        //        await _next(context);
        //    }
        //    catch (Exception error)
        //    {

        //        var response = context.Response;
        //        response.ContentType = "application/json";
        //        var serializerSettings = new JsonSerializerSettings();
        //        serializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        //        switch (error)
        //        {
        //            case JSException _:
        //                response.StatusCode = (int)HttpStatusCode.BadRequest;
        //                await response.WriteAsync(JsonConvert.SerializeObject(new AppResponse { Message = error.Message }, serializerSettings)); ;
        //                break;
        //            default:
        //                response.StatusCode = (int)HttpStatusCode.InternalServerError;
        //                await response.WriteAsync(JsonConvert.SerializeObject(new AppResponse { Message = "Internal server error. Please try again or contact system admin for support if problem persists" }, serializerSettings));
        //                break;
        //        }
        //        Log.Error(error, error.GetType().ToString());
        //    }
        //}
    }
}
