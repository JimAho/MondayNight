
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TestApp1.Models;

public class TeamListing
{
    public const string percentage = "Percentage";

    public int Id { get; set; }
    public string? Rank { get; set; }
    public string? Team { get; set; }
    public string? Mascot { get; set; }
    [DisplayName("Date of Last Win")]
    public string? DateOfLastWin { get; set; }
    [DisplayName("Winning " + percentage)]
    public string? WinningPercentage { get; set; }
    public string? Wins { get; set; }
    public string? Losses { get; set; }
    public string? Ties { get; set; }
    public string? Games { get; set; }


}