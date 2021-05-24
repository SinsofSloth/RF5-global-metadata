[FlagsAttribute] // RVA: 0xAF7F0 Offset: 0xAF8F1 VA: 0xAF7F0
[Serializable]
internal enum InternalTaskOptions // TypeDefIndex: 858
{
	// Fields
	public int value__; // 0x0
	public const InternalTaskOptions None = 0;
	public const InternalTaskOptions InternalOptionsMask = 65280;
	public const InternalTaskOptions ChildReplica = 256;
	public const InternalTaskOptions ContinuationTask = 512;
	public const InternalTaskOptions PromiseTask = 1024;
	public const InternalTaskOptions SelfReplicating = 2048;
	public const InternalTaskOptions LazyCancellation = 4096;
	public const InternalTaskOptions QueuedByRuntime = 8192;
	public const InternalTaskOptions DoNotDispose = 16384;
}

