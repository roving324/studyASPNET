using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BoardWebApp.Models
{
	public class RegisterModel
	{
		[Required]
		[Display(Name = "아이디")]
		public int Id { get; set; }

		[Required]
		[Display(Name = "이름")]
		public string UserName { get;set; }

		[Required]
		[EmailAddress]
		[Display(Name = "이메일")]
		public string Email { get; set; }

		[Required]
		[DataType(DataType.Password)]
		[Display(Name = "패스워드")]
		public string Password { get; set; }

		[Required]
		[DataType(DataType.Password)]
		[Display(Name = "패스워드 확인")]
		[Compare("Password", ErrorMessage = "패스워드가 일치하지 않습니다.")]
		public string ConfirmPassword { get; set; }

		[Display(Name ="핸드폰번호")]
		public string PhoneNumber { get; set; }
	}
}
