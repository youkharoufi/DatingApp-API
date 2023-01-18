using DatingApp.DTOs;
using DatingApp.Models;

namespace DatingApp.Interface
{
    public interface ILikesRepository
    {
        Task<UserLike> GetUserLike(int sourceUserId, int targetUserId);
        Task<AppUser> GetUserWithLike(int userId);
        Task<IEnumerable<LikeDto>> GetUsersLikes(string predicate, int userId);

    }
}
