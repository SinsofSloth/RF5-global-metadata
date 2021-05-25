public abstract class SafeBuffer : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 1325
{
	// Fields
	private bool inited; // 0x1E

	// Methods

	[CLSCompliantAttribute] // RVA: 0xB9900 Offset: 0xB9A01 VA: 0xB9900
	[ReliabilityContractAttribute] // RVA: 0xB9900 Offset: 0xB9A01 VA: 0xB9900
	// RVA: 0x18051B0 Offset: 0x18052B1 VA: 0x18051B0
	public void AcquirePointer(ref byte* pointer) { }

	[ReliabilityContractAttribute] // RVA: 0xB9950 Offset: 0xB9A51 VA: 0xB9950
	// RVA: 0x1805350 Offset: 0x1805451 VA: 0x1805350
	public void ReleasePointer() { }
}

