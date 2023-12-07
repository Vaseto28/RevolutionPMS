using System.ComponentModel.DataAnnotations;
using static RevolutionPMS.Common.EntitiesValidationsAndConstraints.Board;

namespace RevolutionPMS.Data.Models;

public class Board
{
	public Board()
	{
		this.BillingTemplatesBoards = new HashSet<BillingTemplatesBoards>();
	}

	[Key]
	public int Id { get; init; }

	[Required]
	[MaxLength(NameMaxLength, ErrorMessage = NameTooLongErrorMessage)]
	public string Name { get; set; } = null!;

	public virtual ICollection<BillingTemplatesBoards> BillingTemplatesBoards { get; set; } = null!;
}

