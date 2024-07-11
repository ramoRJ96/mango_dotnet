

using Mango.Web.Models;

namespace Mango.Web.Service.IService
{
    public interface ICouponService
    {
        public Task<ResponseDto?> GetCouponAsync(string couponCode);
        public Task<ResponseDto?> GetAllCouponAsync();
        public Task<ResponseDto?> GetCouponByIdAsync(int id);
        public Task<ResponseDto?> CreateCouponsAsync(CouponDto couponDto);
        public Task<ResponseDto?> UpdateCouponsAsync(CouponDto couponDto);
        public Task<ResponseDto?> DeleteCouponsAsync(int id);

    }
}
