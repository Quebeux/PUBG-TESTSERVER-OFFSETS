/// <summary>
/// Auto-generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UCustomizableSkeletalComponent
	{
		public const int CustomizableObjectInstance = 0x03E0;
		public const int UnknownData00 = 0x03E8;
	}

	public class UCustomizableObjectInstance
	{
		public const int CustomizableObject = 0x0028;
		public const int SkeletalMesh = 0x0030;
		public const int State = 0x0038;
		public const int UnknownData00 = 0x003C;
		public const int BoolParameters = 0x0040;
		public const int IntParameters = 0x0050;
		public const int FloatParameters = 0x0060;
		public const int VectorParameters = 0x0070;
		public const int ProjectorParameters = 0x0080;
		public const int bBuildRawData = 0x0090;
		public const int bBuildRenderData = 0x0091;
		public const int UnknownData01 = 0x0092;
		public const int PrivateData = 0x01A8;
	}

	public class UCustomizableInstancePrivateData
	{
		public const int UnknownData00 = 0x0028;
		public const int GeneratedMaterials = 0x0030;
		public const int GeneratedMeshes = 0x0040;
		public const int GeneratedTextures = 0x0050;
		public const int UnknownData01 = 0x0060;
	}

	public class UCustomizableObject
	{
		public const int ReferenceSkeletalMesh = 0x0028;
		public const int ReferenceStaticMesh = 0x0030;
		public const int Relevancy = 0x0038;
		public const int bDisableTextureLayoutManagement = 0x0039;
		public const int UnknownData00 = 0x003A;
		public const int ReferencedMaterials = 0x0040;
		public const int ImageProperties = 0x0050;
		public const int GroupNodeMap = 0x0060;
		public const int CompileOptions = 0x00B0;
		public const int VersionId = 0x00BC;
		public const int UnknownData01 = 0x00CC;
		public const int ParameterProperties = 0x00D0;
		public const int UnknownData02 = 0x00E0;
	}

	public class UCustomizableObjectSystem
	{
		public const int UnknownData00 = 0x0028;
		public const int TextureTrackerArray = 0x0050;
		public const int ProtectedCachedTextures = 0x0060;
		public const int UnknownData01 = 0x0070;
	}

}
