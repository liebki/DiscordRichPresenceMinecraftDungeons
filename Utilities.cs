using System.Diagnostics;

namespace DiscordRichPresenceMinecraftDungeons
{
    public static class Utilities
    {
        private const string processTitle = "Minecraft Dungeons";

        public static bool IsDungeonsActive()
        {
            foreach (Process process in Process.GetProcesses())
            {
                if (process.MainWindowTitle.StartsWith(processTitle))
                {
                    return true;
                }
            }
            return false;
        }

        public static string GetLevelName(string levelname)
        {
            switch (levelname)
            {
                case "squidcoast":
                    return "Squid Coast";

                case "creeperwoods":
                    return "Creeper Woods";

                case "creepycrypt":
                    return "Creepy Crypt";

                case "pumpkinpastures":
                    return "Pumpkin Pastures";

                case "archhaven":
                    return "Arch Haven";

                case "soggyswamp":
                    return "Soggy Swamp";

                case "soggycave":
                    return "Soggy Cave";

                case "mooncorecaverns":
                    return "Redstone Mines";

                case "fieryforge":
                    return "Fiery Forge";

                case "cacticanyon":
                    return "Cacti Canyon";

                case "deserttemple":
                    return "Desert Temple";

                case "lowertemple":
                    return "Lower Temple";

                case "highblockhalls":
                    return "Highblock Halls";

                case "underhalls":
                    return "Underhalls";

                case "obsidianpinnacle":
                    return "Obsidian Pinnacle";

                case "mooshroomisland":
                    return "???";

                case "dingyjungle":
                    return "Dingy Jungle";

                case "overgrowntemple":
                    return "Overgrown Temple";

                case "bamboobluff":
                    return "Bamboo Bluff";

                case "treetoptangle":
                    return "Treetop Tangle";

                case "frozenfjord":
                    return "Frosted Fjord";

                case "lonefortress":
                    return "Lone Fortress";

                case "lostsettlement":
                    return "Lost Settlement";

                case "windsweptpeaks":
                    return "Windswept Peaks";

                case "gauntletofgales":
                    return "Gauntlet of Gales";

                case "galesanctum":
                    return "Gale Sanctum";

                case "endlessrampart":
                    return "Colossal Rampart";

                case "coralrise":
                    return "Coral Rise";

                case "abyssalmonument":
                    return "Abyssal Monument";

                case "radiantravine":
                    return "Radiant Ravine";

                case "netherwastes":
                    return "Nether Wastes";

                case "warpedforest":
                    return "Warped Forest";

                case "crimsonforest":
                    return "Crimson Forest";

                case "soulsandvalley":
                    return "Soul Sand Valley";

                case "basaltdeltas":
                    return "Basalt Deltas";

                case "netherfortress":
                    return "Nether Fortress";

                case "enderwilds":
                    return "End Wilds";

                case "endcitadel":
                case "BlightedCitadel":
                    return "Broken Citadel";

                case "hm_woodlandmansion":
                    return "Woodland Mansion (Ancient)";

                case "hm_woodlandprison":
                    return "Woodland Prison (Ancient)";

                case "hm_spidercave":
                    return "Spider Cave (Ancient)";

                case "andesitehills":
                    return "Andesite Hills";

                case "slimysewers":
                    return "Slimy Sewers";

                case "netherwartforest":
                    return "Netherwart Forest";

                case "scorchedcrags":
                    return "Scorched Crags";

                case "thetower":
                    return "Tower";

                case "netherhypermission":
                    return "Ancient Hunt";

                case "Lobby":
                case "lobby":
                    return levelname;

                default:
                    return string.Empty;
            }
        }
    }
}