/// <summary>
/// Auto-generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UMovieSceneSignedObject
	{
		public const int Signature = 0x0028;
		public const int UnknownData00 = 0x0038;
	}

	public class UMovieScene
	{
		public const int Spawnables = 0x00B0;
		public const int Possessables = 0x00C0;
		public const int ObjectBindings = 0x00D0;
		public const int MasterTracks = 0x00E0;
		public const int CameraCutTrack = 0x00F0;
		public const int SelectionRange = 0x00F8;
		public const int PlaybackRange = 0x0108;
		public const int bForceFixedFrameIntervalPlayback = 0x0118;
		public const int UnknownData00 = 0x0119;
		public const int FixedFrameInterval = 0x011C;
		public const int InTime = 0x0120;
		public const int OutTime = 0x0124;
		public const int StartTime = 0x0128;
		public const int EndTime = 0x012C;
	}

	public class UMovieSceneBindingOverrides
	{
		public const int UnknownData00 = 0x0028;
		public const int BindingData = 0x0030;
		public const int UnknownData01 = 0x0040;
	}

	public class UMovieSceneFolder
	{
		public const int FolderName = 0x0028;
		public const int ChildFolders = 0x0030;
		public const int ChildMasterTracks = 0x0040;
		public const int ChildObjectBindingStrings = 0x0050;
		public const int UnknownData00 = 0x0060;
	}

	public class UMovieSceneSequencePlayer
	{
		public const int UnknownData00 = 0x0028;
		public const int OnPlay = 0x0370;
		public const int OnStop = 0x0380;
		public const int OnPause = 0x0390;
		public const int bIsPlaying = 0x03A0;
		public const int bReversePlayback = 0x03A0;
		public const int bPendingFirstUpdate = 0x03A0;
		public const int UnknownData01 = 0x03A1;
		public const int Sequence = 0x03A8;
		public const int TimeCursorPosition = 0x03B0;
		public const int StartTime = 0x03B4;
		public const int EndTime = 0x03B8;
		public const int CurrentNumLoops = 0x03BC;
		public const int UnknownData02 = 0x03C0;
		public const int PlaybackSettings = 0x03D0;
		public const int UnknownData03 = 0x03F8;
	}

	public class UMovieSceneSection
	{
		public const int EvalOptions = 0x00B0;
		public const int UnknownData00 = 0x00B2;
		public const int StartTime = 0x00B4;
		public const int EndTime = 0x00B8;
		public const int RowIndex = 0x00BC;
		public const int OverlapPriority = 0x00C0;
		public const int bIsActive = 0x00C4;
		public const int bIsLocked = 0x00C4;
		public const int bIsInfinite = 0x00C4;
		public const int UnknownData01 = 0x00C5;
		public const int PrerollTime = 0x00C8;
		public const int PostrollTime = 0x00CC;
	}

	public class UMovieSceneTrack
	{
		public const int EvalOptions = 0x00B0;
		public const int UnknownData00 = 0x00B4;
	}

	public class UMovieSceneSegmentCompilerTestTrack
	{
		public const int SectionArray = 0x00C0;
	}

	public class UMovieSceneSequence
	{
		public const int EvaluationTemplate = 0x00B0;
		public const int TemplateParameters = 0x02D0;
		public const int UnknownData00 = 0x02D2;
		public const int InstancedSubSequenceEvaluationTemplates = 0x02D8;
		public const int bParentContextsAreSignificant = 0x0328;
		public const int UnknownData01 = 0x0329;
	}

}
