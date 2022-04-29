using System.ComponentModel.DataAnnotations;

namespace LIBRARY_DG.Data.Model
{
    public class Student
	{
		[Key]
		public int Identification { get; set; }
        public string? Name { get; set; }
		public string? Institution { get; set; }
		public int Age { get; set; }
		public int BirthDate { get; set; }
	}
}
