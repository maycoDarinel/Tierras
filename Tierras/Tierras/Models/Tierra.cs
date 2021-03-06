﻿
namespace Tierras.Models
{

    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    public class Tierra
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "topLevelDomain")]
        public IList<string> TopLevelDomain { get; set; }


        [JsonProperty(PropertyName = "alpha2Code")]
        public string Alpha2Code { get; set; }


        [JsonProperty(PropertyName = "alpha3Code")]
        public string Alpha3Code { get; set; }


        [JsonProperty(PropertyName = "callingCodes")]
        public IList<string> CallingCodes { get; set; }


        [JsonProperty(PropertyName = "capital")]
        public string Capital { get; set; }


        [JsonProperty(PropertyName = "altSpellings")]
        public IList<string> AltSpellings { get; set; }


        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }


        [JsonProperty(PropertyName = "subregion")]
        public string Subregion { get; set; }


        [JsonProperty(PropertyName = "population")]
        public int Population { get; set; }


        [JsonProperty(PropertyName = "latlng")]
        public IList<double> Latlng { get; set; }


        [JsonProperty(PropertyName = "demonym")]
        public string Demonym { get; set; }


        [JsonProperty(PropertyName = "area")]
        public double? Area { get; set; }


        [JsonProperty(PropertyName = "gini")]
        public double? Gini { get; set; }


        [JsonProperty(PropertyName = "timezones")]
        public IList<string> Timezones { get; set; }


        [JsonProperty(PropertyName = "borders")]
        public IList<string> Borders { get; set; }


        [JsonProperty(PropertyName = "nativeName")]
        public string NativeName { get; set; }


        [JsonProperty(PropertyName = "numericCode")]
        public string NumericCode { get; set; }


        [JsonProperty(PropertyName = "currencies")]
        public IList<Currencies> Currencies { get; set; }


        [JsonProperty(PropertyName = "languages")]
        public IList<Languages> Languages { get; set; }


        [JsonProperty(PropertyName = "translations")]
        public Translations Translations { get; set; }


        [JsonProperty(PropertyName = " flag")]
        public string Flag { get; set; }


        [JsonProperty(PropertyName = "regionalBlocs")]
        public IList<RegionalBlocs> RegionalBlocs { get; set; }


        [JsonProperty(PropertyName = "cioc")]
        public string Cioc { get; set; }
    }
}
