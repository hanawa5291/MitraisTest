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
		// GET api/values
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/values/5
		public string Get(int id)
		{
			return "value";
		}

		// POST api/values
		[HttpPost]
		public string Post([FromBody]RegisterModel value)
		{
			string result = "";
			result = regRepo.RegisterNew(value);
			return result;
		}

		// PUT api/values/5
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE api/values/5
		public void Delete(int id)
		{
		}
	}
}
