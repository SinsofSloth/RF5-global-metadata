internal class CheckCatalogsOperation : AsyncOperationBase<List<string>> // TypeDefIndex: 5709
{
	// Fields
	private AddressablesImpl m_Addressables; // 0x80
	private List<string> m_LocalHashes; // 0x88
	private List<AddressablesImpl.ResourceLocatorInfo> m_LocatorInfos; // 0x90
	private AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp; // 0x98

	// Methods

	// RVA: 0x15E07B0 Offset: 0x15E08B1 VA: 0x15E07B0
	public void .ctor(AddressablesImpl aa) { }

	// RVA: 0x15E0820 Offset: 0x15E0921 VA: 0x15E0820
	public AsyncOperationHandle<List<string>> Start(List<AddressablesImpl.ResourceLocatorInfo> locatorInfos) { }

	// RVA: 0x15E4520 Offset: 0x15E4621 VA: 0x15E4520 Slot: 28
	protected override void Destroy() { }

	// RVA: 0x15E45B0 Offset: 0x15E46B1 VA: 0x15E45B0 Slot: 31
	protected override void GetDependencies(List<AsyncOperationHandle> dependencies) { }

	// RVA: 0x15E4660 Offset: 0x15E4761 VA: 0x15E4660 Slot: 27
	protected override void Execute() { }
}

