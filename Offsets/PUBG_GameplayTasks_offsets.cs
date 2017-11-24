/// <summary>
/// Auto-generated offsets targetting PUBG v 3.2.12
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UGameplayTask
	{
		public const int UnknownData00 = 0x0028;
		public const int InstanceName = 0x0030;
		public const int UnknownData01 = 0x0038;
		public const int ResourceOverlapPolicy = 0x003A;
		public const int UnknownData02 = 0x003B;
		public const int ChildTask = 0x0060;
	}

	public class UGameplayTaskResource
	{
		public const int ManualResourceID = 0x0028;
		public const int AutoResourceID = 0x002C;
		public const int UnknownData00 = 0x002D;
		public const int bManuallySetID = 0x0030;
		public const int UnknownData01 = 0x0031;
	}

	public class UGameplayTask_SpawnActor
	{
		public const int SUCCESS = 0x0068;
		public const int DidNotSpawn = 0x0078;
		public const int UnknownData00 = 0x0088;
		public const int ClassToSpawn = 0x00A0;
	}

	public class UGameplayTask_TimeLimitedExecution
	{
		public const int OnFinished = 0x0068;
		public const int OnTimeExpired = 0x0078;
		public const int UnknownData00 = 0x0088;
	}

	public class UGameplayTask_WaitDelay
	{
		public const int OnFinish = 0x0068;
		public const int UnknownData00 = 0x0078;
	}

	public class UGameplayTasksComponent
	{
		public const int SimulatedTasks = 0x01E0;
		public const int TaskPriorityQueue = 0x01F0;
		public const int UnknownData00 = 0x0200;
		public const int TickingTasks = 0x0210;
		public const int UnknownData01 = 0x0220;
		public const int OnClaimedResourcesChange = 0x0228;
		public const int UnknownData02 = 0x0238;
	}

}
