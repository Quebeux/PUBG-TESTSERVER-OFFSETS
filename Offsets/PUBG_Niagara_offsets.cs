/// <summary>
/// Auto-generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class ANiagaraActor
	{
		public const int NiagaraComponent = 0x03B0;
	}

	public class UNiagaraComponent
	{
		public const int UnknownData00 = 0x0830;
		public const int EffectParameterLocalOverrides = 0x0840;
		public const int EffectDataInterfaceLocalOverrides = 0x0850;
		public const int InstanceDataInterfaces = 0x0860;
		public const int bRenderingEnabled = 0x0870;
		public const int UnknownData01 = 0x0871;
	}

	public class UNiagaraDataInterfaceCurve
	{
		public const int Curve = 0x0028;
	}

	public class UNiagaraDataInterfaceVectorCurve
	{
		public const int XCurve = 0x0028;
		public const int YCurve = 0x0098;
		public const int ZCurve = 0x0108;
	}

	public class UNiagaraDataInterfaceColorCurve
	{
		public const int RedCurve = 0x0028;
		public const int GreenCurve = 0x0098;
		public const int BlueCurve = 0x0108;
		public const int AlphaCurve = 0x0178;
	}

	public class UNiagaraDataInterfaceSpline
	{
		public const int Source = 0x0028;
		public const int UnknownData00 = 0x0030;
	}

	public class UNiagaraDataInterfaceStaticMesh
	{
		public const int DefaultMesh = 0x0028;
		public const int Source = 0x0030;
		public const int SectionFilter = 0x0038;
		public const int bEnableVertexColorRangeSorting = 0x00A0;
		public const int UnknownData00 = 0x00A1;
	}

	public class UNiagaraEffect
	{
		public const int EmitterHandles = 0x0028;
		public const int EffectScript = 0x0038;
		public const int ParameterBindings = 0x0040;
		public const int DataInterfaceBindings = 0x0050;
		public const int InternalEmitterVariableBindings = 0x0060;
	}

	public class UNiagaraLightRendererProperties
	{
		public const int RadiusScale = 0x0028;
		public const int ColorAdd = 0x002C;
	}

	public class UNiagaraMeshRendererProperties
	{
		public const int ParticleMesh = 0x0028;
	}

	public class UNiagaraSpriteRendererProperties
	{
		public const int SubImageSize = 0x0028;
		public const int Alignment = 0x0030;
		public const int FacingMode = 0x0031;
		public const int UnknownData00 = 0x0032;
		public const int CustomFacingVectorMask = 0x0034;
		public const int SortMode = 0x0040;
		public const int UnknownData01 = 0x0041;
	}

	public class UNiagaraScript
	{
		public const int ByteCode = 0x0028;
		public const int Parameters = 0x0038;
		public const int InternalParameters = 0x0048;
		public const int Attributes = 0x0058;
		public const int EventReceivers = 0x0068;
		public const int EventGenerators = 0x0078;
		public const int DataUsage = 0x0088;
		public const int Usage = 0x0089;
		public const int UnknownData00 = 0x008A;
		public const int DataInterfaceInfo = 0x0090;
		public const int CalledVMExternalFunctions = 0x00A0;
		public const int NumericOutputTypeSelectionMode = 0x00B0;
		public const int UnknownData01 = 0x00B1;
		public const int StatScopes = 0x00D8;
	}

	public class UNiagaraEventReceiverEmitterAction_SpawnParticles
	{
		public const int NumParticles = 0x0028;
		public const int UnknownData00 = 0x002C;
	}

	public class UNiagaraEmitterProperties
	{
		public const int SpawnRate = 0x0028;
		public const int bLocalSpace = 0x002C;
		public const int UnknownData00 = 0x002D;
		public const int Material = 0x0030;
		public const int StartTime = 0x0038;
		public const int EndTime = 0x003C;
		public const int NumLoops = 0x0040;
		public const int CollisionMode = 0x0044;
		public const int UnknownData01 = 0x0045;
		public const int RendererProperties = 0x0048;
		public const int UpdateScriptProps = 0x0050;
		public const int SpawnScriptProps = 0x0078;
		public const int EventHandlerScriptProps = 0x00A0;
		public const int Bursts = 0x00F0;
		public const int bInterpolatedSpawning = 0x0100;
		public const int UnknownData02 = 0x0101;
	}

	public class UNiagaraScriptSourceBase
	{
		public const int UnknownData00 = 0x0028;
	}

	public class UNiagaraSettings
	{
		public const int DefaultEffect = 0x0038;
		public const int DefaultEmitter = 0x0048;
		public const int DefaultScript = 0x0058;
		public const int AdditionalParameterTypes = 0x0068;
		public const int AdditionalPayloadTypes = 0x0078;
	}

}
