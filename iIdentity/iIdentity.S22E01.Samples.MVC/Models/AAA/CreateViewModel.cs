﻿using System.ComponentModel.DataAnnotations;

namespace iIdentity.S22E01.Samples.MVC.Models.AAA;

public class CreateViewModel
{
    [Required]
    public string Username { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }

    [Required]
    public string SSN { get; set; }
}
