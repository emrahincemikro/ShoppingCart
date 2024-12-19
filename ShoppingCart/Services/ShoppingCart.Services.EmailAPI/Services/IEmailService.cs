using ShoppingCart.Services.EmailAPI.Models.Dtos;

namespace ShoppingCart.Services.EmailAPI.Services
{
    public interface IEmailService
    {
        public Task EmailCartAndLog(CartDto cartDto);
    }
}
