using System;

namespace Blog.Models
{
    public class TipsViewModel
    {
		public string Id { get; set; }
		public string TipName { get; set; }

		public DateTime CreateTime { get; set; }

		public DataStatus Status { get; set; }
	}
}
