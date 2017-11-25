/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UGeometryCache
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>TArray&lt;UMaterialInterface * &gt;</summary>
		public const int Materials = 0x0030;

		///<summary>TArray&lt;UGeometryCacheTrack * &gt;</summary>
		public const int Tracks = 0x0040;

		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData01 = 0x0050;

	}

	public class AGeometryCacheActor
	{
		///<summary>UGeometryCacheComponent *</summary>
		public const int GeometryCacheComponent = 0x03B0;

	}

	public class UGeometryCacheComponent
	{
		///<summary>UGeometryCache *</summary>
		public const int GeometryCache = 0x0930;

		///<summary>bool</summary>
		public const int bRunning = 0x0938;

		///<summary>bool</summary>
		public const int bLooping = 0x0939;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x093A;

		///<summary>float</summary>
		public const int StartTimeOffset = 0x093C;

		///<summary>float</summary>
		public const int PlaybackSpeed = 0x0940;

		///<summary>int</summary>
		public const int NumTracks = 0x0944;

		///<summary>float</summary>
		public const int ElapsedTime = 0x0948;

		///<summary>unsigned char[0x54]</summary>
		public const int UnknownData01 = 0x094C;

	}

	public class UGeometryCacheTrack
	{
		///<summary>unsigned char[0x28]</summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UGeometryCacheTrack_FlipbookAnimation
	{
		///<summary>uint32_t</summary>
		public const int NumMeshSamples = 0x0050;

		///<summary>unsigned char[0x24]</summary>
		public const int UnknownData00 = 0x0054;

	}

	public class UGeometryCacheTrack_TransformAnimation
	{
		///<summary>unsigned char[0x50]</summary>
		public const int UnknownData00 = 0x0050;

	}

	public class UGeometryCacheTrack_TransformGroupAnimation
	{
		///<summary>unsigned char[0x50]</summary>
		public const int UnknownData00 = 0x0050;

	}

}
