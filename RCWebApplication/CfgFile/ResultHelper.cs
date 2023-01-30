using Model.Other;

namespace RCWebApplication.CfgFile
{
    public class ResultHelper
    {
        public static ApiResult success(object data)
        {
            return new ApiResult()
            {
                code = "200",
                message = "操作成功!",
                data = data
            };
        }

        public static ApiResult success(object data, string message)
        {
            return new ApiResult()
            {
                code = "200",
                message = "操作成功!",
                data = data
            };
        }

        public static ApiResult failed(string message) {
            return new ApiResult() { 
                code = "500",
                message = message,
                data = null
            };
        }

        public static ApiResult failed(object data, string message)
        {
            return new ApiResult()
            {
                code = "500",
                message = message,
                data = data
            };
        }
    }
}
