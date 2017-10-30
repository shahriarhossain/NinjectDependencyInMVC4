using System.ComponentModel.DataAnnotations;

namespace NinjectTest.Models
{
    public class EventModel
    {
        [Key]
        public int EventID { get; set; }
        public string EventName { get; set; }
        public string EventStarts { get; set; }
        public string EventEnds { get; set; }
        public string EventLocation { get; set; }
    }    
}