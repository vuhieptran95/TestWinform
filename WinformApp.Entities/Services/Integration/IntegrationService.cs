using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformApp.Entities.Exceptions;
using WinformApp.Entities.Helpers;
using WinformApp.Entities.Responses;
using WinformApp.Entities.Services.ChannelAdvisor;
using WinformApp.Entities.Services.PartCenter;
using WinformApp.Services.Entities;

namespace WinformApp.Entities.Services.Integration
{
    public class IntegrationService : IIntegrationService
    {
        private readonly IPartCenterService _partCenterService;
        private readonly IChannelAdvisorService _channelAdvisorService;

        public IntegrationService(IPartCenterService partCenterService, IChannelAdvisorService channelAdvisorService)
        {
            _partCenterService = partCenterService;
            _channelAdvisorService = channelAdvisorService;
        }
        
    }
}
