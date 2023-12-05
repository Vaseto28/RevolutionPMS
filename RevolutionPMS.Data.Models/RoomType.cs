using System.ComponentModel.DataAnnotations;
using static RevolutionPMS.Common.EntitiesValidationsAndConstraints.RoomType;

namespace RevolutionPMS.Data.Models;

public class RoomType
{
	[Key]
	public Guid Id { get; set; }

	[Required]
	[MaxLength(NameMaxLength, ErrorMessage = NameTooLongErrorMessage)]
	public string Name { get; set; } = null!;

	[Required]
	public int BedsCount { get; set; }
}

