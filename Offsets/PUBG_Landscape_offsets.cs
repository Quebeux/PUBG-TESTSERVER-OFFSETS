/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class ULandscapeComponent
	{
		///<summary><![CDATA[int]]></summary>
		public const int ComponentSizeQuads = 0x0830;

		///<summary><![CDATA[int]]></summary>
		public const int SubsectionSizeQuads = 0x0834;

		///<summary><![CDATA[int]]></summary>
		public const int NumSubsections = 0x0838;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x083C;

		///<summary><![CDATA[UMaterialInterface *]]></summary>
		public const int OverrideMaterial = 0x0840;

		///<summary><![CDATA[UMaterialInterface *]]></summary>
		public const int OverrideHoleMaterial = 0x0848;

		///<summary><![CDATA[TArray<UMaterialInstanceConstant * >]]></summary>
		public const int MaterialInstances = 0x0850;

		///<summary><![CDATA[TArray<FWeightmapLayerAllocationInfo>]]></summary>
		public const int WeightmapLayerAllocations = 0x0860;

		///<summary><![CDATA[TArray<UTexture2D * >]]></summary>
		public const int WeightmapTextures = 0x0870;

		///<summary><![CDATA[UTexture2D *]]></summary>
		public const int XYOffsetmapTexture = 0x0880;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x0888;

		///<summary><![CDATA[FVector4]]></summary>
		public const int WeightmapScaleBias = 0x0890;

		///<summary><![CDATA[float]]></summary>
		public const int WeightmapSubsectionOffset = 0x08A0;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData02 = 0x08A4;

		///<summary><![CDATA[FVector4]]></summary>
		public const int HeightmapScaleBias = 0x08B0;

		///<summary><![CDATA[UTexture2D *]]></summary>
		public const int HeightmapTexture = 0x08C0;

		///<summary><![CDATA[FBox]]></summary>
		public const int CachedLocalBox = 0x08C8;

		///<summary><![CDATA[TLazyObjectPtr<ULandscapeHeightfieldCollisionComponent>]]></summary>
		public const int CollisionComponent = 0x08E4;

		///<summary><![CDATA[FGuid]]></summary>
		public const int MapBuildDataId = 0x0900;

		///<summary><![CDATA[TArray<FGuid>]]></summary>
		public const int IrrelevantLights = 0x0910;

		///<summary><![CDATA[int]]></summary>
		public const int CollisionMipLevel = 0x0920;

		///<summary><![CDATA[int]]></summary>
		public const int SimpleCollisionMipLevel = 0x0924;

		///<summary><![CDATA[float]]></summary>
		public const int NegativeZBoundsExtension = 0x0928;

		///<summary><![CDATA[float]]></summary>
		public const int PositiveZBoundsExtension = 0x092C;

		///<summary><![CDATA[float]]></summary>
		public const int StaticLightingResolution = 0x0930;

		///<summary><![CDATA[int]]></summary>
		public const int ForcedLOD = 0x0934;

		///<summary><![CDATA[int]]></summary>
		public const int LODBias = 0x0938;

		///<summary><![CDATA[FGuid]]></summary>
		public const int StateId = 0x093C;

		///<summary><![CDATA[FGuid]]></summary>
		public const int BakedTextureMaterialGuid = 0x094C;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData03 = 0x095C;

		///<summary><![CDATA[UTexture2D *]]></summary>
		public const int GIBakedBaseColorTexture = 0x0960;

		///<summary><![CDATA[bool]]></summary>
		public const int bRemoveGrass = 0x0968;

		///<summary><![CDATA[unsigned char]]></summary>
		public const int MobileBlendableLayerMask = 0x0969;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData04 = 0x096A;

		///<summary><![CDATA[UMaterialInterface *]]></summary>
		public const int MobileMaterialInterface = 0x0970;

		///<summary><![CDATA[UTexture2D *]]></summary>
		public const int MobileWeightNormalmapTexture = 0x0978;

		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData05 = 0x0980;

	}

	public class ALandscapeGizmoActiveActor
	{
		///<summary><![CDATA[unsigned char[0x50]]]></summary>
		public const int UnknownData00 = 0x03B0;

	}

	public class ULandscapeGrassType
	{
		///<summary><![CDATA[TArray<FGrassVariety>]]></summary>
		public const int GrassVarieties = 0x0028;

		///<summary><![CDATA[UStaticMesh *]]></summary>
		public const int GrassMesh = 0x0038;

		///<summary><![CDATA[float]]></summary>
		public const int GrassDensity = 0x0040;

		///<summary><![CDATA[float]]></summary>
		public const int PlacementJitter = 0x0044;

		///<summary><![CDATA[int]]></summary>
		public const int StartCullDistance = 0x0048;

		///<summary><![CDATA[int]]></summary>
		public const int EndCullDistance = 0x004C;

		///<summary><![CDATA[bool]]></summary>
		public const int RandomRotation = 0x0050;

		///<summary><![CDATA[bool]]></summary>
		public const int AlignToSurface = 0x0051;

		///<summary><![CDATA[unsigned char[0xE]]]></summary>
		public const int UnknownData00 = 0x0052;

	}

	public class ULandscapeHeightfieldCollisionComponent
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0830;

		///<summary><![CDATA[int]]></summary>
		public const int SectionBaseX = 0x0838;

		///<summary><![CDATA[int]]></summary>
		public const int SectionBaseY = 0x083C;

		///<summary><![CDATA[int]]></summary>
		public const int CollisionSizeQuads = 0x0840;

		///<summary><![CDATA[float]]></summary>
		public const int CollisionScale = 0x0844;

		///<summary><![CDATA[int]]></summary>
		public const int SimpleCollisionSizeQuads = 0x0848;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x084C;

		///<summary><![CDATA[TArray<unsigned char>]]></summary>
		public const int CollisionQuadFlags = 0x0850;

		///<summary><![CDATA[FGuid]]></summary>
		public const int HeightfieldGuid = 0x0860;

		///<summary><![CDATA[FBox]]></summary>
		public const int CachedLocalBox = 0x0870;

		///<summary><![CDATA[TLazyObjectPtr<ULandscapeComponent>]]></summary>
		public const int RenderComponent = 0x088C;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData02 = 0x08A8;

		///<summary><![CDATA[TArray<UPhysicalMaterial * >]]></summary>
		public const int CookedPhysicalMaterials = 0x08B8;

		///<summary><![CDATA[unsigned char[0x48]]]></summary>
		public const int UnknownData03 = 0x08C8;

	}

	public class ULandscapeMeshCollisionComponent
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0910;

	}

	public class ULandscapeInfo
	{
		///<summary><![CDATA[TLazyObjectPtr<ALandscape>]]></summary>
		public const int LandscapeActor = 0x0028;

		///<summary><![CDATA[FGuid]]></summary>
		public const int LandscapeGuid = 0x0044;

		///<summary><![CDATA[int]]></summary>
		public const int ComponentSizeQuads = 0x0054;

		///<summary><![CDATA[int]]></summary>
		public const int SubsectionSizeQuads = 0x0058;

		///<summary><![CDATA[int]]></summary>
		public const int ComponentNumSubsections = 0x005C;

		///<summary><![CDATA[FVector]]></summary>
		public const int DrawScale = 0x0060;

		///<summary><![CDATA[unsigned char[0x54]]]></summary>
		public const int UnknownData00 = 0x006C;

		///<summary><![CDATA[unsigned char[0x50]]]></summary>
		public const int UnknownData01 = 0x006C;

		///<summary><![CDATA[unsigned char[0xF0]]]></summary>
		public const int UnknownData02 = 0x0110;

	}

	public class ULandscapeInfoMap
	{
		///<summary><![CDATA[unsigned char[0x50]]]></summary>
		public const int UnknownData00 = 0x0028;

	}

	public class ULandscapeLayerInfoObject
	{
		///<summary><![CDATA[FName]]></summary>
		public const int LayerName = 0x0028;

		///<summary><![CDATA[UPhysicalMaterial *]]></summary>
		public const int PhysMaterial = 0x0030;

		///<summary><![CDATA[float]]></summary>
		public const int Hardness = 0x0038;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int LayerUsageDebugColor = 0x003C;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x004C;

	}

	public class ULandscapeMaterialInstanceConstant
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsLayerThumbnail = 0x01B0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDisableTessellation = 0x01B0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x01B1;

	}

	public class ALandscapeMeshProxyActor
	{
		///<summary><![CDATA[ULandscapeMeshProxyComponent *]]></summary>
		public const int LandscapeMeshProxyComponent = 0x03B0;

	}

	public class ULandscapeMeshProxyComponent
	{
		///<summary><![CDATA[FGuid]]></summary>
		public const int LandscapeGuid = 0x09C0;

		///<summary><![CDATA[TArray<FIntPoint>]]></summary>
		public const int ProxyComponentBases = 0x09D0;

		///<summary><![CDATA[int8_t]]></summary>
		public const int ProxyLOD = 0x09E0;

		///<summary><![CDATA[unsigned char[0xF]]]></summary>
		public const int UnknownData00 = 0x09E1;

	}

	public class ALandscapeProxy
	{
		///<summary><![CDATA[ULandscapeSplinesComponent *]]></summary>
		public const int SplineComponent = 0x03B0;

		///<summary><![CDATA[FGuid]]></summary>
		public const int LandscapeGuid = 0x03B8;

		///<summary><![CDATA[FIntPoint]]></summary>
		public const int LandscapeSectionOffset = 0x03C8;

		///<summary><![CDATA[int]]></summary>
		public const int MaxLODLevel = 0x03D0;

		///<summary><![CDATA[float]]></summary>
		public const int LODDistanceFactor = 0x03D4;

		///<summary><![CDATA[TEnumAsByte<ELandscapeLODFalloff>]]></summary>
		public const int LODFalloff = 0x03D8;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x03D9;

		///<summary><![CDATA[int]]></summary>
		public const int StaticLightingLOD = 0x03DC;

		///<summary><![CDATA[UPhysicalMaterial *]]></summary>
		public const int DefaultPhysMaterial = 0x03E0;

		///<summary><![CDATA[float]]></summary>
		public const int StreamingDistanceMultiplier = 0x03E8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x03EC;

		///<summary><![CDATA[UMaterialInterface *]]></summary>
		public const int LandscapeMaterial = 0x03F0;

		///<summary><![CDATA[UMaterialInterface *]]></summary>
		public const int LandscapeHoleMaterial = 0x03F8;

		///<summary><![CDATA[float]]></summary>
		public const int NegativeZBoundsExtension = 0x0400;

		///<summary><![CDATA[float]]></summary>
		public const int PositiveZBoundsExtension = 0x0404;

		///<summary><![CDATA[TArray<ULandscapeComponent * >]]></summary>
		public const int LandscapeComponents = 0x0408;

		///<summary><![CDATA[TArray<ULandscapeHeightfieldCollisionComponent * >]]></summary>
		public const int CollisionComponents = 0x0418;

		///<summary><![CDATA[TArray<UHierarchicalInstancedStaticMeshComponent * >]]></summary>
		public const int FoliageComponents = 0x0428;

		///<summary><![CDATA[unsigned char[0x60]]]></summary>
		public const int UnknownData02 = 0x0438;

		///<summary><![CDATA[bool]]></summary>
		public const int bHasLandscapeGrass = 0x0498;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData03 = 0x0499;

		///<summary><![CDATA[float]]></summary>
		public const int StaticLightingResolution = 0x049C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCastStaticShadow = 0x04A0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCastShadowAsTwoSided = 0x04A0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bCastFarShadow = 0x04A0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData04 = 0x04A1;

		///<summary><![CDATA[FLightingChannels]]></summary>
		public const int LightingChannels = 0x04A4;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData05 = 0x04A7;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseMaterialPositionOffsetInStaticLighting = 0x04A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bRenderCustomDepth = 0x04A8;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData06 = 0x04A9;

		///<summary><![CDATA[int]]></summary>
		public const int CustomDepthStencilValue = 0x04AC;

		///<summary><![CDATA[FLightmassPrimitiveSettings]]></summary>
		public const int LightmassSettings = 0x04B0;

		///<summary><![CDATA[int]]></summary>
		public const int CollisionMipLevel = 0x04C8;

		///<summary><![CDATA[int]]></summary>
		public const int SimpleCollisionMipLevel = 0x04CC;

		///<summary><![CDATA[float]]></summary>
		public const int CollisionThickness = 0x04D0;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData07 = 0x04D4;

		///<summary><![CDATA[FBodyInstance]]></summary>
		public const int BodyInstance = 0x04E0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bGenerateOverlapEvents = 0x0720;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bBakeMaterialPositionOffsetIntoCollision = 0x0720;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData08 = 0x0721;

		///<summary><![CDATA[int]]></summary>
		public const int ComponentSizeQuads = 0x0724;

		///<summary><![CDATA[int]]></summary>
		public const int SubsectionSizeQuads = 0x0728;

		///<summary><![CDATA[int]]></summary>
		public const int NumSubsections = 0x072C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUsedForNavigation = 0x0730;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData09 = 0x0731;

		///<summary><![CDATA[ENavDataGatheringMode]]></summary>
		public const int NavigationGeometryGatheringMode = 0x0734;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseLandscapeForCullingInvisibleHLODVertices = 0x0735;

		///<summary><![CDATA[unsigned char[0xDA]]]></summary>
		public const int UnknownData10 = 0x0736;

	}

	public class ALandscapeStreamingProxy
	{
		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData00 = 0x0810;

	}

	public class ULandscapeSplinesComponent
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0830;

		///<summary><![CDATA[TArray<ULandscapeSplineSegment * >]]></summary>
		public const int Segments = 0x0838;

		///<summary><![CDATA[TArray<UMeshComponent * >]]></summary>
		public const int CookedForeignMeshComponents = 0x0848;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x0858;

	}

	public class ULandscapeSplineSegment
	{
		///<summary><![CDATA[FLandscapeSplineSegmentConnection[0x2]]]></summary>
		public const int Connections = 0x0028;

		///<summary><![CDATA[FInterpCurveVector]]></summary>
		public const int SplineInfo = 0x0058;

		///<summary><![CDATA[TArray<FLandscapeSplineInterpPoint>]]></summary>
		public const int Points = 0x0070;

		///<summary><![CDATA[FBox]]></summary>
		public const int Bounds = 0x0080;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x009C;

		///<summary><![CDATA[TArray<USplineMeshComponent * >]]></summary>
		public const int LocalMeshComponents = 0x00A0;

	}

	public class ULandscapeSplineControlPoint
	{
		///<summary><![CDATA[FVector]]></summary>
		public const int Location = 0x0028;

		///<summary><![CDATA[FRotator]]></summary>
		public const int Rotation = 0x0034;

		///<summary><![CDATA[float]]></summary>
		public const int Width = 0x0040;

		///<summary><![CDATA[float]]></summary>
		public const int SideFalloff = 0x0044;

		///<summary><![CDATA[float]]></summary>
		public const int EndFalloff = 0x0048;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x004C;

		///<summary><![CDATA[TArray<FLandscapeSplineConnection>]]></summary>
		public const int ConnectedSegments = 0x0050;

		///<summary><![CDATA[TArray<FLandscapeSplineInterpPoint>]]></summary>
		public const int Points = 0x0060;

		///<summary><![CDATA[FBox]]></summary>
		public const int Bounds = 0x0070;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x008C;

		///<summary><![CDATA[UControlPointMeshComponent *]]></summary>
		public const int LocalMeshComponent = 0x0090;

	}

	public class UMaterialExpressionLandscapeGrassOutput
	{
		///<summary><![CDATA[TArray<FGrassInput>]]></summary>
		public const int GrassTypes = 0x0060;

	}

	public class UMaterialExpressionLandscapeLayerBlend
	{
		///<summary><![CDATA[TArray<FLayerBlendInput>]]></summary>
		public const int Layers = 0x0060;

		///<summary><![CDATA[FGuid]]></summary>
		public const int ExpressionGUID = 0x0070;

	}

	public class UMaterialExpressionLandscapeLayerCoords
	{
		///<summary><![CDATA[TEnumAsByte<ETerrainCoordMappingType>]]></summary>
		public const int MappingType = 0x0060;

		///<summary><![CDATA[TEnumAsByte<ELandscapeCustomizedCoordType>]]></summary>
		public const int CustomUVType = 0x0061;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x0062;

		///<summary><![CDATA[float]]></summary>
		public const int MappingScale = 0x0064;

		///<summary><![CDATA[float]]></summary>
		public const int MappingRotation = 0x0068;

		///<summary><![CDATA[float]]></summary>
		public const int MappingPanU = 0x006C;

		///<summary><![CDATA[float]]></summary>
		public const int MappingPanV = 0x0070;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x0074;

	}

	public class UMaterialExpressionLandscapeLayerSample
	{
		///<summary><![CDATA[FName]]></summary>
		public const int ParameterName = 0x0060;

		///<summary><![CDATA[float]]></summary>
		public const int PreviewWeight = 0x0068;

		///<summary><![CDATA[FGuid]]></summary>
		public const int ExpressionGUID = 0x006C;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x007C;

	}

	public class UMaterialExpressionLandscapeLayerSwitch
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int LayerUsed = 0x0060;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int LayerNotUsed = 0x0098;

		///<summary><![CDATA[FName]]></summary>
		public const int ParameterName = 0x00D0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int PreviewUsed = 0x00D8;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x00D9;

		///<summary><![CDATA[FGuid]]></summary>
		public const int ExpressionGUID = 0x00DC;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x00EC;

	}

	public class UMaterialExpressionLandscapeLayerWeight
	{
		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Base = 0x0060;

		///<summary><![CDATA[FExpressionInput]]></summary>
		public const int Layer = 0x0098;

		///<summary><![CDATA[FName]]></summary>
		public const int ParameterName = 0x00D0;

		///<summary><![CDATA[float]]></summary>
		public const int PreviewWeight = 0x00D8;

		///<summary><![CDATA[FVector]]></summary>
		public const int ConstBase = 0x00DC;

		///<summary><![CDATA[FGuid]]></summary>
		public const int ExpressionGUID = 0x00E8;

	}

	public class UMaterialExpressionLandscapeVisibilityMask
	{
		///<summary><![CDATA[FGuid]]></summary>
		public const int ExpressionGUID = 0x0060;

	}

}
