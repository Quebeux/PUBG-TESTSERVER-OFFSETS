/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UEditableGameplayTagQuery
	{
		///<summary><![CDATA[FString]]></summary>
		public const int UserDescription = 0x0028;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0038;

		///<summary><![CDATA[UEditableGameplayTagQueryExpression *]]></summary>
		public const int RootExpression = 0x0048;

		///<summary><![CDATA[FGameplayTagQuery]]></summary>
		public const int TagQueryExportText_Helper = 0x0050;

	}

	public class UEditableGameplayTagQueryExpression_AnyTagsMatch
	{
		///<summary><![CDATA[FGameplayTagContainer]]></summary>
		public const int Tags = 0x0028;

	}

	public class UEditableGameplayTagQueryExpression_AllTagsMatch
	{
		///<summary><![CDATA[FGameplayTagContainer]]></summary>
		public const int Tags = 0x0028;

	}

	public class UEditableGameplayTagQueryExpression_NoTagsMatch
	{
		///<summary><![CDATA[FGameplayTagContainer]]></summary>
		public const int Tags = 0x0028;

	}

	public class UEditableGameplayTagQueryExpression_AnyExprMatch
	{
		///<summary><![CDATA[TArray<UEditableGameplayTagQueryExpression * >]]></summary>
		public const int Expressions = 0x0028;

	}

	public class UEditableGameplayTagQueryExpression_AllExprMatch
	{
		///<summary><![CDATA[TArray<UEditableGameplayTagQueryExpression * >]]></summary>
		public const int Expressions = 0x0028;

	}

	public class UEditableGameplayTagQueryExpression_NoExprMatch
	{
		///<summary><![CDATA[TArray<UEditableGameplayTagQueryExpression * >]]></summary>
		public const int Expressions = 0x0028;

	}

	public class UGameplayTagsManager
	{
		///<summary><![CDATA[unsigned char[0x80]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[TArray<FGameplayTagSource>]]></summary>
		public const int TagSources = 0x00A8;

		///<summary><![CDATA[unsigned char[0x68]]]></summary>
		public const int UnknownData01 = 0x00B8;

		///<summary><![CDATA[TArray<UDataTable * >]]></summary>
		public const int GameplayTagTables = 0x0120;

		///<summary><![CDATA[unsigned char[0x50]]]></summary>
		public const int UnknownData02 = 0x0130;

	}

	public class UGameplayTagsList
	{
		///<summary><![CDATA[FString]]></summary>
		public const int ConfigFileName = 0x0028;

		///<summary><![CDATA[TArray<FGameplayTagTableRow>]]></summary>
		public const int GameplayTagList = 0x0038;

	}

	public class UGameplayTagsSettings
	{
		///<summary><![CDATA[bool]]></summary>
		public const int ImportTagsFromConfig = 0x0048;

		///<summary><![CDATA[bool]]></summary>
		public const int WarnOnInvalidTags = 0x0049;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData00 = 0x004A;

		///<summary><![CDATA[TArray<FGameplayTagCategoryRemap>]]></summary>
		public const int CategoryRemapping = 0x0050;

		///<summary><![CDATA[bool]]></summary>
		public const int FastReplication = 0x0060;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0061;

		///<summary><![CDATA[TArray<FStringAssetReference>]]></summary>
		public const int GameplayTagTableList = 0x0068;

		///<summary><![CDATA[TArray<FGameplayTagRedirect>]]></summary>
		public const int GameplayTagRedirects = 0x0078;

		///<summary><![CDATA[TArray<FName>]]></summary>
		public const int CommonlyReplicatedTags = 0x0088;

		///<summary><![CDATA[int]]></summary>
		public const int NumBitsForContainerSize = 0x0098;

		///<summary><![CDATA[int]]></summary>
		public const int NetIndexFirstBitSegment = 0x009C;

	}

	public class UGameplayTagsDeveloperSettings
	{
		///<summary><![CDATA[FString]]></summary>
		public const int DeveloperConfigName = 0x0028;

	}

}
