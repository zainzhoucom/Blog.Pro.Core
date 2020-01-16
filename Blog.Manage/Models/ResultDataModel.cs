namespace Blog.Manage.Models
{
    public class ResultDataModel<T>
    {
        public string code { get; set; }

        public string msg { get; set; }

        public T data { get; set; }

        
    }
    /// <summary>
    /// 构造数据返回消息
    /// </summary>
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
                code = ResultCode.SUCCESS,
                msg = msg,
                data = data
            };
        }
    }

    public static class ResultCode
    {
        public const string SUCCESS = "0000";

    }
}
