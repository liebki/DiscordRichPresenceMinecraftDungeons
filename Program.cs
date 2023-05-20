using System;
using Fiddler;
using DiscordRPC;
using Newtonsoft.Json;
using System.Threading;

namespace DiscordRichPresenceMinecraftDungeons
{
    public class Program
    {
        private static DiscordRpcClient discordClient { get; set; }

        private static string activeLevelName { get; set; } = string.Empty;

        private static string discordApplicationId { get; } = "1025336749477601361";

        private static void Main(string[] args)
        {
            CertMaker.createRootCert();
            CertMaker.trustRootCert();

            while (true)
            {
                bool isDungeonsActive = Utilities.IsDungeonsActive();

                if (isDungeonsActive)
                {
                    break;
                }

                Thread.Sleep(1000);
            }

            SetupRPC();
            FiddlerApplication.BeforeResponse += Event_BeforeRequest;

            FiddlerApplication.Startup(8888, true, true);
            Console.ReadKey();

            Console.ReadKey();
            FiddlerApplication.Shutdown();

            discordClient.Dispose();
        }

        private static void SetupRPC()
        {
            discordClient = new DiscordRpcClient(discordApplicationId);
            discordClient.Initialize();
        }

        private static void Event_BeforeRequest(Session session)
        {
            if (session.fullUrl.Contains("https://sessiondirectory.xboxlive.com/serviceconfigs"))
            {
                string jsonResponse = session.GetResponseBodyAsString();
                if (jsonResponse.Contains("LEVEL_NAME"))
                {
                    XboxServiceResponse response = JsonConvert.DeserializeObject<XboxServiceResponse>(jsonResponse);
                    string DetailValue = $"Level: {Utilities.GetLevelName(response.Properties.Custom.LevelFilename)}";

                    string StateValue = $"Threat: {response.Properties.Custom.ThreatLevel.Replace("Threat_", string.Empty)} - Difficulty: {response.Properties.Custom.MissionDifficulty.Replace("Difficulty_", string.Empty)}";
                    string Username = response.Properties.Custom.PlayerName;

                    activeLevelName = DetailValue;
                    if (StateValue.IndexOf("invalid", StringComparison.InvariantCultureIgnoreCase) >= 0)
                    {
                        discordClient.UpdateDetails(activeLevelName);
                        discordClient.UpdateState(string.Empty);
                    }
                    else
                    {
                        discordClient.UpdateDetails(activeLevelName);
                        discordClient.UpdateState(StateValue);
                    }

                    discordClient.UpdateStartTime();

                    Button[] buttonArray = new[]
                    {
                        new Button() { Label = $"Add me ({Username}) as friend", Url = $"https://account.xbox.com/de-de/profile?gamertag={Username}" }
                    };

                    discordClient.UpdateButtons(buttonArray);
                }
            }
        }
    }
}