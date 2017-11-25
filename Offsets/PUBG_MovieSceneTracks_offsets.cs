/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UMovieScene3DConstraintSection
	{
		///<summary><![CDATA[FGuid]]></summary>
		public const int ConstraintId = 0x00D0;

	}

	public class UMovieScene3DAttachSection
	{
		///<summary><![CDATA[FName]]></summary>
		public const int AttachSocketName = 0x00E0;

		///<summary><![CDATA[FName]]></summary>
		public const int AttachComponentName = 0x00E8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bConstrainTx = 0x00F0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bConstrainTy = 0x00F0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bConstrainTz = 0x00F0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bConstrainRx = 0x00F0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bConstrainRy = 0x00F0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bConstrainRz = 0x00F0;

		///<summary><![CDATA[unsigned char[0xF]]]></summary>
		public const int UnknownData00 = 0x00F1;

	}

	public class UMovieScene3DPathSection
	{
		///<summary><![CDATA[FRichCurve]]></summary>
		public const int TimingCurve = 0x00E0;

		///<summary><![CDATA[EMovieScene3DPathSection_Axis]]></summary>
		public const int FrontAxisEnum = 0x0150;

		///<summary><![CDATA[EMovieScene3DPathSection_Axis]]></summary>
		public const int UpAxisEnum = 0x0151;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x0152;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bFollow = 0x0154;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bReverse = 0x0154;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bForceUpright = 0x0154;

		///<summary><![CDATA[unsigned char[0xB]]]></summary>
		public const int UnknownData01 = 0x0155;

	}

	public class UMovieScene3DConstraintTrack
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x00C0;

	}

	public class UMovieScene3DTransformSection
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x00D0;

		///<summary><![CDATA[FRichCurve[0x3]]]></summary>
		public const int Translation = 0x00D8;

		///<summary><![CDATA[FRichCurve[0x3]]]></summary>
		public const int Rotation = 0x0228;

		///<summary><![CDATA[FRichCurve[0x3]]]></summary>
		public const int Scale = 0x0378;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x04C8;

	}

	public class UMovieSceneActorReferenceSection
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x00D0;

		///<summary><![CDATA[FIntegralCurve]]></summary>
		public const int ActorGuidIndexCurve = 0x00D8;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData01 = 0x0148;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int ActorGuidStrings = 0x0158;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData02 = 0x0168;

	}

	public class UMovieSceneAudioSection
	{
		///<summary><![CDATA[USoundBase *]]></summary>
		public const int Sound = 0x00D0;

		///<summary><![CDATA[float]]></summary>
		public const int StartOffset = 0x00D8;

		///<summary><![CDATA[float]]></summary>
		public const int AudioStartTime = 0x00DC;

		///<summary><![CDATA[float]]></summary>
		public const int AudioDilationFactor = 0x00E0;

		///<summary><![CDATA[float]]></summary>
		public const int AudioVolume = 0x00E4;

		///<summary><![CDATA[FRichCurve]]></summary>
		public const int SoundVolume = 0x00E8;

		///<summary><![CDATA[FRichCurve]]></summary>
		public const int PitchMultiplier = 0x0158;

		///<summary><![CDATA[bool]]></summary>
		public const int bSuppressSubtitles = 0x01C8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x01C9;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int OnQueueSubtitles = 0x01D0;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnAudioFinished = 0x01E0;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnAudioPlaybackPercent = 0x01F0;

	}

	public class UMovieSceneAudioTrack
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x00C0;

	}

	public class UMovieSceneBoolSection
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x00D0;

		///<summary><![CDATA[bool]]></summary>
		public const int DefaultValue = 0x00D8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x00D9;

		///<summary><![CDATA[FIntegralCurve]]></summary>
		public const int BoolCurve = 0x00E0;

	}

	public class UMovieSceneByteSection
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x00D0;

		///<summary><![CDATA[FIntegralCurve]]></summary>
		public const int ByteCurve = 0x00D8;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x0148;

	}

	public class UMovieSceneCameraAnimSection
	{
		///<summary><![CDATA[FMovieSceneCameraAnimSectionData]]></summary>
		public const int AnimData = 0x00D0;

		///<summary><![CDATA[UCameraAnim *]]></summary>
		public const int CameraAnim = 0x00F0;

		///<summary><![CDATA[float]]></summary>
		public const int PlayRate = 0x00F8;

		///<summary><![CDATA[float]]></summary>
		public const int PlayScale = 0x00FC;

		///<summary><![CDATA[float]]></summary>
		public const int BlendInTime = 0x0100;

		///<summary><![CDATA[float]]></summary>
		public const int BlendOutTime = 0x0104;

		///<summary><![CDATA[bool]]></summary>
		public const int bLooping = 0x0108;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0109;

	}

	public class UMovieSceneCameraAnimTrack
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x00C0;

	}

	public class UMovieSceneCameraCutSection
	{
		///<summary><![CDATA[FGuid]]></summary>
		public const int CameraGuid = 0x00D0;

	}

	public class UMovieSceneCameraCutTrack
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x00C0;

	}

	public class UMovieSceneCameraShakeSection
	{
		///<summary><![CDATA[FMovieSceneCameraShakeSectionData]]></summary>
		public const int ShakeData = 0x00D0;

		///<summary><![CDATA[UClass *]]></summary>
		public const int ShakeClass = 0x00F0;

		///<summary><![CDATA[float]]></summary>
		public const int PlayScale = 0x00F8;

		///<summary><![CDATA[TEnumAsByte<ECameraAnimPlaySpace>]]></summary>
		public const int PlaySpace = 0x00FC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x00FD;

		///<summary><![CDATA[FRotator]]></summary>
		public const int UserDefinedPlaySpace = 0x0100;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x010C;

	}

	public class UMovieSceneCameraShakeTrack
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x00C0;

	}

	public class UMovieSceneColorSection
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x00D0;

		///<summary><![CDATA[FRichCurve]]></summary>
		public const int RedCurve = 0x00D8;

		///<summary><![CDATA[FRichCurve]]></summary>
		public const int GreenCurve = 0x0148;

		///<summary><![CDATA[FRichCurve]]></summary>
		public const int BlueCurve = 0x01B8;

		///<summary><![CDATA[FRichCurve]]></summary>
		public const int AlphaCurve = 0x0228;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x0298;

	}

	public class UMovieSceneEnumSection
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x00D0;

		///<summary><![CDATA[FIntegralCurve]]></summary>
		public const int EnumCurve = 0x00D8;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x0148;

	}

	public class UMovieSceneEventSection
	{
		///<summary><![CDATA[FNameCurve]]></summary>
		public const int Events = 0x00D0;

		///<summary><![CDATA[FMovieSceneEventSectionData]]></summary>
		public const int EventData = 0x0138;

		///<summary><![CDATA[unsigned char[0x88]]]></summary>
		public const int UnknownData00 = 0x0158;

	}

	public class UMovieSceneSpawnTrack
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x00C0;

		///<summary><![CDATA[FGuid]]></summary>
		public const int ObjectGuid = 0x00C8;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x00D8;

	}

	public class UMovieSceneEventTrack
	{
		///<summary><![CDATA[TArray<FMovieSceneObjectBindingID>]]></summary>
		public const int EventReceivers = 0x00C0;

		///<summary><![CDATA[TArray<UMovieSceneSection * >]]></summary>
		public const int Sections = 0x00D0;

	}

	public class UMovieSceneFloatSection
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x00D0;

		///<summary><![CDATA[FRichCurve]]></summary>
		public const int FloatCurve = 0x00D8;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x0148;

	}

	public class UMovieSceneFadeSection
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0150;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bFadeAudio = 0x0158;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0159;

	}

	public class UMovieSceneIntegerSection
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x00D0;

		///<summary><![CDATA[FIntegralCurve]]></summary>
		public const int IntegerCurve = 0x00D8;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x0148;

	}

	public class UMovieSceneLevelVisibilitySection
	{
		///<summary><![CDATA[ELevelVisibility]]></summary>
		public const int Visibility = 0x00D0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x00D1;

		///<summary><![CDATA[TArray<FName>]]></summary>
		public const int LevelNames = 0x00D8;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x00E8;

	}

	public class UMovieScenePropertyTrack
	{
		///<summary><![CDATA[FString]]></summary>
		public const int PropertyPath = 0x00C0;

		///<summary><![CDATA[TArray<UMovieSceneSection * >]]></summary>
		public const int Sections = 0x00D0;

	}

	public class UMovieSceneLevelVisibilityTrack
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x00C0;

	}

	public class UMovieSceneParameterSection
	{
		///<summary><![CDATA[TArray<FScalarParameterNameAndCurve>]]></summary>
		public const int ScalarParameterNamesAndCurves = 0x00D0;

		///<summary><![CDATA[TArray<FVectorParameterNameAndCurves>]]></summary>
		public const int VectorParameterNamesAndCurves = 0x00E0;

		///<summary><![CDATA[TArray<FColorParameterNameAndCurves>]]></summary>
		public const int ColorParameterNamesAndCurves = 0x00F0;

	}

	public class UMovieSceneMaterialTrack
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x00C0;

	}

	public class UMovieSceneParticleParameterTrack
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x00C0;

	}

	public class UMovieSceneParticleSection
	{
		///<summary><![CDATA[FIntegralCurve]]></summary>
		public const int ParticleKeys = 0x00D0;

	}

	public class UMovieSceneParticleTrack
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x00C0;

	}

	public class UMovieSceneByteTrack
	{
		///<summary><![CDATA[UEnum *]]></summary>
		public const int Enum = 0x00E0;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x00E8;

	}

	public class UMovieSceneColorTrack
	{
		///<summary><![CDATA[bool]]></summary>
		public const int bIsSlateColor = 0x00E0;

		///<summary><![CDATA[unsigned char[0xF]]]></summary>
		public const int UnknownData00 = 0x00E1;

	}

	public class UMovieSceneEnumTrack
	{
		///<summary><![CDATA[UEnum *]]></summary>
		public const int Enum = 0x00E0;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x00E8;

	}

	public class UMovieSceneVectorTrack
	{
		///<summary><![CDATA[int]]></summary>
		public const int NumChannelsUsed = 0x00E0;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData00 = 0x00E4;

	}

	public class UMovieSceneSkeletalAnimationSection
	{
		///<summary><![CDATA[FMovieSceneSkeletalAnimationParams]]></summary>
		public const int Params = 0x00D0;

		///<summary><![CDATA[UAnimSequence *]]></summary>
		public const int AnimSequence = 0x0160;

		///<summary><![CDATA[UAnimSequenceBase *]]></summary>
		public const int Animation = 0x0168;

		///<summary><![CDATA[float]]></summary>
		public const int StartOffset = 0x0170;

		///<summary><![CDATA[float]]></summary>
		public const int EndOffset = 0x0174;

		///<summary><![CDATA[float]]></summary>
		public const int PlayRate = 0x0178;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bReverse = 0x017C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x017D;

		///<summary><![CDATA[FName]]></summary>
		public const int SlotName = 0x0180;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x0188;

	}

	public class UMovieSceneSkeletalAnimationTrack
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x00C0;

	}

	public class UMovieSceneStringSection
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x00D0;

		///<summary><![CDATA[FStringCurve]]></summary>
		public const int StringCurve = 0x00D8;

	}

	public class UMovieSceneSubSection
	{
		///<summary><![CDATA[FMovieSceneSectionParameters]]></summary>
		public const int Parameters = 0x00D0;

		///<summary><![CDATA[float]]></summary>
		public const int StartOffset = 0x00E4;

		///<summary><![CDATA[float]]></summary>
		public const int TimeScale = 0x00E8;

		///<summary><![CDATA[float]]></summary>
		public const int PrerollTime = 0x00EC;

		///<summary><![CDATA[UMovieSceneSequence *]]></summary>
		public const int SubSequence = 0x00F0;

		///<summary><![CDATA[TLazyObjectPtr<AActor>]]></summary>
		public const int ActorToRecord = 0x00F8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0114;

		///<summary><![CDATA[FString]]></summary>
		public const int TargetSequenceName = 0x0118;

		///<summary><![CDATA[FDirectoryPath]]></summary>
		public const int TargetPathToRecordTo = 0x0128;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x0138;

	}

	public class UMovieSceneCinematicShotSection
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0140;

	}

	public class UMovieSceneSubTrack
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x00C0;

	}

	public class UMovieSceneVectorSection
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x00D0;

		///<summary><![CDATA[FRichCurve[0x4]]]></summary>
		public const int Curves = 0x00D8;

		///<summary><![CDATA[int]]></summary>
		public const int ChannelsUsed = 0x0298;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x029C;

	}

}
