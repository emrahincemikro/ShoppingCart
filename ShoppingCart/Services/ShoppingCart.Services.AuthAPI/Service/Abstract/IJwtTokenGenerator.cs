using ShoppingCart.Services.AuthAPI.Models;

namespace ShoppingCart.Services.AuthAPI.Service.Abstract
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationUser, IEnumerable<string> roles);
    }
}

