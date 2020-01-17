using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Manage.Models;
using Blog.Utils.Pager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Manage.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpPost]
        public ResultDataModel<ApiUserModel> Login(LoginModel model)
        {
            if(!ModelState.IsValid)
            {
                return Result.Failed<ApiUserModel>(ResultCode.VerifyFfailed, "账号密码不能为空");
            }
            if(model.account != "admin" || model.checkPass != "123456")
            {
                return Result.Failed<ApiUserModel>(ResultCode.VerifyFfailed, "账号密码错误");
            }
            return Result.Success(new ApiUserModel
            {
                userName = "ZainZhou",
                headPortrait = "https://upload.cc/i1/2019/12/20/JtRx5S.jpg",
                authToken = Guid.NewGuid().ToString().Replace("-", "", StringComparison.Ordinal)
            });
        }
    }
}