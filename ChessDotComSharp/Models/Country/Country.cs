namespace ChessDotComSharp.Models
{
    using System.Collections.Generic;
    using J = Newtonsoft.Json.JsonPropertyAttribute;

    public partial class Country
    {
        [J("@id")] public string Id { get; set; }
        [J("code")] public string Code { get; set; }
        [J("name")] public string Name { get; set; }
    }

    public partial class CountryClubs
    {
        public List<string> Clubs { get; set; }
    }
    public partial class CountryPlayers
    {
        public List<string> Players { get; set; }
    }

}
