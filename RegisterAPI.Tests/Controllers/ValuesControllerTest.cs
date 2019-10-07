using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegisterAPI;
using RegisterAPI.Controllers;
using RegisterAPI.Models;

namespace RegisterAPI.Tests.Controllers
{
	[TestClass]
	public class ValuesControllerTest
	{
		

		[TestMethod]
		public void Post()
		{
			RegisterModel mod = new RegisterModel();
			mod = Reg();
			// Arrange
			ValuesController controller = new ValuesController();
			string result="";
			// Act
			result =controller.Post(mod);

			// Assert
			Assert.IsNotNull(result);
			Assert.Equals(result,"SUCCESS");
		}

		private RegisterModel Reg()
		{
			RegisterModel newReg = new RegisterModel();
			newReg.MobileNumber = "6285726103240";
			newReg.FirstName = "hanawa";
			newReg.LastName = "hanzo";
			newReg.BirthDate = "1/1/1991";
			newReg.Gender = "Male";
			newReg.Email = "hanawa5291@gmail.com";
			return newReg;
		}

		
	
	}
}
