[ComVisibleAttribute] // RVA: 0xACE00 Offset: 0xACF01 VA: 0xACE00
[Serializable]
public abstract class MulticastDelegate : Delegate // TypeDefIndex: 388
{
	// Fields
	private Delegate[] delegates; // 0x68

	// Methods

	// RVA: 0x18E0970 Offset: 0x18E0A71 VA: 0x18E0970 Slot: 9
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18E0980 Offset: 0x18E0A81 VA: 0x18E0980 Slot: 6
	protected sealed override object DynamicInvokeImpl(object[] args) { }

	// RVA: 0x18E0A20 Offset: 0x18E0B21 VA: 0x18E0A20 Slot: 0
	public sealed override bool Equals(object obj) { }

	// RVA: 0x18E0C30 Offset: 0x18E0D31 VA: 0x18E0C30 Slot: 2
	public sealed override int GetHashCode() { }

	// RVA: 0x18E0C40 Offset: 0x18E0D41 VA: 0x18E0C40 Slot: 8
	protected override MethodInfo GetMethodImpl() { }

	// RVA: 0x18E0CA0 Offset: 0x18E0DA1 VA: 0x18E0CA0 Slot: 10
	public sealed override Delegate[] GetInvocationList() { }

	// RVA: 0x18E0DA0 Offset: 0x18E0EA1 VA: 0x18E0DA0 Slot: 11
	protected sealed override Delegate CombineImpl(Delegate follow) { }

	// RVA: 0x18E1070 Offset: 0x18E1171 VA: 0x18E1070
	private int LastIndexOf(Delegate[] haystack, Delegate[] needle) { }

	// RVA: 0x18E11C0 Offset: 0x18E12C1 VA: 0x18E11C0 Slot: 12
	protected sealed override Delegate RemoveImpl(Delegate value) { }
}

