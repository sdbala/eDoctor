
using System;

namespace eDoctor.WebUI.Models
{
    public class Doctor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime DoB { get; set; }
        public string Mobile { get; set; }
        public string LandLine { get; set; }
        public string Qualification { get; set; }
    }
}