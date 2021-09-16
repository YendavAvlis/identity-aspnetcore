using System;

namespace identity_aspnetcore.DTOs
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

    }
}