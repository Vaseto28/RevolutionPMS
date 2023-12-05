using System.ComponentModel.DataAnnotations;
using static RevolutionPMS.Common.EntitiesValidationsAndConstraints.PropertyType;

namespace RevolutionPMS.Data.Models;

public class PropertyType
{
	[Key]
	public int Id { get; init; }

	[Required]
	[MaxLength(NameMaxLength, ErrorMessage = NameTooLongErrorMessage)]
	public string Name { get; set; } = null!;

	public virtual ICollection<Property> Properties { get; set; } = null!;
}

