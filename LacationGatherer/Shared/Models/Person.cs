using LacationGatherer.Shared.Infrastructue.Validators;
using System.ComponentModel.DataAnnotations;

namespace LacationGatherer.Shared.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Code is required!")]
        [IntMinValue(0, ErrorMessage = "Code is required!")]
        public int PersonalCode { get; set; }

        [Required(ErrorMessage = "Name is required!")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please select your location.")]
        [DecimalMinValue(0, ErrorMessage = "Please select your location.")]
        public decimal Latitude { get; set; }

        [Required(ErrorMessage = "Please select your location.")]
        [DecimalMinValue(0, ErrorMessage = "Please select your location.")]
        public decimal Longitude { get; set; }
    }
}
