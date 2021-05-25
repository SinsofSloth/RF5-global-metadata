public struct IrCameraConfig : IEquatable<IrCameraConfig> // TypeDefIndex: 11528
{
	// Fields
	public long exposureTimeNanoSeconds; // 0x0
	public IrCameraLightTarget lightTarget; // 0x8
	public int gain; // 0xC
	public bool isNegativeImageUsed; // 0x10

	// Methods

	// RVA: 0x39FB90 Offset: 0x39FC91 VA: 0x39FB90 Slot: 3
	public override string ToString() { }

	// RVA: 0x34ECC90 Offset: 0x34ECD91 VA: 0x34ECC90
	public static bool op_Equality(IrCameraConfig lhs, IrCameraConfig rhs) { }

	// RVA: 0x34ECD00 Offset: 0x34ECE01 VA: 0x34ECD00
	public static bool op_Inequality(IrCameraConfig lhs, IrCameraConfig rhs) { }

	// RVA: 0x39FBA0 Offset: 0x39FCA1 VA: 0x39FBA0 Slot: 0
	public override bool Equals(object right) { }

	// RVA: 0x39FC90 Offset: 0x39FD91 VA: 0x39FC90 Slot: 4
	public bool Equals(IrCameraConfig other) { }

	// RVA: 0x39FCF0 Offset: 0x39FDF1 VA: 0x39FCF0 Slot: 2
	public override int GetHashCode() { }
}

