public struct AnalogStickState // TypeDefIndex: 11537
{
	// Fields
	public const int Max = 32767;
	public int x; // 0x0
	public int y; // 0x4

	// Properties
	public float fx { get; }
	public float fy { get; }

	// Methods

	// RVA: 0x363BE0 Offset: 0x363CE1 VA: 0x363BE0
	public float get_fx() { }

	// RVA: 0x363C00 Offset: 0x363D01 VA: 0x363C00
	public float get_fy() { }

	// RVA: 0x363C20 Offset: 0x363D21 VA: 0x363C20
	public void Clear() { }

	// RVA: 0x363C30 Offset: 0x363D31 VA: 0x363C30 Slot: 3
	public override string ToString() { }
}

