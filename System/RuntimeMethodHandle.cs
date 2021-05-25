[ComVisibleAttribute] // RVA: 0xACF50 Offset: 0xAD051 VA: 0xACF50
[Serializable]
public struct RuntimeMethodHandle : ISerializable // TypeDefIndex: 401
{
	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x1F20 Offset: 0x2021 VA: 0x1F20
	internal void .ctor(IntPtr v) { }

	// RVA: 0x1F30 Offset: 0x2031 VA: 0x1F30
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1F40 Offset: 0x2041 VA: 0x1F40
	public IntPtr get_Value() { }

	// RVA: 0x1F50 Offset: 0x2051 VA: 0x1F50 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContractAttribute] // RVA: 0xB74A0 Offset: 0xB75A1 VA: 0xB74A0
	// RVA: 0x1F60 Offset: 0x2061 VA: 0x1F60 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1F70 Offset: 0x2071 VA: 0x1F70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15214B0 Offset: 0x15215B1 VA: 0x15214B0
	internal static string ConstructInstantiation(RuntimeMethodInfo method, TypeNameFormatFlags format) { }

	// RVA: 0x1F80 Offset: 0x2081 VA: 0x1F80
	internal bool IsNullHandle() { }
}

