﻿using System.ComponentModel.DataAnnotations;
using static RevolutionPMS.Common.EntitiesValidationsAndConstraints.PropertyType;

namespace RevolutionPMS.Web.ViewModels.SettingsModels;

public class PropertyTypeViewModel
{
	[MinLength(NameMinLength, ErrorMessage = NameTooShortErrorMessage)]
	public string Name { get; set; } = null!;

	public ICollection<PropertyTypeViewModel> PropertyTypes { get; set; } = null!;
}

