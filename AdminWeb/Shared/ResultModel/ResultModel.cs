using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.ResultModel
{
	public class ResultModels
	{
		public int Flag { get; set; }
		public string? Message { get; set; }		
		public dynamic? Data { get; set; }		

		public static dynamic Success(string message, dynamic data)
		{
			return new ResultModels() { Message = message, Flag = 1 , Data =  data};
		}

		public static dynamic Fail(string message, dynamic data)
		{
			return new ResultModels() { Message = message, Flag = 0, Data = data };
		}
	}
}
