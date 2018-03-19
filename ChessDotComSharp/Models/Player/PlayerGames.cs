using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using J = Newtonsoft.Json.JsonPropertyAttribute;
using System.Globalization;


namespace ChessDotComSharp.Models
{
    public partial class PlayerArchivedGames : GameList { }

    public partial class PlayerGames
    {
        [J("games")] public IReadOnlyList<ActiveGame> Games { get; set; }
    }

    public partial class PlayerToMoveGames
    {
        [J("games")] public IReadOnlyList<ToMoveGame> Games { get; set; }
    }

    public partial class ArchivedGamesList
    {
        [J("archives")] public IReadOnlyList<string> Archives { get; set; }
    }

    public partial class PlayerInformation
    {
        [J("rating")] public int Rating { get; set; }
        [J("result")] public string Result { get; set; }
        [J("@id")] public string Id { get; set; }
        [J("username")] public string Username { get; set; }
    }

    public partial class ActiveGame : GameBase
    {
        /// <summary>
        /// Timestamp of the when the move must be made by, null if the player is on vacation.
        /// </summary>
        [J("move_by")] public DateTime? MoveBy { get; set; }
        [J("last_activity")] public DateTime? LastActivity { get; set; }
        [J("draw_offer")] public Side? DrawOffer { get; set; }
        [J("turn")] public Side Turn { get; set; }
        [J("white")] public string White { get; set; }
        [J("black")] public string Black { get; set; }
    }

    public partial class ToMoveGame
    {

        [J("url")] public string Url { get; set; }
        /// <summary>
        /// Timestamp of the when the move must be made by, null if not the players' turn.
        /// </summary>
        [J("move_by")] public DateTime? MoveBy { get; set; }
        [J("last_activity")] public DateTime LastActivity { get; set; }
        [J("draw_offer")] public bool? IsDrawOffered { get; set; }
    }


}
