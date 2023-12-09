using System.ComponentModel.DataAnnotations;
using static RevolutionPMS.Common.EntitiesValidationsAndConstraints.Room;

namespace RevolutionPMS.Data.Models;

public class Room
{
	[Key]
	public int Id { get; init; }

	public int Number { get; set; }

	public int Block { get; set; }

	[Required]
	[MaxLength(DescriptionMaxLength, ErrorMessage = DescriptionTooLongErrorMessage)]
	public string Description { get; set; } = null!;

	public int RoomTypeId { get; set; }

	public virtual RoomType RoomType { get; set; } = null!;

	public Guid PropertyId { get; set; }

	public virtual Property Property { get; set; } = null!;

	public int? IssueId { get; set; }

	public virtual Issue? Issue { get; set; }

	public int? HouseholdTaskId { get; set; }

	public virtual HouseholdTask? HouseholdTask { get; set; } = null!;
}

