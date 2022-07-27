using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RegisterandLogin.Models
{
    public class User
    {

		[Key]
		public Guid g { get; set; }

		//[Required(ErrorMessage = "Please enter FirstName")]
		//[Display(Name = "FirstName")]
		public string FirstName { get; set; }

		//[Required(ErrorMessage = "Please enter LastName")]
		//[Display(Name = "LastName")]
		public string LastName { get; set; }

		//[Required]
		//[RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail id is not valid")]
		public string Email { get; set; }

		//[DataType(DataType.PhoneNumber), ErrorMessage=""]
		//[Display(Name = "Phone Number")]
		//[Required]
  //      [RegularExpression(@"^(\d{10})$", ErrorMessage = "Entered phone format is not valid.")]
        public int Number { get; set; }

        //[Required(ErrorMessage = "Please enter password")]
        //[DataType(DataType.Password)]
        //[StringLength(100, ErrorMessage = "Password \"{0}\" must have {2} character", MinimumLength = 8)]
        //[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$", ErrorMessage = "Password must be between 6 and 20 characters and contain one uppercase letter, one lowercase letter, one digit and one special character.")]
        public string Password { get; set; }
    }
}
