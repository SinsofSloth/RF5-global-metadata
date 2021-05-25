internal sealed class PinnedBufferMemoryStream : UnmanagedMemoryStream // TypeDefIndex: 655
{
	// Fields
	private byte[] _array; // 0x68
	private GCHandle _pinningHandle; // 0x70

	// Methods

	// RVA: 0x18B0860 Offset: 0x18B0961 VA: 0x18B0860
	internal void .ctor(byte[] array) { }

	// RVA: 0x18B0960 Offset: 0x18B0A61 VA: 0x18B0960 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x18B09E0 Offset: 0x18B0AE1 VA: 0x18B09E0 Slot: 16
	protected override void Dispose(bool disposing) { }
}

