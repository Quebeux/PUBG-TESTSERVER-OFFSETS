/// <summary>
/// Auto-generated offsets targetting PUBG v 3.2.12
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UMaterialExpressionSpriteTextureSampler
	{
		public const int bSampleAdditionalTextures = 0x01B8;
		public const int UnknownData00 = 0x01B9;
		public const int AdditionalSlotIndex = 0x01BC;
		public const int SlotDisplayName = 0x01C0;
	}

	public class APaperCharacter
	{
		public const int Sprite = 0x07E0;
		public const int UnknownData00 = 0x07E8;
	}

	public class UPaperFlipbook
	{
		public const int FramesPerSecond = 0x0028;
		public const int UnknownData00 = 0x002C;
		public const int KeyFrames = 0x0030;
		public const int DefaultMaterial = 0x0040;
		public const int CollisionSource = 0x0048;
		public const int UnknownData01 = 0x0049;
	}

	public class APaperFlipbookActor
	{
		public const int RenderComponent = 0x03B0;
	}

	public class UPaperFlipbookComponent
	{
		public const int SourceFlipbook = 0x0930;
		public const int Material = 0x0938;
		public const int PlayRate = 0x0940;
		public const int bLooping = 0x0944;
		public const int bReversePlayback = 0x0944;
		public const int bPlaying = 0x0944;
		public const int UnknownData00 = 0x0945;
		public const int AccumulatedTime = 0x0948;
		public const int CachedFrameIndex = 0x094C;
		public const int SpriteColor = 0x0950;
		public const int CachedBodySetup = 0x0960;
		public const int OnFinishedPlaying = 0x0968;
		public const int UnknownData01 = 0x0978;
	}

	public class APaperGroupedSpriteActor
	{
		public const int RenderComponent = 0x03B0;
	}

	public class UPaperGroupedSpriteComponent
	{
		public const int InstanceMaterials = 0x0930;
		public const int PerInstanceSpriteData = 0x0940;
		public const int UnknownData00 = 0x0950;
	}

	public class UPaperRuntimeSettings
	{
		public const int bEnableSpriteAtlasGroups = 0x0028;
		public const int bEnableTerrainSplineEditing = 0x0029;
		public const int bResizeSpriteDataToMatchTextures = 0x002A;
		public const int UnknownData00 = 0x002B;
	}

	public class UPaperSprite
	{
		public const int UnknownData00 = 0x0028;
		public const int SourceUV = 0x0038;
		public const int SourceDimension = 0x0040;
		public const int SourceTexture = 0x0048;
		public const int AdditionalSourceTextures = 0x0050;
		public const int BakedSourceUV = 0x0060;
		public const int BakedSourceDimension = 0x0068;
		public const int BakedSourceTexture = 0x0070;
		public const int DefaultMaterial = 0x0078;
		public const int AlternateMaterial = 0x0080;
		public const int Sockets = 0x0088;
		public const int SpriteCollisionDomain = 0x0098;
		public const int UnknownData01 = 0x0099;
		public const int PixelsPerUnrealUnit = 0x009C;
		public const int BodySetup = 0x00A0;
		public const int AlternateMaterialSplitIndex = 0x00A8;
		public const int UnknownData02 = 0x00AC;
		public const int BakedRenderData = 0x00B0;
	}

	public class APaperSpriteActor
	{
		public const int RenderComponent = 0x03B0;
	}

	public class UPaperSpriteComponent
	{
		public const int SourceSprite = 0x0930;
		public const int MaterialOverride = 0x0938;
		public const int SpriteColor = 0x0940;
	}

	public class APaperTerrainActor
	{
		public const int DummyRoot = 0x03B0;
		public const int SplineComponent = 0x03B8;
		public const int RenderComponent = 0x03C0;
	}

	public class UPaperTerrainComponent
	{
		public const int bClosedSpline = 0x0830;
		public const int bFilledSpline = 0x0831;
		public const int UnknownData00 = 0x0832;
		public const int AssociatedSpline = 0x0838;
		public const int RandomSeed = 0x0840;
		public const int SegmentOverlapAmount = 0x0844;
		public const int TerrainColor = 0x0848;
		public const int ReparamStepsPerSegment = 0x0858;
		public const int SpriteCollisionDomain = 0x085C;
		public const int UnknownData01 = 0x085D;
		public const int CollisionThickness = 0x0860;
		public const int UnknownData02 = 0x0864;
		public const int CachedBodySetup = 0x0868;
		public const int UnknownData03 = 0x0870;
	}

	public class UPaperTerrainMaterial
	{
		public const int Rules = 0x0030;
		public const int InteriorFill = 0x0040;
	}

	public class UPaperTerrainSplineComponent
	{
		public const int UnknownData00 = 0x0910;
	}

	public class UPaperTileLayer
	{
		public const int LayerName = 0x0028;
		public const int LayerWidth = 0x0040;
		public const int LayerHeight = 0x0044;
		public const int bHiddenInGame = 0x0048;
		public const int bLayerCollides = 0x0048;
		public const int bOverrideCollisionThickness = 0x0048;
		public const int bOverrideCollisionOffset = 0x0048;
		public const int UnknownData00 = 0x0049;
		public const int CollisionThicknessOverride = 0x004C;
		public const int CollisionOffsetOverride = 0x0050;
		public const int LayerColor = 0x0054;
		public const int AllocatedWidth = 0x0064;
		public const int AllocatedHeight = 0x0068;
		public const int UnknownData01 = 0x006C;
		public const int AllocatedCells = 0x0070;
		public const int TileSet = 0x0080;
		public const int AllocatedGrid = 0x0088;
	}

	public class UPaperTileMap
	{
		public const int MapWidth = 0x0028;
		public const int MapHeight = 0x002C;
		public const int TileWidth = 0x0030;
		public const int TileHeight = 0x0034;
		public const int PixelsPerUnrealUnit = 0x0038;
		public const int SeparationPerTileX = 0x003C;
		public const int SeparationPerTileY = 0x0040;
		public const int SeparationPerLayer = 0x0044;
		public const int SelectedTileSet = 0x0048;
		public const int Material = 0x0068;
		public const int TileLayers = 0x0070;
		public const int CollisionThickness = 0x0080;
		public const int SpriteCollisionDomain = 0x0084;
		public const int ProjectionMode = 0x0085;
		public const int UnknownData00 = 0x0086;
		public const int HexSideLength = 0x0088;
		public const int UnknownData01 = 0x008C;
		public const int BodySetup = 0x0090;
		public const int LayerNameIndex = 0x0098;
		public const int UnknownData02 = 0x009C;
	}

	public class APaperTileMapActor
	{
		public const int RenderComponent = 0x03B0;
	}

	public class UPaperTileMapComponent
	{
		public const int MapWidth = 0x0930;
		public const int MapHeight = 0x0934;
		public const int TileWidth = 0x0938;
		public const int TileHeight = 0x093C;
		public const int DefaultLayerTileSet = 0x0940;
		public const int Material = 0x0948;
		public const int TileLayers = 0x0950;
		public const int TileMapColor = 0x0960;
		public const int UseSingleLayerIndex = 0x0970;
		public const int bUseSingleLayer = 0x0974;
		public const int UnknownData00 = 0x0975;
		public const int TileMap = 0x0978;
	}

	public class UPaperTileSet
	{
		public const int TileSize = 0x0028;
		public const int TileSheet = 0x0030;
		public const int BorderMargin = 0x0038;
		public const int PerTileSpacing = 0x0048;
		public const int DrawingOffset = 0x0050;
		public const int WidthInTiles = 0x0058;
		public const int HeightInTiles = 0x005C;
		public const int AllocatedWidth = 0x0060;
		public const int AllocatedHeight = 0x0064;
		public const int PerTileData = 0x0068;
		public const int Terrains = 0x0078;
		public const int TileWidth = 0x0088;
		public const int TileHeight = 0x008C;
		public const int Margin = 0x0090;
		public const int Spacing = 0x0094;
	}

}
