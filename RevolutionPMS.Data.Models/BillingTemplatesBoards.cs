using System.ComponentModel.DataAnnotations;

namespace RevolutionPMS.Data.Models;

public class BillingTemplatesBoards
{
	[Required]
	public int BoardId { get; set; }

	public virtual Board Board { get; set; } = null!;

	[Required]
	public Guid BillingTemplateId { get; set; }

	public virtual BillingTemplate BillingTemplate { get; set; } = null!;
}

