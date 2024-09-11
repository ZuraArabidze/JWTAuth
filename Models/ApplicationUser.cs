﻿using JWTAuth.Enums;
using Microsoft.AspNetCore.Identity;

namespace JWTAuth.Models


public class ApplicationUser : IdentityUser
{
    public Role Role { get; set; }
}
