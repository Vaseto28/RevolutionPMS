using System.ComponentModel.DataAnnotations;
using static RevolutionPMS.Common.EntitiesValidationsAndConstraints.Property;

namespace RevolutionPMS.Data.Models;

public class Property
{
	public Property()
	{
		this.Id = Guid.NewGuid();

		this.Rooms = new HashSet<Room>();
	}

	[Key]
	public Guid Id { get; set; }

	[Required]
	[MaxLength(NameMaxLength, ErrorMessage = NameTooLongErrorMessage)]
	public string Name { get; set; } = null!;

	[Required]
	[MaxLength(LocationMaxLength, ErrorMessage = LocationTooLongErrorMessage)]
	public string Location { get; set; } = null!;

	public int RoomsCapacity { get; set; }

	[Required]
	public string MarketingEmail { get; set; } = null!;

	[Required]
	public string Website { get; set; } = null!;

	public int PropertyTypeId { get; set; }

	public virtual PropertyType PropertyType { get; set; } = null!;

	[Required]
	public Guid CompanyId { get; set; }

	public virtual Company Company { get; set; } = null!;

	public virtual ICollection<Room> Rooms { get; set; } = null!;
}

