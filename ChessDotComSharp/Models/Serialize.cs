using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessDotComSharp.Models
{
    public static class Serialize
    {
        public static string ToJson(this PlayerProfile self) => JsonConvert.SerializeObject(self, Converter.Settings);
        public static string ToJson(this PlayerStats self) => JsonConvert.SerializeObject(self, Converter.Settings);
        public static string ToJson(this GameList self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
}
