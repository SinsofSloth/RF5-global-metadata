public sealed class SafeWaitHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 101
{
	// Methods

	[ReliabilityContractAttribute] // RVA: 0xB5660 Offset: 0xB5761 VA: 0xB5660
	// RVA: 0x192B4B0 Offset: 0x192B5B1 VA: 0x192B4B0
	public void .ctor(IntPtr existingHandle, bool ownsHandle) { }

	// RVA: 0x192B520 Offset: 0x192B621 VA: 0x192B520 Slot: 7
	protected override bool ReleaseHandle() { }
}

