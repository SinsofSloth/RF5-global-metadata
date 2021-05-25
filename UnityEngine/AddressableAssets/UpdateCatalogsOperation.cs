internal class UpdateCatalogsOperation : AsyncOperationBase<List<IResourceLocator>> // TypeDefIndex: 5711
{
	// Fields
	private AddressablesImpl m_Addressables; // 0x80
	private List<AddressablesImpl.ResourceLocatorInfo> m_LocatorInfos; // 0x88
	private AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp; // 0x90

	// Methods

	// RVA: 0x15E11E0 Offset: 0x15E12E1 VA: 0x15E11E0
	public void .ctor(AddressablesImpl aa) { }

	// RVA: 0x15E1250 Offset: 0x15E1351 VA: 0x15E1250
	public AsyncOperationHandle<List<IResourceLocator>> Start(IEnumerable<string> catalogIds) { }

	// RVA: 0x15EDF20 Offset: 0x15EE021 VA: 0x15EDF20 Slot: 28
	protected override void Destroy() { }

	// RVA: 0x15EDFB0 Offset: 0x15EE0B1 VA: 0x15EDFB0 Slot: 31
	protected override void GetDependencies(List<AsyncOperationHandle> dependencies) { }

	// RVA: 0x15EE060 Offset: 0x15EE161 VA: 0x15EE060 Slot: 27
	protected override void Execute() { }
}

