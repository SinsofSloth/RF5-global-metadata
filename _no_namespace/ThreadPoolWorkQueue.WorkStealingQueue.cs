internal class ThreadPoolWorkQueue.WorkStealingQueue // TypeDefIndex: 814
{
	// Fields
	internal IThreadPoolWorkItem[] m_array; // 0x10
	private int m_mask; // 0x18
	private int m_headIndex; // 0x1C
	private int m_tailIndex; // 0x20
	private SpinLock m_foreignLock; // 0x24

	// Methods

	// RVA: 0x158B100 Offset: 0x158B201 VA: 0x158B100
	public void LocalPush(IThreadPoolWorkItem obj) { }

	// RVA: 0x158B8A0 Offset: 0x158B9A1 VA: 0x158B8A0
	public bool LocalFindAndPop(IThreadPoolWorkItem obj) { }

	// RVA: 0x158BE50 Offset: 0x158BF51 VA: 0x158BE50
	public bool LocalPop(out IThreadPoolWorkItem obj) { }

	// RVA: 0x158C3A0 Offset: 0x158C4A1 VA: 0x158C3A0
	public bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal) { }

	// RVA: 0x158CB10 Offset: 0x158CC11 VA: 0x158CB10
	private bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal, int millisecondsTimeout) { }

	// RVA: 0x158CEC0 Offset: 0x158CFC1 VA: 0x158CEC0
	public void .ctor() { }
}

