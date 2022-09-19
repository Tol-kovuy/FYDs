using System;

namespace FYD_s.Domain.Entity
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Patronymic { get; set; }
        public string Position { get; set; }
        public decimal Price { get; set; }
        public bool PaidOfFree { get; set; }
        public string Hospital { get; set; }
        public DateTime PatientHours { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Cabinet { get; set; }
        public string Experience { get; set; }
        public byte[]? Avatar { get; set; }
    }
}
