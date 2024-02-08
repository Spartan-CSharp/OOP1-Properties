namespace ConsoleUI
{
	internal class AddressModel
	{
		internal string StreetAddress
		{
			get; set;
		}
		internal string City
		{
			get; set;
		}
		internal string State
		{
			get; set;
		}
		internal string ZipCode
		{
			get; set;
		}
		internal string FullAddress
		{
			get
			{
				return $"{StreetAddress}, {City} {State} {ZipCode}";
			}
		}
		internal AddressModel()
		{
		}
		internal AddressModel(string streetAddress, string city, string state, string zipCode)
		{
			StreetAddress = streetAddress;
			City = city;
			State = state;
			ZipCode = zipCode;
		}
	}
}
