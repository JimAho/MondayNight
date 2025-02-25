using Microsoft.EntityFrameworkCore;
using TestApp1.Data;
using TestApp1.Models;

namespace TestApp1.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new TestApp1Context(
            serviceProvider.GetRequiredService<
                DbContextOptions<TestApp1Context>>()))
        {
            if (context == null || context.TeamListing == null)
            {
                throw new ArgumentNullException("Null RazorPagesTeamContext");
            }

            context.TeamListing.ExecuteDelete();

            // Look for any teams.
            if (context.TeamListing.Any())
            {
                return;   // DB has been seeded
            }

            // The information from this section was pasted from Excel. It is left unformatted for readablity and easier line comparison.
            context.TeamListing.AddRange(
                new TeamListing { Rank = "1", Team = "Michigan", Mascot = "Wolverines", DateOfLastWin = "10/12/13", WinningPercentage = "0.73663", Wins = "877", Losses = "302", Ties = "36", Games = "1215" },
new TeamListing { Rank = "2", Team = "Notre Dame", Mascot = "Fighting Irish", DateOfLastWin = "10/5/13", WinningPercentage = "0.73396", Wins = "837", Losses = "290", Ties = "42", Games = "1169" },
new TeamListing { Rank = "3", Team = "Texas", Mascot = "Longhorns", DateOfLastWin = "10/12/13", WinningPercentage = "0.72032", Wins = "845", Losses = "318", Ties = "33", Games = "1196" },
new TeamListing { Rank = "4", Team = "Ohio State", Mascot = "Buckeyes", DateOfLastWin = "9/28/13", WinningPercentage = "0.71653", Wins = "819", Losses = "308", Ties = "53", Games = "1180" },
new TeamListing { Rank = "5", Team = "Oklahoma", Mascot = "Sooners", DateOfLastWin = "9/21/13", WinningPercentage = "0.71534", Wins = "799", Losses = "302", Ties = "53", Games = "1154" },
new TeamListing { Rank = "6", Team = "Alabama", Mascot = "Roll Tide", DateOfLastWin = "10/5/13", WinningPercentage = "0.70678", Wins = "792", Losses = "316", Ties = "43", Games = "1151" },
new TeamListing { Rank = "7", Team = "Southern Cal", Mascot = "Trojans", DateOfLastWin = "10/12/13", WinningPercentage = "0.70599", Wins = "775", Losses = "307", Ties = "54", Games = "1136" },
new TeamListing { Rank = "8", Team = "Nebraska", Mascot = "Cornhuskers", DateOfLastWin = "10/5/13", WinningPercentage = "0.70116", Wins = "827", Losses = "341", Ties = "40", Games = "1208" },
new TeamListing { Rank = "9", Team = "Tennessee", Mascot = "Volunteers", DateOfLastWin = "Go Vols", WinningPercentage = "0.69247", Wins = "783", Losses = "333", Ties = "53", Games = "1169" },
new TeamListing { Rank = "10", Team = "Penn State", Mascot = "Nittany Lions", DateOfLastWin = "9/21/13", WinningPercentage = "0.69103", Wins = "811", Losses = "351", Ties = "42", Games = "1204" },
new TeamListing { Rank = "11", Team = "Florida State", Mascot = "Seminoles", DateOfLastWin = "9/28/13", WinningPercentage = "0.66261", Wins = "454", Losses = "227", Ties = "17", Games = "698" },
new TeamListing { Rank = "12", Team = "Georgia", Mascot = "Bulldogs", DateOfLastWin = "9/21/13", WinningPercentage = "0.64566", Wins = "731", Losses = "389", Ties = "54", Games = "1174" },
new TeamListing { Rank = "13", Team = "Louisiana State", Mascot = "Tigers", DateOfLastWin = "9/28/13", WinningPercentage = "0.64086", Wins = "709", Losses = "387", Ties = "47", Games = "1143" },
new TeamListing { Rank = "14", Team = "Miami-Florida", Mascot = "Hurricanes", DateOfLastWin = "9/21/13", WinningPercentage = "0.63488", Wins = "553", Losses = "314", Ties = "19", Games = "886" },
new TeamListing { Rank = "15", Team = "Florida", Mascot = "Gators", DateOfLastWin = "10/12/13", WinningPercentage = "0.63109", Wins = "654", Losses = "374", Ties = "40", Games = "1068" },
new TeamListing { Rank = "16", Team = "Auburn", Mascot = "Tigers", DateOfLastWin = "10/5/13", WinningPercentage = "0.6272", Wins = "689", Losses = "400", Ties = "47", Games = "1136" },
new TeamListing { Rank = "17", Team = "Miami-Ohio", Mascot = "Redhawks", DateOfLastWin = "9/28/13", WinningPercentage = "0.61993", Wins = "650", Losses = "390", Ties = "44", Games = "1084" },
new TeamListing { Rank = "18", Team = "Washington", Mascot = "Huskies", DateOfLastWin = "9/21/13", WinningPercentage = "0.61421", Wins = "658", Losses = "404", Ties = "50", Games = "1112" },
new TeamListing { Rank = "19", Team = "Arizona State", Mascot = "Sun Devils", DateOfLastWin = "10/12/13", WinningPercentage = "0.61245", Wins = "549", Losses = "343", Ties = "24", Games = "916" },
new TeamListing { Rank = "20", Team = "Central Michigan", Mascot = "Chippewas", DateOfLastWin = "10/5/13", WinningPercentage = "0.61059", Wins = "570", Losses = "357", Ties = "36", Games = "963" },
new TeamListing { Rank = "21", Team = "Virginia Tech", Mascot = "Hokies", DateOfLastWin = "10/12/13", WinningPercentage = "0.60508", Wins = "668", Losses = "428", Ties = "46", Games = "1142" },
new TeamListing { Rank = "22", Team = "Colorado", Mascot = "Buffaloes", DateOfLastWin = "10/5/13", WinningPercentage = "0.60158", Wins = "666", Losses = "435", Ties = "36", Games = "1137" },
new TeamListing { Rank = "23", Team = "West Virginia", Mascot = "Mountaineers", DateOfLastWin = "9/28/13", WinningPercentage = "1.59856", Wins = "682", Losses = "450", Ties = "45", Games = "1177" },
new TeamListing { Rank = "24", Team = "Texas A&M", Mascot = "Aggies", DateOfLastWin = "9/21/13", WinningPercentage = "0.59757", Wins = "665", Losses = "440", Ties = "48", Games = "1153" },
new TeamListing { Rank = "25", Team = "Georgia Tech", Mascot = "Yellow Jackets", DateOfLastWin = "10/12/13", WinningPercentage = "0.59741", Wins = "672", Losses = "446", Ties = "42", Games = "1160" },
new TeamListing { Rank = "26", Team = "Fresno State", Mascot = "Bulldogs", DateOfLastWin = "10/5/13", WinningPercentage = "0.59671", Wins = "547", Losses = "365", Ties = "29", Games = "941" },
new TeamListing { Rank = "27", Team = "Bowling Green", Mascot = "Falcons", DateOfLastWin = "10/12/13", WinningPercentage = "0.5931", Wins = "490", Losses = "328", Ties = "52", Games = "870" },
new TeamListing { Rank = "28", Team = "Southern Miss", Mascot = "Golden Eagles", DateOfLastWin = "10/5/13", WinningPercentage = "0.59269", Wins = "531", Losses = "361", Ties = "25", Games = "917" },
new TeamListing { Rank = "29", Team = "Arkansas", Mascot = "Razorbacks", DateOfLastWin = "9/28/13", WinningPercentage = "0.59119", Wins = "658", Losses = "449", Ties = "39", Games = "1146" },
new TeamListing { Rank = "30", Team = "Clemson", Mascot = "Tigers", DateOfLastWin = "9/21/13", WinningPercentage = "0.59083", Wins = "641", Losses = "437", Ties = "45", Games = "1123" },
new TeamListing { Rank = "31", Team = "Boston College", Mascot = "Eagles", DateOfLastWin = "10/12/13", WinningPercentage = "0.58945", Wins = "624", Losses = "429", Ties = "37", Games = "1090" },
new TeamListing { Rank = "32", Team = "Michigan State", Mascot = "Spartans", DateOfLastWin = "10/5/13", WinningPercentage = "0.5884", Wins = "617", Losses = "425", Ties = "44", Games = "1086" },
new TeamListing { Rank = "33", Team = "Utah", Mascot = "Utes", DateOfLastWin = "10/12/13", WinningPercentage = "0.58837", Wins = "607", Losses = "420", Ties = "31", Games = "1058" },
new TeamListing { Rank = "34", Team = "UCLA", Mascot = "Tigers", DateOfLastWin = "10/5/13", WinningPercentage = "0.58659", Wins = "537", Losses = "373", Ties = "37", Games = "947" },
new TeamListing { Rank = "35", Team = "Syracuse", Mascot = "Orangemen", DateOfLastWin = "10/12/13", WinningPercentage = "0.5825", Wins = "678", Losses = "479", Ties = "49", Games = "1206" },
new TeamListing { Rank = "36", Team = "Army", Mascot = "Mules", DateOfLastWin = "10/5/13", WinningPercentage = "0.58094", Wins = "642", Losses = "456", Ties = "51", Games = "1149" },
new TeamListing { Rank = "37", Team = "Pittsburgh", Mascot = "Panthers", DateOfLastWin = "10/12/13", WinningPercentage = "0.57819", Wins = "663", Losses = "478", Ties = "42", Games = "1183" },
new TeamListing { Rank = "38", Team = "Minnesota", Mascot = "Golden Gophers", DateOfLastWin = "9/28/13", WinningPercentage = "0.5775", Wins = "639", Losses = "462", Ties = "41", Games = "1142" },
new TeamListing { Rank = "39", Team = "Brigham Young", Mascot = "Cougars", DateOfLastWin = "9/21/13", WinningPercentage = "0.57238", Wins = "505", Losses = "374", Ties = "26", Games = "905" },
new TeamListing { Rank = "40", Team = "Arizona", Mascot = "Wildcats", DateOfLastWin = "10/5/13", WinningPercentage = "0.57193", Wins = "552", Losses = "409", Ties = "33", Games = "994" },
new TeamListing { Rank = "41", Team = "Louisiana Tech", Mascot = "Bulldogs", DateOfLastWin = "9/28/13", WinningPercentage = "0.5719", Wins = "500", Losses = "370", Ties = "34", Games = "904" },
new TeamListing { Rank = "42", Team = "North Carolina", Mascot = "Tarheels", DateOfLastWin = "9/21/13", WinningPercentage = "0.56686", Wins = "647", Losses = "488", Ties = "54", Games = "1189" },
new TeamListing { Rank = "43", Team = "Hawaii", Mascot = "Rainbow Warriors", DateOfLastWin = "10/12/13", WinningPercentage = "0.5662", Wins = "513", Losses = "390", Ties = "26", Games = "929" },
new TeamListing { Rank = "44", Team = "California", Mascot = "Golden Bears", DateOfLastWin = "10/5/13", WinningPercentage = "0.56603", Wins = "626", Losses = "474", Ties = "51", Games = "1151" },
new TeamListing { Rank = "45", Team = "Mississippi", Mascot = "Rebels", DateOfLastWin = "10/12/13", WinningPercentage = "0.56574", Wins = "615", Losses = "468", Ties = "35", Games = "1118" },
new TeamListing { Rank = "46", Team = "Wisconsin", Mascot = "Badgers", DateOfLastWin = "10/5/13", WinningPercentage = "0.56543", Wins = "613", Losses = "465", Ties = "53", Games = "1131" },
new TeamListing { Rank = "47", Team = "Texas Tech", Mascot = "Red Raiders", DateOfLastWin = "10/12/13", WinningPercentage = "0.56303", Wins = "511", Losses = "393", Ties = "32", Games = "936" },
new TeamListing { Rank = "48", Team = "Tulsa", Mascot = "Golden Hurricanes", DateOfLastWin = "10/5/13", WinningPercentage = "0.56077", Wins = "554", Losses = "431", Ties = "27", Games = "1012" },
new TeamListing { Rank = "49", Team = "Stanford", Mascot = "Cardinals", DateOfLastWin = "9/28/13", WinningPercentage = "0.56017", Wins = "562", Losses = "436", Ties = "49", Games = "1047" },
new TeamListing { Rank = "50", Team = "Western Michigan", Mascot = "Broncos", DateOfLastWin = "9/21/13", WinningPercentage = "0.55996", Wins = "511", Losses = "399", Ties = "24", Games = "934" },
new TeamListing { Rank = "51", Team = "Navy", Mascot = "Goats", DateOfLastWin = "10/12/13", WinningPercentage = "0.55045", Wins = "642", Losses = "519", Ties = "58", Games = "1219" },
new TeamListing { Rank = "52", Team = "Oregon", Mascot = "Ducks", DateOfLastWin = "10/5/13", WinningPercentage = "0.5481", Wins = "569", Losses = "??", Ties = "47", Games = "1081" },
new TeamListing { Rank = "53", Team = "Air Force", Mascot = "Falcons", DateOfLastWin = "10/12/13", WinningPercentage = "0.5439", Wins = "328", Losses = "274", Ties = "13", Games = "615" },
new TeamListing { Rank = "54", Team = "Toledo", Mascot = "Rockets", DateOfLastWin = "10/5/13", WinningPercentage = "0.54318", Wins = "466", Losses = "390", Ties = "24", Games = "880" },
new TeamListing { Rank = "55", Team = "Missouri", Mascot = "Tigers", DateOfLastWin = "9/28/13", WinningPercentage = "0.54082", Wins = "610", Losses = "514", Ties = "52", Games = "1176" },
new TeamListing { Rank = "56", Team = "Purdue", Mascot = "Boilermakers", DateOfLastWin = "9/21/13", WinningPercentage = "0.53623", Wins = "575", Losses = "494", Ties = "49", Games = "1118" },
new TeamListing { Rank = "57", Team = "Iowa", Mascot = "Hawkeyes", DateOfLastWin = "10/12/13", WinningPercentage = "0.53012", Wins = "579", Losses = "511", Ties = "39", Games = "1129" },
new TeamListing { Rank = "58", Team = "Virginia", Mascot = "Cavaliers", DateOfLastWin = "10/5/13", WinningPercentage = "0.5299", Wins = "614", Losses = "542", Ties = "48", Games = "1204" },
new TeamListing { Rank = "59", Team = "Maryland", Mascot = "Terrapins", DateOfLastWin = "10/12/13", WinningPercentage = "0.52936", Wins = "601", Losses = "532", Ties = "42", Games = "1175" },
new TeamListing { Rank = "60", Team = "North Texas", Mascot = "Mean Green", DateOfLastWin = "9/28/13", WinningPercentage = "0.52803", Wins = "399", Losses = "355", Ties = "31", Games = "785" },
new TeamListing { Rank = "61", Team = "Houston", Mascot = "Cougars", DateOfLastWin = "9/21/13", WinningPercentage = "0.52762", Wins = "365", Losses = "326", Ties = "15", Games = "706" },
new TeamListing { Rank = "62", Team = "Texas Christian", Mascot = "Horned Frogs", DateOfLastWin = "10/5/13", WinningPercentage = "0.52604", Wins = "568", Losses = "509", Ties = "56", Games = "1133" },
new TeamListing { Rank = "63", Team = "Ball State", Mascot = "Cardinals", DateOfLastWin = "10/12/13", WinningPercentage = "0.52315", Wins = "402", Losses = "365", Ties = "32", Games = "799" },
new TeamListing { Rank = "64", Team = "East Carolina", Mascot = "Pirates", DateOfLastWin = "9/28/13", WinningPercentage = "0.51921", Wins = "386", Losses = "357", Ties = "12", Games = "755" },
new TeamListing { Rank = "65", Team = "Illinois", Mascot = "Fighting Illini", DateOfLastWin = "9/21/13", WinningPercentage = "0.51845", Wins = "565", Losses = "523", Ties = "50", Games = "1138" },
new TeamListing { Rank = "66", Team = "Northern Illinois", Mascot = "Huskies", DateOfLastWin = "10/5/13", WinningPercentage = "0.51647", Wins = "467", Losses = "436", Ties = "38", Games = "941" },
new TeamListing { Rank = "67", Team = "Louisville", Mascot = "Cardinals", DateOfLastWin = "10/12/13", WinningPercentage = "0.50848", Wins = "441", Losses = "426", Ties = "17", Games = "884" },
new TeamListing { Rank = "68", Team = "Kansas", Mascot = "Jayhawks", DateOfLastWin = "10/5/13", WinningPercentage = "0.50765", Wins = "568", Losses = "550", Ties = "58", Games = "1176" },
new TeamListing { Rank = "69", Team = "Rutgers", Mascot = "Scarlet Knights", DateOfLastWin = "10/12/13", WinningPercentage = "0.50565", Wins = "606", Losses = "592", Ties = "42", Games = "1240" },
new TeamListing { Rank = "70", Team = "Akron", Mascot = "Zips", DateOfLastWin = "10/5/13", WinningPercentage = "0.50553", Wins = "485", Losses = "474", Ties = "36", Games = "995" },
new TeamListing { Rank = "71", Team = "San Jose State", Mascot = "Spartans", DateOfLastWin = "10/12/13", WinningPercentage = "0.50436", Wins = "444", Losses = "436", Ties = "37", Games = "917" },
new TeamListing { Rank = "72", Team = "Kentucky", Mascot = "Wildcats", DateOfLastWin = "10/5/13", WinningPercentage = "0.50385", Wins = "567", Losses = "558", Ties = "44", Games = "1169" },
new TeamListing { Rank = "73", Team = "North Carolina State", Mascot = "Wolfpack", DateOfLastWin = "9/28/13", WinningPercentage = "0.50314", Wins = "533", Losses = "526", Ties = "55", Games = "1114" },
new TeamListing { Rank = "74", Team = "South Carolina", Mascot = "Gamecocks", DateOfLastWin = "9/21/13", WinningPercentage = "0.50135", Wins = "535", Losses = "532", Ties = "44", Games = "1111" },
new TeamListing { Rank = "75", Team = "Cincinnati", Mascot = "Bearcats", DateOfLastWin = "10/12/13", WinningPercentage = "0.5", Wins = "542", Losses = "542", Ties = "50", Games = "1134" },
new TeamListing { Rank = "76", Team = "Vanderbilt", Mascot = "Commodores", DateOfLastWin = "10/5/13", WinningPercentage = "0.49957", Wins = "556", Losses = "557", Ties = "50", Games = "1163" },
new TeamListing { Rank = "77", Team = "Baylor", Mascot = "Bears", DateOfLastWin = "10/12/13", WinningPercentage = "0.49909", Wins = "524", Losses = "526", Ties = "43", Games = "1093" },
new TeamListing { Rank = "78", Team = "Washington State", Mascot = "Cougars", DateOfLastWin = "10/5/13", WinningPercentage = "0.49806", Wins = "492", Losses = "496", Ties = "45", Games = "1033" },
new TeamListing { Rank = "79", Team = "Oklahoma State", Mascot = "Cowboys", DateOfLastWin = "10/12/13", WinningPercentage = "0.49395", Wins = "507", Losses = "520", Ties = "48", Games = "1075" },
new TeamListing { Rank = "80", Team = "Duke", Mascot = "Blue Devils", DateOfLastWin = "9/31/2013", WinningPercentage = "0.49314", Wins = "452", Losses = "465", Ties = "31", Games = "948" },
new TeamListing { Rank = "81", Team = "Utah State", Mascot = "Aggies", DateOfLastWin = "9/21/13", WinningPercentage = "0.49243", Wins = "473", Losses = "488", Ties = "30", Games = "991" },
new TeamListing { Rank = "82", Team = "Nevada-Reno", Mascot = "Wolf Pack", DateOfLastWin = "10/5/13", WinningPercentage = "0.49225", Wins = "366", Losses = "378", Ties = "30", Games = "774" },
new TeamListing { Rank = "83", Team = "Ohio University", Mascot = "Bobcats", DateOfLastWin = "10/12/13", WinningPercentage = "0.49105", Wins = "497", Losses = "516", Ties = "48", Games = "1061" },
new TeamListing { Rank = "84", Team = "Wyoming", Mascot = "Cowboys", DateOfLastWin = "10/5/13", WinningPercentage = "0.48826", Wins = "485", Losses = "509", Ties = "28", Games = "1022" },
new TeamListing { Rank = "85", Team = "Louisiana-Lafayette", Mascot = "Ragin' Cajuns", DateOfLastWin = "10/12/13", WinningPercentage = "0.48703", Wins = "473", Losses = "499", Ties = "30", Games = "1002" },
new TeamListing { Rank = "86", Team = "Oregon State", Mascot = "Beavers", DateOfLastWin = "10/5/13", WinningPercentage = "0.48465", Wins = "496", Losses = "529", Ties = "50", Games = "1075" },
new TeamListing { Rank = "87", Team = "Memphis", Mascot = "Tigers", DateOfLastWin = "9/28/13", WinningPercentage = "0.48426", Wins = "430", Losses = "459", Ties = "32", Games = "921" },
new TeamListing { Rank = "88", Team = "Southern Methodist", Mascot = "Mustangs", DateOfLastWin = "9/21/13", WinningPercentage = "0.48269", Wins = "447", Losses = "481", Ties = "54", Games = "982" },
new TeamListing { Rank = "89", Team = "Mississippi State", Mascot = "Bulldogs", DateOfLastWin = "10/12/13", WinningPercentage = "0.4793", Wins = "490", Losses = "534", Ties = "39", Games = "N/A" },
new TeamListing { Rank = "90", Team = "Arkansas State", Mascot = "Red Wolves", DateOfLastWin = "10/5/13", WinningPercentage = "0.47877", Wins = "333", Losses = "364", Ties = "33", Games = "730" },
new TeamListing { Rank = "91", Team = "Colorado State", Mascot = "Rams", DateOfLastWin = "10/12/13", WinningPercentage = "0.47649", Wins = "470", Losses = "518", Ties = "33", Games = "1021" },
new TeamListing { Rank = "92", Team = "Marshall", Mascot = "Thundering Herd", DateOfLastWin = "10/5/13", WinningPercentage = "0.47532", Wins = "383", Losses = "425", Ties = "43", Games = "851" },
new TeamListing { Rank = "93", Team = "New Mexico", Mascot = "Lobos", DateOfLastWin = "10/12/13", WinningPercentage = "0.46464", Wins = "451", Losses = "522", Ties = "31", Games = "1004" },
new TeamListing { Rank = "94", Team = "Iowa State", Mascot = "Cyclones", DateOfLastWin = "9/28/13", WinningPercentage = "0.45916", Wins = "489", Losses = "580", Ties = "45", Games = "1114" },
new TeamListing { Rank = "95", Team = "Tulane", Mascot = "Green Wave", DateOfLastWin = "9/21/13", WinningPercentage = "0.45852", Wins = "484", Losses = "575", Ties = "38", Games = "1097" },
new TeamListing { Rank = "96", Team = "Eastern Michigan", Mascot = "Eagles", DateOfLastWin = "10/5/13", WinningPercentage = "0.45413", Wins = "427", Losses = "518", Ties = "47", Games = "992" },
new TeamListing { Rank = "97", Team = "Nevada-Las Vegas", Mascot = "Rebels", DateOfLastWin = "10/12/13", WinningPercentage = "0.44186", Wins = "207", Losses = "262", Ties = "4", Games = "473" },
new TeamListing { Rank = "98", Team = "Rice", Mascot = "Owls", DateOfLastWin = "10/5/13", WinningPercentage = "0.44048", Wins = "428", Losses = "548", Ties = "32", Games = "1008" },
new TeamListing { Rank = "99", Team = "Temple", Mascot = "Owls", DateOfLastWin = "10/12/13", WinningPercentage = "0.43706", Wins = "408", Losses = "533", Ties = "52", Games = "993" },
new TeamListing { Rank = "100", Team = "Kansas State", Mascot = "Wildcats", DateOfLastWin = "9/28/13", WinningPercentage = "0.43433", Wins = "459", Losses = "604", Ties = "41", Games = "1104" },
new TeamListing { Rank = "101", Team = "New Mexico State", Mascot = "Aggies", DateOfLastWin = "9/21/13", WinningPercentage = "0.43254", Wins = "420", Losses = "556", Ties = "32", Games = "1008" },
new TeamListing { Rank = "102", Team = "Northwestern", Mascot = "Wildcats", DateOfLastWin = "10/5/13", WinningPercentage = "0.42844", Wins = "461", Losses = "622", Ties = "42", Games = "1125" },
new TeamListing { Rank = "103", Team = "Indiana", Mascot = "Hoosiers", DateOfLastWin = "10/12/13", WinningPercentage = "0.42441", Wins = "444", Losses = "610", Ties = "44", Games = "1098" },
new TeamListing { Rank = "104", Team = "Louisiana-Monroe", Mascot = "Warhawks", DateOfLastWin = "9/28/13", WinningPercentage = "0.41885", Wins = "246", Losses = "345", Ties = "19", Games = "610" },
new TeamListing { Rank = "105", Team = "Wake Forest", Mascot = "Demon Deacons", DateOfLastWin = "9/21/13", WinningPercentage = "0.41111", Wins = "409", Losses = "593", Ties = "33", Games = "1035" },
new TeamListing { Rank = "106", Team = "Texas-El Paso", Mascot = "Miners", DateOfLastWin = "10/5/13", WinningPercentage = "0.41069", Wins = "358", Losses = "520", Ties = "29", Games = "907" },
new TeamListing { Rank = "107", Team = "Idaho", Mascot = "Vandals", DateOfLastWin = "10/12/13", WinningPercentage = "0.39695", Wins = "299", Losses = "461", Ties = "26", Games = "786" },
new TeamListing { Rank = "108", Team = "Kent", Mascot = "Golden Flashes", DateOfLastWin = "", WinningPercentage = "", Wins = "", Losses = "NULL", Ties = "NULL", Games = "NULL" }

            );
            context.SaveChanges();
        }
        
    }
}