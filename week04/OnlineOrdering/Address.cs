public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public string GetStreet() { return _street; }
    public void SetStreet(string street) { _street = street; }

    public string GetCity() { return _city; }
    public void SetCity(string city) { _city = city; }

    public string GetStateProvince() { return _stateProvince; }
    public void SetStateProvince(string stateProvince) { _stateProvince = stateProvince; }

    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }

    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_stateProvince}\n{_country}";
    }
}