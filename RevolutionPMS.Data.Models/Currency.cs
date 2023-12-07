using System.ComponentModel.DataAnnotations;
using static RevolutionPMS.Common.EntitiesValidationsAndConstraints.Currency;

namespace RevolutionPMS.Data.Models;

public class Currency
{
	public Currency()
	{
		this.Id = Guid.NewGuid();
		this.TaxSettings = new HashSet<TaxSettings>();
	}

	public Guid Id { get; set; }

	[Required]
	[MaxLength(NameMaxLength, ErrorMessage = NameTooLongErrorMessage)]
	public string Name { get; set; } = null!;

	public decimal ExchangeRate { get; set; }

	public virtual ICollection<TaxSettings> TaxSettings { get; set; } = null!;
}

