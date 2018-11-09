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
                case "Finland":
                    countryCode = "fl";
                    break;
                case "Italy":
                    countryCode = "it";
                    break;
                case "Brazil":
                    countryCode = "br";
                    break;
                case "Germany":
                    countryCode = "de";
                    break;
                case "Switzerland":
                    countryCode = "ch";
                    break;
                case "Mexico":
                    countryCode = "mx";
                    break;
                case "Sweden":
                    countryCode = "se";
                    break;
                case "Argentina":
                    countryCode = "ar";
                    break;
                case "Austria":
                    countryCode = "at";
                    break;
                case "UK":
                    countryCode = "gb";
                    break;
                case "Poland":
                    countryCode = "pl";
                    break;
                case "Canada":
                    countryCode = "ca";
                    break;
                case "Ireland":
                    countryCode = "ie";
                    break;
                case "Norway":
                    countryCode = "no";
                    break;
                case "France":
                    countryCode = "fr";
                    break;
                case "Belgium":
                    countryCode = "be";
                    break;
                case "Spain":
                    countryCode = "es";
                    break;
                case "Venezuela":
                    countryCode = "ve";
                    break;
                case "Denmark":
                    countryCode = "dk";
                    break;
                case "Portugal":
                    countryCode = "pt";
                    break;
                default:
                    throw new Exception($"{countryName} has unsupported flag.");
            }

            return $"https://www.countryflags.io/{countryCode}/flat/64.png";
        }
    }
}
