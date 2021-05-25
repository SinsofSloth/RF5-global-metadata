[ComVisibleAttribute] // RVA: 0xAF500 Offset: 0xAF601 VA: 0xAF500
[FlagsAttribute] // RVA: 0xAF500 Offset: 0xAF601 VA: 0xAF500
[Serializable]
public enum ThreadState // TypeDefIndex: 821
{
	// Fields
	public int value__; // 0x0
	public const ThreadState Running = 0;
	public const ThreadState StopRequested = 1;
	public const ThreadState SuspendRequested = 2;
	public const ThreadState Background = 4;
	public const ThreadState Unstarted = 8;
	public const ThreadState Stopped = 16;
	public const ThreadState WaitSleepJoin = 32;
	public const ThreadState Suspended = 64;
	public const ThreadState AbortRequested = 128;
	public const ThreadState Aborted = 256;
}

