﻿using System.ComponentModel.DataAnnotations;

namespace SpaDay6;

public class AddUserViewModel
{
    [Required(ErrorMessage = "Username is required.")]
    [StringLength (15, MinimumLength = 5, ErrorMessage = "Username must be 5-15 characters long.")]
    public string? Username { get; set; }
    
    
    [Required(ErrorMessage = "Password is required")]
    [StringLength (20, MinimumLength = 6, ErrorMessage = "Password must be 6-20 characters long.")]
    public string? Password { get; set; }

    
    [Required(ErrorMessage = "Password verification is required")]
    [StringLength (20, MinimumLength = 6, ErrorMessage = "Password must be 6-20 characters long.")]
    [Compare("Password", ErrorMessage ="Passwords must match.")]
    public string? VerifyPassword { get; set; }

    [EmailAddress]
    public string? Email { get; set; }

}
