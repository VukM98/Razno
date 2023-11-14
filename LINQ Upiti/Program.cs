using System;
using Assignment_LINQUpiti;

class Program
{
    static void Main(string[] args)
    {
        Country[] countryCollection =
                {
            new Country("Afghanistan", 34656032),
            new Country("Austria", 8857960),
            new Country("Brazil", 210147125),
            new Country("Denmark", 5789957),
            new Country("Russia", 144526636),
            new Country("China", 1403500365),
            new Country("Turkey", 80810525),
            new Country("Serbia", 7001444),
            new Country("Iraq", 37202572),
            new Country("San Marino", 33344),

            };
        var country = from coun in countryCollection
                      orderby coun.Population descending
                      select coun;
        foreach (Country coun in country)
        {
            Console.WriteLine("Country: {0} Population: {1}", coun.Name, coun.Population);
        }
    }
}