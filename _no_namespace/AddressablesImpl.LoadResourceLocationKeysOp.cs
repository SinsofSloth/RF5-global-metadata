private class AddressablesImpl.LoadResourceLocationKeysOp : AsyncOperationBase<IList<IResourceLocation>> // TypeDefIndex: 5675
{
	// Fields
	private IEnumerable m_Key; // 0x80
	private Addressables.MergeMode m_MergeMode; // 0x88
	private IList<IResourceLocation> m_locations; // 0x90
	private AddressablesImpl m_Addressables; // 0x98
	private Type m_ResourceType; // 0xA0

	// Properties
	protected override string DebugName { get; }

	// Methods

	// RVA: 0x15E31C0 Offset: 0x15E32C1 VA: 0x15E31C0 Slot: 30
	protected override string get_DebugName() { }

	// RVA: 0x15DE300 Offset: 0x15DE401 VA: 0x15DE300
	public void Init(AddressablesImpl aa, Type t, IEnumerable key, Addressables.MergeMode mergeMode) { }

	// RVA: 0x15E3210 Offset: 0x15E3311 VA: 0x15E3210 Slot: 27
	protected override void Execute() { }

	// RVA: 0x15DE2B0 Offset: 0x15DE3B1 VA: 0x15DE2B0
	public void .ctor() { }
}

