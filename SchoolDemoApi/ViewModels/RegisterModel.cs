﻿using System.ComponentModel.DataAnnotations;

namespace SchoolDemoApi.ViewModels
{
    public class RegisterModel
    {
        
        public string Username { get; set; }        
        public string Password { get; set; }
        public string Email { get; set; }
    }
}