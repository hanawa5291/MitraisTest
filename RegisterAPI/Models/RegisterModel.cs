using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegisterAPI.Models
{
	public class RegisterModel
	{
		[Required]
		[Phone]
		[DataType(DataType.PhoneNumber)]
		[Display(Name = "Mobile Number")]
		[RegularExpression("^62\\d{7,11}", ErrorMessage = "Please Input Valid Indonesian Number")]
		public string MobileNumber { get; set; }
		[Required]
		[Display(Name = "First Name")]
		public string FirstName { get; set; }
		[Required]
		[Display(Name = "Last Name")]
		public string LastName { get; set; }
		[Display(Name = "Birth Date")]
		public string BirthDate { get; set; }
		[Display(Name = "Gender")]
		public string Gender { get; set; }

		[Required]
		[EmailAddress]
		[DataType(DataType.EmailAddress)]
		[Display(Name = "Email")]
		public string Email { get; set; }
	}
}