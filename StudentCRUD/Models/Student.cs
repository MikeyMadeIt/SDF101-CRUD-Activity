
using System.ComponentModel.DataAnnotations;

namespace StudentCRUD.Models
{
    public class Student
        {
            [Key]
            public int StudentId { get; set; }

			[Required]
			public string Name { get; set; } = string.Empty;

			[Required]
			public string Section { get; set; } = string.Empty;

			[Required]
			[EmailAddress]
			public string EmailId { get; set; } = string.Empty;

			[Required]
			public string Branch { get; set; } = string.Empty;
		}
}
