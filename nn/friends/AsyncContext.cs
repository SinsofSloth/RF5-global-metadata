public sealed class AsyncContext : IDisposable // TypeDefIndex: 11670
{
	// Fields
	internal IntPtr _context; // 0x10

	// Methods

	// RVA: 0x26A97E0 Offset: 0x26A98E1 VA: 0x26A97E0
	public void .ctor() { }

	// RVA: 0x26A9850 Offset: 0x26A9951 VA: 0x26A9850 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x26A9960 Offset: 0x26A9A61 VA: 0x26A9960 Slot: 4
	public void Dispose() { }

	// RVA: 0x26A9900 Offset: 0x26A9A01 VA: 0x26A9900
	private void Dispose(bool disposing) { }

	// RVA: 0x26A9A20 Offset: 0x26A9B21 VA: 0x26A9A20
	public Result Cancel() { }

	// RVA: 0x26A9A60 Offset: 0x26A9B61 VA: 0x26A9A60
	public Result HasDone(ref bool outDone) { }

	// RVA: 0x26A9AA0 Offset: 0x26A9BA1 VA: 0x26A9AA0
	public Result GetResult() { }

	// RVA: 0x26A9840 Offset: 0x26A9941 VA: 0x26A9840
	private static extern IntPtr Create() { }

	// RVA: 0x26A9A10 Offset: 0x26A9B11 VA: 0x26A9A10
	private static extern void Destroy(IntPtr context) { }

	// RVA: 0x26A9A40 Offset: 0x26A9B41 VA: 0x26A9A40
	private static extern Result Cancel(IntPtr context) { }

	// RVA: 0x26A9A80 Offset: 0x26A9B81 VA: 0x26A9A80
	private static extern Result HasDone(IntPtr context, ref bool outDone) { }

	// RVA: 0x26A9AC0 Offset: 0x26A9BC1 VA: 0x26A9AC0
	private static extern Result GetResult(IntPtr context) { }
}

