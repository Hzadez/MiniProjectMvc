﻿using System.ComponentModel.DataAnnotations;

namespace MiniProjectMvc.ViewModels.Register
{
    public class UserSignInVM
    {
        public string Username { get; set; }
        public string Password { get; set; }
        [Display(Name = "Məni xatırla")]
        public bool RememberMe { get; set; }
    }
}
