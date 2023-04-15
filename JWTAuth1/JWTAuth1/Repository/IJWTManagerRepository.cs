using JWTAuth1.Models;

namespace JWTAuth1.Repository
{
    public interface IJWTManagerRepository
    {
        Tokens Authenticate(Users users);
    }
}
