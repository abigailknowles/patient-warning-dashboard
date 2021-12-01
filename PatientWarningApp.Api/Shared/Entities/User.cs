﻿namespace PatientWarningApp.Api.Shared.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Gender { get; set; }
        public string DOB { get; set; }
        public int Age { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public string Postcode { get; set; }
    }
}
