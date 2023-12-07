using System.ComponentModel.DataAnnotations;
using static RevolutionPMS.Common.EntitiesValidationsAndConstraints.BillingTemplate;

namespace RevolutionPMS.Data.Models;

public class BillingTemplate
{
	public BillingTemplate()
	{
		this.BillingTemplatesBoards = new HashSet<BillingTemplatesBoards>();
	}

	[Key]
	public Guid Id { get; set; }

	[Required]
	[MaxLength(NameMaxLength, ErrorMessage = NameTooLongErrorMessage)]
	public string Name { get; set; } = null!;

	public decimal Price { get; set; }

	public int Quantity { get; set; }

	public int InitialQuantity { get; set; }

	public decimal TaxPersentage { get; set; }

	[Required]
	public bool IsPriceChangeable { get; set; }

	public virtual ICollection<BillingTemplatesBoards> BillingTemplatesBoards { get; set; } = null!;
}

