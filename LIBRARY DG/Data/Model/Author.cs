using System.ComponentModel.DataAnnotations;

namespace LIBRARY_DG.Data.Model
{
    public class Author
	{
		[Key]
		public int IdNumber { get; set; }
		public string? Name { get; set; }
		public string? Nationality { get; set; }
		public string? Alias { get; set; }
		public int BirthDate { get; set; }
	}
}
