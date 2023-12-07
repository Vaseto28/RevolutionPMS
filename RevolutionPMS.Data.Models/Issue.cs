using System.ComponentModel.DataAnnotations;
using static RevolutionPMS.Common.EntitiesValidationsAndConstraints.Issue;

namespace RevolutionPMS.Data.Models;

public class Issue
{
	public Issue()
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

	[Required]
	public DateTime StartDate { get; set; }

	[Required]
	public DateTime EndDate { get; set; }

	public virtual ICollection<Room> Rooms { get; set; } = null!;
}

