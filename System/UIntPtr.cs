[ComVisibleAttribute] // RVA: 0xAD000 Offset: 0xAD101 VA: 0xAD000
[CLSCompliantAttribute] // RVA: 0xAD000 Offset: 0xAD101 VA: 0xAD000
[Serializable]
public struct UIntPtr : ISerializable // TypeDefIndex: 427
{
	// Fields
	public static readonly UIntPtr Zero; // 0x0
	private void* _pointer; // 0x0

	// Properties
	public static int Size { get; }

	// Methods

	// RVA: 0x1B110 Offset: 0x1B211 VA: 0x1B110
	public void .ctor(ulong value) { }

	// RVA: 0x1B190 Offset: 0x1B291 VA: 0x1B190
	public void .ctor(uint value) { }

	[CLSCompliantAttribute] // RVA: 0xB7500 Offset: 0xB7601 VA: 0xB7500
	// RVA: 0x1B1A0 Offset: 0x1B2A1 VA: 0x1B1A0
	public void .ctor(void* value) { }

	// RVA: 0x1B1B0 Offset: 0x1B2B1 VA: 0x1B1B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1B260 Offset: 0x1B361 VA: 0x1B260 Slot: 2
	public override int GetHashCode() { }

	[CLSCompliantAttribute] // RVA: 0xB7520 Offset: 0xB7621 VA: 0xB7520
	// RVA: 0x1B270 Offset: 0x1B371 VA: 0x1B270
	public void* ToPointer() { }

	// RVA: 0x1B280 Offset: 0x1B381 VA: 0x1B280 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B300 Offset: 0x1B401 VA: 0x1B300 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1AE3B40 Offset: 0x1AE3C41 VA: 0x1AE3B40
	public static bool op_Equality(UIntPtr value1, UIntPtr value2) { }

	// RVA: 0x1AE3B50 Offset: 0x1AE3C51 VA: 0x1AE3B50
	public static bool op_Inequality(UIntPtr value1, UIntPtr value2) { }

	// RVA: 0x1AE3B60 Offset: 0x1AE3C61 VA: 0x1AE3B60
	public static ulong op_Explicit(UIntPtr value) { }

	// RVA: 0x1AE3B70 Offset: 0x1AE3C71 VA: 0x1AE3B70
	public static uint op_Explicit(UIntPtr value) { }

	// RVA: 0x1AE3B80 Offset: 0x1AE3C81 VA: 0x1AE3B80
	public static UIntPtr op_Explicit(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0xB7540 Offset: 0xB7641 VA: 0xB7540
	// RVA: 0x1AE3C00 Offset: 0x1AE3D01 VA: 0x1AE3C00
	public static UIntPtr op_Explicit(void* value) { }

	[CLSCompliantAttribute] // RVA: 0xB7560 Offset: 0xB7661 VA: 0xB7560
	// RVA: 0x1AE3C10 Offset: 0x1AE3D11 VA: 0x1AE3C10
	public static void* op_Explicit(UIntPtr value) { }

	// RVA: 0x1AE3910 Offset: 0x1AE3A11 VA: 0x1AE3910
	public static int get_Size() { }

	// RVA: 0x1AE3C20 Offset: 0x1AE3D21 VA: 0x1AE3C20
	public static UIntPtr op_Subtraction(UIntPtr pointer, int offset) { }

	// RVA: 0x1AE3C90 Offset: 0x1AE3D91 VA: 0x1AE3C90
	private static void .cctor() { }
}

