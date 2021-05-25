internal class ResourceFallbackManager : IEnumerable<CultureInfo>, IEnumerable // TypeDefIndex: 499
{
	// Fields
	private CultureInfo m_startingCulture; // 0x10
	private CultureInfo m_neutralResourcesCulture; // 0x18
	private bool m_useParents; // 0x20

	// Methods

	// RVA: 0x17F7BA0 Offset: 0x17F7CA1 VA: 0x17F7BA0
	internal void .ctor(CultureInfo startingCulture, CultureInfo neutralResourcesCulture, bool useParents) { }

	// RVA: 0x17F7C70 Offset: 0x17F7D71 VA: 0x17F7C70 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[IteratorStateMachineAttribute] // RVA: 0xB7EC0 Offset: 0xB7FC1 VA: 0xB7EC0
	// RVA: 0x17F7CF0 Offset: 0x17F7DF1 VA: 0x17F7CF0 Slot: 4
	public IEnumerator<CultureInfo> GetEnumerator() { }
}

