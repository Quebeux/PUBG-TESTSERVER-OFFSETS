/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UMovieSceneSignedObject
	{
		///<summary><![CDATA[FGuid]]></summary>
		public const int Signature = 0x0028;

		///<summary><![CDATA[unsigned char[0x78]]]></summary>
		public const int UnknownData00 = 0x0038;

	}

	public class UMovieScene
	{
		///<summary><![CDATA[TArray<FMovieSceneSpawnable>]]></summary>
		public const int Spawnables = 0x00B0;

		///<summary><![CDATA[TArray<FMovieScenePossessable>]]></summary>
		public const int Possessables = 0x00C0;

		///<summary><![CDATA[TArray<FMovieSceneBinding>]]></summary>
		public const int ObjectBindings = 0x00D0;

		///<summary><![CDATA[TArray<UMovieSceneTrack * >]]></summary>
		public const int MasterTracks = 0x00E0;

		///<summary><![CDATA[UMovieSceneTrack *]]></summary>
		public const int CameraCutTrack = 0x00F0;

		///<summary><![CDATA[FFloatRange]]></summary>
		public const int SelectionRange = 0x00F8;

		///<summary><![CDATA[FFloatRange]]></summary>
		public const int PlaybackRange = 0x0108;

		///<summary><![CDATA[bool]]></summary>
		public const int bForceFixedFrameIntervalPlayback = 0x0118;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0119;

		///<summary><![CDATA[float]]></summary>
		public const int FixedFrameInterval = 0x011C;

		///<summary><![CDATA[float]]></summary>
		public const int InTime = 0x0120;

		///<summary><![CDATA[float]]></summary>
		public const int OutTime = 0x0124;

		///<summary><![CDATA[float]]></summary>
		public const int StartTime = 0x0128;

		///<summary><![CDATA[float]]></summary>
		public const int EndTime = 0x012C;

	}

	public class UMovieSceneBindingOverrides
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[TArray<FMovieSceneBindingOverrideData>]]></summary>
		public const int BindingData = 0x0030;

		///<summary><![CDATA[unsigned char[0x58]]]></summary>
		public const int UnknownData01 = 0x0040;

	}

	public class UMovieSceneFolder
	{
		///<summary><![CDATA[FName]]></summary>
		public const int FolderName = 0x0028;

		///<summary><![CDATA[TArray<UMovieSceneFolder * >]]></summary>
		public const int ChildFolders = 0x0030;

		///<summary><![CDATA[TArray<UMovieSceneTrack * >]]></summary>
		public const int ChildMasterTracks = 0x0040;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int ChildObjectBindingStrings = 0x0050;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0060;

	}

	public class UMovieSceneSequencePlayer
	{
		///<summary><![CDATA[unsigned char[0x348]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnPlay = 0x0370;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnStop = 0x0380;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnPause = 0x0390;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsPlaying = 0x03A0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bReversePlayback = 0x03A0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bPendingFirstUpdate = 0x03A0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x03A1;

		///<summary><![CDATA[UMovieSceneSequence *]]></summary>
		public const int Sequence = 0x03A8;

		///<summary><![CDATA[float]]></summary>
		public const int TimeCursorPosition = 0x03B0;

		///<summary><![CDATA[float]]></summary>
		public const int StartTime = 0x03B4;

		///<summary><![CDATA[float]]></summary>
		public const int EndTime = 0x03B8;

		///<summary><![CDATA[int]]></summary>
		public const int CurrentNumLoops = 0x03BC;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData02 = 0x03C0;

		///<summary><![CDATA[FMovieSceneSequencePlaybackSettings]]></summary>
		public const int PlaybackSettings = 0x03D0;

		///<summary><![CDATA[unsigned char[0x308]]]></summary>
		public const int UnknownData03 = 0x03F8;

	}

	public class UMovieSceneSection
	{
		///<summary><![CDATA[FMovieSceneSectionEvalOptions]]></summary>
		public const int EvalOptions = 0x00B0;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x00B2;

		///<summary><![CDATA[float]]></summary>
		public const int StartTime = 0x00B4;

		///<summary><![CDATA[float]]></summary>
		public const int EndTime = 0x00B8;

		///<summary><![CDATA[int]]></summary>
		public const int RowIndex = 0x00BC;

		///<summary><![CDATA[int]]></summary>
		public const int OverlapPriority = 0x00C0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsActive = 0x00C4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsLocked = 0x00C4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsInfinite = 0x00C4;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x00C5;

		///<summary><![CDATA[float]]></summary>
		public const int PrerollTime = 0x00C8;

		///<summary><![CDATA[float]]></summary>
		public const int PostrollTime = 0x00CC;

	}

	public class UMovieSceneTrack
	{
		///<summary><![CDATA[FMovieSceneTrackEvalOptions]]></summary>
		public const int EvalOptions = 0x00B0;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData00 = 0x00B4;

	}

	public class UMovieSceneSegmentCompilerTestTrack
	{
		///<summary><![CDATA[TArray<UMovieSceneSection * >]]></summary>
		public const int SectionArray = 0x00C0;

	}

	public class UMovieSceneSequence
	{
		///<summary><![CDATA[FCachedMovieSceneEvaluationTemplate]]></summary>
		public const int EvaluationTemplate = 0x00B0;

		///<summary><![CDATA[FMovieSceneTrackCompilationParams]]></summary>
		public const int TemplateParameters = 0x02D0;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData00 = 0x02D2;

		///<summary><![CDATA[TMap<UObject *,FCachedMovieSceneEvaluationTemplate>]]></summary>
		public const int InstancedSubSequenceEvaluationTemplates = 0x02D8;

		///<summary><![CDATA[bool]]></summary>
		public const int bParentContextsAreSignificant = 0x0328;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0329;

	}

}
