using AutoMapper;
using Microsoft.IdentityModel.Tokens;
using SportsOrderApp.Core;
using SportsOrderApp.DTOs;
using SportsOrderApp.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using static SportsOrderApp.Repositories.IRepositories;

namespace SportsOrderApp.Services
{
    public interface IUserService
    {
        public IList<UserListModel> GetClientUserList();
        public bool ValidateUser(string username, string password);
        public string GenerateJwtToken(string username);
        UserModel GetUserByUsername(string username);

    }
    public class UserService: IUserService
    {
       private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        private readonly JwtSettings _jwtSettings;
        public UserService(IMapper mapper, IUserRepository userRepository, JwtSettings jwtSettings) 
        {
            _mapper = mapper;
            _userRepository = userRepository;
            _jwtSettings = jwtSettings;
        }
        public UserModel GetUserByUsername(string username)
        {
            var user = _userRepository.FindBy(x => x.UserName == username).FirstOrDefault();
            return _mapper.Map<UserModel>(user);
        }
        public IList<UserListModel> GetClientUserList()
        {
            var clinet = _userRepository.FindBy(x => x.Active == true
                                                && x.Deleted == false
                                                && x.UserType == "CLIENT").ToList();
            return _mapper.Map<List<UserListModel>>(clinet);

        }
        public bool ValidateUser(string username, string password)
        {
            var user = GetUserByUsername(username);

            if (user == null) return false;

            return BCrypt.Net.BCrypt.Verify(password, user.Password);
        }

        public string GenerateJwtToken(string username)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_jwtSettings.Secret); // Ensure this key is at least 32 characters
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, username) }),
                Expires = DateTime.UtcNow.AddMinutes(_jwtSettings.ExpiryMinutes),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }


        public void RegisterUser(RegisterModel model)
        {
            var user = new RegisterModel
            {
                UserName = model.UserName,
                Password = BCrypt.Net.BCrypt.HashPassword(model.Password),
                UserType = model.UserType,
                RoleId = model.RoleId,
                
            };
            var res = _mapper.Map<JsTblUser>(user);
            res.Active = true;
            res.Deleted = false;
            //res.RoleId = 1;
            res.CreatedBy = "AAMIR";
            res.CreatedDate = DateTime.Now;
            res.ModifiedBy = "AAMIR";
            res.ModifiedDate = DateTime.Now;
            _userRepository.Add(res);
            _userRepository.Commit();
        }
    }
}
