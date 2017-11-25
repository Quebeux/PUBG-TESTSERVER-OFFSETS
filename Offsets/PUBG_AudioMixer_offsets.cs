/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class USubmixEffectDynamicsProcessorPreset
	{
		///<summary><![CDATA[unsigned char[0x50]]]></summary>
		public const int UnknownData00 = 0x0040;

		///<summary><![CDATA[FSubmixEffectDynamicsProcessorSettings]]></summary>
		public const int Settings = 0x0090;

	}

	public class USubmixEffectReverbPreset
	{
		///<summary><![CDATA[unsigned char[0x58]]]></summary>
		public const int UnknownData00 = 0x0040;

		///<summary><![CDATA[FSubmixEffectReverbSettings]]></summary>
		public const int Settings = 0x0098;

	}

	public class USubmixEffectSubmixEQPreset
	{
		///<summary><![CDATA[unsigned char[0x38]]]></summary>
		public const int UnknownData00 = 0x0040;

		///<summary><![CDATA[FSubmixEffectSubmixEQSettings]]></summary>
		public const int Settings = 0x0078;

	}

	public class USynthSound
	{
		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData00 = 0x0300;

	}

	public class USynthComponent
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAutoDestroy = 0x03E0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bStopWhenOwnerDestroyed = 0x03E0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bAllowSpatialization = 0x03E0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOverrideAttenuation = 0x03E0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x03E1;

		///<summary><![CDATA[USoundAttenuation *]]></summary>
		public const int AttenuationSettings = 0x03E8;

		///<summary><![CDATA[FSoundAttenuationSettings]]></summary>
		public const int AttenuationOverrides = 0x03F0;

		///<summary><![CDATA[USoundConcurrency *]]></summary>
		public const int ConcurrencySettings = 0x0520;

		///<summary><![CDATA[USoundClass *]]></summary>
		public const int SoundClass = 0x0528;

		///<summary><![CDATA[USoundEffectSourcePresetChain *]]></summary>
		public const int SourceEffectChain = 0x0530;

		///<summary><![CDATA[float]]></summary>
		public const int DefaultMasterReverbSendAmount = 0x0538;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x053C;

		///<summary><![CDATA[USoundSubmix *]]></summary>
		public const int SoundSubmix = 0x0540;

		///<summary><![CDATA[TArray<FSoundSubmixSendInfo>]]></summary>
		public const int SoundSubmixSends = 0x0548;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData02 = 0x0558;

		///<summary><![CDATA[USynthSound *]]></summary>
		public const int Synth = 0x0560;

		///<summary><![CDATA[UAudioComponent *]]></summary>
		public const int AudioComponent = 0x0568;

		///<summary><![CDATA[unsigned char[0x40]]]></summary>
		public const int UnknownData03 = 0x0570;

	}

}
