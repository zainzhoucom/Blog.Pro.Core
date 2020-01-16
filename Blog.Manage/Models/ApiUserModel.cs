using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Manage.Models
{
    public class ApiUserModel
    {
        public string userName { get; set; }

        public string headPortrait { get; set; }

        public string authToken { get; set; }
    }
}
