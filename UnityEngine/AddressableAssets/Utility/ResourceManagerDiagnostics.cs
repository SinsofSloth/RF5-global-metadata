internal class ResourceManagerDiagnostics : IDisposable // TypeDefIndex: 5717
{
	// Fields
	private ResourceManager m_ResourceManager; // 0x10
	private Dictionary<int, DiagnosticInfo> m_cachedDiagnosticInfo; // 0x18

	// Methods

	// RVA: 0x15E67D0 Offset: 0x15E68D1 VA: 0x15E67D0
	public void .ctor(ResourceManager resourceManager) { }

	// RVA: 0x15EE6B0 Offset: 0x15EE7B1 VA: 0x15EE6B0
	internal int SumDependencyNameHashCodes(AsyncOperationHandle handle) { }

	// RVA: 0x15EE8A0 Offset: 0x15EE9A1 VA: 0x15EE8A0
	internal int CalculateHashCode(AsyncOperationHandle handle) { }

	// RVA: 0x15EE9A0 Offset: 0x15EEAA1 VA: 0x15EE9A0
	private void OnResourceManagerDiagnosticEvent(ResourceManager.DiagnosticEventContext eventContext) { }

	// RVA: 0x15E72A0 Offset: 0x15E73A1 VA: 0x15E72A0 Slot: 4
	public void Dispose() { }
}

