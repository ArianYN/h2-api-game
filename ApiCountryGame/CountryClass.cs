namespace ApiCountryGame;

public class CountryClass
{
    public string id { get; set; } // A long set of characters used to identify a country
    public NameInfo name { get; set; } // A nested struct with common and official name
    public string tld { get; set; } // Top Level Domain
    public string capital { get; set; } // Capital of the country
    public string altSpellings { get; set; } // The 2 letter version of a country. Denmark = DK
    public int population { get; set; } // The population of a country
}

public class NameInfo
{
    public string Common { get; set; }
    public string Official { get; set; }
    
}