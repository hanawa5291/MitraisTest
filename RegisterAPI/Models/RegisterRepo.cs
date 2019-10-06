using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RegisterAPI.Models;

namespace RegisterAPI.Models
{
	public class RegisterRepo
	{
		private RegisterDataContext db = new RegisterDataContext();

		public string RegisterNew(RegisterModel newReg)
		{
			string result = "";
			Register Regnew = new Register();
			Regnew.MobileNumber = newReg.MobileNumber;
			Regnew.FirstName = newReg.FirstName;
			Regnew.LastName = newReg.LastName;
			Regnew.BirthDate = Convert.ToDateTime(newReg.BirthDate);
			Regnew.Gender  = newReg.Gender;
			Regnew.Email = newReg.Email;

			db.Registers.InsertOnSubmit(Regnew);
			try
			{
				db.SubmitChanges();
				result = "SUCCESS";
			}catch(Exception ex)
			{
				result = ex.Message.ToString();
			}
			return result;
		}
	}
}