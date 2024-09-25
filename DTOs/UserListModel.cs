namespace SportsOrderApp.DTOs
{
    public class UserListModel
    {
        public long UserId { get; set; }
        public long? RoleId { get; set; }
        public string? UserName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? FullName { get; set; }
    }

    public class UserModel
    {
        public long UserId { get; set; }
        public long? RoleId { get; set; }
        public string? UserName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? FullName { get; set; }
        public string? Password { get; set; }
        public string? Salt { get; set; }
        public string? Mobile { get; set; }
        public string? Mobile2 { get; set; }
        public string? Phone { get; set; }
        public string? Phone2 { get; set; }
        public string? IdCardNo { get; set; }
        public string? Nationality { get; set; }
        public string? Sso { get; set; }
        public string? ApiKey { get; set; }
        public bool? Active { get; set; }
        public bool? Deleted { get; set; }
        public string? UserType { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? EmpId { get; set; }
    }
}
