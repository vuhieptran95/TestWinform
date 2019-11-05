using Newtonsoft.Json;
using System;
using System.IO;
using System.Threading.Tasks;
using WinformApp.Entities.Config;
using WinformApp.Entities.Responses;

namespace WinformApp.Entities.Helpers
{
    public class ConfigHelper
    {
        public static BaseConfigFile Config;

        public static async Task<BaseResponse<T>> ReloadConfigAsync<T>(string filePath) where T: BaseConfigFile
        {
            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    var stringJson = await reader.ReadToEndAsync();
                    var configFile = JsonConvert.DeserializeObject<T>(stringJson);

                    return new BaseResponse<T>(configFile);
                }
            }
            catch (Exception ex)
            {
                return new BaseResponse<T>(ex);
            }
            
        }
    }
}
