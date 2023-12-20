using System.ComponentModel.DataAnnotations;
using static RevolutionPMS.Common.EntitiesValidationsAndConstraints.AccommodationType;

namespace RevolutionPMS.Web.ViewModels.SettingsModels;

public class AccommodationTypeViewModel
{
	public int Id { get; set; }

	[Required]
	[MinLength(NameMinLength, ErrorMessage = NameTooShortErrorMessage)]
	public string Name { get; set; } = null!;
}

