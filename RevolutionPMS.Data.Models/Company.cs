using System.ComponentModel.DataAnnotations;
using static RevolutionPMS.Common.EntitiesValidationsAndConstraints.Company;

namespace RevolutionPMS.Data.Models;

public class Company
{
	public Company()
	{
		this.Id = Guid.NewGuid();
		this.Properties = new HashSet<Property>();
	}

	[Key]
	public Guid Id { get; set; }

	[Required]
	[MaxLength(NameMaxLength, ErrorMessage = NameTooLongErrorMessage)]
	public string Name { get; set; } = null!;

	[Required]
	[MaxLength(VATRequiredLength, ErrorMessage = VATIncorrectLengthErrorMessage)]
	public string VATNumber { get; set; } = null!;

	[Required]
	[MaxLength(BulstatRequiredLength, ErrorMessage = BulstatIncorrectLengthErrorMessage)]
	public string Bulstat { get; set; } = null!;

	[Required]
    [MaxLength(CountryMaxLength, ErrorMessage = CountryTooLongErrorMessage)]
    public string Country { get; set; } = null!;

	[Required]
	[MaxLength(AddressMaxLength, ErrorMessage = AddressTooLongErrorMessage)]
	public string Address { get; set; } = null!;

	[Required]
	[MaxLength(CityMaxLength, ErrorMessage = CityTooLongErrorMessage)]
	public string City { get; set; } = null!;

    [Required]
    [MaxLength(RegionMaxLength, ErrorMessage = RegionTooLongErrorMessage)]
    public string Region { get; set; } = null!;

	[Required]
	[MaxLength(PostCodeRequiredLength, ErrorMessage = PostCodeIncorrectLengthErrorMessage)]
	public string PostCode { get; set; } = null!;

	[Required]
	[MaxLength(AccountablePersonNameMaxLength, ErrorMessage = AccountablePersonNameTooLongErrorMessage)]
	public string AccountablePerson { get; set; } = null!;

	public virtual ICollection<Property> Properties { get; set; } = null!;
}

