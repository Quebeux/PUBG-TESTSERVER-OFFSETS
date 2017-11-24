/// <summary>
/// Auto-generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UAchievementQueryCallbackProxy
	{
		public const int OnSuccess = 0x0028;
		public const int OnFailure = 0x0038;
		public const int UnknownData00 = 0x0048;
	}

	public class UAchievementWriteCallbackProxy
	{
		public const int OnSuccess = 0x0028;
		public const int OnFailure = 0x0038;
		public const int UnknownData00 = 0x0048;
	}

	public class UConnectionCallbackProxy
	{
		public const int OnSuccess = 0x0028;
		public const int OnFailure = 0x0038;
		public const int UnknownData00 = 0x0048;
	}

	public class UCreateSessionCallbackProxy
	{
		public const int OnSuccess = 0x0028;
		public const int OnFailure = 0x0038;
		public const int UnknownData00 = 0x0048;
	}

	public class UDestroySessionCallbackProxy
	{
		public const int OnSuccess = 0x0028;
		public const int OnFailure = 0x0038;
		public const int UnknownData00 = 0x0048;
	}

	public class UEndMatchCallbackProxy
	{
		public const int OnSuccess = 0x0028;
		public const int OnFailure = 0x0038;
		public const int UnknownData00 = 0x0048;
	}

	public class UEndTurnCallbackProxy
	{
		public const int OnSuccess = 0x0028;
		public const int OnFailure = 0x0038;
		public const int UnknownData00 = 0x0048;
	}

	public class UFindSessionsCallbackProxy
	{
		public const int OnSuccess = 0x0028;
		public const int OnFailure = 0x0038;
		public const int UnknownData00 = 0x0048;
	}

	public class UFindTurnBasedMatchCallbackProxy
	{
		public const int OnSuccess = 0x0028;
		public const int OnFailure = 0x0038;
		public const int UnknownData00 = 0x0048;
	}

	public class UInAppPurchaseCallbackProxy
	{
		public const int OnSuccess = 0x0028;
		public const int OnFailure = 0x0038;
		public const int UnknownData00 = 0x0048;
	}

	public class UInAppPurchaseQueryCallbackProxy
	{
		public const int OnSuccess = 0x0028;
		public const int OnFailure = 0x0038;
		public const int UnknownData00 = 0x0048;
	}

	public class UInAppPurchaseRestoreCallbackProxy
	{
		public const int OnSuccess = 0x0028;
		public const int OnFailure = 0x0038;
		public const int UnknownData00 = 0x0048;
	}

	public class UIpConnection
	{
	}

	public class UIpNetDriver
	{
		public const int LogPortUnreach = 0x0420;
		public const int AllowPlayerPortUnreach = 0x0420;
		public const int UnknownData00 = 0x0421;
		public const int MaxPortCountToTry = 0x0424;
		public const int UnknownData01 = 0x0428;
	}

	public class UJoinSessionCallbackProxy
	{
		public const int OnSuccess = 0x0028;
		public const int OnFailure = 0x0038;
		public const int UnknownData00 = 0x0048;
	}

	public class ULeaderboardFlushCallbackProxy
	{
		public const int OnSuccess = 0x0028;
		public const int OnFailure = 0x0038;
		public const int UnknownData00 = 0x0048;
	}

	public class ULeaderboardQueryCallbackProxy
	{
		public const int OnSuccess = 0x0028;
		public const int OnFailure = 0x0038;
		public const int UnknownData00 = 0x0048;
	}

	public class ULogoutCallbackProxy
	{
		public const int OnSuccess = 0x0028;
		public const int OnFailure = 0x0038;
		public const int UnknownData00 = 0x0048;
	}

	public class AOnlineBeacon
	{
		public const int UnknownData00 = 0x03B0;
		public const int BeaconConnectionInitialTimeout = 0x03B8;
		public const int BeaconConnectionTimeout = 0x03BC;
		public const int NetDriver = 0x03C0;
		public const int UnknownData01 = 0x03C8;
	}

	public class AOnlineBeaconClient
	{
		public const int BeaconOwner = 0x03D8;
		public const int BeaconConnection = 0x03E0;
		public const int ConnectionState = 0x03E8;
		public const int UnknownData00 = 0x03E9;
	}

	public class UPartyBeaconState
	{
		public const int SessionName = 0x0028;
		public const int NumConsumedReservations = 0x0030;
		public const int MaxReservations = 0x0034;
		public const int NumTeams = 0x0038;
		public const int NumPlayersPerTeam = 0x003C;
		public const int TeamAssignmentMethod = 0x0040;
		public const int ReservedHostTeamNum = 0x0048;
		public const int ForceTeamNum = 0x004C;
		public const int Reservations = 0x0050;
		public const int UnknownData00 = 0x0060;
	}

	public class APartyBeaconClient
	{
		public const int UnknownData00 = 0x0440;
		public const int DestSessionId = 0x0500;
		public const int PendingReservation = 0x0510;
		public const int RequestType = 0x0540;
		public const int bPendingReservationSent = 0x0541;
		public const int bCancelReservation = 0x0542;
		public const int UnknownData01 = 0x0543;
	}

	public class AOnlineBeaconHost
	{
		public const int ListenPort = 0x03D8;
		public const int UnknownData00 = 0x03DC;
		public const int ClientActors = 0x03E0;
		public const int UnknownData01 = 0x03F0;
	}

	public class AOnlineBeaconHostObject
	{
		public const int BeaconTypeName = 0x03B0;
		public const int ClientBeaconActorClass = 0x03C0;
		public const int ClientActors = 0x03C8;
	}

	public class APartyBeaconHost
	{
		public const int State = 0x03D8;
		public const int UnknownData00 = 0x03E0;
		public const int bLogoutOnSessionTimeout = 0x0520;
		public const int UnknownData01 = 0x0521;
		public const int SessionTimeoutSecs = 0x0524;
		public const int TravelSessionTimeoutSecs = 0x0528;
		public const int UnknownData02 = 0x052C;
	}

	public class UOnlineEngineInterfaceImpl
	{
		public const int UnknownData00 = 0x0028;
	}

	public class UOnlinePIESettings
	{
		public const int bOnlinePIEEnabled = 0x0038;
		public const int UnknownData00 = 0x0039;
		public const int Logins = 0x0040;
	}

	public class UOnlineSessionClient
	{
		public const int UnknownData00 = 0x0028;
		public const int bIsFromInvite = 0x02B0;
		public const int bHandlingDisconnect = 0x02B1;
		public const int UnknownData01 = 0x02B2;
	}

	public class UQuitMatchCallbackProxy
	{
		public const int OnSuccess = 0x0028;
		public const int OnFailure = 0x0038;
		public const int UnknownData00 = 0x0048;
	}

	public class UShowLoginUICallbackProxy
	{
		public const int OnSuccess = 0x0028;
		public const int OnFailure = 0x0038;
		public const int UnknownData00 = 0x0048;
	}

}
