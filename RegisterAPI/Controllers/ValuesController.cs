using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RegisterAPI.Models;
using System.Web.Http.Cors;
namespace RegisterAPI.Controllers
{
	public class ValuesController : ApiController
	{
		private RegisterRepo regRepo = new RegisterRepo();
		

		// POST api/values
		[HttpPost]
		public string Post([FromBody]RegisterModel value)
		{
			string result = "";
			result = regRepo.RegisterNew(value);
			return result;
		}

	}
}
