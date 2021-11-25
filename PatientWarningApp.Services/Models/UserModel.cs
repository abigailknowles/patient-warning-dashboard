﻿using PatientWarningApp.Data.Entities;
using System;

namespace PatientWarningApp.Services.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Gender { get; set; }
        public string DOB { get; set; }
        public string MobileNumber { get; set; }
        public Address Address { get; set; }
    }
}