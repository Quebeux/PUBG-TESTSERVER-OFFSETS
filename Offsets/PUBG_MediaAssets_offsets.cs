/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UMediaOverlays
	{
		public const int UnknownData00 = 0x0028;
	}

	public class UMediaPlayer
	{
		public const int UnknownData00 = 0x0028;
		public const int OnEndReached = 0x0040;
		public const int OnMediaClosed = 0x0050;
		public const int OnMediaOpened = 0x0060;
		public const int OnMediaOpenFailed = 0x0070;
		public const int OnPlaybackResumed = 0x0080;
		public const int OnPlaybackSuspended = 0x0090;
		public const int PlayOnOpen = 0x00A0;
		public const int UnknownData01 = 0x00A1;
		public const int Shuffle = 0x00A4;
		public const int Loop = 0x00A4;
		public const int UnknownData02 = 0x00A5;
		public const int Overlays = 0x00A8;
		public const int Playlist = 0x00B0;
		public const int PlaylistIndex = 0x00B8;
		public const int UnknownData03 = 0x00BC;
		public const int SoundWave = 0x00C0;
		public const int VideoTexture = 0x00C8;
		public const int UnknownData04 = 0x00D0;
	}

	public class UMediaPlaylist
	{
		public const int Items = 0x0028;
	}

	public class UMediaSoundWave
	{
		public const int UnknownData00 = 0x0280;
		public const int AudioTrackIndex = 0x0288;
		public const int UnknownData01 = 0x028C;
		public const int MediaPlayer = 0x0290;
		public const int UnknownData02 = 0x0298;
	}

	public class UMediaSource
	{
		public const int UnknownData00 = 0x0028;
	}

	public class UBaseMediaSource
	{
		public const int PlayerName = 0x0030;
	}

	public class UFileMediaSource
	{
		public const int FilePath = 0x0038;
		public const int PrecacheFile = 0x0048;
		public const int UnknownData00 = 0x0049;
	}

	public class UStreamMediaSource
	{
		public const int StreamUrl = 0x0038;
	}

	public class UPlatformMediaSource
	{
		public const int MediaSource = 0x0030;
	}

	public class UMediaTexture
	{
		public const int UnknownData00 = 0x00C8;
		public const int AddressX = 0x00D0;
		public const int AddressY = 0x00D1;
		public const int UnknownData01 = 0x00D2;
		public const int ClearColor = 0x00D4;
		public const int UnknownData02 = 0x00E4;
		public const int MediaPlayer = 0x00E8;
		public const int VideoTrackIndex = 0x00F0;
		public const int UnknownData03 = 0x00F4;
	}

}
