[Serializable]
private class DelegateSerializationHolder.DelegateEntry // TypeDefIndex: 369
{
	// Fields
	private string type; // 0x10
	private string assembly; // 0x18
	private object target; // 0x20
	private string targetTypeAssembly; // 0x28
	private string targetTypeName; // 0x30
	private string methodName; // 0x38
	public DelegateSerializationHolder.DelegateEntry delegateEntry; // 0x40

	// Methods

	// RVA: 0x19B48F0 Offset: 0x19B49F1 VA: 0x19B48F0
	public void .ctor(Delegate del, string targetLabel) { }

	// RVA: 0x19B4690 Offset: 0x19B4791 VA: 0x19B4690
	public Delegate DeserializeDelegate(SerializationInfo info, int index) { }
}

