
namespace Tierras.Models
{ 
    using Newtonsoft.Json;
public class RegionalBlocs
    {
        [JsonProperty(PropertyName = "acronym")]
        public string Acronym { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    

    }
}
