using System;
using System.Collections.Generic;
using System.Linq;
using LBPUnion.ProjectLighthouse.Types;

namespace LBPUnion.ProjectLighthouse.Helpers
{
    public class GameVersionHelper
    {
        // https://www.serialstation.com/games/b89b4eb4-4e4c-4e54-b72b-f7f9dbfac125
        public readonly string[] LittleBigPlanet1TitleIds =
        {
            "BCES00141",
            "BCAS20091",
            "BCUS98208",
            "BCAS20078",
            "BCJS70009",
            "BCES00611",
            "BCUS98148",
            "BCAS20058",
            "BCJS30018",
            "UCAS40262",
            "BCET70011",
            "BCUS98199",
            "BCJB95003",
            "NPUA70045",
            "NPEA00241",
            "NPEA00147",
            "NPHG00033",
            "NPHG00035",
        };

        // https://serialstation.com/games/35e69aba-1872-4fd7-9d39-11ce75924040
        public readonly string[] LittleBigPlanet2TitleIds =
        {
            "BCUS98249",
            "BCES01086",
            "BCAS20113",
            "BCJS70024",
            "BCAS20201",
            "BCUS98245",
            "BCES01345",
            "BCJS30058",
            "BCUS98372",
            "BCES00850",
            "BCES01346",
            "BCUS90260",
            "BCET70023",
            "NPUA80662",
        };

        // https://www.serialstation.com/games/b62d53d9-fdff-4463-8134-64b81e1cbd50
        // includes PS4 games
        public readonly string[] LittleBigPlanet3TitleIds =
        {
            "CUSA00063",
            "CUSA00693",
            "CUSA00473",
            "CUSA00810",
            "CUSA00473",
            "CUSA01072",
            "CUSA00738",
            "PCJS50003",
            "BCES02068",
            "BCAS20322",
            "BCJS30095",
            "BCES01663",
            "CUSA00063",
            "BCUS98362",
            "PCKS90007",
            "PCAS00012",
            "CUSA00601",
            "CUSA00810",
            "CUSA00762",
            "PCAS20007",
            "CUSA00473",
            "CUSA01077",
            "CUSA01304",
        };
        
        public GameVersion FromTitleId(string titleId)
        {
            if (this.LittleBigPlanet1TitleIds.Contains(titleId)) return GameVersion.LittleBigPlanet1;
            if (this.LittleBigPlanet2TitleIds.Contains(titleId)) return GameVersion.LittleBigPlanet2;
            if (this.LittleBigPlanet3TitleIds.Contains(titleId)) return GameVersion.LittleBigPlanet3;
            
            return GameVersion.Unknown;
        }
    }
}