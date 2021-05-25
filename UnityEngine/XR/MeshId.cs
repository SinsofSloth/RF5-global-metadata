[UsedByNativeCodeAttribute] // RVA: 0x106C00 Offset: 0x106D01 VA: 0x106C00
[NativeHeaderAttribute] // RVA: 0x106C00 Offset: 0x106D01 VA: 0x106C00
public struct MeshId : IEquatable<MeshId> // TypeDefIndex: 3736
{
	// Fields
	private static MeshId s_InvalidId; // 0x0
	private ulong m_SubId1; // 0x0
	private ulong m_SubId2; // 0x8

	// Methods

	// RVA: 0x25FD0 Offset: 0x260D1 VA: 0x25FD0 Slot: 3
	public override string ToString() { }

	// RVA: 0x26060 Offset: 0x26161 VA: 0x26060 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x260A0 Offset: 0x261A1 VA: 0x260A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x26170 Offset: 0x26271 VA: 0x26170 Slot: 4
	public bool Equals(MeshId other) { }

	// RVA: 0x1BCCFC0 Offset: 0x1BCD0C1 VA: 0x1BCCFC0
	private static void .cctor() { }
}

