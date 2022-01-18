using System;
using System.Collections.Generic;

namespace DatabaseFirstEF.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string EmailAddress { get; set; } = null!;
        public string Mobile { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
