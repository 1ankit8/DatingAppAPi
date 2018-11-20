using System;

namespace DatingApp.API.dto
{
    public class PhotoForDetailedDTO
    {
        public int Id { get; set; }
        public string URL { get; set; }
        public string Description { get; set; }
        public DateTime AddedOn { get; set; }
        public bool IsMain { get; set; }
    }
}