private struct UnitySynchronizationContext.WorkRequest // TypeDefIndex: 3037
{
	// Fields
	private readonly SendOrPostCallback m_DelagateCallback; // 0x0
	private readonly object m_DelagateState; // 0x8
	private readonly ManualResetEvent m_WaitHandle; // 0x10

	// Methods

	// RVA: 0x20F60 Offset: 0x21061 VA: 0x20F60
	public void .ctor(SendOrPostCallback callback, object state, ManualResetEvent waitHandle) { }

	// RVA: 0x20FB0 Offset: 0x210B1 VA: 0x20FB0
	public void Invoke() { }
}

