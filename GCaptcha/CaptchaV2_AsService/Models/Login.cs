﻿namespace CaptchaV2_AsService.Models;

public class Login
{
    public string Email { get; set; } = default!;
    public string Password { get; set; } = default!;
    public string Token { get; set; } = default!;
}