class Address
{
    private string streetAddress;
    private string city;
    private string state;
    private string country;

    public Address(string streetAddress, string city, string state, string country)
    {
        this.streetAddress = streetAddress;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    public bool IsInUSA()
    {
        return country.Equals("USA");
    }

    public string GetFullAddress()
    {
        return "Street Address: " + streetAddress + "\nCity: " + city + "\nState/Province: " + state + "\nCountry: " + country;
    }
}