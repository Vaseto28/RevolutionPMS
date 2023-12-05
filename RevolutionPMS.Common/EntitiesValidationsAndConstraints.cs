namespace RevolutionPMS.Common;

public static class EntitiesValidationsAndConstraints
{
    public static class RoomType
    {
        public const int NameMinLength = 3;
        public const int NameMaxLength = 50;
        public const string NameTooShortErrorMessage = "The chosen name is too short!";
        public const string NameTooLongErrorMessage = "The chosen name is too long!";

        public const int BedsCountMinValue = 1;
        public const string BedsCountMinValueErrorMessage = "There should be at least one bed in the room!";
    }

    public static class Property
	{
		public const int NameMinLength = 2;
		public const int NameMaxLength = 50;
        public const string NameTooShortErrorMessage = "The name of the property is too short!";
		public const string NameTooLongErrorMessage = "The name of the property is too long!";
		
        public const int LocationMinLength = 3;
        public const int LocationMaxLength = 50;
        public const string LocationTooShortErrorMessage = "The name of the location is too short!";
        public const string LocationTooLongErrorMessage = "The name of the location is too long!";
    }

    public static class CompanyInvoiceData
    {
        public const int NameMinLength = 3;
        public const int NameMaxLength = 60;
        public const string NameTooShortErrorMessage = "The name of the company is too short!";
        public const string NameTooLongErrorMessage = "The name of the company is too long!";

        public const int VATRequiredLength = 11;
        public const string VATIncorrectLengthErrorMessage = "The VAT of the company is incorrect!";

        public const int BulstatRequiredLength = 11;
        public const string BulstatIncorrectLengthErrorMessage = "The bulstat of the company is incorrect!";

        public const int CountryMinLength = 3;
        public const int CountryMaxLength = 30;
        public const string CountryTooShortErrorMessage = "The name of the country is too short!";
        public const string CountryTooLongErrorMessage = "The name of the country is too long!";

        public const int AddressMinLength = 3;
        public const int AddressMaxLength = 100;
        public const string AddressTooShortErrorMessage = "The address of the company is too short!";
        public const string AddressTooLongErrorMessage = "The address of the company is too long!";

        public const int CityMinLength = 3;
        public const int CityMaxLength = 50;
        public const string CityTooShortErrorMessage = "The name of the city is too short!";
        public const string CityTooLongErrorMessage = "The name of teh city is too long!";

        public const int RegionMinLength = 3;
        public const int RegionMaxLength = 50;
        public const string RegionTooShortErrorMessage = "The name of the region is too short!";
        public const string RegionTooLongErrorMessage = "The name of teh region is too long!";

        public const int PostCodeRequiredLength = 4;
        public const string PostCodeIncorrectLengthErrorMessage = "The post code is incorrect!";

        public const int AccountablePersonNameMinLength = 5;
        public const int AccountablePersonNameMaxLength = 40;
        public const string AccountablePersonNameTooShortErrorMessage = "The accountable person's name is too short!";
        public const string AccountablePersonNameTooLongErrorMessage = "The name of the accountable person is too long!. Fill in only first and last name.";
    }

    public static class PropertyType
    {
        public const int NameMinLength = 3;
        public const int NameMaxLength = 20;
        public const string NameTooShortErrorMessage = "The name of the property type is too short!";
        public const string NameTooLongErrorMessage = "The name of the property type is too long!";
    }
}

