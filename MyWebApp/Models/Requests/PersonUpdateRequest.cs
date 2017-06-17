using System.ComponentModel.DataAnnotations;

namespace MyWebApp.Models.Requests
{
    public class PersonUpdateRequest : PersonAddRquest
    {
        [Required]
        public int ID { get; set; }
    }
}