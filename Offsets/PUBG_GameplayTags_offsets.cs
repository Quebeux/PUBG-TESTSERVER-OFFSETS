/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UEditableGameplayTagQuery
	{
		public const int UserDescription = 0x0028;
		public const int UnknownData00 = 0x0038;
		public const int RootExpression = 0x0048;
		public const int TagQueryExportText_Helper = 0x0050;
	}

	public class UEditableGameplayTagQueryExpression_AnyTagsMatch
	{
		public const int Tags = 0x0028;
	}

	public class UEditableGameplayTagQueryExpression_AllTagsMatch
	{
		public const int Tags = 0x0028;
	}

	public class UEditableGameplayTagQueryExpression_NoTagsMatch
	{
		public const int Tags = 0x0028;
	}

	public class UEditableGameplayTagQueryExpression_AnyExprMatch
	{
		public const int Expressions = 0x0028;
	}

	public class UEditableGameplayTagQueryExpression_AllExprMatch
	{
		public const int Expressions = 0x0028;
	}

	public class UEditableGameplayTagQueryExpression_NoExprMatch
	{
		public const int Expressions = 0x0028;
	}

	public class UGameplayTagsManager
	{
		public const int UnknownData00 = 0x0028;
		public const int TagSources = 0x00A8;
		public const int UnknownData01 = 0x00B8;
		public const int GameplayTagTables = 0x0120;
		public const int UnknownData02 = 0x0130;
	}

	public class UGameplayTagsList
	{
		public const int ConfigFileName = 0x0028;
		public const int GameplayTagList = 0x0038;
	}

	public class UGameplayTagsSettings
	{
		public const int ImportTagsFromConfig = 0x0048;
		public const int WarnOnInvalidTags = 0x0049;
		public const int UnknownData00 = 0x004A;
		public const int CategoryRemapping = 0x0050;
		public const int FastReplication = 0x0060;
		public const int UnknownData01 = 0x0061;
		public const int GameplayTagTableList = 0x0068;
		public const int GameplayTagRedirects = 0x0078;
		public const int CommonlyReplicatedTags = 0x0088;
		public const int NumBitsForContainerSize = 0x0098;
		public const int NetIndexFirstBitSegment = 0x009C;
	}

	public class UGameplayTagsDeveloperSettings
	{
		public const int DeveloperConfigName = 0x0028;
	}

}
