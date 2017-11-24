/// <summary>
/// Auto-generated offsets targetting PUBG v 3.2.12
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class AWheeledVehicle
	{
		public const int Mesh = 0x0410;
		public const int VehicleMovement = 0x0418;
	}

	public class UWheeledVehicleMovementComponent
	{
		public const int UnknownData00 = 0x0260;
		public const int bDeprecatedSpringOffsetMode = 0x0268;
		public const int UnknownData01 = 0x0269;
		public const int TirePunctured = 0x0270;
		public const int WheelSetups = 0x0280;
		public const int Mass = 0x0290;
		public const int DragCoefficient = 0x0294;
		public const int ChassisWidth = 0x0298;
		public const int ChassisHeight = 0x029C;
		public const int bReverseAsBrake = 0x02A0;
		public const int UnknownData02 = 0x02A1;
		public const int DragArea = 0x02A4;
		public const int EstimatedMaxEngineSpeed = 0x02A8;
		public const int MaxEngineRPM = 0x02AC;
		public const int DebugDragMagnitude = 0x02B0;
		public const int InertiaTensorScale = 0x02B4;
		public const int MinNormalizedTireLoad = 0x02C0;
		public const int MinNormalizedTireLoadFiltered = 0x02C4;
		public const int MaxNormalizedTireLoad = 0x02C8;
		public const int MaxNormalizedTireLoadFiltered = 0x02CC;
		public const int ThresholdLongitudinalSpeed = 0x02D0;
		public const int LowForwardSpeedSubStepCount = 0x02D4;
		public const int HighForwardSpeedSubStepCount = 0x02D8;
		public const int UnknownData03 = 0x02DC;
		public const int Wheels = 0x02E0;
		public const int UnknownData04 = 0x02F0;
		public const int bUseRVOAvoidance = 0x0308;
		public const int UnknownData05 = 0x0309;
		public const int RVOAvoidanceRadius = 0x030C;
		public const int RVOAvoidanceHeight = 0x0310;
		public const int AvoidanceConsiderationRadius = 0x0314;
		public const int RVOSteeringStep = 0x0318;
		public const int RVOThrottleStep = 0x031C;
		public const int AvoidanceUID = 0x0320;
		public const int AvoidanceGroup = 0x0324;
		public const int GroupsToAvoid = 0x0328;
		public const int GroupsToIgnore = 0x032C;
		public const int AvoidanceWeight = 0x0330;
		public const int PendingLaunchVelocity = 0x0334;
		public const int ReplicatedState = 0x0340;
		public const int UnknownData06 = 0x0354;
		public const int RawSteeringInput = 0x0358;
		public const int RawThrottleInput = 0x035C;
		public const int RawBrakeInput = 0x0360;
		public const int bRawHandbrakeInput = 0x0364;
		public const int bRawGearUpInput = 0x0364;
		public const int bRawGearDownInput = 0x0364;
		public const int UnknownData07 = 0x0365;
		public const int SteeringInput = 0x0368;
		public const int ThrottleInput = 0x036C;
		public const int BrakeInput = 0x0370;
		public const int HandbrakeInput = 0x0374;
		public const int IdleBrakeInput = 0x0378;
		public const int StopThreshold = 0x037C;
		public const int WrongDirectionThreshold = 0x0380;
		public const int ThrottleInputRate = 0x0384;
		public const int BrakeInputRate = 0x038C;
		public const int HandbrakeInputRate = 0x0394;
		public const int SteeringInputRate = 0x039C;
		public const int bWasAvoidanceUpdated = 0x03A4;
		public const int UnknownData08 = 0x03A5;
	}

	public class UWheeledVehicleMovementComponent4W
	{
		public const int EngineSetup = 0x03D0;
		public const int DifferentialSetup = 0x0460;
		public const int UnknownData00 = 0x047C;
		public const int TransmissionSetup = 0x0480;
		public const int SteeringCurve = 0x04B0;
		public const int AckermannAccuracy = 0x0528;
		public const int UnknownData01 = 0x052C;
	}

	public class UVehicleWheel
	{
		public const int CollisionMesh = 0x0028;
		public const int bDontCreateShape = 0x0030;
		public const int bAutoAdjustCollisionSize = 0x0031;
		public const int UnknownData00 = 0x0032;
		public const int Offset = 0x0034;
		public const int ShapeRadius = 0x0040;
		public const int ShapeWidth = 0x0044;
		public const int Mass = 0x0048;
		public const int DampingRate = 0x004C;
		public const int SteerAngle = 0x0050;
		public const int bAffectedByHandbrake = 0x0054;
		public const int UnknownData01 = 0x0055;
		public const int TireType = 0x0058;
		public const int TireConfig = 0x0060;
		public const int LatStiffMaxLoad = 0x0068;
		public const int LatStiffValue = 0x006C;
		public const int LongStiffValue = 0x0070;
		public const int SuspensionForceOffset = 0x0074;
		public const int SuspensionForceOffsetX = 0x0078;
		public const int SuspensionTravelDir = 0x007C;
		public const int TireForceOffset = 0x0088;
		public const int SuspensionMaxRaise = 0x0094;
		public const int SuspensionMaxDrop = 0x0098;
		public const int SuspensionNaturalFrequency = 0x009C;
		public const int SuspensionDampingRatio = 0x00A0;
		public const int MaxBrakeTorque = 0x00A4;
		public const int MaxHandBrakeTorque = 0x00A8;
		public const int QueryChannel = 0x00AC;
		public const int UnknownData02 = 0x00AD;
		public const int VehicleSim = 0x00B0;
		public const int WheelIndex = 0x00B8;
		public const int DebugLongSlip = 0x00BC;
		public const int DebugLatSlip = 0x00C0;
		public const int DebugNormalizedTireLoad = 0x00C4;
		public const int UnknownData03 = 0x00C8;
		public const int DebugWheelTorque = 0x00CC;
		public const int DebugLongForce = 0x00D0;
		public const int DebugLatForce = 0x00D4;
		public const int Location = 0x00D8;
		public const int OldLocation = 0x00E4;
		public const int Velocity = 0x00F0;
		public const int UnknownData04 = 0x00FC;
	}

	public class UVehicleAnimInstance
	{
		public const int UnknownData00 = 0x0378;
		public const int WheeledVehicleMovementComponent = 0x0870;
		public const int bUseSupsensionInterpolation = 0x0878;
		public const int UnknownData01 = 0x0879;
		public const int VehicleSuspensionInterpSpeed_ContactUpwards = 0x087C;
		public const int VehicleSuspensionInterpSpeed_Contact = 0x0880;
		public const int VehicleSuspensionInterpSpeed_NoContact = 0x0884;
		public const int UnknownData02 = 0x0888;
	}

	public class UTireConfig
	{
		public const int FrictionScale = 0x0030;
		public const int UnknownData00 = 0x0034;
		public const int TireFrictionScales = 0x0038;
		public const int UnknownData01 = 0x0048;
	}

}
