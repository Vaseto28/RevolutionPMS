namespace RevolutionPMS.Common;

public static class EntitiesValidationsAndConstraints
{
    public static class PropertyType
    {
        public const int NameMinLength = 3;
        public const int NameMaxLength = 50;
        public const string NameTooLongErrorMessage = "The chosen name is too long!";

        public const int LocationMinLength = 3;
        public const int LocationMaxLength = 50;
        public const string LocationTooLongErrorMessage = "The location name is too long!";
    }

    public static class Property
	{
		public const int NameMinLength = 3;
		public const int NameMaxLength = 50;
		public const string NameTooLongErrorMessage = "The property name is too long!";
		
        public const int LocationMinLength = 3;
        public const int LocationMaxLength = 50;
        public const string LocationTooLongErrorMessage = "The location name is too long!";
    }
}

