namespace Blog.Utils.Pager
{
    /// <summary>
    /// api result model
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ResultDataModel<T>
    {
        public string code { get; set; }

        public string msg { get; set; }

        public T data { get; set; }
    }
    public static class Result
    {
        /// <summary>
        /// 成功消息
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static ResultDataModel<T> Success<T>(T data, string msg = "")
        {
            return new ResultDataModel<T>
            {
                code = ResultCode.Success,
                msg = msg,
                data = data
            };
        }
        /// <summary>
        /// 构建错误返回
        /// </summary>
        /// <param name="code"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static ResultDataModel<T> Failed<T>(string code = "", string msg = "")
        {
            return new ResultDataModel<T>
            {
                code = code ?? ResultCode.DefaultFailed,
                msg = msg,
                data = default(T)
            };
        }
    }
    public static class ResultCode
    {
        /// <summary>
        /// 成功code
        /// </summary>
        public const string Success = "0000";
        /// <summary>
        /// 默认错误code
        /// </summary>
        public const string DefaultFailed = "9999";
        /// <summary>
        /// 校验失败错误code
        /// </summary>
        public const string VerifyFfailed = "2000";
    }
}
