using System.ComponentModel.DataAnnotations;

namespace sample.Models.Dto;

public class UserRegistrationDto
{
    [Required] 
    [EmailAddress] 
    public string Username { get; set; } = string.Empty;

    [Required] 
    [MinLength(8)]
    public string Password { get; set; } = string.Empty;
}