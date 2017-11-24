/// <summary>
/// Auto-generated offsets targetting PUBG v 3.2.12
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class ULandscapeComponent
	{
		public const int ComponentSizeQuads = 0x0830;
		public const int SubsectionSizeQuads = 0x0834;
		public const int NumSubsections = 0x0838;
		public const int UnknownData00 = 0x083C;
		public const int OverrideMaterial = 0x0840;
		public const int OverrideHoleMaterial = 0x0848;
		public const int MaterialInstances = 0x0850;
		public const int WeightmapLayerAllocations = 0x0860;
		public const int WeightmapTextures = 0x0870;
		public const int XYOffsetmapTexture = 0x0880;
		public const int UnknownData01 = 0x0888;
		public const int WeightmapScaleBias = 0x0890;
		public const int WeightmapSubsectionOffset = 0x08A0;
		public const int UnknownData02 = 0x08A4;
		public const int HeightmapScaleBias = 0x08B0;
		public const int HeightmapTexture = 0x08C0;
		public const int CachedLocalBox = 0x08C8;
		public const int CollisionComponent = 0x08E4;
		public const int MapBuildDataId = 0x0900;
		public const int IrrelevantLights = 0x0910;
		public const int CollisionMipLevel = 0x0920;
		public const int SimpleCollisionMipLevel = 0x0924;
		public const int NegativeZBoundsExtension = 0x0928;
		public const int PositiveZBoundsExtension = 0x092C;
		public const int StaticLightingResolution = 0x0930;
		public const int ForcedLOD = 0x0934;
		public const int LODBias = 0x0938;
		public const int StateId = 0x093C;
		public const int BakedTextureMaterialGuid = 0x094C;
		public const int UnknownData03 = 0x095C;
		public const int GIBakedBaseColorTexture = 0x0960;
		public const int bRemoveGrass = 0x0968;
		public const int MobileBlendableLayerMask = 0x0969;
		public const int UnknownData04 = 0x096A;
		public const int MobileMaterialInterface = 0x0970;
		public const int MobileWeightNormalmapTexture = 0x0978;
		public const int UnknownData05 = 0x0980;
	}

	public class ALandscapeGizmoActiveActor
	{
		public const int UnknownData00 = 0x03B0;
	}

	public class ULandscapeGrassType
	{
		public const int GrassVarieties = 0x0028;
		public const int GrassMesh = 0x0038;
		public const int GrassDensity = 0x0040;
		public const int PlacementJitter = 0x0044;
		public const int StartCullDistance = 0x0048;
		public const int EndCullDistance = 0x004C;
		public const int RandomRotation = 0x0050;
		public const int AlignToSurface = 0x0051;
		public const int UnknownData00 = 0x0052;
	}

	public class ULandscapeHeightfieldCollisionComponent
	{
		public const int UnknownData00 = 0x0830;
		public const int SectionBaseX = 0x0838;
		public const int SectionBaseY = 0x083C;
		public const int CollisionSizeQuads = 0x0840;
		public const int CollisionScale = 0x0844;
		public const int SimpleCollisionSizeQuads = 0x0848;
		public const int UnknownData01 = 0x084C;
		public const int CollisionQuadFlags = 0x0850;
		public const int HeightfieldGuid = 0x0860;
		public const int CachedLocalBox = 0x0870;
		public const int RenderComponent = 0x088C;
		public const int UnknownData02 = 0x08A8;
		public const int CookedPhysicalMaterials = 0x08B8;
		public const int UnknownData03 = 0x08C8;
	}

	public class ULandscapeMeshCollisionComponent
	{
		public const int UnknownData00 = 0x0910;
	}

	public class ULandscapeInfo
	{
		public const int LandscapeActor = 0x0028;
		public const int LandscapeGuid = 0x0044;
		public const int ComponentSizeQuads = 0x0054;
		public const int SubsectionSizeQuads = 0x0058;
		public const int ComponentNumSubsections = 0x005C;
		public const int DrawScale = 0x0060;
		public const int UnknownData00 = 0x006C;
		public const int UnknownData01 = 0x006C;
		public const int UnknownData02 = 0x0110;
	}

	public class ULandscapeInfoMap
	{
		public const int UnknownData00 = 0x0028;
	}

	public class ULandscapeLayerInfoObject
	{
		public const int LayerName = 0x0028;
		public const int PhysMaterial = 0x0030;
		public const int Hardness = 0x0038;
		public const int LayerUsageDebugColor = 0x003C;
		public const int UnknownData00 = 0x004C;
	}

	public class ULandscapeMaterialInstanceConstant
	{
		public const int bIsLayerThumbnail = 0x01B0;
		public const int bDisableTessellation = 0x01B0;
		public const int UnknownData00 = 0x01B1;
	}

	public class ALandscapeMeshProxyActor
	{
		public const int LandscapeMeshProxyComponent = 0x03B0;
	}

	public class ULandscapeMeshProxyComponent
	{
		public const int LandscapeGuid = 0x09C0;
		public const int ProxyComponentBases = 0x09D0;
		public const int ProxyLOD = 0x09E0;
		public const int UnknownData00 = 0x09E1;
	}

	public class ALandscapeProxy
	{
		public const int SplineComponent = 0x03B0;
		public const int LandscapeGuid = 0x03B8;
		public const int LandscapeSectionOffset = 0x03C8;
		public const int MaxLODLevel = 0x03D0;
		public const int LODDistanceFactor = 0x03D4;
		public const int LODFalloff = 0x03D8;
		public const int UnknownData00 = 0x03D9;
		public const int StaticLightingLOD = 0x03DC;
		public const int DefaultPhysMaterial = 0x03E0;
		public const int StreamingDistanceMultiplier = 0x03E8;
		public const int UnknownData01 = 0x03EC;
		public const int LandscapeMaterial = 0x03F0;
		public const int LandscapeHoleMaterial = 0x03F8;
		public const int NegativeZBoundsExtension = 0x0400;
		public const int PositiveZBoundsExtension = 0x0404;
		public const int LandscapeComponents = 0x0408;
		public const int CollisionComponents = 0x0418;
		public const int FoliageComponents = 0x0428;
		public const int UnknownData02 = 0x0438;
		public const int bHasLandscapeGrass = 0x0498;
		public const int UnknownData03 = 0x0499;
		public const int StaticLightingResolution = 0x049C;
		public const int bCastStaticShadow = 0x04A0;
		public const int bCastShadowAsTwoSided = 0x04A0;
		public const int bCastFarShadow = 0x04A0;
		public const int UnknownData04 = 0x04A1;
		public const int LightingChannels = 0x04A4;
		public const int UnknownData05 = 0x04A7;
		public const int bUseMaterialPositionOffsetInStaticLighting = 0x04A8;
		public const int bRenderCustomDepth = 0x04A8;
		public const int UnknownData06 = 0x04A9;
		public const int CustomDepthStencilValue = 0x04AC;
		public const int LightmassSettings = 0x04B0;
		public const int CollisionMipLevel = 0x04C8;
		public const int SimpleCollisionMipLevel = 0x04CC;
		public const int CollisionThickness = 0x04D0;
		public const int UnknownData07 = 0x04D4;
		public const int BodyInstance = 0x04E0;
		public const int bGenerateOverlapEvents = 0x0720;
		public const int bBakeMaterialPositionOffsetIntoCollision = 0x0720;
		public const int UnknownData08 = 0x0721;
		public const int ComponentSizeQuads = 0x0724;
		public const int SubsectionSizeQuads = 0x0728;
		public const int NumSubsections = 0x072C;
		public const int bUsedForNavigation = 0x0730;
		public const int UnknownData09 = 0x0731;
		public const int NavigationGeometryGatheringMode = 0x0734;
		public const int bUseLandscapeForCullingInvisibleHLODVertices = 0x0735;
		public const int UnknownData10 = 0x0736;
	}

	public class ALandscapeStreamingProxy
	{
		public const int UnknownData00 = 0x0810;
	}

	public class ULandscapeSplinesComponent
	{
		public const int UnknownData00 = 0x0830;
		public const int Segments = 0x0838;
		public const int CookedForeignMeshComponents = 0x0848;
		public const int UnknownData01 = 0x0858;
	}

	public class ULandscapeSplineSegment
	{
		public const int Connections = 0x0028;
		public const int SplineInfo = 0x0058;
		public const int Points = 0x0070;
		public const int Bounds = 0x0080;
		public const int UnknownData00 = 0x009C;
		public const int LocalMeshComponents = 0x00A0;
	}

	public class ULandscapeSplineControlPoint
	{
		public const int Location = 0x0028;
		public const int Rotation = 0x0034;
		public const int Width = 0x0040;
		public const int SideFalloff = 0x0044;
		public const int EndFalloff = 0x0048;
		public const int UnknownData00 = 0x004C;
		public const int ConnectedSegments = 0x0050;
		public const int Points = 0x0060;
		public const int Bounds = 0x0070;
		public const int UnknownData01 = 0x008C;
		public const int LocalMeshComponent = 0x0090;
	}

	public class UMaterialExpressionLandscapeGrassOutput
	{
		public const int GrassTypes = 0x0060;
	}

	public class UMaterialExpressionLandscapeLayerBlend
	{
		public const int Layers = 0x0060;
		public const int ExpressionGUID = 0x0070;
	}

	public class UMaterialExpressionLandscapeLayerCoords
	{
		public const int MappingType = 0x0060;
		public const int CustomUVType = 0x0061;
		public const int UnknownData00 = 0x0062;
		public const int MappingScale = 0x0064;
		public const int MappingRotation = 0x0068;
		public const int MappingPanU = 0x006C;
		public const int MappingPanV = 0x0070;
		public const int UnknownData01 = 0x0074;
	}

	public class UMaterialExpressionLandscapeLayerSample
	{
		public const int ParameterName = 0x0060;
		public const int PreviewWeight = 0x0068;
		public const int ExpressionGUID = 0x006C;
		public const int UnknownData00 = 0x007C;
	}

	public class UMaterialExpressionLandscapeLayerSwitch
	{
		public const int LayerUsed = 0x0060;
		public const int LayerNotUsed = 0x0098;
		public const int ParameterName = 0x00D0;
		public const int PreviewUsed = 0x00D8;
		public const int UnknownData00 = 0x00D9;
		public const int ExpressionGUID = 0x00DC;
		public const int UnknownData01 = 0x00EC;
	}

	public class UMaterialExpressionLandscapeLayerWeight
	{
		public const int Base = 0x0060;
		public const int Layer = 0x0098;
		public const int ParameterName = 0x00D0;
		public const int PreviewWeight = 0x00D8;
		public const int ConstBase = 0x00DC;
		public const int ExpressionGUID = 0x00E8;
	}

	public class UMaterialExpressionLandscapeVisibilityMask
	{
		public const int ExpressionGUID = 0x0060;
	}

}
