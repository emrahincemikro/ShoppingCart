using ShoppingCart.Services.AuthAPI.Models.Dto;

namespace ShoppingCart.Services.AuthAPI.Service.Abstract
{
    public interface IAuthService
    {
        public Task<string> Register(RegisterDto registerDto);

        public Task<LoginResponseDto> Login(LoginDto loginDto);

        Task<bool> AssignRole(string email, string role);
    }
}
