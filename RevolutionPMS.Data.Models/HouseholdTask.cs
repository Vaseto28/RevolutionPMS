using System.ComponentModel.DataAnnotations;
using static RevolutionPMS.Common.EntitiesValidationsAndConstraints.HouseholdTask;

namespace RevolutionPMS.Data.Models;

public class HouseholdTask
{
	public HouseholdTask()
	{
		this.Rooms = new HashSet<Room>();
	}

	[Key]
	public int Id { get; init; }

	[Required]
	[MaxLength(NameMaxLength, ErrorMessage = NameTooLongErrorMessage)]
	public string Name { get; set; } = null!;

	[Required]
	[MaxLength(DescriptionMaxLength, ErrorMessage = DescriptionTooLongErrorMessage)]
	public string Description { get; set; } = null!;

	public virtual ICollection<Room> Rooms { get; set; } = null!;
}

