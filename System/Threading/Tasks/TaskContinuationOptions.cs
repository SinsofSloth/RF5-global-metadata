[FlagsAttribute] // RVA: 0xAF800 Offset: 0xAF901 VA: 0xAF800
[Serializable]
public enum TaskContinuationOptions // TypeDefIndex: 859
{
	// Fields
	public int value__; // 0x0
	public const TaskContinuationOptions None = 0;
	public const TaskContinuationOptions PreferFairness = 1;
	public const TaskContinuationOptions LongRunning = 2;
	public const TaskContinuationOptions AttachedToParent = 4;
	public const TaskContinuationOptions DenyChildAttach = 8;
	public const TaskContinuationOptions HideScheduler = 16;
	public const TaskContinuationOptions LazyCancellation = 32;
	public const TaskContinuationOptions RunContinuationsAsynchronously = 64;
	public const TaskContinuationOptions NotOnRanToCompletion = 65536;
	public const TaskContinuationOptions NotOnFaulted = 131072;
	public const TaskContinuationOptions NotOnCanceled = 262144;
	public const TaskContinuationOptions OnlyOnRanToCompletion = 393216;
	public const TaskContinuationOptions OnlyOnFaulted = 327680;
	public const TaskContinuationOptions OnlyOnCanceled = 196608;
	public const TaskContinuationOptions ExecuteSynchronously = 524288;
}

