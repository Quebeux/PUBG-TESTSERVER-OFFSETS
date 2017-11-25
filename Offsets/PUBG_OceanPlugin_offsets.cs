/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UBuoyancyForceComponent
	{
		///<summary><![CDATA[AOceanManager *]]></summary>
		public const int OceanManager = 0x03E0;

		///<summary><![CDATA[float]]></summary>
		public const int MeshDensity = 0x03E8;

		///<summary><![CDATA[float]]></summary>
		public const int FluidDensity = 0x03EC;

		///<summary><![CDATA[float]]></summary>
		public const int FluidLinearDamping = 0x03F0;

		///<summary><![CDATA[float]]></summary>
		public const int FluidAngularDamping = 0x03F4;

		///<summary><![CDATA[FVector]]></summary>
		public const int VelocityDamper = 0x03F8;

		///<summary><![CDATA[bool]]></summary>
		public const int ClampMaxVelocity = 0x0404;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0405;

		///<summary><![CDATA[float]]></summary>
		public const int MaxUnderwaterVelocity = 0x0408;

		///<summary><![CDATA[float]]></summary>
		public const int TestPointRadius = 0x040C;

		///<summary><![CDATA[TArray<FVector>]]></summary>
		public const int TestPoints = 0x0410;

		///<summary><![CDATA[bool]]></summary>
		public const int ApplyForceToBones = 0x0420;

		///<summary><![CDATA[bool]]></summary>
		public const int SnapToSurfaceIfNoPhysics = 0x0421;

		///<summary><![CDATA[bool]]></summary>
		public const int TwoGerstnerIterations = 0x0422;

		///<summary><![CDATA[unsigned char[0x5]]]></summary>
		public const int UnknownData01 = 0x0423;

		///<summary><![CDATA[TArray<float>]]></summary>
		public const int PointDensityOverride = 0x0428;

		///<summary><![CDATA[TArray<FStructBoneOverride>]]></summary>
		public const int BoneOverride = 0x0438;

		///<summary><![CDATA[bool]]></summary>
		public const int DrawDebugPoints = 0x0448;

		///<summary><![CDATA[bool]]></summary>
		public const int EnableStayUprightConstraint = 0x0449;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData02 = 0x044A;

		///<summary><![CDATA[float]]></summary>
		public const int StayUprightStiffness = 0x044C;

		///<summary><![CDATA[float]]></summary>
		public const int StayUprightDamping = 0x0450;

		///<summary><![CDATA[FRotator]]></summary>
		public const int StayUprightDesiredRotation = 0x0454;

		///<summary><![CDATA[bool]]></summary>
		public const int EnableWaveForces = 0x0460;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData03 = 0x0461;

		///<summary><![CDATA[float]]></summary>
		public const int WaveForceMultiplier = 0x0464;

		///<summary><![CDATA[TEnumAsByte<ETickingGroup>]]></summary>
		public const int TickGroup = 0x0468;

		///<summary><![CDATA[unsigned char[0x17]]]></summary>
		public const int UnknownData04 = 0x0469;

	}

	public class AOceanManager
	{
		///<summary><![CDATA[bool]]></summary>
		public const int EnableGerstnerWaves = 0x03B0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x03B1;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int GlobalWaveDirection = 0x03B4;

		///<summary><![CDATA[float]]></summary>
		public const int GlobalWaveSpeed = 0x03BC;

		///<summary><![CDATA[float]]></summary>
		public const int GlobalWaveAmplitude = 0x03C0;

		///<summary><![CDATA[float]]></summary>
		public const int DistanceCheck = 0x03C4;

		///<summary><![CDATA[TArray<FWaveParameter>]]></summary>
		public const int WaveClusters = 0x03C8;

		///<summary><![CDATA[TArray<FWaveSetParameters>]]></summary>
		public const int WaveSetOffsetsOverride = 0x03D8;

		///<summary><![CDATA[float]]></summary>
		public const int NetWorkTimeOffset = 0x03E8;

		///<summary><![CDATA[bool]]></summary>
		public const int bEnableLandscapeModulation = 0x03EC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x03ED;

		///<summary><![CDATA[float]]></summary>
		public const int ModulationStartHeight = 0x03F0;

		///<summary><![CDATA[float]]></summary>
		public const int ModulationMaxHeight = 0x03F4;

		///<summary><![CDATA[float]]></summary>
		public const int ModulationPower = 0x03F8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x03FC;

		///<summary><![CDATA[ALandscape *]]></summary>
		public const int Landscape = 0x0400;

		///<summary><![CDATA[UTexture2D *]]></summary>
		public const int HeightmapTexture = 0x0408;

		///<summary><![CDATA[unsigned char[0x28]]]></summary>
		public const int UnknownData03 = 0x0410;

	}

	public class UAdvancedBuoyancyComponent
	{
		///<summary><![CDATA[bool]]></summary>
		public const int bUseDrag = 0x03E0;

		///<summary><![CDATA[bool]]></summary>
		public const int bDebugOn = 0x03E1;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData00 = 0x03E2;

		///<summary><![CDATA[AOceanManager *]]></summary>
		public const int TheOcean = 0x03E8;

		///<summary><![CDATA[float]]></summary>
		public const int WaterDensity = 0x03F0;

		///<summary><![CDATA[float]]></summary>
		public const int Gravity = 0x03F4;

		///<summary><![CDATA[float]]></summary>
		public const int MeshDensity = 0x03F8;

		///<summary><![CDATA[unsigned char[0x14]]]></summary>
		public const int UnknownData01 = 0x03FC;

		///<summary><![CDATA[UStaticMeshComponent *]]></summary>
		public const int BuoyantMesh = 0x0410;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData02 = 0x0418;

		///<summary><![CDATA[FTransform]]></summary>
		public const int MeshTransform = 0x0420;

		///<summary><![CDATA[float]]></summary>
		public const int FalseVolume = 0x0450;

		///<summary><![CDATA[float]]></summary>
		public const int BuoyancyReductionCoefficient = 0x0454;

		///<summary><![CDATA[float]]></summary>
		public const int BuoyancyPitchReductionCoefficient = 0x0458;

		///<summary><![CDATA[float]]></summary>
		public const int DensityCorrection = 0x045C;

		///<summary><![CDATA[float]]></summary>
		public const int DensityCorrectionModifier = 0x0460;

		///<summary><![CDATA[float]]></summary>
		public const int SubmergedVolume = 0x0464;

		///<summary><![CDATA[float]]></summary>
		public const int ImpactCoefficient = 0x0468;

		///<summary><![CDATA[FVector]]></summary>
		public const int DragCoefficient = 0x046C;

		///<summary><![CDATA[FVector]]></summary>
		public const int SuctionCoefficient = 0x0478;

		///<summary><![CDATA[float]]></summary>
		public const int ViscousDragCoefficient = 0x0484;

		///<summary><![CDATA[float]]></summary>
		public const int MaxSlamAcceleration = 0x0488;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData03 = 0x048C;

		///<summary><![CDATA[TArray<FVector>]]></summary>
		public const int AdvancedGridHeight = 0x0490;

		///<summary><![CDATA[TArray<FForceTriangle>]]></summary>
		public const int SubmergedTris = 0x04A0;

		///<summary><![CDATA[TArray<float>]]></summary>
		public const int TriSizes = 0x04B0;

		///<summary><![CDATA[TArray<float>]]></summary>
		public const int TriSubmergedArea = 0x04C0;

		///<summary><![CDATA[unsigned char[0x30]]]></summary>
		public const int UnknownData04 = 0x04D0;

	}

	public class UBuoyancyComponent
	{
		///<summary><![CDATA[AOceanManager *]]></summary>
		public const int OceanManager = 0x0220;

		///<summary><![CDATA[float]]></summary>
		public const int MeshDensity = 0x0228;

		///<summary><![CDATA[float]]></summary>
		public const int FluidDensity = 0x022C;

		///<summary><![CDATA[float]]></summary>
		public const int FluidLinearDamping = 0x0230;

		///<summary><![CDATA[float]]></summary>
		public const int FluidAngularDamping = 0x0234;

		///<summary><![CDATA[FVector]]></summary>
		public const int VelocityDamper = 0x0238;

		///<summary><![CDATA[bool]]></summary>
		public const int ClampMaxVelocity = 0x0244;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0245;

		///<summary><![CDATA[float]]></summary>
		public const int MaxUnderwaterVelocity = 0x0248;

		///<summary><![CDATA[float]]></summary>
		public const int TestPointRadius = 0x024C;

		///<summary><![CDATA[TArray<FVector>]]></summary>
		public const int TestPoints = 0x0250;

		///<summary><![CDATA[TArray<float>]]></summary>
		public const int PointDensityOverride = 0x0260;

		///<summary><![CDATA[bool]]></summary>
		public const int DrawDebugPoints = 0x0270;

		///<summary><![CDATA[bool]]></summary>
		public const int EnableStayUprightConstraint = 0x0271;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData01 = 0x0272;

		///<summary><![CDATA[float]]></summary>
		public const int StayUprightStiffness = 0x0274;

		///<summary><![CDATA[float]]></summary>
		public const int StayUprightDamping = 0x0278;

		///<summary><![CDATA[FRotator]]></summary>
		public const int StayUprightDesiredRotation = 0x027C;

		///<summary><![CDATA[bool]]></summary>
		public const int EnableWaveForces = 0x0288;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x0289;

		///<summary><![CDATA[float]]></summary>
		public const int WaveForceMultiplier = 0x028C;

		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData03 = 0x0290;

	}

	public class UBuoyantDestructibleComponent
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0B80;

		///<summary><![CDATA[AOceanManager *]]></summary>
		public const int OceanManager = 0x0B88;

		///<summary><![CDATA[float]]></summary>
		public const int ChunkDensity = 0x0B90;

		///<summary><![CDATA[float]]></summary>
		public const int FluidDensity = 0x0B94;

		///<summary><![CDATA[float]]></summary>
		public const int FluidLinearDamping = 0x0B98;

		///<summary><![CDATA[float]]></summary>
		public const int FluidAngularDamping = 0x0B9C;

		///<summary><![CDATA[FVector]]></summary>
		public const int VelocityDamper = 0x0BA0;

		///<summary><![CDATA[bool]]></summary>
		public const int ClampMaxVelocity = 0x0BAC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0BAD;

		///<summary><![CDATA[float]]></summary>
		public const int MaxUnderwaterVelocity = 0x0BB0;

		///<summary><![CDATA[float]]></summary>
		public const int TestPointRadius = 0x0BB4;

		///<summary><![CDATA[bool]]></summary>
		public const int DrawDebugPoints = 0x0BB8;

		///<summary><![CDATA[bool]]></summary>
		public const int EnableWaveForces = 0x0BB9;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData02 = 0x0BBA;

		///<summary><![CDATA[float]]></summary>
		public const int WaveForceMultiplier = 0x0BBC;

		///<summary><![CDATA[float]]></summary>
		public const int ChunkSleepThreshold = 0x0BC0;

		///<summary><![CDATA[float]]></summary>
		public const int ChunkStabilizationThreshold = 0x0BC4;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData03 = 0x0BC8;

	}

	public class ABuoyantDestructible
	{
		///<summary><![CDATA[UBuoyantDestructibleComponent *]]></summary>
		public const int BuoyantDestructibleComponent = 0x03B0;

	}

	public class UBuoyantMeshComponent
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x09C0;

		///<summary><![CDATA[bool]]></summary>
		public const int bVerticalForcesOnly = 0x09C8;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseWaterPatch = 0x09C9;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseStaticForces = 0x09CA;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseDynamicForces = 0x09CB;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x09CC;

		///<summary><![CDATA[AOceanManager *]]></summary>
		public const int OceanManager = 0x09D0;

		///<summary><![CDATA[bool]]></summary>
		public const int bDrawForceArrows = 0x09D8;

		///<summary><![CDATA[bool]]></summary>
		public const int bDrawWaterline = 0x09D9;

		///<summary><![CDATA[bool]]></summary>
		public const int bDrawVertices = 0x09DA;

		///<summary><![CDATA[bool]]></summary>
		public const int bDrawTriangles = 0x09DB;

		///<summary><![CDATA[bool]]></summary>
		public const int bDrawSubtriangles = 0x09DC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x09DD;

		///<summary><![CDATA[float]]></summary>
		public const int ForceArrowSize = 0x09E0;

		///<summary><![CDATA[bool]]></summary>
		public const int bOverrideMeshDensity = 0x09E4;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData03 = 0x09E5;

		///<summary><![CDATA[float]]></summary>
		public const int MeshDensity = 0x09E8;

		///<summary><![CDATA[bool]]></summary>
		public const int bOverrideMass = 0x09EC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData04 = 0x09ED;

		///<summary><![CDATA[float]]></summary>
		public const int Mass = 0x09F0;

		///<summary><![CDATA[float]]></summary>
		public const int WaterDensity = 0x09F4;

		///<summary><![CDATA[unsigned char[0x28]]]></summary>
		public const int UnknownData05 = 0x09F8;

		///<summary><![CDATA[UWaterHeightmapComponent *]]></summary>
		public const int WaterHeightmap = 0x0A20;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData06 = 0x0A28;

	}

	public class ACustomVehicleController
	{
		///<summary><![CDATA[APawn *]]></summary>
		public const int PlayerPawn = 0x06F0;

	}

	public class AFishManager
	{
		///<summary><![CDATA[TArray<UClass * >]]></summary>
		public const int flockTypes = 0x03B0;

		///<summary><![CDATA[TArray<float>]]></summary>
		public const int numInFlock = 0x03C0;

		///<summary><![CDATA[float]]></summary>
		public const int minZ = 0x03D0;

		///<summary><![CDATA[float]]></summary>
		public const int maxZ = 0x03D4;

		///<summary><![CDATA[float]]></summary>
		public const int underwaterBoxLength = 0x03D8;

		///<summary><![CDATA[bool]]></summary>
		public const int attachToPlayer = 0x03DC;

		///<summary><![CDATA[bool]]></summary>
		public const int DebugMode = 0x03DD;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x03DE;

		///<summary><![CDATA[UClass *]]></summary>
		public const int playerType = 0x03E0;

		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData01 = 0x03E8;

	}

	public class AFlockFish
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0410;

		///<summary><![CDATA[USphereComponent *]]></summary>
		public const int FishInteractionSphere = 0x0420;

		///<summary><![CDATA[bool]]></summary>
		public const int isLeader = 0x0428;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0429;

		///<summary><![CDATA[TArray<UClass * >]]></summary>
		public const int enemyTypes = 0x0430;

		///<summary><![CDATA[TArray<UClass * >]]></summary>
		public const int preyTypes = 0x0440;

		///<summary><![CDATA[UClass *]]></summary>
		public const int neighborType = 0x0450;

		///<summary><![CDATA[float]]></summary>
		public const int followDist = 0x0458;

		///<summary><![CDATA[float]]></summary>
		public const int Speed = 0x045C;

		///<summary><![CDATA[float]]></summary>
		public const int MaxSpeed = 0x0460;

		///<summary><![CDATA[float]]></summary>
		public const int turnSpeed = 0x0464;

		///<summary><![CDATA[float]]></summary>
		public const int turnFrequency = 0x0468;

		///<summary><![CDATA[float]]></summary>
		public const int hungerResetTime = 0x046C;

		///<summary><![CDATA[float]]></summary>
		public const int distBehindSpeedUpRange = 0x0470;

		///<summary><![CDATA[float]]></summary>
		public const int SeperationDistanceMultiplier = 0x0474;

		///<summary><![CDATA[float]]></summary>
		public const int FleeDistanceMultiplier = 0x0478;

		///<summary><![CDATA[float]]></summary>
		public const int FleeAccelerationMultiplier = 0x047C;

		///<summary><![CDATA[float]]></summary>
		public const int ChaseAccelerationMultiplier = 0x0480;

		///<summary><![CDATA[float]]></summary>
		public const int SeekDecelerationMultiplier = 0x0484;

		///<summary><![CDATA[float]]></summary>
		public const int AvoidForceMultiplier = 0x0488;

		///<summary><![CDATA[float]]></summary>
		public const int AvoidanceForce = 0x048C;

		///<summary><![CDATA[UClass *]]></summary>
		public const int playerType = 0x0490;

		///<summary><![CDATA[FVector]]></summary>
		public const int underwaterMin = 0x0498;

		///<summary><![CDATA[FVector]]></summary>
		public const int underwaterMax = 0x04A4;

		///<summary><![CDATA[float]]></summary>
		public const int CustomZSeekMin = 0x04B0;

		///<summary><![CDATA[float]]></summary>
		public const int CustomZSeekMax = 0x04B4;

		///<summary><![CDATA[float]]></summary>
		public const int NumNeighborsToEvaluate = 0x04B8;

		///<summary><![CDATA[float]]></summary>
		public const int UpdateEveryTick = 0x04BC;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData02 = 0x04C0;

		///<summary><![CDATA[bool]]></summary>
		public const int DebugMode = 0x04D0;

		///<summary><![CDATA[unsigned char[0xBF]]]></summary>
		public const int UnknownData03 = 0x04D1;

	}

	public class UInfiniteSystemComponent
	{
		///<summary><![CDATA[bool]]></summary>
		public const int UpdateInEditor = 0x03E0;

		///<summary><![CDATA[TEnumAsByte<EFollowMethod>]]></summary>
		public const int FollowMethod = 0x03E1;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x03E2;

		///<summary><![CDATA[float]]></summary>
		public const int GridSnapSize = 0x03E4;

		///<summary><![CDATA[float]]></summary>
		public const int MaxLookAtDistance = 0x03E8;

		///<summary><![CDATA[bool]]></summary>
		public const int ScaleByDistance = 0x03EC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x03ED;

		///<summary><![CDATA[float]]></summary>
		public const int ScaleDistanceFactor = 0x03F0;

		///<summary><![CDATA[float]]></summary>
		public const int ScaleStartDistance = 0x03F4;

		///<summary><![CDATA[float]]></summary>
		public const int ScaleMin = 0x03F8;

		///<summary><![CDATA[float]]></summary>
		public const int ScaleMax = 0x03FC;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData02 = 0x0400;

	}

	public class ATimeManager
	{
		///<summary><![CDATA[FTimeDate]]></summary>
		public const int CurrentLocalTime = 0x03B0;

		///<summary><![CDATA[float]]></summary>
		public const int Latitude = 0x03CC;

		///<summary><![CDATA[float]]></summary>
		public const int Longitude = 0x03D0;

		///<summary><![CDATA[int]]></summary>
		public const int OffsetUTC = 0x03D4;

		///<summary><![CDATA[int]]></summary>
		public const int OffsetDST = 0x03D8;

		///<summary><![CDATA[bool]]></summary>
		public const int bAllowDaylightSavings = 0x03DC;

		///<summary><![CDATA[bool]]></summary>
		public const int bDaylightSavingsActive = 0x03DD;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x03DE;

		///<summary><![CDATA[float]]></summary>
		public const int TimeScaleMultiplier = 0x03E0;

		///<summary><![CDATA[float]]></summary>
		public const int SolarTime = 0x03E4;

		///<summary><![CDATA[float]]></summary>
		public const int LocalClockTime = 0x03E8;

		///<summary><![CDATA[float]]></summary>
		public const int TimeCorrection = 0x03EC;

		///<summary><![CDATA[int]]></summary>
		public const int LSTM = 0x03F0;

		///<summary><![CDATA[int]]></summary>
		public const int DayOfYear = 0x03F4;

		///<summary><![CDATA[float]]></summary>
		public const int EoT = 0x03F8;

		///<summary><![CDATA[float]]></summary>
		public const int SolarAltAngle = 0x03FC;

		///<summary><![CDATA[float]]></summary>
		public const int SolarDeclination = 0x0400;

		///<summary><![CDATA[float]]></summary>
		public const int SolarAzimuth = 0x0404;

		///<summary><![CDATA[float]]></summary>
		public const int SolarHRA = 0x0408;

		///<summary><![CDATA[float]]></summary>
		public const int SiderealTime = 0x040C;

		///<summary><![CDATA[float]]></summary>
		public const int LunarAltAngle = 0x0410;

		///<summary><![CDATA[float]]></summary>
		public const int LunarHRA = 0x0414;

		///<summary><![CDATA[float]]></summary>
		public const int LunarDeclination = 0x0418;

		///<summary><![CDATA[float]]></summary>
		public const int LunarAzimuth = 0x041C;

		///<summary><![CDATA[float]]></summary>
		public const int LunarRightAsc = 0x0420;

		///<summary><![CDATA[float]]></summary>
		public const int LunarElapsedDays = 0x0424;

		///<summary><![CDATA[float]]></summary>
		public const int EcLongitude = 0x0428;

		///<summary><![CDATA[float]]></summary>
		public const int EcLatitude = 0x042C;

		///<summary><![CDATA[float]]></summary>
		public const int EcDistance = 0x0430;

		///<summary><![CDATA[float]]></summary>
		public const int PartL = 0x0434;

		///<summary><![CDATA[float]]></summary>
		public const int PartM = 0x0438;

		///<summary><![CDATA[float]]></summary>
		public const int PartF = 0x043C;

		///<summary><![CDATA[unsigned char[0x38]]]></summary>
		public const int UnknownData01 = 0x0440;

	}

	public class UWaterHeightmapComponent
	{
		///<summary><![CDATA[float]]></summary>
		public const int GridSizeMultiplier = 0x01E0;

		///<summary><![CDATA[bool]]></summary>
		public const int bDrawUsedTriangles = 0x01E4;

		///<summary><![CDATA[bool]]></summary>
		public const int bDrawHeightmap = 0x01E5;

		///<summary><![CDATA[unsigned char[0x62]]]></summary>
		public const int UnknownData00 = 0x01E6;

		///<summary><![CDATA[AOceanManager *]]></summary>
		public const int OceanManager = 0x0248;

	}

}
