using System.ComponentModel.DataAnnotations;
using static RevolutionPMS.Common.EntitiesValidationsAndConstraints.AccommodationType;

namespace RevolutionPMS.Data.Models;

public class AccommodationType
{
	public AccommodationType()
	{
		this.PropertyTypes = new HashSet<PropertyType>();
	}

	[Key]
	public int Id { get; init; }

	[Required]
	[MaxLength(NameMaxLength, ErrorMessage = NameTooLongErrorMessage)]
	public string Name { get; set; } = null!;

	public virtual ICollection<PropertyType> PropertyTypes { get; set; } = null!;
}

