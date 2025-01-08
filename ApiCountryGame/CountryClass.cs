namespace ApiCountryGame;

public class CountryClass
{
    public string id { get; set; } // A long set of characters used to identify a country
    public NameInfo name { get; set; } // A nested struct with common and official name
    public List<string> tld { get; set; } // Top Level Domain
    public List<string> capital { get; set; } // Capital of the country (array)
    public List<string> altSpellings { get; set; } // The 2 letter version of a country. Denmark = DK (array)
    public Flags flags { get; set; }
    public string population { get; set; } // The population of a country
    public string area { get; set; } // The countrys size in m2
}

public class NameInfo
{
    public string common { get; set; }
    public string official { get; set; }
}

public class Flags
{
    public string png { get; set; }
    public string svg { get; set; }
}
