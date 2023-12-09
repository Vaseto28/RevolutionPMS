using System.ComponentModel.DataAnnotations;
using static RevolutionPMS.Common.EntitiesValidationsAndConstraints.TaxSettings;

namespace RevolutionPMS.Data.Models;

public class TaxSettings
{
	[Key]
	public Guid Id { get; set; }

	[Required]
	public bool IsTaxIncludedInThePrices { get; set; }

	[Required]
	[MaxLength(NameMaxLength, ErrorMessage = NameTooLongErrorMessage)]
	public string TaxName { get; set; } = null!;

	public decimal TaxPersentage { get; set; }

	public int PriceRounding { get; set; }

	[Required]
	public Guid CurrencyId { get; set; }

	public virtual Currency DefaultCurrency { get; set; } = null!;
}

