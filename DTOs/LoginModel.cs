namespace SportsOrderApp.DTOs
{
    public class LoginModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class RegisterModel
    {
        public long UserId { get; set; }
        public long? RoleId { get; set; }
        public string? UserName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? FullName { get; set; }
        public string Password { get; set; }
        public string? UserType { get; set; }
    }

}
