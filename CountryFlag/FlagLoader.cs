using System;

namespace CountryFlag
{
    public class FlagLoader : IFlagLoader
    {
        public string GetFlagUrlByCountryName(string countryName)
        {
            var countryCode = string.Empty;
            switch (countryName)
            {
                case "USA":
                    countryCode = "us";
                    break;
                default:
                    throw new Exception($"{countryName} has unsupported flag.");
            }

            return $"https://www.countryflags.io/{countryCode}/flat/64.png";
        }
    }
}
