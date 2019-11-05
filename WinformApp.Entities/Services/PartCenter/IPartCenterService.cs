using WinformApp.Entities.Responses;
using WinformApp.Services.Entities;

namespace WinformApp.Entities.Services.PartCenter
{
    public interface IPartCenterService
    {
        Product[] GetAndMapPartToLineItem();

        object[] GetAndMapToOrderShippingLineItems();

        BaseResponse<string> CreatePartCSV();
    }
}