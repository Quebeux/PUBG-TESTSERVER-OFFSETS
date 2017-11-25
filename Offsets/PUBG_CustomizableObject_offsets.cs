/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UCustomizableSkeletalComponent
	{
		///<summary>UCustomizableObjectInstance *</summary>
		public const int CustomizableObjectInstance = 0x03E0;

		///<summary>unsigned char[0x48]</summary>
		public const int UnknownData00 = 0x03E8;

	}

	public class UCustomizableObjectInstance
	{
		///<summary>UCustomizableObject *</summary>
		public const int CustomizableObject = 0x0028;

		///<summary>USkeletalMesh *</summary>
		public const int SkeletalMesh = 0x0030;

		///<summary>int</summary>
		public const int State = 0x0038;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x003C;

		///<summary>TArray<FCustomizableObjectBoolParameterValue></summary>
		public const int BoolParameters = 0x0040;

		///<summary>TArray<FCustomizableObjectIntParameterValue></summary>
		public const int IntParameters = 0x0050;

		///<summary>TArray<FCustomizableObjectFloatParameterValue></summary>
		public const int FloatParameters = 0x0060;

		///<summary>TArray<FCustomizableObjectVectorParameterValue></summary>
		public const int VectorParameters = 0x0070;

		///<summary>TArray<FCustomizableObjectProjectorParameterValue></summary>
		public const int ProjectorParameters = 0x0080;

		///<summary>bool</summary>
		public const int bBuildRawData = 0x0090;

		///<summary>bool</summary>
		public const int bBuildRenderData = 0x0091;

		///<summary>unsigned char[0x116]</summary>
		public const int UnknownData01 = 0x0092;

		///<summary>UCustomizableInstancePrivateData *</summary>
		public const int PrivateData = 0x01A8;

	}

	public class UCustomizableInstancePrivateData
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>TArray<FGeneratedMaterial></summary>
		public const int GeneratedMaterials = 0x0030;

		///<summary>TArray<FGeneratedMesh></summary>
		public const int GeneratedMeshes = 0x0040;

		///<summary>TArray<FGeneratedTexture></summary>
		public const int GeneratedTextures = 0x0050;

		///<summary>unsigned char[0xB0]</summary>
		public const int UnknownData01 = 0x0060;

	}

	public class UCustomizableObject
	{
		///<summary>USkeletalMesh *</summary>
		public const int ReferenceSkeletalMesh = 0x0028;

		///<summary>UStaticMesh *</summary>
		public const int ReferenceStaticMesh = 0x0030;

		///<summary>ECustomizableObjectRelevancy</summary>
		public const int Relevancy = 0x0038;

		///<summary>bool</summary>
		public const int bDisableTextureLayoutManagement = 0x0039;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData00 = 0x003A;

		///<summary>TArray<UMaterialInterface * ></summary>
		public const int ReferencedMaterials = 0x0040;

		///<summary>TArray<FMutableModelImageProperties></summary>
		public const int ImageProperties = 0x0050;

		///<summary>TMap<FString,FCustomizableObjectIdPair></summary>
		public const int GroupNodeMap = 0x0060;

		///<summary>FCompilationOptions</summary>
		public const int CompileOptions = 0x00B0;

		///<summary>FGuid</summary>
		public const int VersionId = 0x00BC;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x00CC;

		///<summary>TArray<FMutableModelParameterProperties></summary>
		public const int ParameterProperties = 0x00D0;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData02 = 0x00E0;

	}

	public class UCustomizableObjectSystem
	{
		///<summary>unsigned char[0x28]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>TArray<FMutableTextureTracker></summary>
		public const int TextureTrackerArray = 0x0050;

		///<summary>TArray<UTexture2D * ></summary>
		public const int ProtectedCachedTextures = 0x0060;

		///<summary>unsigned char[0x80]</summary>
		public const int UnknownData01 = 0x0070;

	}

}
