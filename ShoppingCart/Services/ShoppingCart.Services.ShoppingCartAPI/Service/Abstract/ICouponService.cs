using ShoppingCart.Services.ShoppingCartAPI.Models.Dto;

namespace ShoppingCart.Services.ShoppingCartAPI.Service.Abstract
{
    public interface ICouponService
    {
        public Task<CouponDto> GetCouponAsync(string couponCode);
    }
}
