/// <summary>
/// Auto-generated offsets targetting PUBG v 3.2.12
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UBuoyancyForceComponent
	{
		public const int OceanManager = 0x03E0;
		public const int MeshDensity = 0x03E8;
		public const int FluidDensity = 0x03EC;
		public const int FluidLinearDamping = 0x03F0;
		public const int FluidAngularDamping = 0x03F4;
		public const int VelocityDamper = 0x03F8;
		public const int ClampMaxVelocity = 0x0404;
		public const int UnknownData00 = 0x0405;
		public const int MaxUnderwaterVelocity = 0x0408;
		public const int TestPointRadius = 0x040C;
		public const int TestPoints = 0x0410;
		public const int ApplyForceToBones = 0x0420;
		public const int SnapToSurfaceIfNoPhysics = 0x0421;
		public const int TwoGerstnerIterations = 0x0422;
		public const int UnknownData01 = 0x0423;
		public const int PointDensityOverride = 0x0428;
		public const int BoneOverride = 0x0438;
		public const int DrawDebugPoints = 0x0448;
		public const int EnableStayUprightConstraint = 0x0449;
		public const int UnknownData02 = 0x044A;
		public const int StayUprightStiffness = 0x044C;
		public const int StayUprightDamping = 0x0450;
		public const int StayUprightDesiredRotation = 0x0454;
		public const int EnableWaveForces = 0x0460;
		public const int UnknownData03 = 0x0461;
		public const int WaveForceMultiplier = 0x0464;
		public const int TickGroup = 0x0468;
		public const int UnknownData04 = 0x0469;
	}

	public class AOceanManager
	{
		public const int EnableGerstnerWaves = 0x03B0;
		public const int UnknownData00 = 0x03B1;
		public const int GlobalWaveDirection = 0x03B4;
		public const int GlobalWaveSpeed = 0x03BC;
		public const int GlobalWaveAmplitude = 0x03C0;
		public const int DistanceCheck = 0x03C4;
		public const int WaveClusters = 0x03C8;
		public const int WaveSetOffsetsOverride = 0x03D8;
		public const int NetWorkTimeOffset = 0x03E8;
		public const int bEnableLandscapeModulation = 0x03EC;
		public const int UnknownData01 = 0x03ED;
		public const int ModulationStartHeight = 0x03F0;
		public const int ModulationMaxHeight = 0x03F4;
		public const int ModulationPower = 0x03F8;
		public const int UnknownData02 = 0x03FC;
		public const int Landscape = 0x0400;
		public const int HeightmapTexture = 0x0408;
		public const int UnknownData03 = 0x0410;
	}

	public class UAdvancedBuoyancyComponent
	{
		public const int bUseDrag = 0x03E0;
		public const int bDebugOn = 0x03E1;
		public const int UnknownData00 = 0x03E2;
		public const int TheOcean = 0x03E8;
		public const int WaterDensity = 0x03F0;
		public const int Gravity = 0x03F4;
		public const int MeshDensity = 0x03F8;
		public const int UnknownData01 = 0x03FC;
		public const int BuoyantMesh = 0x0410;
		public const int UnknownData02 = 0x0418;
		public const int MeshTransform = 0x0420;
		public const int FalseVolume = 0x0450;
		public const int BuoyancyReductionCoefficient = 0x0454;
		public const int BuoyancyPitchReductionCoefficient = 0x0458;
		public const int DensityCorrection = 0x045C;
		public const int DensityCorrectionModifier = 0x0460;
		public const int SubmergedVolume = 0x0464;
		public const int ImpactCoefficient = 0x0468;
		public const int DragCoefficient = 0x046C;
		public const int SuctionCoefficient = 0x0478;
		public const int ViscousDragCoefficient = 0x0484;
		public const int MaxSlamAcceleration = 0x0488;
		public const int UnknownData03 = 0x048C;
		public const int AdvancedGridHeight = 0x0490;
		public const int SubmergedTris = 0x04A0;
		public const int TriSizes = 0x04B0;
		public const int TriSubmergedArea = 0x04C0;
		public const int UnknownData04 = 0x04D0;
	}

	public class UBuoyancyComponent
	{
		public const int OceanManager = 0x0220;
		public const int MeshDensity = 0x0228;
		public const int FluidDensity = 0x022C;
		public const int FluidLinearDamping = 0x0230;
		public const int FluidAngularDamping = 0x0234;
		public const int VelocityDamper = 0x0238;
		public const int ClampMaxVelocity = 0x0244;
		public const int UnknownData00 = 0x0245;
		public const int MaxUnderwaterVelocity = 0x0248;
		public const int TestPointRadius = 0x024C;
		public const int TestPoints = 0x0250;
		public const int PointDensityOverride = 0x0260;
		public const int DrawDebugPoints = 0x0270;
		public const int EnableStayUprightConstraint = 0x0271;
		public const int UnknownData01 = 0x0272;
		public const int StayUprightStiffness = 0x0274;
		public const int StayUprightDamping = 0x0278;
		public const int StayUprightDesiredRotation = 0x027C;
		public const int EnableWaveForces = 0x0288;
		public const int UnknownData02 = 0x0289;
		public const int WaveForceMultiplier = 0x028C;
		public const int UnknownData03 = 0x0290;
	}

	public class UBuoyantDestructibleComponent
	{
		public const int UnknownData00 = 0x0B80;
		public const int OceanManager = 0x0B88;
		public const int ChunkDensity = 0x0B90;
		public const int FluidDensity = 0x0B94;
		public const int FluidLinearDamping = 0x0B98;
		public const int FluidAngularDamping = 0x0B9C;
		public const int VelocityDamper = 0x0BA0;
		public const int ClampMaxVelocity = 0x0BAC;
		public const int UnknownData01 = 0x0BAD;
		public const int MaxUnderwaterVelocity = 0x0BB0;
		public const int TestPointRadius = 0x0BB4;
		public const int DrawDebugPoints = 0x0BB8;
		public const int EnableWaveForces = 0x0BB9;
		public const int UnknownData02 = 0x0BBA;
		public const int WaveForceMultiplier = 0x0BBC;
		public const int ChunkSleepThreshold = 0x0BC0;
		public const int ChunkStabilizationThreshold = 0x0BC4;
		public const int UnknownData03 = 0x0BC8;
	}

	public class ABuoyantDestructible
	{
		public const int BuoyantDestructibleComponent = 0x03B0;
	}

	public class UBuoyantMeshComponent
	{
		public const int UnknownData00 = 0x09C0;
		public const int bVerticalForcesOnly = 0x09C8;
		public const int bUseWaterPatch = 0x09C9;
		public const int bUseStaticForces = 0x09CA;
		public const int bUseDynamicForces = 0x09CB;
		public const int UnknownData01 = 0x09CC;
		public const int OceanManager = 0x09D0;
		public const int bDrawForceArrows = 0x09D8;
		public const int bDrawWaterline = 0x09D9;
		public const int bDrawVertices = 0x09DA;
		public const int bDrawTriangles = 0x09DB;
		public const int bDrawSubtriangles = 0x09DC;
		public const int UnknownData02 = 0x09DD;
		public const int ForceArrowSize = 0x09E0;
		public const int bOverrideMeshDensity = 0x09E4;
		public const int UnknownData03 = 0x09E5;
		public const int MeshDensity = 0x09E8;
		public const int bOverrideMass = 0x09EC;
		public const int UnknownData04 = 0x09ED;
		public const int Mass = 0x09F0;
		public const int WaterDensity = 0x09F4;
		public const int UnknownData05 = 0x09F8;
		public const int WaterHeightmap = 0x0A20;
		public const int UnknownData06 = 0x0A28;
	}

	public class ACustomVehicleController
	{
		public const int PlayerPawn = 0x06F0;
	}

	public class AFishManager
	{
		public const int flockTypes = 0x03B0;
		public const int numInFlock = 0x03C0;
		public const int minZ = 0x03D0;
		public const int maxZ = 0x03D4;
		public const int underwaterBoxLength = 0x03D8;
		public const int attachToPlayer = 0x03DC;
		public const int DebugMode = 0x03DD;
		public const int UnknownData00 = 0x03DE;
		public const int playerType = 0x03E0;
		public const int UnknownData01 = 0x03E8;
	}

	public class AFlockFish
	{
		public const int UnknownData00 = 0x0410;
		public const int FishInteractionSphere = 0x0420;
		public const int isLeader = 0x0428;
		public const int UnknownData01 = 0x0429;
		public const int enemyTypes = 0x0430;
		public const int preyTypes = 0x0440;
		public const int neighborType = 0x0450;
		public const int followDist = 0x0458;
		public const int Speed = 0x045C;
		public const int MaxSpeed = 0x0460;
		public const int turnSpeed = 0x0464;
		public const int turnFrequency = 0x0468;
		public const int hungerResetTime = 0x046C;
		public const int distBehindSpeedUpRange = 0x0470;
		public const int SeperationDistanceMultiplier = 0x0474;
		public const int FleeDistanceMultiplier = 0x0478;
		public const int FleeAccelerationMultiplier = 0x047C;
		public const int ChaseAccelerationMultiplier = 0x0480;
		public const int SeekDecelerationMultiplier = 0x0484;
		public const int AvoidForceMultiplier = 0x0488;
		public const int AvoidanceForce = 0x048C;
		public const int playerType = 0x0490;
		public const int underwaterMin = 0x0498;
		public const int underwaterMax = 0x04A4;
		public const int CustomZSeekMin = 0x04B0;
		public const int CustomZSeekMax = 0x04B4;
		public const int NumNeighborsToEvaluate = 0x04B8;
		public const int UpdateEveryTick = 0x04BC;
		public const int UnknownData02 = 0x04C0;
		public const int DebugMode = 0x04D0;
		public const int UnknownData03 = 0x04D1;
	}

	public class UInfiniteSystemComponent
	{
		public const int UpdateInEditor = 0x03E0;
		public const int FollowMethod = 0x03E1;
		public const int UnknownData00 = 0x03E2;
		public const int GridSnapSize = 0x03E4;
		public const int MaxLookAtDistance = 0x03E8;
		public const int ScaleByDistance = 0x03EC;
		public const int UnknownData01 = 0x03ED;
		public const int ScaleDistanceFactor = 0x03F0;
		public const int ScaleStartDistance = 0x03F4;
		public const int ScaleMin = 0x03F8;
		public const int ScaleMax = 0x03FC;
		public const int UnknownData02 = 0x0400;
	}

	public class ATimeManager
	{
		public const int CurrentLocalTime = 0x03B0;
		public const int Latitude = 0x03CC;
		public const int Longitude = 0x03D0;
		public const int OffsetUTC = 0x03D4;
		public const int OffsetDST = 0x03D8;
		public const int bAllowDaylightSavings = 0x03DC;
		public const int bDaylightSavingsActive = 0x03DD;
		public const int UnknownData00 = 0x03DE;
		public const int TimeScaleMultiplier = 0x03E0;
		public const int SolarTime = 0x03E4;
		public const int LocalClockTime = 0x03E8;
		public const int TimeCorrection = 0x03EC;
		public const int LSTM = 0x03F0;
		public const int DayOfYear = 0x03F4;
		public const int EoT = 0x03F8;
		public const int SolarAltAngle = 0x03FC;
		public const int SolarDeclination = 0x0400;
		public const int SolarAzimuth = 0x0404;
		public const int SolarHRA = 0x0408;
		public const int SiderealTime = 0x040C;
		public const int LunarAltAngle = 0x0410;
		public const int LunarHRA = 0x0414;
		public const int LunarDeclination = 0x0418;
		public const int LunarAzimuth = 0x041C;
		public const int LunarRightAsc = 0x0420;
		public const int LunarElapsedDays = 0x0424;
		public const int EcLongitude = 0x0428;
		public const int EcLatitude = 0x042C;
		public const int EcDistance = 0x0430;
		public const int PartL = 0x0434;
		public const int PartM = 0x0438;
		public const int PartF = 0x043C;
		public const int UnknownData01 = 0x0440;
	}

	public class UWaterHeightmapComponent
	{
		public const int GridSizeMultiplier = 0x01E0;
		public const int bDrawUsedTriangles = 0x01E4;
		public const int bDrawHeightmap = 0x01E5;
		public const int UnknownData00 = 0x01E6;
		public const int OceanManager = 0x0248;
	}

}
