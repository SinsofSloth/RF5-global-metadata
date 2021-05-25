[ComVisibleAttribute] // RVA: 0xACDC0 Offset: 0xACEC1 VA: 0xACDC0
[Serializable]
public struct IntPtr : ISerializable // TypeDefIndex: 380
{
	// Fields
	private void* m_value; // 0x0
	public static readonly IntPtr Zero; // 0x0

	// Properties
	public static int Size { get; }

	// Methods

	[ReliabilityContractAttribute] // RVA: 0xB7190 Offset: 0xB7291 VA: 0xB7190
	// RVA: 0x103B0 Offset: 0x104B1 VA: 0x103B0
	public void .ctor(int value) { }

	[ReliabilityContractAttribute] // RVA: 0xB71B0 Offset: 0xB72B1 VA: 0xB71B0
	// RVA: 0x103C0 Offset: 0x104C1 VA: 0x103C0
	public void .ctor(long value) { }

	[ReliabilityContractAttribute] // RVA: 0xB71D0 Offset: 0xB72D1 VA: 0xB71D0
	[CLSCompliantAttribute] // RVA: 0xB71D0 Offset: 0xB72D1 VA: 0xB71D0
	// RVA: 0x103D0 Offset: 0x104D1 VA: 0x103D0
	public void .ctor(void* value) { }

	// RVA: 0x103E0 Offset: 0x104E1 VA: 0x103E0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContractAttribute] // RVA: 0xB7220 Offset: 0xB7321 VA: 0xB7220
	// RVA: 0x18DA390 Offset: 0x18DA491 VA: 0x18DA390
	public static int get_Size() { }

	// RVA: 0x10450 Offset: 0x10551 VA: 0x10450 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x10500 Offset: 0x10601 VA: 0x10500 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x105B0 Offset: 0x106B1 VA: 0x105B0 Slot: 2
	public override int GetHashCode() { }

	[ReliabilityContractAttribute] // RVA: 0xB7240 Offset: 0xB7341 VA: 0xB7240
	// RVA: 0x105C0 Offset: 0x106C1 VA: 0x105C0
	public int ToInt32() { }

	[ReliabilityContractAttribute] // RVA: 0xB7260 Offset: 0xB7361 VA: 0xB7260
	// RVA: 0x105D0 Offset: 0x106D1 VA: 0x105D0
	public long ToInt64() { }

	[CLSCompliantAttribute] // RVA: 0xB7280 Offset: 0xB7381 VA: 0xB7280
	[ReliabilityContractAttribute] // RVA: 0xB7280 Offset: 0xB7381 VA: 0xB7280
	// RVA: 0x105E0 Offset: 0x106E1 VA: 0x105E0
	public void* ToPointer() { }

	// RVA: 0x105F0 Offset: 0x106F1 VA: 0x105F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x10680 Offset: 0x10781 VA: 0x10680
	public string ToString(string format) { }

	[ReliabilityContractAttribute] // RVA: 0xB72D0 Offset: 0xB73D1 VA: 0xB72D0
	// RVA: 0x18DA660 Offset: 0x18DA761 VA: 0x18DA660
	public static bool op_Equality(IntPtr value1, IntPtr value2) { }

	[ReliabilityContractAttribute] // RVA: 0xB72F0 Offset: 0xB73F1 VA: 0xB72F0
	// RVA: 0x18DA670 Offset: 0x18DA771 VA: 0x18DA670
	public static bool op_Inequality(IntPtr value1, IntPtr value2) { }

	[ReliabilityContractAttribute] // RVA: 0xB7310 Offset: 0xB7411 VA: 0xB7310
	// RVA: 0x18DA680 Offset: 0x18DA781 VA: 0x18DA680
	public static IntPtr op_Explicit(int value) { }

	[ReliabilityContractAttribute] // RVA: 0xB7330 Offset: 0xB7431 VA: 0xB7330
	// RVA: 0x18DA690 Offset: 0x18DA791 VA: 0x18DA690
	public static IntPtr op_Explicit(long value) { }

	[ReliabilityContractAttribute] // RVA: 0xB7350 Offset: 0xB7451 VA: 0xB7350
	[CLSCompliantAttribute] // RVA: 0xB7350 Offset: 0xB7451 VA: 0xB7350
	// RVA: 0x18DA6A0 Offset: 0x18DA7A1 VA: 0x18DA6A0
	public static IntPtr op_Explicit(void* value) { }

	// RVA: 0x18DA6B0 Offset: 0x18DA7B1 VA: 0x18DA6B0
	public static int op_Explicit(IntPtr value) { }

	// RVA: 0x18DA6C0 Offset: 0x18DA7C1 VA: 0x18DA6C0
	public static long op_Explicit(IntPtr value) { }

	[CLSCompliantAttribute] // RVA: 0xB73A0 Offset: 0xB74A1 VA: 0xB73A0
	// RVA: 0x18DA6D0 Offset: 0x18DA7D1 VA: 0x18DA6D0
	public static void* op_Explicit(IntPtr value) { }

	[ReliabilityContractAttribute] // RVA: 0xB73C0 Offset: 0xB74C1 VA: 0xB73C0
	// RVA: 0x18DA6E0 Offset: 0x18DA7E1 VA: 0x18DA6E0
	public static IntPtr op_Addition(IntPtr pointer, int offset) { }

	[ReliabilityContractAttribute] // RVA: 0xB73E0 Offset: 0xB74E1 VA: 0xB73E0
	// RVA: 0x18DA6F0 Offset: 0x18DA7F1 VA: 0x18DA6F0
	public static IntPtr op_Subtraction(IntPtr pointer, int offset) { }

	[ReliabilityContractAttribute] // RVA: 0xB7400 Offset: 0xB7501 VA: 0xB7400
	// RVA: 0x10710 Offset: 0x10811 VA: 0x10710
	internal bool IsNull() { }
}

