public struct MomentProcessorConfig : IEquatable<MomentProcessorConfig> // TypeDefIndex: 11531
{
	// Fields
	public IrCameraConfig irCameraConfig; // 0x0
	public Rect windowOfInterest; // 0x18
	public MomentProcessorPreprocess preprocess; // 0x20
	public int preprocessIntensityThreshold; // 0x24

	// Methods

	// RVA: 0x39FD70 Offset: 0x39FE71 VA: 0x39FD70 Slot: 3
	public override string ToString() { }

	// RVA: 0x34ED490 Offset: 0x34ED591 VA: 0x34ED490
	public static bool op_Equality(MomentProcessorConfig lhs, MomentProcessorConfig rhs) { }

	// RVA: 0x34ED5C0 Offset: 0x34ED6C1 VA: 0x34ED5C0
	public static bool op_Inequality(MomentProcessorConfig lhs, MomentProcessorConfig rhs) { }

	// RVA: 0x39FD80 Offset: 0x39FE81 VA: 0x39FD80 Slot: 0
	public override bool Equals(object right) { }

	// RVA: 0x39FD90 Offset: 0x39FE91 VA: 0x39FD90 Slot: 4
	public bool Equals(MomentProcessorConfig other) { }

	// RVA: 0x39FE70 Offset: 0x39FF71 VA: 0x39FE70 Slot: 2
	public override int GetHashCode() { }
}

