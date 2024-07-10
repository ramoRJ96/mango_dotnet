using Mango.Web.Models;

namespace Mango.Web.Service.IService
{
    public interface IBaseService
    {
        public Task<ResponseDto?> SendAsync(RequestDto requestDto);
    }
}
