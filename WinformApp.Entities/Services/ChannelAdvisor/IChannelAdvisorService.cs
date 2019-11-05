using WinformApp.Entities.Responses;

namespace WinformApp.Entities.Services.ChannelAdvisor
{
    public interface IChannelAdvisorService
    {
        BaseResponse<object> PushPartCSVToServer();

        BaseResponse<object> GetOrdersFromServer();

        BaseResponse<object> PushOrderShippingToServer();
    }
}
