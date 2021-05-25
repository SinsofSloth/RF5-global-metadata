[Serializable]
internal enum StackCrawlMark // TypeDefIndex: 805
{
	// Fields
	public int value__; // 0x0
	public const StackCrawlMark LookForMe = 0;
	public const StackCrawlMark LookForMyCaller = 1;
	public const StackCrawlMark LookForMyCallersCaller = 2;
	public const StackCrawlMark LookForThread = 3;
}

