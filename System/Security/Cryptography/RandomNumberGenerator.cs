[ComVisibleAttribute] // RVA: 0xB00B0 Offset: 0xB01B1 VA: 0xB00B0
public abstract class RandomNumberGenerator : IDisposable // TypeDefIndex: 946
{
	// Methods

	// RVA: 0x262DC40 Offset: 0x262DD41 VA: 0x262DC40
	protected void .ctor() { }

	// RVA: 0x262DC50 Offset: 0x262DD51 VA: 0x262DC50
	public static RandomNumberGenerator Create() { }

	// RVA: 0x262DCB0 Offset: 0x262DDB1 VA: 0x262DCB0 Slot: 4
	public void Dispose() { }

	// RVA: 0x262DD30 Offset: 0x262DE31 VA: 0x262DD30 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void GetBytes(byte[] data) { }
}

