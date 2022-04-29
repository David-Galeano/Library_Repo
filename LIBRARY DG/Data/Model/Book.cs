using System.ComponentModel.DataAnnotations;

namespace LIBRARY_DG.Data.Model
{
    public class Book
	{
		[Key]
		public int Identification { get; set; }
		public string? Name { get; set; }
		public string? Category { get; set; }
		public string? Author { get; set; }
		public int PageNumber { get; set; }
	}
}
