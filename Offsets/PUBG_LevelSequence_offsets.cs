/// <summary>
/// Auto-generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class ULevelSequence
	{
		public const int MovieScene = 0x0330;
		public const int ObjectReferences = 0x0338;
		public const int BindingReferences = 0x0388;
		public const int PossessedObjects = 0x03D8;
		public const int UnknownData00 = 0x0428;
	}

	public class ULevelSequencePlayer
	{
		public const int UnknownData00 = 0x0700;
		public const int AdditionalEventReceivers = 0x0720;
		public const int UnknownData01 = 0x0730;
	}

	public class ULevelSequenceBurnInOptions
	{
		public const int bUseBurnIn = 0x0028;
		public const int UnknownData00 = 0x0029;
		public const int BurnInClass = 0x0030;
		public const int Settings = 0x0040;
	}

	public class ALevelSequenceActor
	{
		public const int UnknownData00 = 0x03B0;
		public const int bAutoPlay = 0x03B8;
		public const int UnknownData01 = 0x03B9;
		public const int PlaybackSettings = 0x03C0;
		public const int SequencePlayer = 0x03E8;
		public const int LevelSequence = 0x03F0;
		public const int AdditionalEventReceivers = 0x0400;
		public const int BurnInOptions = 0x0410;
		public const int BindingOverrides = 0x0418;
		public const int BurnInInstance = 0x0420;
	}

	public class ULevelSequenceBurnIn
	{
		public const int FrameInformation = 0x0240;
		public const int LevelSequenceActor = 0x0290;
	}

}
