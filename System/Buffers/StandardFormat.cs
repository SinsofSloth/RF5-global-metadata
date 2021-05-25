[IsReadOnlyAttribute] // RVA: 0x128BC0 Offset: 0x128CC1 VA: 0x128BC0
public struct StandardFormat : IEquatable<StandardFormat> // TypeDefIndex: 4407
{
	// Fields
	private readonly byte _format; // 0x0
	private readonly byte _precision; // 0x1

	// Properties
	public char Symbol { get; }
	public byte Precision { get; }
	public bool IsDefault { get; }

	// Methods

	// RVA: 0x20330 Offset: 0x20431 VA: 0x20330
	public char get_Symbol() { }

	// RVA: 0x20340 Offset: 0x20441 VA: 0x20340
	public byte get_Precision() { }

	// RVA: 0x20350 Offset: 0x20451 VA: 0x20350
	public bool get_IsDefault() { }

	// RVA: 0x20370 Offset: 0x20471 VA: 0x20370
	public void .ctor(char symbol, byte precision = 255) { }

	// RVA: 0x1B668C0 Offset: 0x1B669C1 VA: 0x1B668C0
	public static StandardFormat op_Implicit(char symbol) { }

	// RVA: 0x203C0 Offset: 0x204C1 VA: 0x203C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20490 Offset: 0x20591 VA: 0x20490 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x204F0 Offset: 0x205F1 VA: 0x204F0 Slot: 4
	public bool Equals(StandardFormat other) { }

	// RVA: 0x20520 Offset: 0x20621 VA: 0x20520 Slot: 3
	public override string ToString() { }
}

