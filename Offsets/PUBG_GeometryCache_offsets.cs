/// <summary>
/// Auto-generated offsets targetting PUBG v 3.2.12
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UGeometryCache
	{
		public const int UnknownData00 = 0x0028;
		public const int Materials = 0x0030;
		public const int Tracks = 0x0040;
		public const int UnknownData01 = 0x0050;
	}

	public class AGeometryCacheActor
	{
		public const int GeometryCacheComponent = 0x03B0;
	}

	public class UGeometryCacheComponent
	{
		public const int GeometryCache = 0x0930;
		public const int bRunning = 0x0938;
		public const int bLooping = 0x0939;
		public const int UnknownData00 = 0x093A;
		public const int StartTimeOffset = 0x093C;
		public const int PlaybackSpeed = 0x0940;
		public const int NumTracks = 0x0944;
		public const int ElapsedTime = 0x0948;
		public const int UnknownData01 = 0x094C;
	}

	public class UGeometryCacheTrack
	{
		public const int UnknownData00 = 0x0028;
	}

	public class UGeometryCacheTrack_FlipbookAnimation
	{
		public const int NumMeshSamples = 0x0050;
		public const int UnknownData00 = 0x0054;
	}

	public class UGeometryCacheTrack_TransformAnimation
	{
		public const int UnknownData00 = 0x0050;
	}

	public class UGeometryCacheTrack_TransformGroupAnimation
	{
		public const int UnknownData00 = 0x0050;
	}

}
