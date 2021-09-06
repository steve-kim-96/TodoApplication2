using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApplication2.Models
{
    public class Todo
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50,MinimumLength = 3)]
        public string Title { get; set; }
        [Display(Name = "Type of Todo")]
        [StringLength(50, MinimumLength = 3)]
        public string? Type { get; set; }
        [Display(Name="Done By Date")]
        [DataType(DataType.Date)]
        public DateTime DoneByDate { get; set; }
        [Display(Name = "Is Completed")]
        public bool IsCompleted { get; set; }
        [RegularExpression(@"^[A-Z]+", ErrorMessage = "Must be capital letters")]
        [StringLength(50, MinimumLength = 3)]
        public string Difficulty { get; set; }
    }
}
