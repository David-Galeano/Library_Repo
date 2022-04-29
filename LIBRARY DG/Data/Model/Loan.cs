using System.ComponentModel.DataAnnotations;

namespace LIBRARY_DG.Data.Model
{
    public class Loan
	{
		[Key]
		public int IdNumber { get; set; }
		public string? LoanerName { get; set; }
		public string? BankName { get; set; }
		public string? BookName { get; set; }
		public int Amount { get; set; }
	}
}
