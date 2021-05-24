internal class InitalizationObjectsOperation : AsyncOperationBase<bool> // TypeDefIndex: 5668
{
	// Fields
	private AsyncOperationHandle<ResourceManagerRuntimeData> m_RtdOp; // 0x80
	private AddressablesImpl m_Addressables; // 0x98
	private AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp; // 0xA0

	// Properties
	protected override string DebugName { get; }

	// Methods

	// RVA: 0x1BD89F0 Offset: 0x1BD8AF1 VA: 0x1BD89F0
	public void Init(AsyncOperationHandle<ResourceManagerRuntimeData> rtdOp, AddressablesImpl addressables) { }

	// RVA: 0x1BD8A60 Offset: 0x1BD8B61 VA: 0x1BD8A60 Slot: 30
	protected override string get_DebugName() { }

	// RVA: 0x1BD8AB0 Offset: 0x1BD8BB1 VA: 0x1BD8AB0
	internal bool LogRuntimeWarnings(string pathToBuildLogs) { }

	// RVA: 0x1BD8C80 Offset: 0x1BD8D81 VA: 0x1BD8C80 Slot: 27
	protected override void Execute() { }

	// RVA: 0x1BD9260 Offset: 0x1BD9361 VA: 0x1BD9260
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x13E540 Offset: 0x13E641 VA: 0x13E540
	// RVA: 0x1BD92B0 Offset: 0x1BD93B1 VA: 0x1BD92B0
	private void <Execute>b__7_0(AsyncOperationHandle<IList<AsyncOperationHandle>> obj) { }
}

