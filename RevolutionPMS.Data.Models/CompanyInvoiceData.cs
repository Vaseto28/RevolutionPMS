using System.ComponentModel.DataAnnotations;

namespace RevolutionPMS.Data.Models.DataModels;

public class CompanyInvoiceData
{
	public CompanyInvoiceData()
	{
		this.Id = Guid.NewGuid();
	}

	[Key]
	public Guid Id { get; set; }

	[Required]
	[MaxLength(60, ErrorMessage = "The company name is too long!")]
	public string Name { get; set; } = null!;

	[Required]
	[MaxLength(11, ErrorMessage = "Invalid VAT number!")]
	public string VATNumber { get; set; } = null!;

	[Required]
	[MaxLength(9, ErrorMessage = "Invalid Bulstat / EIC!")]
	public string Bulstat { get; set; } = null!;

	[Required]
    [MaxLength(30, ErrorMessage = "The address is too long!")]
    public string Country { get; set; } = null!;

	[Required]
	[MaxLength(100, ErrorMessage = "The address is too long!")]
	public string Address { get; set; } = null!;

	[Required]
	[MaxLength(50, ErrorMessage = "The city name is too long!")]
	public string City { get; set; } = null!;

    [Required]
    [MaxLength(50, ErrorMessage = "The city name is too long!")]
    public string Region { get; set; } = null!;

	[Required]
	[MaxLength(4, ErrorMessage = "Invalid post code!")]
	public string PostCode { get; set; } = null!;

	[Required]
	[MaxLength(40, ErrorMessage = "The name of the accountable person is too long!. Fill in only first and last name.")]
	public string AccountablePerson { get; set; } = null!;
}

