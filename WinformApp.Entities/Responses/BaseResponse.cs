using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformApp.Entities.Helpers;

namespace WinformApp.Entities.Responses
{
    public class BaseResponse<T>
    {
        public BaseResponse(T payload = default)
        {
            Status = ResponseHelper.STATUS_SUCCESS;
            Payload = payload;
        }

        public BaseResponse(Exception exception)
        {
            Status = ResponseHelper.STATUS_FAILURE;

            Exception = exception;

            while (exception.InnerException != null)
            {
                exception = exception.InnerException;
            }

            Message = exception.Message;
        }

        public string Status { get; set; }
        public string ErrorCode { get; set; }
        public string Message { get; set; }
        public T Payload { get; }
        public Exception Exception { get; set; }
    }
}
