using DatingApp.API.Database.Entities;

namespace DatingApp.API.Services
{
    public interface ITokenService
    {
        public string CreateToken(User user);
    }
}