using System.ComponentModel.DataAnnotations;
namespace form_submission.Models
{
  public class User
  {
    [Required]
    [MinLength(4, ErrorMessage = "First Name must be at least 4 characters long")]
    // [Display(Name = "First Name")]
    public string FName {get; set;}

    [Required]
    [MinLength(4,ErrorMessage = "Last Name must be at least 4 characters long")]
    // [Display(Name = "First Name")]
    public string LName {get; set;}

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Age must be a positive integer")]
    public int Age {get; set;}

    [Required]
    [EmailAddress]
    public string Email {get; set;}

    [Required]
    [MinLength(8, ErrorMessage = "Password must be 8 characters long"), DataType(DataType.Password)]
    public string Password {get; set;}

    public User(){}
    public User(string fname, string lname, int age, string email, string password){
      FName = fname;
      LName = lname;
      Age = age;
      Email = email;
      Password = password;

    }
  }
}