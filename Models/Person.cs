﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsVotingSystem.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNUmber { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
    }
}