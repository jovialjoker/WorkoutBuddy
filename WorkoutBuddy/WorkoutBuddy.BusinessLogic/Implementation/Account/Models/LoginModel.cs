﻿namespace WorkoutBuddy.BusinessLogic.Implementation.Models
{
    public class LoginModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool AreCredentialsInvalid { get; set; }
        public bool IsDisabled { get; set; }
    }
}
