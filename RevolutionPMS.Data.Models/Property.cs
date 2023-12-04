using System.ComponentModel.DataAnnotations;
using static RevolutionPMS.Common.EntitiesValidationsAndConstraints.Property;

namespace RevolutionPMS.Data.Models.DataModels;

public class Property
{
	public Property()
	{
		this.Id = Guid.NewGuid();
	}

	[Key]
	public Guid Id { get; set; }

	[Required]
	[MaxLength(NameMaxLength, ErrorMessage = NameTooLongErrorMessage)]
	public string Name { get; set; } = null!;

	[Required]
	[MaxLength(LocationMaxLength, ErrorMessage = LocationTooLongErrorMessage)]
	public string Location { get; set; } = null!;

	public int RoomCapacity { get; set; }

	[Required]
	public string MarketingEmail { get; set; } = null!;

	[Required]
	public string Website { get; set; } = null!;

	[Required]
	public Guid CompanyInvoiceDataId { get; set; }

	public virtual CompanyInvoiceData CompanyInvoiceData { get; set; } = null!;
}

