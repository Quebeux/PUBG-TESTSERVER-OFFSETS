/// <summary>
/// Auto-generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UMovieScene3DConstraintSection
	{
		public const int ConstraintId = 0x00D0;
	}

	public class UMovieScene3DAttachSection
	{
		public const int AttachSocketName = 0x00E0;
		public const int AttachComponentName = 0x00E8;
		public const int bConstrainTx = 0x00F0;
		public const int bConstrainTy = 0x00F0;
		public const int bConstrainTz = 0x00F0;
		public const int bConstrainRx = 0x00F0;
		public const int bConstrainRy = 0x00F0;
		public const int bConstrainRz = 0x00F0;
		public const int UnknownData00 = 0x00F1;
	}

	public class UMovieScene3DPathSection
	{
		public const int TimingCurve = 0x00E0;
		public const int FrontAxisEnum = 0x0150;
		public const int UpAxisEnum = 0x0151;
		public const int UnknownData00 = 0x0152;
		public const int bFollow = 0x0154;
		public const int bReverse = 0x0154;
		public const int bForceUpright = 0x0154;
		public const int UnknownData01 = 0x0155;
	}

	public class UMovieScene3DConstraintTrack
	{
		public const int UnknownData00 = 0x00C0;
	}

	public class UMovieScene3DTransformSection
	{
		public const int UnknownData00 = 0x00D0;
		public const int Translation = 0x00D8;
		public const int Rotation = 0x0228;
		public const int Scale = 0x0378;
		public const int UnknownData01 = 0x04C8;
	}

	public class UMovieSceneActorReferenceSection
	{
		public const int UnknownData00 = 0x00D0;
		public const int ActorGuidIndexCurve = 0x00D8;
		public const int UnknownData01 = 0x0148;
		public const int ActorGuidStrings = 0x0158;
		public const int UnknownData02 = 0x0168;
	}

	public class UMovieSceneAudioSection
	{
		public const int Sound = 0x00D0;
		public const int StartOffset = 0x00D8;
		public const int AudioStartTime = 0x00DC;
		public const int AudioDilationFactor = 0x00E0;
		public const int AudioVolume = 0x00E4;
		public const int SoundVolume = 0x00E8;
		public const int PitchMultiplier = 0x0158;
		public const int bSuppressSubtitles = 0x01C8;
		public const int UnknownData00 = 0x01C9;
		public const int OnQueueSubtitles = 0x01D0;
		public const int OnAudioFinished = 0x01E0;
		public const int OnAudioPlaybackPercent = 0x01F0;
	}

	public class UMovieSceneAudioTrack
	{
		public const int UnknownData00 = 0x00C0;
	}

	public class UMovieSceneBoolSection
	{
		public const int UnknownData00 = 0x00D0;
		public const int DefaultValue = 0x00D8;
		public const int UnknownData01 = 0x00D9;
		public const int BoolCurve = 0x00E0;
	}

	public class UMovieSceneByteSection
	{
		public const int UnknownData00 = 0x00D0;
		public const int ByteCurve = 0x00D8;
		public const int UnknownData01 = 0x0148;
	}

	public class UMovieSceneCameraAnimSection
	{
		public const int AnimData = 0x00D0;
		public const int CameraAnim = 0x00F0;
		public const int PlayRate = 0x00F8;
		public const int PlayScale = 0x00FC;
		public const int BlendInTime = 0x0100;
		public const int BlendOutTime = 0x0104;
		public const int bLooping = 0x0108;
		public const int UnknownData00 = 0x0109;
	}

	public class UMovieSceneCameraAnimTrack
	{
		public const int UnknownData00 = 0x00C0;
	}

	public class UMovieSceneCameraCutSection
	{
		public const int CameraGuid = 0x00D0;
	}

	public class UMovieSceneCameraCutTrack
	{
		public const int UnknownData00 = 0x00C0;
	}

	public class UMovieSceneCameraShakeSection
	{
		public const int ShakeData = 0x00D0;
		public const int ShakeClass = 0x00F0;
		public const int PlayScale = 0x00F8;
		public const int PlaySpace = 0x00FC;
		public const int UnknownData00 = 0x00FD;
		public const int UserDefinedPlaySpace = 0x0100;
		public const int UnknownData01 = 0x010C;
	}

	public class UMovieSceneCameraShakeTrack
	{
		public const int UnknownData00 = 0x00C0;
	}

	public class UMovieSceneColorSection
	{
		public const int UnknownData00 = 0x00D0;
		public const int RedCurve = 0x00D8;
		public const int GreenCurve = 0x0148;
		public const int BlueCurve = 0x01B8;
		public const int AlphaCurve = 0x0228;
		public const int UnknownData01 = 0x0298;
	}

	public class UMovieSceneEnumSection
	{
		public const int UnknownData00 = 0x00D0;
		public const int EnumCurve = 0x00D8;
		public const int UnknownData01 = 0x0148;
	}

	public class UMovieSceneEventSection
	{
		public const int Events = 0x00D0;
		public const int EventData = 0x0138;
		public const int UnknownData00 = 0x0158;
	}

	public class UMovieSceneSpawnTrack
	{
		public const int UnknownData00 = 0x00C0;
		public const int ObjectGuid = 0x00C8;
		public const int UnknownData01 = 0x00D8;
	}

	public class UMovieSceneEventTrack
	{
		public const int EventReceivers = 0x00C0;
		public const int Sections = 0x00D0;
	}

	public class UMovieSceneFloatSection
	{
		public const int UnknownData00 = 0x00D0;
		public const int FloatCurve = 0x00D8;
		public const int UnknownData01 = 0x0148;
	}

	public class UMovieSceneFadeSection
	{
		public const int UnknownData00 = 0x0150;
		public const int bFadeAudio = 0x0158;
		public const int UnknownData01 = 0x0159;
	}

	public class UMovieSceneIntegerSection
	{
		public const int UnknownData00 = 0x00D0;
		public const int IntegerCurve = 0x00D8;
		public const int UnknownData01 = 0x0148;
	}

	public class UMovieSceneLevelVisibilitySection
	{
		public const int Visibility = 0x00D0;
		public const int UnknownData00 = 0x00D1;
		public const int LevelNames = 0x00D8;
		public const int UnknownData01 = 0x00E8;
	}

	public class UMovieScenePropertyTrack
	{
		public const int PropertyPath = 0x00C0;
		public const int Sections = 0x00D0;
	}

	public class UMovieSceneLevelVisibilityTrack
	{
		public const int UnknownData00 = 0x00C0;
	}

	public class UMovieSceneParameterSection
	{
		public const int ScalarParameterNamesAndCurves = 0x00D0;
		public const int VectorParameterNamesAndCurves = 0x00E0;
		public const int ColorParameterNamesAndCurves = 0x00F0;
	}

	public class UMovieSceneMaterialTrack
	{
		public const int UnknownData00 = 0x00C0;
	}

	public class UMovieSceneParticleParameterTrack
	{
		public const int UnknownData00 = 0x00C0;
	}

	public class UMovieSceneParticleSection
	{
		public const int ParticleKeys = 0x00D0;
	}

	public class UMovieSceneParticleTrack
	{
		public const int UnknownData00 = 0x00C0;
	}

	public class UMovieSceneByteTrack
	{
		public const int Enum = 0x00E0;
		public const int UnknownData00 = 0x00E8;
	}

	public class UMovieSceneColorTrack
	{
		public const int bIsSlateColor = 0x00E0;
		public const int UnknownData00 = 0x00E1;
	}

	public class UMovieSceneEnumTrack
	{
		public const int Enum = 0x00E0;
		public const int UnknownData00 = 0x00E8;
	}

	public class UMovieSceneVectorTrack
	{
		public const int NumChannelsUsed = 0x00E0;
		public const int UnknownData00 = 0x00E4;
	}

	public class UMovieSceneSkeletalAnimationSection
	{
		public const int Params = 0x00D0;
		public const int AnimSequence = 0x0160;
		public const int Animation = 0x0168;
		public const int StartOffset = 0x0170;
		public const int EndOffset = 0x0174;
		public const int PlayRate = 0x0178;
		public const int bReverse = 0x017C;
		public const int UnknownData00 = 0x017D;
		public const int SlotName = 0x0180;
		public const int UnknownData01 = 0x0188;
	}

	public class UMovieSceneSkeletalAnimationTrack
	{
		public const int UnknownData00 = 0x00C0;
	}

	public class UMovieSceneStringSection
	{
		public const int UnknownData00 = 0x00D0;
		public const int StringCurve = 0x00D8;
	}

	public class UMovieSceneSubSection
	{
		public const int Parameters = 0x00D0;
		public const int StartOffset = 0x00E4;
		public const int TimeScale = 0x00E8;
		public const int PrerollTime = 0x00EC;
		public const int SubSequence = 0x00F0;
		public const int ActorToRecord = 0x00F8;
		public const int UnknownData00 = 0x0114;
		public const int TargetSequenceName = 0x0118;
		public const int TargetPathToRecordTo = 0x0128;
		public const int UnknownData01 = 0x0138;
	}

	public class UMovieSceneCinematicShotSection
	{
		public const int UnknownData00 = 0x0140;
	}

	public class UMovieSceneSubTrack
	{
		public const int UnknownData00 = 0x00C0;
	}

	public class UMovieSceneVectorSection
	{
		public const int UnknownData00 = 0x00D0;
		public const int Curves = 0x00D8;
		public const int ChannelsUsed = 0x0298;
		public const int UnknownData01 = 0x029C;
	}

}
