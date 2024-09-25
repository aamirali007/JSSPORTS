namespace SportsOrderApp.Core
{
    public class JwtSettings
    {
        public string Secret { get; set; }
        public int ExpiryMinutes { get; set; }
    }

}
