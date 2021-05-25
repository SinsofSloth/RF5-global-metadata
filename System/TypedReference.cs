[ComVisibleAttribute] // RVA: 0xACAB0 Offset: 0xACBB1 VA: 0xACAB0
[CLSCompliantAttribute] // RVA: 0xACAB0 Offset: 0xACBB1 VA: 0xACAB0
public struct TypedReference // TypeDefIndex: 333
{
	// Fields
	private RuntimeTypeHandle type; // 0x0
	private IntPtr Value; // 0x8
	private IntPtr Type; // 0x10

	// Properties
	internal bool IsNull { get; }

	// Methods

	[CLSCompliantAttribute] // RVA: 0xB6F80 Offset: 0xB7081 VA: 0xB6F80
	// RVA: 0x1AE10B0 Offset: 0x1AE11B1 VA: 0x1AE10B0
	public static TypedReference MakeTypedReference(object target, FieldInfo[] flds) { }

	// RVA: 0x1AE1490 Offset: 0x1AE1591 VA: 0x1AE1490
	private static TypedReference MakeTypedReferenceInternal(object target, FieldInfo[] fields) { }

	// RVA: 0x19890 Offset: 0x19991 VA: 0x19890 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x198A0 Offset: 0x199A1 VA: 0x198A0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x198B0 Offset: 0x199B1 VA: 0x198B0
	internal bool get_IsNull() { }

	[CLSCompliantAttribute] // RVA: 0xB6FA0 Offset: 0xB70A1 VA: 0xB6FA0
	// RVA: 0x1AE1680 Offset: 0x1AE1781 VA: 0x1AE1680
	public static void SetTypedReference(TypedReference target, object value) { }
}

