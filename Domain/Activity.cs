using System;

namespace Domain
{
    public class Activity
    {
        public Guid Id { get; set; }
        public string Make { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Model { get; set; }
        public string City { get; set; }
    }
}