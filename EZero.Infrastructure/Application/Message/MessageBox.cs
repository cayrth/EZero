using EZero.Infrastructure.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZero.Infrastructure.Application.Message
{
    public class MessageBox
    {
        public bool Success { get; private set; } = false;

        public string Message { get; private set; }

        public ResultStatus ResultStatus { get; private set; }


        public void NotFound(string message = "")
        {
            Message = !string.IsNullOrEmpty(message) ? message : ResultStatus.NotFound.GetDescription();
            ResultStatus = ResultStatus.NotFound;
        }

        public void Fail(string message = "", ResultStatus resultStatus = ResultStatus.Failed)
        {
            Message = !string.IsNullOrEmpty(message) ? message : resultStatus.GetDescription();
            ResultStatus = resultStatus;
        }

        public void Exception(string message = ExceptionMessage)
        {
            Message = message;
            ResultStatus = ResultStatus.Exception;
        }

        public void Done(string message = "")
        {
            Success = true;
            Message = !string.IsNullOrEmpty(message) ? message : ResultStatus.Successed.GetDescription();
            ResultStatus = ResultStatus.Successed;
        }

        private const string ExceptionMessage = "系统错误";
    }
}
