using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformApp.Entities.Responses;

namespace WinformApp.Entities.Services.ChannelAdvisor
{
    public class ChannelAdvisorService : IChannelAdvisorService
    {
        public BaseResponse<object> GetOrdersFromServer()
        {
            throw new NotImplementedException();
        }

        public BaseResponse<object> PushOrderShippingToServer()
        {
            throw new NotImplementedException();
        }

        public BaseResponse<object> PushPartCSVToServer()
        {
            throw new NotImplementedException();
        }
    }
}
