using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ChessDotComSharp.Models
{
    public enum PlayerTitle
    {
        GM, WGM, IM, WIM, FM, WFM, NM, WNM, CM, WCM
    }

    public enum GameVariant
    {
        Chess,
        Chess960,
        [EnumMember(Value = "bughouse")]
        BugHouse,
        [EnumMember(Value = "kingofthehill")]
        KingOfTheHill,
        [EnumMember(Value = "threecheck")]
        ThreeCheck,
        [EnumMember(Value = "crazyhouse")]
        CrazyHouse,
        [EnumMember(Value = "oddschess")]
        OddsChess
    };

    public enum TimeClass { Daily, Rapid, Blitz, Bullet, Lightning, Standard };

    public enum Side { Black, White };

    public enum MatchResult
    {
        Win, //Win
        Checkmated, //Checkmated
        [EnumMember(Value = "agreed")]
        DrawAgreed, //Draw agreed
        [EnumMember(Value = "repetition")]
        DrawRepetition, //Draw by repetition
        Timeout, //Timeout
        Resigned, //Resigned
        Stalemate, //Stalemate
        Lose, //Lose
        Insufficient, //Insufficient material
        [EnumMember(Value = "50move")]
        FiftyMove, //Draw by 50-move rule
        Abandoned, //Abandoned
        [EnumMember(Value = "kingofthehill")]
        KingOfTheHill, //Opponent king reached the hill
        [EnumMember(Value = "threecheck")]
        ThreeCheck, //Checked for the 3rd time
        [EnumMember(Value = "timevsinsufficient")]
        TimeVsInsufficient, //Draw by timeout vs insufficient material
        [EnumMember(Value = "buhousepartnerlose")]
        BughousePartnerLost, //Bughouse partner lost
    }

    public enum ClubMatchResult { Draw, Lose, Win };


    public enum PlayerTournamentStatus { Active, Eliminated, Winner, Withdrew, Removed, Invited, Registered };

    public enum TournamentState
    {

        Finished,
        [EnumMember(Value = "in_progress")]
        InProgress,
        Registration
    }

    public enum TeamMatchStatus
    {
        Finished,
        Registration, 
        [EnumMember(Value = "in_progress")]
        InProgress
    }

    public enum Visibility
    {
        Public,
        Private
    }
}
