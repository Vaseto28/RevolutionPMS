using System.ComponentModel.DataAnnotations;
using static RevolutionPMS.Common.EntitiesValidationsAndConstraints.RoomType;

namespace RevolutionPMS.Data.Models;

public class RoomType
{
	public RoomType()
	{
		this.Rooms = new HashSet<Room>();
	}

	[Key]
	public int Id { get; init; }

	[Required]
	[MaxLength(NameMaxLength, ErrorMessage = NameTooLongErrorMessage)]
	public string Name { get; set; } = null!;

	[Required]
	public int BedsCount { get; set; }

	public virtual ICollection<Room> Rooms { get; set; } = null!;
}

