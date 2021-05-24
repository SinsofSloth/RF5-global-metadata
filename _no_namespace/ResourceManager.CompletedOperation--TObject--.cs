private class ResourceManager.CompletedOperation<TObject> : AsyncOperationBase<TObject> // TypeDefIndex: 4454
{
	// Fields
	private bool m_Success; // 0x0
	private string m_ErrorMsg; // 0x0
	private bool m_ReleaseDependenciesOnFailure; // 0x0

	// Properties
	protected override string DebugName { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA7470 Offset: 0x2AA7571 VA: 0x2AA7470
	|-ResourceManager.CompletedOperation<bool>..ctor
	|
	|-RVA: 0x2AA75C0 Offset: 0x2AA76C1 VA: 0x2AA75C0
	|-ResourceManager.CompletedOperation<long>..ctor
	|
	|-RVA: 0x2AA7710 Offset: 0x2AA7811 VA: 0x2AA7710
	|-ResourceManager.CompletedOperation<object>..ctor
	|
	|-RVA: 0x2AA7860 Offset: 0x2AA7961 VA: 0x2AA7860
	|-ResourceManager.CompletedOperation<SceneInstance>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Init(TObject result, bool success, string errorMsg, bool releaseDependenciesOnFailure = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA74A0 Offset: 0x2AA75A1 VA: 0x2AA74A0
	|-ResourceManager.CompletedOperation<bool>.Init
	|
	|-RVA: 0x2AA75F0 Offset: 0x2AA76F1 VA: 0x2AA75F0
	|-ResourceManager.CompletedOperation<long>.Init
	|
	|-RVA: 0x2AA7740 Offset: 0x2AA7841 VA: 0x2AA7740
	|-ResourceManager.CompletedOperation<object>.Init
	|
	|-RVA: 0x2AA7890 Offset: 0x2AA7991 VA: 0x2AA7890
	|-ResourceManager.CompletedOperation<SceneInstance>.Init
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected override string get_DebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA7510 Offset: 0x2AA7611 VA: 0x2AA7510
	|-ResourceManager.CompletedOperation<bool>.get_DebugName
	|
	|-RVA: 0x2AA7660 Offset: 0x2AA7761 VA: 0x2AA7660
	|-ResourceManager.CompletedOperation<long>.get_DebugName
	|
	|-RVA: 0x2AA77B0 Offset: 0x2AA78B1 VA: 0x2AA77B0
	|-ResourceManager.CompletedOperation<object>.get_DebugName
	|
	|-RVA: 0x2AA7900 Offset: 0x2AA7A01 VA: 0x2AA7900
	|-ResourceManager.CompletedOperation<SceneInstance>.get_DebugName
	*/

	// RVA: -1 Offset: -1 Slot: 27
	protected override void Execute() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA7560 Offset: 0x2AA7661 VA: 0x2AA7560
	|-ResourceManager.CompletedOperation<bool>.Execute
	|
	|-RVA: 0x2AA76B0 Offset: 0x2AA77B1 VA: 0x2AA76B0
	|-ResourceManager.CompletedOperation<long>.Execute
	|
	|-RVA: 0x2AA7800 Offset: 0x2AA7901 VA: 0x2AA7800
	|-ResourceManager.CompletedOperation<object>.Execute
	|
	|-RVA: 0x2AA7950 Offset: 0x2AA7A51 VA: 0x2AA7950
	|-ResourceManager.CompletedOperation<SceneInstance>.Execute
	*/
}

