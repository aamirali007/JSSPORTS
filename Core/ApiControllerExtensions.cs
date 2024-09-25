using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace SportsOrderApp.Core
{
    public class ApiControllerExtensions :  ControllerBase
    {
        [NonAction]
        //public HeaderData GetProfile()
        //{
        //    //string response = Request.Headers["Token"];
        //    string response = Request.Headers["Authorization"];
        //    try
        //    {
        //        response = response.Replace("Bearer ", "");
        //        var res = GetTokenData(response);
        //        ClaimsPrincipal currentUser = this.User;
        //        HeaderData header = new HeaderData()
        //        {
        //            UserName = res["unique_name"],
        //            Email = res["email"],
        //            //LastModified = Convert.ToDateTime(res["LastModified"]),
        //            PracticeCode = !string.IsNullOrEmpty(res["PracticeCode"]) ? Convert.ToInt64(res["PracticeCode"]) : 0,
        //            ProviderCode = !string.IsNullOrEmpty(res["ProviderCode"]) ? Convert.ToInt64(res["ProviderCode"]) : 0,
        //            FirstName = res["FirstName"],
        //            LastName = res["LastName"],
        //            Designation = res["Designation"],
        //            IsAdmin = !string.IsNullOrEmpty(res["IsAdmin"]) ? Convert.ToBoolean(res["IsAdmin"]) : false,
        //            IsActive = !string.IsNullOrEmpty(res["IsActive"]) ? Convert.ToBoolean(res["IsActive"]) : false,
        //            //IsLockedOut = res["IsLockedOut"],
        //            userID = !string.IsNullOrEmpty(res["UserId"]) ? Convert.ToInt64(res["UserId"]) : 0,
        //            RoleId = !string.IsNullOrEmpty(res["RoleId"]) ? Convert.ToInt64(res["RoleId"]) : 0,
        //            WebServerName = res["WEBSERVERNAME"],
        //            ServerName = res["ServerName"],
        //            serverId = res.ContainsKey("ServerId") && !string.IsNullOrEmpty(res["ServerId"]) ? Convert.ToInt32(res["ServerId"]) : 14,
        //            BRAND_NAME = res["BRAND_NAME"],
        //            EMR_Name = res["EMR_Name"],
        //            isTalkRehab = bool.Parse(res["isTalkRehab"])
        //        };
        //        NCPDPTokenServiceModule.AddUpdateToken(response, DateTime.Now.AddHours(12).ToString(), header.PracticeCode.ToString());
        //        return header;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }

        //}
        public static Dictionary<string, string> GetTokenData(string tokenHeader)
        {
            var jwtHandler = new JwtSecurityTokenHandler();
            var jwtInput = tokenHeader;
            var readableToken = jwtHandler.CanReadToken(jwtInput);
            Dictionary<string, string> headerData = new Dictionary<string, string>();

            if (readableToken)
            {
                var token = jwtHandler.ReadJwtToken(jwtInput);
                var claims = token.Claims;

                foreach (Claim c in claims)
                {
                    headerData.Add(c.Type, c.Value);
                }
            }
            return headerData;
        }


        [NonAction]
        protected void InsertLogInDB(string searchedText, string module, string type, string patientAccount, string serverId)
        {
            //    var conn = Helper.getConnectionString(serverId);
            //    object Token = string.Empty;
            //    Request.Properties.TryGetValue("Token", out Token);

            //    //get profile from business operations
            //    var provider = Configuration.DependencyResolver.GetService(typeof(ITokenServices)) as ITokenServices;
            //    var userProfile = provider.GetProfile(Token.ToString()).userProfile;

            //    //For Logging
            //    ClientActivityLog activitylog = new ClientActivityLog();
            //    type = type.ToLower();
            //    switch (type)
            //    {
            //        case "search":
            //            activitylog.logFor = "Module Search";
            //            activitylog.logMessage = "{\"Section\":\"" + module + "\",\"SearchedText\":\"" +
            //                searchedText + "\",\"PatientAccount\":\"" + patientAccount + "\",\"Url\":\"" + Request.RequestUri + "\"}";
            //            break;
            //        case "print":
            //            activitylog.logFor = "Module Print";
            //            activitylog.logMessage = "{\"Section\":\"" + module + "\",\"PatientAccount\":\"" +
            //                patientAccount + "\",\"Url\":\"" + Request.RequestUri + "\"}";
            //            break;
            //        case "download":
            //            activitylog.logFor = "Module Download";
            //            activitylog.logMessage = "{\"Section\":\"" + module + "\",\"PatientAccount\":\"" +
            //                patientAccount + "\",\"Url\":\"" + Request.RequestUri + "\"}";
            //            break;
            //        case "copy":
            //            activitylog.logFor = "Module Download";
            //            activitylog.logMessage = "{\"Section\":\"" + module + "\",\"PatientAccount\":\"" +
            //                patientAccount + "\",\"Url\":\"" + Request.RequestUri + "\"}";
            //            break;
            //        default:
            //            activitylog.logFor = module;
            //            activitylog.logMessage = Request.RequestUri.ToString();
            //            break;

            //    }
            //    AsyncInsertActivityLog AsyncLog = new AsyncInsertActivityLog(ActivityLogService.InsertActivityLog);
            //    AsyncLog.BeginInvoke(activitylog.logFor, activitylog.logMessage, userProfile.UserName, string.Format("{0},{1}", userProfile.Token, userProfile.EmergencyMode), conn, null, null);
        }
    }
}
