using DatingApp.Models;

namespace DatingApp.Interface
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
