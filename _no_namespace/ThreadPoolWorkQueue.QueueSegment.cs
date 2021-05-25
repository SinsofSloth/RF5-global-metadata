internal class ThreadPoolWorkQueue.QueueSegment // TypeDefIndex: 815
{
	// Fields
	internal readonly IThreadPoolWorkItem[] nodes; // 0x10
	private int indexes; // 0x18
	public ThreadPoolWorkQueue.QueueSegment Next; // 0x20

	// Methods

	// RVA: 0x158CA50 Offset: 0x158CB51 VA: 0x158CA50
	private void GetIndexes(out int upper, out int lower) { }

	// RVA: 0x158CA90 Offset: 0x158CB91 VA: 0x158CA90
	private bool CompareExchangeIndexes(ref int prevUpper, int newUpper, ref int prevLower, int newLower) { }

	[ReliabilityContractAttribute] // RVA: 0xB8DC0 Offset: 0xB8EC1 VA: 0xB8DC0
	// RVA: 0x158AD70 Offset: 0x158AE71 VA: 0x158AD70
	public void .ctor() { }

	// RVA: 0x158C350 Offset: 0x158C451 VA: 0x158C350
	public bool IsUsedUp() { }

	// RVA: 0x158B7C0 Offset: 0x158B8C1 VA: 0x158B7C0
	public bool TryEnqueue(IThreadPoolWorkItem node) { }

	// RVA: 0x158C220 Offset: 0x158C321 VA: 0x158C220
	public bool TryDequeue(out IThreadPoolWorkItem node) { }
}

