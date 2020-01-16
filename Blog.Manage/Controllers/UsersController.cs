using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Manage.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Manage.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpPost]
        public ResultDataModel<ApiUserModel> Login()
        {
            return Result.Success(new ApiUserModel
            {
                userName = "ZainZhou",
                headPortrait = "https://upload.cc/i1/2019/12/20/JtRx5S.jpg",
                authToken = Guid.NewGuid().ToString().Replace("-","")
            });
        }
    }
}