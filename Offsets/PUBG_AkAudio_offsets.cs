/// <summary>
/// Auto-generated offsets targetting PUBG v 3.2.12
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class AAkAmbientSound
	{
		public const int UnknownData00 = 0x03B0;
		public const int AkComponent = 0x03C0;
		public const int AutoPost = 0x03C8;
		public const int UnknownData01 = 0x03C9;
		public const int AutoPlayDistance = 0x03CC;
	}

	public class UAkAudioBank
	{
		public const int AutoLoad = 0x0028;
		public const int UnknownData00 = 0x0029;
	}

	public class UAkAudioEvent
	{
		public const int RequiredBank = 0x0028;
		public const int MaxAttenuationRadius = 0x0030;
		public const int IsInfinite = 0x0034;
		public const int UnknownData00 = 0x0035;
		public const int MinimumDuration = 0x0038;
		public const int MaximumDuration = 0x003C;
	}

	public class UAkAuxBus
	{
		public const int RequiredBank = 0x0028;
		public const int UnknownData00 = 0x0030;
	}

	public class UAkComponent
	{
		public const int StopWhenOwnerDestroyed = 0x03E0;
		public const int bDynamicReverb = 0x03E1;
		public const int bUseDoppler = 0x03E2;
		public const int UnknownData00 = 0x03E3;
		public const int AttenuationScalingFactor = 0x03E4;
		public const int OcclusionRefreshInterval = 0x03E8;
		public const int UnknownData01 = 0x03EC;
		public const int AkAudioEvent = 0x03F0;
		public const int EventName = 0x03F8;
		public const int UnknownData02 = 0x0408;
	}

	public class AAkReverbVolume
	{
		public const int bEnabled = 0x03E8;
		public const int UnknownData00 = 0x03E9;
		public const int AuxBus = 0x03F0;
		public const int AuxBusName = 0x03F8;
		public const int SendLevel = 0x0408;
		public const int FadeRate = 0x040C;
		public const int Priority = 0x0410;
		public const int UnknownData01 = 0x0414;
		public const int NextLowerPriorityAkReverbVolume = 0x0418;
	}

	public class UAkSettings
	{
		public const int MaxSimultaneousReverbVolumes = 0x0028;
		public const int UnknownData00 = 0x0029;
		public const int WwiseProjectPath = 0x0030;
		public const int WwiseWindowsInstallationPath = 0x0040;
		public const int WwiseMacInstallationPath = 0x0050;
		public const int SuppressWwiseProjectPathWarnings = 0x0060;
		public const int UnknownData01 = 0x0061;
	}

	public class UInterpTrackAkAudioEvent
	{
		public const int Events = 0x0090;
		public const int bContinueEventOnMatineeEnd = 0x00A0;
		public const int UnknownData00 = 0x00A1;
	}

	public class UInterpTrackAkAudioRTPC
	{
		public const int Param = 0x0090;
		public const int bPlayOnReverse = 0x00A0;
		public const int bContinueRTPCOnMatineeEnd = 0x00A0;
		public const int UnknownData00 = 0x00A1;
	}

	public class UInterpTrackInstAkAudioEvent
	{
		public const int LastUpdatePosition = 0x0028;
		public const int UnknownData00 = 0x002C;
	}

	public class UInterpTrackInstAkAudioRTPC
	{
		public const int LastUpdatePosition = 0x0028;
		public const int UnknownData00 = 0x002C;
	}

	public class UMovieSceneAkAudioEventSection
	{
		public const int Event = 0x00D0;
		public const int EventName = 0x00D8;
		public const int UnknownData00 = 0x00E8;
	}

	public class UMovieSceneAkAudioRTPCSection
	{
		public const int UnknownData00 = 0x00D0;
		public const int Name = 0x00D8;
		public const int FloatCurve = 0x00E8;
		public const int UnknownData01 = 0x0158;
	}

	public class UMovieSceneAkTrack
	{
		public const int UnknownData00 = 0x00C0;
		public const int bIsAMasterTrack = 0x00C8;
		public const int UnknownData01 = 0x00C9;
	}

}
