using System;

namespace DatingApp.API.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string URL { get; set; }
        public string Description { get; set; }
        public DateTime AddedOn { get; set; }
        public bool IsMain { get; set; }
        public User user { get; set; }
        public int UserId { get; set; }
    }
}