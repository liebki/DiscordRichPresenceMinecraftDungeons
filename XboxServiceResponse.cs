using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordRichPresenceMinecraftDungeons
{
    public partial class XboxServiceResponse
    {
        [JsonProperty("membersInfo", NullValueHandling = NullValueHandling.Ignore)]
        public MembersInfo MembersInfo { get; set; }

        [JsonProperty("constants", NullValueHandling = NullValueHandling.Ignore)]
        public XboxServiceResponseConstants Constants { get; set; }

        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public XboxServiceResponseProperties Properties { get; set; }

        [JsonProperty("servers", NullValueHandling = NullValueHandling.Ignore)]
        public Servers Servers { get; set; }

        [JsonProperty("members", NullValueHandling = NullValueHandling.Ignore)]
        public Members Members { get; set; }

        [JsonProperty("correlationId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? CorrelationId { get; set; }

        [JsonProperty("contractVersion", NullValueHandling = NullValueHandling.Ignore)]
        public long? ContractVersion { get; set; }

        [JsonProperty("branch", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Branch { get; set; }

        [JsonProperty("changeNumber", NullValueHandling = NullValueHandling.Ignore)]
        public long? ChangeNumber { get; set; }

        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartTime { get; set; }
    }

    public partial class XboxServiceResponseConstants
    {
        [JsonProperty("system", NullValueHandling = NullValueHandling.Ignore)]
        public PurpleSystem System { get; set; }

        [JsonProperty("custom", NullValueHandling = NullValueHandling.Ignore)]
        public Servers Custom { get; set; }
    }

    public partial class Servers
    {
    }

    public partial class PurpleSystem
    {
        [JsonProperty("readyRemovalTimeout", NullValueHandling = NullValueHandling.Ignore)]
        public long? ReadyRemovalTimeout { get; set; }

        [JsonProperty("reservedRemovalTimeout", NullValueHandling = NullValueHandling.Ignore)]
        public long? ReservedRemovalTimeout { get; set; }

        [JsonProperty("sessionEmptyTimeout", NullValueHandling = NullValueHandling.Ignore)]
        public long? SessionEmptyTimeout { get; set; }

        [JsonProperty("inactiveRemovalTimeout", NullValueHandling = NullValueHandling.Ignore)]
        public long? InactiveRemovalTimeout { get; set; }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public long? Version { get; set; }

        [JsonProperty("maxMembersCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxMembersCount { get; set; }

        [JsonProperty("visibility", NullValueHandling = NullValueHandling.Ignore)]
        public string Visibility { get; set; }

        [JsonProperty("inviteProtocol", NullValueHandling = NullValueHandling.Ignore)]
        public string InviteProtocol { get; set; }

        [JsonProperty("capabilities", NullValueHandling = NullValueHandling.Ignore)]
        public Capabilities Capabilities { get; set; }

        [JsonProperty("memberInitialization", NullValueHandling = NullValueHandling.Ignore)]
        public MemberInitialization MemberInitialization { get; set; }
    }

    public partial class Capabilities
    {
        [JsonProperty("connectivity", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Connectivity { get; set; }

        [JsonProperty("crossPlay", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CrossPlay { get; set; }

        [JsonProperty("gameplay", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Gameplay { get; set; }

        [JsonProperty("userAuthorizationStyle", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UserAuthorizationStyle { get; set; }
    }

    public partial class MemberInitialization
    {
        [JsonProperty("membersNeededToStart", NullValueHandling = NullValueHandling.Ignore)]
        public long? MembersNeededToStart { get; set; }
    }

    public partial class Members
    {
        [JsonProperty("0", NullValueHandling = NullValueHandling.Ignore)]
        public The0 The0 { get; set; }
    }

    public partial class The0
    {
        [JsonProperty("next", NullValueHandling = NullValueHandling.Ignore)]
        public long? Next { get; set; }

        [JsonProperty("joinTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? JoinTime { get; set; }

        [JsonProperty("constants", NullValueHandling = NullValueHandling.Ignore)]
        public The0_Constants Constants { get; set; }

        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public The0_Properties Properties { get; set; }

        [JsonProperty("gamertag", NullValueHandling = NullValueHandling.Ignore)]
        public string Gamertag { get; set; }

        [JsonProperty("activeTitleId", NullValueHandling = NullValueHandling.Ignore)]
        public long? ActiveTitleId { get; set; }

        [JsonProperty("deviceToken", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceToken { get; set; }
    }

    public partial class The0_Constants
    {
        [JsonProperty("system", NullValueHandling = NullValueHandling.Ignore)]
        public FluffySystem System { get; set; }

        [JsonProperty("custom", NullValueHandling = NullValueHandling.Ignore)]
        public Servers Custom { get; set; }
    }

    public partial class FluffySystem
    {
        [JsonProperty("initialize", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Initialize { get; set; }

        [JsonProperty("xuid", NullValueHandling = NullValueHandling.Ignore)]
        public string Xuid { get; set; }

        [JsonProperty("index", NullValueHandling = NullValueHandling.Ignore)]
        public long? Index { get; set; }
    }

    public partial class The0_Properties
    {
        [JsonProperty("system", NullValueHandling = NullValueHandling.Ignore)]
        public TentacledSystem System { get; set; }

        [JsonProperty("custom", NullValueHandling = NullValueHandling.Ignore)]
        public PurpleCustom Custom { get; set; }
    }

    public partial class PurpleCustom
    {
        [JsonProperty("PLATFORM", NullValueHandling = NullValueHandling.Ignore)]
        public string Platform { get; set; }
    }

    public partial class TentacledSystem
    {
        [JsonProperty("subscription", NullValueHandling = NullValueHandling.Ignore)]
        public Subscription Subscription { get; set; }

        [JsonProperty("secureDeviceAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string SecureDeviceAddress { get; set; }

        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; }

        [JsonProperty("connection", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Connection { get; set; }
    }

    public partial class Subscription
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("changeTypes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ChangeTypes { get; set; }
    }

    public partial class MembersInfo
    {
        [JsonProperty("first", NullValueHandling = NullValueHandling.Ignore)]
        public long? First { get; set; }

        [JsonProperty("next", NullValueHandling = NullValueHandling.Ignore)]
        public long? Next { get; set; }

        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public long? Count { get; set; }

        [JsonProperty("accepted", NullValueHandling = NullValueHandling.Ignore)]
        public long? Accepted { get; set; }

        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public long? Active { get; set; }
    }

    public partial class XboxServiceResponseProperties
    {
        [JsonProperty("system", NullValueHandling = NullValueHandling.Ignore)]
        public StickySystem System { get; set; }

        [JsonProperty("custom", NullValueHandling = NullValueHandling.Ignore)]
        public FluffyCustom Custom { get; set; }
    }

    public partial class FluffyCustom
    {
        [JsonProperty("Joinability", NullValueHandling = NullValueHandling.Ignore)]
        public string Joinability { get; set; }

        [JsonProperty("Version", NullValueHandling = NullValueHandling.Ignore)]
        public long? Version { get; set; }

        [JsonProperty("OwningUserName", NullValueHandling = NullValueHandling.Ignore)]
        public string OwningUserName { get; set; }

        [JsonProperty("OwningXUID", NullValueHandling = NullValueHandling.Ignore)]
        public string OwningXuid { get; set; }

        [JsonProperty("PLATFORM", NullValueHandling = NullValueHandling.Ignore)]
        public string Platform { get; set; }

        [JsonProperty("IsPrivateGame", NullValueHandling = NullValueHandling.Ignore)]
        public long? IsPrivateGame { get; set; }

        [JsonProperty("PLAYER_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string PlayerName { get; set; }

        [JsonProperty("GAME_VERSION", NullValueHandling = NullValueHandling.Ignore)]
        public string GameVersion { get; set; }

        [JsonProperty("CROSSPLAY", NullValueHandling = NullValueHandling.Ignore)]
        public long? Crossplay { get; set; }

        [JsonProperty("UNREAL_MAP_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string UnrealMapName { get; set; }

        [JsonProperty("LEVEL_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string LevelName { get; set; }

        [JsonProperty("LEVEL_FILENAME", NullValueHandling = NullValueHandling.Ignore)]
        public string LevelFilename { get; set; }

        [JsonProperty("MISSION_DIFFICULTY", NullValueHandling = NullValueHandling.Ignore)]
        public string MissionDifficulty { get; set; }

        [JsonProperty("THREAT_LEVEL", NullValueHandling = NullValueHandling.Ignore)]
        public string ThreatLevel { get; set; }

        [JsonProperty("ENDLESS_STRUGGLE", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndlessStruggle { get; set; }

        [JsonProperty("EMERGENT_DIFFICULTY_RAIDDIFFICULTY", NullValueHandling = NullValueHandling.Ignore)]
        public long? EmergentDifficultyRaiddifficulty { get; set; }

        [JsonProperty("EMERGENT_DIFFICULTY_AFFECTORSNUM", NullValueHandling = NullValueHandling.Ignore)]
        public long? EmergentDifficultyAffectorsnum { get; set; }

        [JsonProperty("RANDOM_SEED", NullValueHandling = NullValueHandling.Ignore)]
        public long? RandomSeed { get; set; }

        [JsonProperty("RECONNECTABLE_GUIDS", NullValueHandling = NullValueHandling.Ignore)]
        public string ReconnectableGuids { get; set; }

        [JsonProperty("LEVEL_NAME_ENUM", NullValueHandling = NullValueHandling.Ignore)]
        public long? LevelNameEnum { get; set; }

        [JsonProperty("IsSessionReady", NullValueHandling = NullValueHandling.Ignore)]
        public long? IsSessionReady { get; set; }

        [JsonProperty("PLAYERS_NAMES", NullValueHandling = NullValueHandling.Ignore)]
        public List<PlayersName> PlayersNames { get; set; }
    }

    public partial class PlayersName
    {
        [JsonProperty("PSNName", NullValueHandling = NullValueHandling.Ignore)]
        public string PsnName { get; set; }

        [JsonProperty("XBLGamerTag", NullValueHandling = NullValueHandling.Ignore)]
        public string XblGamerTag { get; set; }
    }

    public partial class StickySystem
    {
        [JsonProperty("joinRestriction", NullValueHandling = NullValueHandling.Ignore)]
        public string JoinRestriction { get; set; }

        [JsonProperty("readRestriction", NullValueHandling = NullValueHandling.Ignore)]
        public string ReadRestriction { get; set; }

        [JsonProperty("turn", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Turn { get; set; }

        [JsonProperty("host", NullValueHandling = NullValueHandling.Ignore)]
        public string Host { get; set; }
    }
}